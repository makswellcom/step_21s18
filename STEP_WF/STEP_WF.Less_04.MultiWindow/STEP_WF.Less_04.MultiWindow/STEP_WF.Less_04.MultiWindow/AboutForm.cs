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
    public partial class AboutForm : Form
    {
        public string Text
        {
            set { textBox1.Text = value; }
            get { return textBox1.Text; }
        }

        public AboutForm()
        {
            InitializeComponent();
        }
    }
}
