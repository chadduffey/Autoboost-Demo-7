using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autoboost7
{
    public partial class Form1 : Form
    {
        int second = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //configure the timer control
            timer1.Interval = 1000;
            
            //blank out status labels
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";

            //blank out the priorities
            labelPri1.Text = "";
            labelpri2.Text = "";
            labelpri3.Text = "";
                
            //hide the lock indicators.
            labellock1.Visible = false;
            labellock2.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //start the timer
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            second = second + 1;
            
            //first action
            //make thread 1 appear in ready state
            if ((second > 1) && (second < 3))
            {
                //Thread 1 runnning
                label1.BackColor = System.Drawing.Color.Blue;
                label1.Text = "Ready";
                labelPri1.Text = "Priority 6";
            }

            //second action
            //move thread 1 to running
            if ((second > 4) && (second < 6))
            {
                label1.BackColor = System.Drawing.Color.Green;
                label1.Text = "Running";
            }
        
            //third action
            //thread 1 aquires the lock
            if ((second > 7) && (second < 9))
            {
                labellock1.Visible = true;
            }

            //fourth action
            //make thread 2 and 3 ready
            if ((second > 9) && (second < 13))
            {
                label2.Text = "Ready";
                label3.Text = "Ready";
                label2.BackColor = System.Drawing.Color.Blue;
                label3.BackColor = System.Drawing.Color.Blue;
                labelpri2.Text = "Priority 10";
                labelpri3.Text = "Priority 8";
            }

            //fifth action
            //make thread 1 ready, thread 2 running
            if ((second > 13) && (second < 16))
            {
                label2.Text = "Running";
                label2.BackColor = System.Drawing.Color.Green;

                labelaquireA.Visible = true;

                label1.Text = "Ready";
                label1.BackColor = System.Drawing.Color.Blue;
            }

            //sixth action
            //show that thread 2 goes waiting, thread 3 is running.
            if ((second > 17) && (second < 20))
            {
                label2.Text = "WAITING!";
                label2.BackColor = System.Drawing.Color.Red;

                label3.Text = "Running";
                label3.BackColor = System.Drawing.Color.Green;
            }
        
        //done.
        }
    }
}
