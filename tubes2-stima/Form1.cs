using System;
using System.Windows.Forms;
using System.IO;

namespace tubes2_stima
{
    public partial class Form1 : Form
    {
        //PROPERTY
        Graf graf;
        string chosenPeople;
        string chosenFriend;
        string mode;

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
                    var Edge = graph.AddEdge(temp[0], temp[1]);
                    Edge.Attr.ArrowheadAtTarget = Microsoft.Msagl.Drawing.ArrowStyle.None;
                    Edge.Attr.ArrowheadAtSource = Microsoft.Msagl.Drawing.ArrowStyle.None;
                }

                viewer.Graph = graph;
                visualisasiGraf.SuspendLayout();
                viewer.Dock = DockStyle.Fill;
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
                    this.exploreFriendDropDown.Items.Add(id);
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
                this.chosenFriend = graf.getNodeId()[this.exploreFriendDropDown.SelectedIndex];
            }
            catch(Exception ee)
            {
                MessageBox.Show("there was an error: " + ee);
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            exploreFriends();
            recommendFriends();
        }

        // Fungsi untuk menampilkan hasil explore friends
        private void exploreFriends()
        {
            string[] path;
            if (this.mode == "BFS")
            {
                path = graf.BFS(graf.getNodebyId(this.chosenPeople), graf.getNodebyId(this.chosenFriend));
            }
            else if (this.mode == "DFS")
            {
                path = graf.DFS(graf.getNodebyId(this.chosenPeople), graf.getNodebyId(this.chosenFriend));
            }
            else
            {
                path = new string[0];
            }

            // Explore friends
            string koneksiText = "";

            for (int i = 0; i < path.Length; i++)
            {
                if (i == path.Length - 1)
                {
                    koneksiText += path[i] + "\n";
                }
                else
                {
                    koneksiText += path[i] + " -> ";
                }
            }

            degreeOfConnect(path.Length);

            this.jalurKoneksi.Text = koneksiText;
        }

        // Cari degree of connection
        private void degreeOfConnect(int length)
        {
            if (length == 0)
            {
                this.degreeConnection.Text = "Tidak ada jalur koneksi yang tersedia\n";
            } else if (length - 2 == 1)
            {
                this.degreeConnection.Text = (length-2).ToString() + "st-degree connection";
            } else if (length - 2 == 2)
            {
                this.degreeConnection.Text = (length - 2).ToString() + "nd-degree connection";
            } else if (length - 2 == 3)
            {
                this.degreeConnection.Text = (length - 2).ToString() + "rd-degree connection";
            } else
            {
                this.degreeConnection.Text = (length - 2).ToString() + "th-degree connection";
            }
        }

        // Cari rekomendasi teman
        private void recommendFriends()
        {
            // Rekomendasi teman
            string recommendText = "";
            this.friendRecommendLabel.Text = "Friends Recommendations for " + this.chosenPeople + ":";
            Graf.Node chosenUser = graf.getNodebyId(this.chosenPeople);
            string[] recommendFriend = graf.recommendFriend(chosenUser);

            for (int i = 0; i < recommendFriend.Length; i++)
            {
                string[] mutual = chosenUser.mutualFriend(graf.getNodebyId(recommendFriend[i]));
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

        private void radioButtonBFS_CheckedChanged(object sender, EventArgs e)
        {
            this.mode = "BFS";
        }

        private void radioButtonDFS_CheckedChanged(object sender, EventArgs e)
        {
            this.mode = "DFS";
        }
    }
}
