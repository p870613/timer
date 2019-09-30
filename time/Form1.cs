using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace time
{
    public partial class Form1 : Form
    {
        int count=0;
        public Form1()
        {
            InitializeComponent();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            count++;
            label1.Text = "" + count;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }
        private void bottom1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            string s = label1.Text;
            
            count = (s[7] - '0' + (s[6] - '0') * 10)
                    +  (60 * (s[4] - '0' + (s[3] - '0') * 10))
                    + (3600 * (s[1] - '0' + (s[0] - '0') * 10));
        }
        /*01:34:67*/

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            label1.Text = "00:00:00";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            timer1.Interval = 1000;   
            count++;

            label1.Text = ((count / 3600).ToString()).PadLeft(2, '0')+":" +((count / 60 % 60).ToString()).PadLeft(2, '0') + ":"+ ((count % 60).ToString()).PadLeft(2, '0');
                       
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Icon = new System.Drawing.Icon(@"4.ico");
        }
    }
}
