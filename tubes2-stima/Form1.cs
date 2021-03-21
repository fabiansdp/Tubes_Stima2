using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace tubes2_stima
{
    public partial class Form1 : Form
    {
        string chosenPeople;
        string chosenFriend;
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fileBrowserButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog fd = new OpenFileDialog();
            fd.Title = "Cari File pertemanan";
            fd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            fd.RestoreDirectory = 1 == 1;

            if (fd.ShowDialog() == DialogResult.OK)
            {
                string path = fd.FileName;
                namaFileUploaded.Text = this.pathProcessor(path);
                if (processFile(path))
                {
                    this.graf.infoGraf();
                    chooseAccountDropDown.Items.Clear();
                    chooseAccountDropDown.ResetText();
                    foreach(string s in graf.getNodeId())
                    {
                        this.chooseAccountDropDown.Items.Add(s);
                    }
                }
                
            }
            
        }

        private bool processFile(string fileloc)
        {
            try
            {
                this.graf = new Graf();
                string[] isitxt = File.ReadAllLines(fileloc);

                for(int i=1;i<isitxt.Length;i++)
                {
                    string[] temp = isitxt[i].Split(' ');
                    graf.addNode(temp[0], temp[1]);
                }

                return true;
            }
            catch(Exception ee)
            {
                MessageBox.Show("there was an error: "+ee);
                //Console.WriteLine(e);
                return false;
            }
        }

        private string pathProcessor(string longpath)
        {
            string s = "";
            int a = longpath.Length-1;
            while(a>=0 && longpath[a] != '\\')
            {
                s = longpath[a] + s;
                a--;
            }
            return s;
        }

        //PROPERTY
        Graf graf;

        private void chooseAccountDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int s = this.chooseAccountDropDown.SelectedIndex;
                this.chosenPeople = graf.getNodeId()[s];
                exploreFriendDropDown.Items.Clear();
                exploreFriendDropDown.ResetText();
                foreach (string teman in graf.getFriend(chosenPeople))
                {
                    exploreFriendDropDown.Items.Add(teman);
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("there was an error: " + ee);
            }
        }

        private void exploreFriendDropDown_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string[] temanku = graf.getFriend(this.chosenPeople);
                this.chosenFriend = temanku[exploreFriendDropDown.SelectedIndex];
                Console.WriteLine(chosenFriend);
            }
            catch(Exception ee)
            {
                MessageBox.Show("there was an error: " + ee);
                //Console.WriteLine(e);
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            try
            {
                string recommendText = "";
                this.friendRecommendLabel.Text = "Friends Recommendations for " + this.chosenPeople + ":";
                int index = graf.searchNode(this.chosenPeople);
                Graf.Node chosenUser = graf.getNode(index);
                string[] recommendFriend = graf.recommendFriend(chosenUser);

                for (int i = 0; i < recommendFriend.Length; i++)
                {
                    int friendIdx = graf.searchNode(recommendFriend[i]);
                    string[] mutual = chosenUser.mutualFriend(graf.getNode(friendIdx));
                    recommendText = recommendText + "Nama Akun: " + recommendFriend[i] + "\n";
                    recommendText += mutual.Length.ToString() + " mutual friends:\n";
                    for (int j = 0; j < mutual.Length; j++)
                    {
                        recommendText = recommendText + mutual[j] + "\n";
                    }
                    recommendText += "\n";
                }

                this.recommend.Text = recommendText;

            } catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }
    }
}
