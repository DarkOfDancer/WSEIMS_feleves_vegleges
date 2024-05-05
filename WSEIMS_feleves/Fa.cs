using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSEIMS_feleves
{
    public class Fa
    {
        class Node
        {
            public Tankor tartalom;
            public int kulcs=0;
            public Node left;
            public Node right;
            public Node parent;
        }
        Node root;
        public void Add(Tankor tartalom, int kulcs)
        {
            PAdd(ref root, tartalom, kulcs);
        }

        private void PAdd(ref Node p, Tankor tartalom, int kulcs)
        {

            Node parent = p;
            if (p == null)
            {
                p.parent = parent;
                p = new Node();
                p.tartalom = tartalom;
                p.kulcs = kulcs;
            }
            else
            {
                parent = p;
                if (p.kulcs > kulcs)
                {
                    PAdd(ref p.left, tartalom, kulcs);
                }
                else if (p.kulcs < kulcs)
                {
                    PAdd(ref p.right, tartalom, kulcs);
                }
            }
        }

        public void Delete(int kulcs)
        {
            _Delete(ref root, kulcs);
        }

        private void _Delete(ref Node p, int kulcs)
        {

                if (p == null)
                    return;

                if (p.left == null && p.right == null)
                {
                    #region Remove leaf
                    if (p == root)
                        root = null;
                    else
                    {
                        Node parent = p.parent;
                        if (parent.left == p)
                            parent.left = null;
                        else
                            parent.right= null;
                    }
                    #endregion
                }
                else if (p.left == null || p.right == null)
                {
                    #region Remove item with one child
                    bool isroot = p == root;

                    Node parent = p.parent;
                    Node newchild = p.left ?? p.right;
                    newchild.parent = parent;
                    if (parent.left == p)
                        parent.left = newchild;
                    else
                        parent.right = newchild;

                    if (isroot)
                        root = newchild;
                    #endregion
                }
                else
                {
                    #region Remove item with two children
                    Node repl = Max(p.left);
                    p.tartalom = repl.tartalom;
                    _Delete(ref p,repl.kulcs);
                    #endregion
                }
            }

        private Node Max(Node node)
            {
                Node tmp = node;
                Node ret = node;
                while (tmp != null)
                {
                    ret = tmp;
                    tmp = tmp.right;
                }
                return ret;
            }

        private Node Keresés(Node root, int keresett)
        {
            if (root == null || root.kulcs == keresett)
                return root;

            if (root.kulcs < ker)
                return Keresés(root.right, kulcs);

            return Keresés(root.left, kulcs);
        }
        public void _DeleteHallgato(string hallgato)
        {
            Tankor tankor= new Tankor();
            if (tankor.Keres(hallgato)==true)
            {
                DeleteHallagato(tankor, hallgato);
            }            
        }
        private void DeleteHallagato(Tankor tankor,string halgato)
        {
            Node tankor = root;
            
            tankor.Kiiratkoztatas(halgato);
            tankor.Fabeillesztoszam();

            if (tankor.Fabeillesztoszam()==0)
            {
                this.Delete(0);
            }
        }
    }
}
