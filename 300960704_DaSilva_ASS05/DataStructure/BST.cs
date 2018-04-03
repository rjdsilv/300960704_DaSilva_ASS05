using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _300960704_DaSilva_ASS04.DataStructure
{
    public class BST<T>
        where T : IComparable
    {
        private Node<T> m_root;

        public void Insert(T data)
        {
            if (null == m_root)
            {
                m_root = new Node<T>(data);
            }
            else
            {
                m_root.Insert(data);
            }
        }

        public void PreOrderPrint()
        {
            PreOrderPrintHelper(m_root);
        }

        public void LevelOrderPrint()
        {
            LevelOrderPrintHelper(m_root, new List<Node<T>>());
        }

        private void PreOrderPrintHelper(Node<T> node)
        {
            if (null != node)
            {
                Console.Write($"{node.Data} ");
                PreOrderPrintHelper(node.LeftNode);
                PreOrderPrintHelper(node.RightNode);
            }
        }

        private void LevelOrderPrintHelper(Node<T> node, List<Node<T>> nodeList)
        {
            if (null != node)
            {
                nodeList.Add(node);
            }

            if (nodeList.Count > 0)
            {
                // Traverses the tree going each level at a time.
                for (int currIndex = 0; currIndex < nodeList.Count; currIndex++)
                {
                    if (null != nodeList[currIndex].LeftNode)
                    {
                        nodeList.Add(nodeList[currIndex].LeftNode);
                    }

                    if (null != nodeList[currIndex].RightNode)
                    {
                        nodeList.Add(nodeList[currIndex].RightNode);
                    }
                }

                // Prints all the elements.
                foreach (Node<T> item in nodeList)
                {
                    Console.Write($"{item.Data} ");
                }
            }
        }

        private class Node<D>
            where D : T
        {
            public D Data { get; private set; }
            public Node<D> LeftNode { get; set; }
            public Node<D> RightNode { get; set; }

            public Node(D data)
            {
                Data = data;
                LeftNode = null;
                RightNode = null;
            }

            public void Insert(D data)
            {   
                if (data.CompareTo(Data) < 0)
                {
                    if (null == LeftNode)
                    {
                        LeftNode = new Node<D>(data);
                    }
                    else
                    {
                        LeftNode.Insert(data);
                    }
                }
                else
                {
                    if (null == RightNode)
                    {
                        RightNode = new Node<D>(data);
                    }
                    else
                    {
                        RightNode.Insert(data);
                    }
                }
            }
        }
    }
}
