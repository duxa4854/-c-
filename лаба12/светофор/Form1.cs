using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace сВЕТОФОР
{
    public partial class Form1: Form
    {
        //int step = 0;
        private enum LightState
        {
            Red,
            Yellow,
            Green,
        }
        private LightState currentState = LightState.Green;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttoNsTART_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1000;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            SwitchToNextState();
            ShowLight();
        }

        private void SwitchToNextState()
        {
            switch (currentState) {
            case LightState.Red:
            currentState = LightState.Yellow; break;
            case LightState.Yellow:
            currentState = LightState.Green; break;
            case LightState.Green:
            currentState = LightState.Red; break;
            }
        }

        private void ShowLight()
        {
            panel1Red.BackColor = Color.Gray;
            panel3Eloy.BackColor = Color.Gray;
            panel2Green.BackColor = Color.Gray;

            switch(currentState)
            {
                case LightState.Red:
                    panel1Red.BackColor = Color.Red; break;
                case LightState.Yellow:
                    panel3Eloy.BackColor = Color.Yellow; break;
                case LightState.Green:
                    panel2Green.BackColor = Color.Green; break;
            }
        }
    }
}
