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
                Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
                Microsoft.Msagl.Drawing.Graph graph = new Microsoft.Msagl.Drawing.Graph("graph");
                string[] isitxt = File.ReadAllLines(fileloc);

                for(int i=1;i<isitxt.Length;i++)
                {
                    string[] temp = isitxt[i].Split(' ');
                    graf.addNode(temp[0], temp[1]);
                    graph.AddEdge(temp[0], temp[1]);
                }

                viewer.Graph = graph;
                visualisasiGraf.SuspendLayout();
                viewer.Dock = System.Windows.Forms.DockStyle.Fill;
                visualisasiGraf.Controls.Add(viewer);
                visualisasiGraf.ResumeLayout();
                visualisasiGraf.Show();

                return true;
            }
            catch(Exception ee)
            {
                MessageBox.Show("there was an error: "+ee);
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
                int idx = this.chooseAccountDropDown.SelectedIndex;
                this.chosenPeople = graf.getNodeId()[idx];
                exploreFriendDropDown.Items.Clear();
                exploreFriendDropDown.ResetText();

                foreach (string id in graf.getNodeId())
                {
                    if (id != this.chosenPeople)
                    {
                        this.exploreFriendDropDown.Items.Add(id);
                    }
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
            }
            catch(Exception ee)
            {
                MessageBox.Show("there was an error: " + ee);
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
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
        }
    }
}
