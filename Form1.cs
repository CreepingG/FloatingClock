using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FloatingClock
{
    public partial class Form1 : Form
    {
        bool showTitle = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Timer dateTimer = new Timer();
            dateTimer.Tick += GetDateTimeTick;
            dateTimer.Interval = 1;
            dateTimer.Start();
        }
        private void GetDateTimeTick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss") + ":" + DateTime.Now.Millisecond.ToString();
            this.TopMost = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            showTitle = !showTitle;
            if (showTitle)
            {
                ActiveForm.FormBorderStyle = FormBorderStyle.FixedSingle;
            }
            else
            {
                ActiveForm.FormBorderStyle = FormBorderStyle.None;
            }
        }
    }
}
