using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        // create btn without designer
        private Button button2;

        public Form1()
        {
            // do all we need to see btn
            button2 = new Button();
            this.button2.Location = new Point(16, 95);
            this.button2.Name = "button2";
            this.button2.Size = new Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Hand made";
            this.button2.UseVisualStyleBackColor = true;
            this.Controls.Add(this.button2);

            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dfdsfdfasfdasdf(object sender, EventArgs e)
        {

        }
    }
}
