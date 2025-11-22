using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StopTimer
{
    public partial class Form1 : Form
    {
        private readonly Stopw stopWatch;
        public Form1()
        {
            InitializeComponent();
            stopWatch = new Stopw(15);
            timer1.Interval = 10;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void startBTN_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void stopBTN_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            stopWatch.Reset();
            UpdateLabel();
        }

        private void resetBTN_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            stopWatch.Tick();
            UpdateLabel();
        }
        private void UpdateLabel()
        {
            label1.Text = stopWatch.GetFormattedTime();
        }
    }
}