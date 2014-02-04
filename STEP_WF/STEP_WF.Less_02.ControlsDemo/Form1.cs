using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace STEP_WF.Less_02.ControlsDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            radioButton2.CheckedChanged += ChangeColorHandler;
            radioButton3.CheckedChanged += ChangeColorHandler;
            radioButton4.CheckedChanged += ChangeColorHandler;


            List<Color> colorList = new List<Color>{Color.Fuchsia, Color.Firebrick, Color.ForestGreen};

            foreach (var c in colorList)
            {
                colorComboBox.Items.Add(c);
            }
           
        }

        private void MyBtn_Click(object sender, EventArgs e)
        {
            testRradioBtn.Checked = !testRradioBtn.Checked;
        }

        private void testRradioBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is real click on RBtn", "Event");
        }

        private void testRradioBtn_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Rbtn CheckedChanged event", "Event");
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            var mouseEvents = (MouseEventArgs) e;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = dateTimePicker1.Value.ToLongTimeString();
        }

        public void ChangeColorHandler(object s, EventArgs e)
        {
            RadioButton tmp = (RadioButton) s;
            label1.Text = tmp.Text;

            textBox1.ForeColor = Color.FromName(tmp.Text);
        }

        /// Task: Converter of angle units (from gefree to radians) and back
        /// You have text box(TB) (multirow) in each row - number
        /// under TB 2 RadioButtons, that allow to select units.
        /// After change automatically change text in TB (in each row)
        /// It will be more user-friendly to show to user button "Convert" that
        /// do same as change on radiobuttons.

        private void MyNewHandler(object sender, EventArgs e)
        {
        
        }

        private void colorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var s = (ComboBox) sender;
            label1.Text = ((Color)s.SelectedItem).ToString();
        }

        private void FormCLickHandler(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs) e;

            label1.Text = String.Format("Click at ({0}, {1})", me.X, me.Y);
        }



    }
}
