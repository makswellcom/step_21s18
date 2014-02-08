using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STEP_WF.Less_03.Lists
{
    public partial class Form1 : Form
    {
        private List<Hamster> list; 
        public Form1()
        {
            InitializeComponent();

            lColors.Items.Add("Greeen");
            lColors.Items.Add("Blue");
            lColors.Items.Add("Dark red");
            lColors.Items.Add("Khaki");
            lColors.Items.AddRange(new object[] { "Gold", "Silver", "White", "Pink", "Olive", "Black", "Ultraviolet", "Magenta", "Obsidian" });

            lColors.MultiColumn = true;
            //lColors.ColumnWidth = 70;

            lColors.SelectionMode = SelectionMode.MultiExtended;

            // fill list
            InitializeHamsters();
            lObjects.DataSource = list;
            lObjects.DisplayMember = "Name";
            lObjects.ValueMember = "Color";

            //checkedListBox.Items.AddRange(list.ToArray());
            checkedListBox.DataSource = list;
            //checkedListBox.DisplayMember = "Name";
            checkedListBox.CheckOnClick = true;


            // TASK 1
            /// We have a list of participants in Olympic games (Full name, age, country, kind of sport)
            /// In first List we see this list (Name and country)
            /// We can select few and move to checklist;
            /// When we select any list we se all info about this person
            /// 
            
            timer1.Start();
            numericUpDown1.Maximum = progressBar1.Maximum;

        }

        private void InitializeHamsters()
        {
            list = new List<Hamster>
            {
                new Hamster{Name = "Tilly", Age = 10, Color = "White"},
                new Hamster{Name = "Billy", Age = 11, Color = "Pink"},
                new Hamster{Name = "Willy", Age = 5, Color = "Orange"}
            };
        }


        private void MoveButton_Click(object sender, EventArgs e)
        {
            // check if something is selected
            if (lColors.SelectedItems != null)
            {
                var cnt = lColors.SelectedItems.Count;
                for (int i = 0; i < cnt; i++)
                {
                    lColorsRight.Items.Add(lColors.SelectedItems[i]);
                }
                for (int i = lColors.SelectedItems.Count-1; i>=0; i--)
                {
                    lColors.Items.Remove(lColors.SelectedItems[i]);
                }
            }
        }

        private void lObjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text = lObjects.SelectedValue.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.PerformStep();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            timer1.Stop();

            var v = ((NumericUpDown) sender).Value;

            progressBar1.Value = (int)v;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            timer1.Stop();
            trackBar1.Maximum = progressBar1.Maximum;
            progressBar1.Value = trackBar1.Value;
        }
    }
}
