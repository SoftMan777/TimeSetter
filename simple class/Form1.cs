using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using static Timesetter.Program;

namespace simple_class
{

    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Time T = new Time(24, 0, 0);
            try
            {
                string[] time = DateTime.Now.ToString().Split('.',' ',':');
                T.SetTime(Convert.ToInt32(time[3]), Convert.ToInt32(time[4]), Convert.ToInt32(time[5]));
                label1.Text = T.Hours.ToString() +":"+ T.Minutes.ToString() + ":" + T.Seconds.ToString();
            }
            catch (TimeExcepts exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct SYSTEMTIME
        {
            public short wHour;
            public short wMinute;
            public short wSecond;
            [DllImport("kernel32.dll", SetLastError = true)]
            public static extern bool SetSystemTime([In] ref SYSTEMTIME st);
        }
        private void button7_Click(object sender, EventArgs e)
            
        {
            Time T = new Time(0, 0, 0);
            try
            {
                 string[] time = label1.Text.Split(':');
                T.SetTime(Convert.ToInt32(time[0]), Convert.ToInt32(time[1]), Convert.ToInt32(time[2]));
                SYSTEMTIME st = new SYSTEMTIME();
                st.wHour = Convert.ToInt16(time[0]);
                st.wMinute = Convert.ToInt16(time[1]);
                st.wSecond = Convert.ToInt16(time[2]);
                SYSTEMTIME.SetSystemTime(ref st);
            }
            catch (TimeExcepts exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Time T = new Time(24, 0, 0);
            try
            {
                string[] time = label1.Text.Split(':');
            time[0] = Convert.ToString((Convert.ToInt32(time[0]) + 1));
                if (time[0] == "24")
                    time[0] = "0";
            T.SetTime(Convert.ToInt32(time[0]), Convert.ToInt32(time[1]), Convert.ToInt32(time[2]));
            label1.Text = T.Hours.ToString() + ":" + T.Minutes.ToString() + ":" + T.Seconds.ToString();
            }
            catch (TimeExcepts exc)
            {
                MessageBox.Show(exc.Message);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Time T = new Time(24, 0, 0);
            try
            {
                string[] time = label1.Text.Split(':');
                time[1] = Convert.ToString((Convert.ToInt32(time[1]) + 1));
                if (time[1] == "60")
                    time[1] = "0";
                T.SetTime(Convert.ToInt32(time[0]), Convert.ToInt32(time[1]), Convert.ToInt32(time[2]));
                label1.Text = T.Hours.ToString() + ":" + T.Minutes.ToString() + ":" + T.Seconds.ToString();
            }
            catch (TimeExcepts exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Time T = new Time(24, 0, 0);
            try
            {
                string[] time = label1.Text.Split(':');
                time[2] = Convert.ToString((Convert.ToInt32(time[2]) + 1));
                if (time[2] == "60")
                    time[2] = "0";
                T.SetTime(Convert.ToInt32(time[0]), Convert.ToInt32(time[1]), Convert.ToInt32(time[2]));
                label1.Text = T.Hours.ToString() + ":" + T.Minutes.ToString() + ":" + T.Seconds.ToString();
            }
            catch (TimeExcepts exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Time T = new Time(24, 0, 0);
            try
            {
                string[] time = label1.Text.Split(':');
                time[2] = Convert.ToString((Convert.ToInt32(time[2]) - 1));
                if (time[2] == "-1")
                    time[2] = "59";
                T.SetTime(Convert.ToInt32(time[0]), Convert.ToInt32(time[1]), Convert.ToInt32(time[2]));
                label1.Text = T.Hours.ToString() + ":" + T.Minutes.ToString() + ":" + T.Seconds.ToString();
            }
            catch (TimeExcepts exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Time T = new Time(24, 0, 0);
            try
            {
                string[] time = label1.Text.Split(':');
                time[1] = Convert.ToString(Convert.ToInt32(time[1]) - 1);
                if (time[1] == "-1")
                    time[1] = "59";
                T.SetTime(Convert.ToInt32(time[0]), Convert.ToInt32(time[1]), Convert.ToInt32(time[2]));
                label1.Text = T.Hours.ToString() + ":" + T.Minutes.ToString() + ":" + T.Seconds.ToString();
            }
            catch (TimeExcepts exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Time T = new Time(24, 0, 0);
            try
            {
                string[] time = label1.Text.Split(':');
                time[0] = Convert.ToString((Convert.ToInt32(time[0]) - 1));
                if (time[0] == "-1")
                    time[0] = "23";
                T.SetTime(Convert.ToInt32(time[0]), Convert.ToInt32(time[1]), Convert.ToInt32(time[2]));
                label1.Text = T.Hours.ToString() + ":" + T.Minutes.ToString() + ":" + T.Seconds.ToString();
            }
            catch (TimeExcepts exc)
            {
                MessageBox.Show(exc.Message);
            }
        }
    }
}
