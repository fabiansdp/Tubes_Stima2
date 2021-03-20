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
        string choosenPeople;
        string choosenFriend;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

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
                this.choosenPeople = graf.getNodeId()[s];
                exploreFriendDropDown.Items.Clear();
                exploreFriendDropDown.ResetText();
                foreach (string teman in graf.getFriend(choosenPeople))
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
                string[] temanku = graf.getFriend(this.choosenPeople);
                this.choosenFriend = temanku[exploreFriendDropDown.SelectedIndex];
                Console.WriteLine(choosenFriend);
            }
            catch(Exception ee)
            {
                MessageBox.Show("there was an error: " + ee);
                //Console.WriteLine(e);
            }
        }
    }
}
