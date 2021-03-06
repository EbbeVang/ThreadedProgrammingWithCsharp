﻿using System;
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
        //container for graphics object used to draw on panel
        System.Drawing.Graphics g;
        Point pointCar1;
        Point pointCar2;

        Bitmap ic1;
        Bitmap ic2;

        public Form1()
        {
            InitializeComponent();

            //enable double buffering to avoid flickering
            this.SetStyle(ControlStyles.DoubleBuffer |
            ControlStyles.UserPaint |
            ControlStyles.AllPaintingInWmPaint,
            true);
            this.UpdateStyles();

            panelRace.Paint += new PaintEventHandler(paintRacePanel);
            
            Bitmap sprinteSheet =  Image.FromFile(@"..\..\carSprites.png") as Bitmap;
           
            ic1 = new Bitmap(sprinteSheet).Clone(new Rectangle(0, 10, 95, 48), sprinteSheet.PixelFormat);
            ic2 = new Bitmap(sprinteSheet).Clone(new Rectangle(160, 136, 95, 48), sprinteSheet.PixelFormat);

            pointCar1 = new Point(0, 10);
            pointCar2 = new Point(0, 80);

        }

        // used to draw graphics on panel
        private void paintRacePanel(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawImage(ic1, pointCar1);
            e.Graphics.DrawImage(ic2, pointCar2); 
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
                
                pointCar1.X += 1;
                //labelIncremental.Text = pointCar1.X.ToString();
                //labelIncremental.Update();
                panelRace.Invalidate();
            }
        }
       

          

        
    }
}
