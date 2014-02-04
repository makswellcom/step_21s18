using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows;
using System.Windows.Forms;

namespace STEP_WF.Less_01.ConsoleDemo
{
    class MyWindow : Form
    {
        // custom fields
        private Timer timer = new Timer();


        public MyWindow()
        {
            // custom elements on form
            // add event handler
            Click += new EventHandler(ClickHandler);
            this.Text = "Hello WinForms world";
            timer.Tick +=  new EventHandler(TimerHandler);
            timer.Interval = 100;
            timer.Start();
        }


        // handler
        public void ClickHandler(object sender, EventArgs e)
        {
            MessageBox.Show("Surprise!", "Text 2", MessageBoxButtons.OK);
        }

        public void TimerHandler(object sender, EventArgs e)
        {
             this.Text += timer.GetLifetimeService().ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // who just watching - task: repeat
            Form f = new MyWindow();
            f.Text = "New Text";
            f.MinimizeBox = false;
            f.ShowDialog();
            //Console.ReadKey();
        }
    }
}
