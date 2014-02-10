using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STEP_WF.Less_04.MultiWindow
{
    public partial class InputForm : Form
    {
        public string Info 
        { 
            set { textBox1.Text = value; }
            get { return textBox1.Text; }
        }
        public string Info2
        {
            set { textBox2.Text = value; }
            get { return textBox2.Text; }
        }
        public int ProgressInfo
        {
            set { progressBar1.Value = value; }
        }

        public InputForm()
        {
            InitializeComponent();
        }
    }
}
