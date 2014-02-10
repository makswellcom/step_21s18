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

namespace STEP_WF.Less_04.MultiWindow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            toolStripComboBox1.Items.AddRange(new object[] { "item 1", "item 2",  "item 3", "item 4"});
        }

        private void bestToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm af = new AboutForm();
            af.Text = "Copyright 2014 Bla-bla";
            //af.ShowDialog();
            af.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            var iform = new InputForm();
            iform.Info = "Enter data you want. (Hello from parent)";
            iform.ProgressInfo = 45;
            DialogResult dr = iform.ShowDialog();

            if (dr == DialogResult.OK)
            {
                MessageBox.Show(string.Format("sent: {0}, {1}", iform.Info, iform.Info2));

            }
            else if (dr == DialogResult.Cancel)
            {
                MessageBox.Show("Error", "Error");
            }
        }

        private void Load_File(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "All Files(*.*)|*.*|Text Files (*.txt)|*.txt";
            open.FilterIndex = 0;
            open.Multiselect = true;

            if (open.ShowDialog() == DialogResult.OK)
            {
                StreamReader reader = File.OpenText(open.FileName);
                textBox1.Text = reader.ReadToEnd();
                reader.Close();

                foreach (var file in open.FileNames)
                {
                    var child = new AboutForm();
                    child.Text = (File.OpenText(file)).ReadToEnd();
                    child.Show();
                }
            }

        }

        private void Save_File(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.AddExtension = true;
            save.DefaultExt = "kmg";
            save.Filter = "Application files (*.kmg)|*.kmg|Text files (*.txt)|*.txt";

            if (save.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(save.FileName);

                writer.Write(textBox1.Text);
                writer.Close();
            }
        }
    }
}
