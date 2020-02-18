using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlightWithoutAtmosphere
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        decimal t, dt = 0.1M, x0, y0, v0, cosa, sina;
        bool paused = false;

        private void button_launch_Click(object sender, EventArgs e)
        {
            if (!timer1.Enabled && !paused)
            {

                chart1.ChartAreas[0].AxisX.Maximum = 100;
                chart1.ChartAreas[0].AxisY.Maximum = 50;
                button_launch.Text = "Pause";
                chart1.Series[0].Points.Clear();
                t = 0;
                dt = numericUpDown1.Value;
                x0 = 0;
                y0 = edit_height.Value;
                v0 = edit_speed.Value;

                double a = (double)edit_angle.Value * Math.PI / 189;

                cosa = (decimal)Math.Cos(a);

                sina = (decimal)Math.Sin(a);
                chart1.Series[0].Points.AddXY(x0, y0);
                timer1.Start();

            }
            else if (!paused)
            {
                timer1.Stop();
                paused = true;
                button_launch.Text = "Continue";
            }
            else
            {
                button_launch.Text = "Pause";
                timer1.Start();
            }
        }

        const decimal g = 9.81M;

        private void timer1_Tick(object sender, EventArgs e)
        {

            t += dt;
            decimal x = x0 + v0 * cosa * t;
            decimal y = y0 + v0 * sina * t - g * t * t / 2;

            if (x > (decimal)chart1.ChartAreas[0].AxisX.Maximum)
            {
                chart1.ChartAreas[0].AxisX.Maximum = (int)x + 3;
            }

            if (y > (decimal)chart1.ChartAreas[0].AxisY.Maximum)
            {
                chart1.ChartAreas[0].AxisY.Maximum = (int)y + 3;
            }

            chart1.Series[0].Points.AddXY(x, y);
            if (y <= 0)
            {
                timer1.Stop();
                paused = false;
                button_launch.Text = "Launch";
            }

            text_time.Text = "Time: " + t.ToString() + " s";

        }
    }
}