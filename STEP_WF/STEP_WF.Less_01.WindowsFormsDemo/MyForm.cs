using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STEP_WF.Less_01.WindowsFormsDemo
{
    public partial class MyForm : Form
    {
        private int num1 = 0, num2 = 0;

        public MyForm()
        {
            InitializeComponent();

            /*this.*/Text = "This is new text";
            this.ClientSize = new System.Drawing.Size(800, 600);
            InputTextBox.Text = "Enter your text";
            
        }

        private void MyHandler(object s, EventArgs e)
        {
            MessageBox.Show("Booo");
        }

        private void ThirdHandler(object sender, EventArgs e)
        {
            ResultTextBox.Text = InputTextBox.Text;
            resultLbl.Text = "Done!";
        }

        private void plusBtn_Click(object sender, EventArgs e)
        {
            num1 = int.Parse(InputTextBox.Text);
        }

        private void resultBtn_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(InputTextBox.Text);
            ResultTextBox.Text = (num1 + num2).ToString();
        }

        // Task: Create application that recieve user name and surmane
        // and on button click create password, and show it in other 
        // input, in label show result status (Success or Error) and quantity of symbols. 
        //Example - enter: John Smith
        // pass: htimSnhoJ
        // in label: Success 9 symbols
        // if less than 8 symbols than error and label text is red.
    }
}
