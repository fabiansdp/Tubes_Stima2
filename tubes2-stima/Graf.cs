using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tubes2_stima
{
    public class Graf
    {
        private Node[] nodes;
        private int nodesCount;

        public class Node
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

            public int getNumOfFriend()
            {
                return this.numOfFriend;
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

            // Mengembalikan sebuah list node berupa mutual friend user1 dan user2
            public string[] mutualFriend(Node node)
            {
                List<string> mutual = new List<string>();

                for (int i = 0; i < this.numOfFriend; i++)
                {
                    if (node.cariTeman(this.teman[i]))
                    {
                       mutual.Add(this.teman[i]);
                    }
                }

                return mutual.ToArray();
            }
        }

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

        public Node getNode(int index)
        {
            return this.nodes[index];
        }

        public Node getNodebyId(string nodeId)
        {
            return this.nodes[this.searchNode(nodeId)];
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

        public void infoGraf()
        {
            for (int i = 0; i < this.nodesCount; i++)
            {
                nodes[i].printInfo();
            }
        }

        public string[] getNodeId()
        {
            string[] ret = new string[nodesCount];
            for(int i = 0; i < nodesCount; i++)
            {
                ret[i] = nodes[i].getId();
            }
            return ret;
        }  

        // Mengembalikan sebuah list berisi rekomendasi friend untuk user
        public string[] recommendFriend(Node user)
        {
            string[] userFriend = user.getTeman();
            List<string> resultList = new List<string>();

            for (int i = 0; i < user.getNumOfFriend(); i++)
            {
                int friendNodeIdx = searchNode(userFriend[i]);
                Node friend = this.nodes[friendNodeIdx];
                string[] friendList = friend.getTeman();

                for (int j = 0; j < friend.getNumOfFriend(); j++)
                {
                    int resultIndex = resultList.BinarySearch(friendList[j]);

                    if (resultIndex < 0 && !userFriend.Contains(friendList[j]) && friendList[j] != user.getId()) 
                    {
                        resultList.Insert(~resultIndex, friendList[j]);
                    }
                }
            }

            return resultList.ToArray();
        }

        public string[] BFS(Node node1, Node node2)
        {
            Queue<Node> antrian = new Queue<Node>();
            Boolean[] dikunjungi = new Boolean[this.getNodesCount()];
            List<string> kunjungan = new List<string>();
            Node currNode = new Node("-");
            string[] currFriend;
            antrian.Enqueue(node1);
            while (antrian.Count() != 0 && currNode != node2)
            {
                if (antrian.Count() != 0){
                    currNode = antrian.Dequeue();
                }
                kunjungan.Add(currNode.getId());
                dikunjungi[searchNode(currNode.getId())] = true;
                currFriend = this.getFriend(currNode.getId());
                for (int i = 0; i < currNode.getNumOfFriend(); i++)
                {
                    if (dikunjungi[searchNode(currFriend[i])] != true && !antrian.Contains(this.getNodebyId(currFriend[i])))
                    {
                        antrian.Enqueue(getNodebyId(currFriend[i]));
                    }
                }
            }
            if (kunjungan.Contains(node2.getId()))
            {
                for (int i = kunjungan.Count()-1; i >= 1; i--)
                {
                    if (!this.getNodebyId(kunjungan.ElementAt(i)).cariTeman(kunjungan.ElementAt(i-1))){
                        kunjungan.RemoveAt(i-1);
                    }
                }
                for (int i = kunjungan.Count()-1; i >= 2; i--)
                {
                    if (this.getNodebyId(kunjungan.ElementAt(i)).cariTeman(kunjungan.ElementAt(i-2)))
                    {
                        kunjungan.RemoveAt(i-1);
                    }
                }
                return kunjungan.ToArray();
            } else
            {
                return string[];
            }
        }

        public string[] DFS(Node node1, Node node2)
        {
            Boolean[] dikunjungi = new Boolean[this.getNodesCount()];
            List<string> kunjungan = new List<string>();
            Stack<Node> stack = new Stack<Node>();
            Node currNode = new Node("-");
            string[] currFriend;
            stack.Push(node1);
            while (stack.Count() != 0 && !kunjungan.Contains(node2.getId()))
            {
                currNode = stack.Pop();
                currFriend = currNode.getTeman();
                kunjungan.Add(currNode.getId());
                dikunjungi[searchNode(currNode.getId())] = true;
                for (int i = currNode.getNumOfFriend()-1; i >= 0; i--){
                    if (!dikunjungi[searchNode(currFriend[i])] && !kunjungan.Contains(currFriend[i]))
                    {
                        stack.Push(getNodebyId(currFriend[i]));
                    }
                }
            }
            if (kunjungan.Contains(node2.getId()))
            {
                for (int i = kunjungan.Count()-1; i >= 1; i--)
                {
                    if (!this.getNodebyId(kunjungan.ElementAt(i)).cariTeman(kunjungan.ElementAt(i-1))){
                        kunjungan.RemoveAt(i-1);
                    }
                }
                return kunjungan.ToArray();
            } else
            {
                return string[];
            }
        }
    }
}
