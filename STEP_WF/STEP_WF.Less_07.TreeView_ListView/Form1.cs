using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace povtor
{
    public partial class Form1 : Form
    {
        private ImageList treeImageList = new ImageList();

        private int lvStyle = 0;


        // image collections for listView
        ImageList smallImageList = new ImageList();
        ImageList largeImageList = new ImageList();
        
        public Form1()
        {
            InitializeComponent();
            InitializeTree();

            // fill data to listView
            InitializaListView();

            //treeView1.ShowLines = false;
            treeView1.AllowDrop = true;

            
        }

        private void InitializeTree()
        {
            /* simple hand made
             * 
            treeView1.Nodes.Add("test");
            treeView1.Nodes.Add("test");
            treeView1.Nodes.Add("test");
            treeView1.Nodes.Add("test");
            treeView1.Nodes.Add("test");

            treeView1.Nodes[0].Nodes.Add("Subitem");
            treeView1.Nodes[0].Nodes.Add("Subitem");
            treeView1.Nodes[2].Nodes.Add("Subitem");
            treeView1.Nodes[2].Nodes.Add("Subitem");

            treeView1.Nodes[0].Nodes[0].Nodes.Add("Wow");
             */

            // with use of icons and more easy access
            /*TreeNode root = new TreeNode("Root");
            TreeNode node = new TreeNode("Node 1");
            TreeNode node2 = new TreeNode("Node 2");
            root.Nodes.Add(node);
            root.Nodes.Add(node2);
            treeView1.Nodes.Add(root);
             */

            treeImageList.ImageSize = new Size(32, 32);
            CreateImageList(treeImageList, @"..\..\images");
            // connect tree list with ImageList
            treeView1.ImageList = treeImageList;

            TreeNode root = new TreeNode("Root", 1, 0);
            TreeNode node1, node2, node3, node4;

            node1 = new TreeNode("Node 1", 1, 0);
            node2 = new TreeNode("Node 2", 1, 0);
            node3 = new TreeNode("Node 1_1", 1, 0);
            node4 = new TreeNode("Node 1_2", 1, 0);

            node1.Nodes.Add(node3);
            node1.Nodes.Add(node4);

            node2.Nodes.Add("2_1", "Node 2_1", 1, 0);
            node2.Nodes.Add("2_2", "Node 2_2", 1, 0);

            node2.Nodes["2_1"].Nodes.Add("2_1_1", "Deep node 1", 1, 0);
            node2.Nodes["2_1"].Nodes.Add("2_1_2", "Deep node 2", 1, 0);

            root.Nodes.Add(node1);
            root.Nodes.Add(node2);

            // IMPORTANT
            treeView1.Nodes.Add(root);
        }

        private void CreateImageList(ImageList list, string path)
        {
            list.ColorDepth = ColorDepth.Depth32Bit;
            string[] files = Directory.GetFiles(path);

            foreach (var file in files)
            {
                if (file.EndsWith("ico") || file.EndsWith("png"))
                {
                    list.Images.Add(new Bitmap(file));
                }
            }
        }

        private void InitializaListView()
        {
            int width = listData.Width/4;

            // add column
            listData.Columns.Add("kName", "Name", width);
            listData.Columns.Add("kModule1", "Module 1", width);
            listData.Columns.Add("kModule2", "Module 2", width);
            listData.Columns.Add("kModule3", "Module 3", width);

            listData.View = View.Details; // this style mean that we will see listView like table
            // additional view options
            listData.FullRowSelect = true;
            listData.GridLines = true;



            smallImageList.ImageSize = new Size(16, 16);
            CreateImageList(smallImageList, @"..\..\smallImages");

            largeImageList.ImageSize = new Size(32, 32);
            CreateImageList(largeImageList, @"..\..\largeImages");


            // set image collections 
            listData.SmallImageList = smallImageList;
            listData.LargeImageList = largeImageList;

            string[] data = {"Олександр", "Міша", "Павло", "Андрій", "Влад", "Оля", "Ярослав", "Максим"};


            // add one Item
            /*
            listData.Items.Add(new ListViewItem(
                                                    new string[]
                                                        {
                                                            "DEmo",
                                                            "Data 1",
                                                            "Data 2",
                                                            "Data 3",
                                                        }
                                                )
                );
             * */

            Random r = new Random();
            int n = 0;

            foreach (var s in data)
            {
                listData.Items.Add(
                    new ListViewItem(new string[]
                        {s, r.Next(1, 12).ToString(), r.Next(1, 12).ToString(), r.Next(1, 12).ToString()}, n));

                n++;
            }


        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            lvStyle++;
            lvStyle = lvStyle > 4 ? 0 : lvStyle;

            switch (lvStyle)
            {
                case 0:
                    listData.View = View.LargeIcon;
                    break;
                case 1:
                    listData.View = View.Details;
                    break;
                case 2:
                    listData.View = View.List;
                    break;
                case 3:
                    listData.View = View.SmallIcon;
                    break;
                case 4:
                    listData.View = View.Tile;
                    break;

                default:
                    listData.View = View.Tile;
                    break;
            }
            
        }


        private void bGetItem_Click(object sender, EventArgs e)
        {
            // get all selected
            ListView.SelectedListViewItemCollection sic = listData.SelectedItems;

            // show them
            foreach (ListViewItem item in sic)
            {
                string row = string.Format("Student \n Name:{0} \nModule 1: {1} \nModule 2: {2} \nModule 3: {3}", 
                                                item.SubItems[0].Text, item.SubItems[1].Text, 
                                                item.SubItems[2].Text, item.SubItems[3].Text
                    );

                MessageBox.Show(row, "Info");
                pictureBox1.Image = listData.LargeImageList.Images[item.ImageIndex];
            }

        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            // get selected
            ListView.SelectedListViewItemCollection sic = listData.SelectedItems;

            foreach (ListViewItem item in sic)
            {
                listData.Items.Remove(item);
            }

        }

        private void lData_DoubleClick(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection sic = listData.SelectedItems;

            if(sic != null)
            {
                foreach (ListViewItem item in sic)
                {
                    string row = string.Format("Student \n Name:{0} \nModule 1: {1} \nModule 2: {2} \nModule 3: {3}",
                                               item.SubItems[0].Text, item.SubItems[1].Text,
                                               item.SubItems[2].Text, item.SubItems[3].Text
                        );

                    MessageBox.Show(row, "Info");
                    pictureBox1.Image = listData.LargeImageList.Images[item.ImageIndex];
                }
            }
        }

        private void bGetNode_Click(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            if (node != null)
            {
                MessageBox.Show(string.Format("Node: {0} \nFullPath: {1} \nName: {2}", node.Text, node.FullPath,
                                              node.Name));
            }
        }

    }
}
