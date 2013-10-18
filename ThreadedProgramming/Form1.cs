using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ThreadedProgramming
{
    public partial class Form1 : Form
    {

        UpdateThread updater = new UpdateThread();

        public Form1()
        {
            InitializeComponent();
            
        }

        private void buttonBlockUIThread_Click(object sender, EventArgs e)
        {
            updateLabel();
        }

        private void buttonNewThread_Click(object sender, EventArgs e)
        {
            Thread myThread = new Thread(updateLabel);
            myThread.Start();              
        }

        private void updateLabel()
        {
            for (int i = 0; i < 100; i++)
            {
                Thread.Sleep(200);
                labelIncremental.Text = i.ToString();
                labelIncremental.Update();
            }
        }
       

          

        
    }
}
