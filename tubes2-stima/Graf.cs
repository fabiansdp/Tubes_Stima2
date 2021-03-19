﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tubes2_stima
{
    public class Graf
    {
        private class Node
        {
            private string id;
            private string[] teman;
            private int numOfFriend;

            public Node(string id)
            {
                numOfFriend = 0;
                this.id = id;
                teman = new string[0];
            }

            public void setId(string id)
            {
                this.id = id;
            }

            public void addFriend(string friend)
            {
                if (!this.cariTeman(friend))
                {
                    if (numOfFriend == 0)
                    {
                        teman = new string[1];
                        teman[0] = friend;
                        numOfFriend = 1;
                    }
                    else
                    {
                        string[] temp = teman;
                        teman = new string[numOfFriend + 1];
                        for (int i = 0; i < numOfFriend; i++)
                        {
                            teman[i] = temp[i];
                        }
                        teman[numOfFriend] = friend;
                        numOfFriend++;
                    }
                }
            }

            public string getId()
            {
                return id;
            }
            public string[] getTeman()
            {
                return this.teman;
            }
            public bool cariTeman(string namaTeman)
            {
                int i = 0;
                bool flag = false;
                while (i < teman.Length && flag == false)
                {
                    if (string.Compare(teman[i].ToLower(), namaTeman.ToLower()) == 0)
                    {
                        flag = true;
                    }
                    else { i++; }
                }
                return flag;
            }
            public void printInfo()
            {
                Console.WriteLine("personId : " + this.id);
                Console.Write("daftar teman: ");
                foreach (string haha in this.teman)
                {
                    Console.Write(haha + " ");
                }
                Console.Write("\n");
            }
        }
        private Node[] nodes;
        private int nodesCount;
        public Graf()
        {
            nodesCount = 0;
        }  
        public int getNodesCount()
        {
            return nodesCount;
        }
        public int searchNode(string nodeId)
        {
            int i;
            for (i = 0; i < nodesCount; i++)
            {
                if (string.Compare(nodeId.ToLower(), nodes[i].getId().ToLower()) == 0)
                {
                    return i;
                }
            }
            return -1;
        }
        public string[] getFriend(string nodeId)
        {
            if (this.searchNode(nodeId) < 0)
            {
                return new string[0];
            }
            else
            {
                int i;
                for (i = 0; i < nodesCount; i++)
                {
                    if (string.Compare(nodeId.ToLower(), nodes[i].getId().ToLower()) == 0)
                    {
                        return nodes[i].getTeman();
                    }
                }
                return new string[0];
            }
        }
        public void addNode(string id)
        {
            int flag = searchNode(id);
            if (flag < 0)
            {
                if (nodesCount == 0)
                {
                    nodes = new Node[1];
                    nodes[0] = new Node(id);
                    nodesCount = 1;
                }
                else
                {
                    Node[] temp = nodes;
                    nodes = new Node[nodesCount + 1];
                    for (int i = 0; i < nodesCount; i++)
                    {
                        nodes[i] = temp[i];
                    }
                    nodes[nodesCount] = new Node(id);
                    nodesCount++;
                }
            }
        }
        public void addNode(string id, string friend)
        {
            addNode(id);
            int flag = searchNode(id);
            nodes[flag].addFriend(friend);
            addNode(friend);
            flag = searchNode(friend);
            nodes[flag].addFriend(id);
        }
        public void uinfoGraf()
        {
            for (int i = 0; i < this.nodesCount; i++)
            {
                nodes[i].printInfo();
            }
        }

    }
}