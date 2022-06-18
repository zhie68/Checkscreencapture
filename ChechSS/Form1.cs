using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Timers;
using System.IO;
using System.Collections;
using System.Runtime;
using System.Net;

namespace ChechSS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            dataGridView1.ReadOnly = true;
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "HMI";
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Name = "NODE NAME";
            dataGridView1.Columns[1].Width = 50;
            dataGridView1.Columns[2].Name = "FIRST DAY";
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Name = "LAST DAY";
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Name = "TOTAL DAY";
            dataGridView1.Columns[4].Width = 50;
            
        }
        static readonly string cb = "\\\\172.21.86.150\\D$\\PICT\\";
        static readonly string cs = "\\\\172.21.86.47\\D$\\PICT\\";
        static readonly string cssch = "\\\\172.21.86.48\\D$\\PICT\\";
        static readonly string dss = "\\\\172.21.86.50\\D$\\PICT\\";
        static readonly string ds = "\\\\172.21.86.44\\D$\\PICT\\";
        static readonly string mrk = "\\\\172.21.86.56\\D$\\PICT\\";
        static readonly string ins = "\\\\172.21.86.52\\D$\\PICT\\";
        static readonly string cl = "\\\\172.21.86.58\\D$\\System32\\Windows\\";
        
        private void button1_Click(object sender, EventArgs e)
        {
            System.Net.NetworkInformation.NetworkInterface[] network;
            network = System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces();

            if (Directory.Exists(cb))
            {
                checkCB();
            }
            else
            {
                string[] row = new string[] { "CB", "HMI53", "CANNOT", "ACESS", "!" };
                dataGridView1.Rows.Add(row);
                dataGridView1.Rows[0].DefaultCellStyle.BackColor = Color.Red;
            }
            if (Directory.Exists(cs))
            {
                checkcs();
            }
            else
            {
                string[] row = new string[] { "CS", "HMI54", "CANNOT", "ACESS", "!" };
                dataGridView1.Rows.Add(row);
                dataGridView1.Rows[1].DefaultCellStyle.BackColor = Color.Red;
            }
            if (Directory.Exists(cssch))
            {
                checkcssch();
            }
            else
            {
                string[] row = new string[] { "CSSCH", "HMI55", "CANNOT", "ACESS", "!" };
                dataGridView1.Rows.Add(row);
                dataGridView1.Rows[2].DefaultCellStyle.BackColor = Color.Red;
            }
            if (Directory.Exists(dss))
            {
                checkdss();
            }
            else
            {
                string[] row = new string[] { "DSS", "HMI57", "CANNOT", "ACESS", "!" };
                dataGridView1.Rows.Add(row);
                dataGridView1.Rows[3].DefaultCellStyle.BackColor = Color.Red;
            }
            if (Directory.Exists(ds))
            {
                checkds();
            }
            else
            {
                string[] row = new string[] { "DS", "HMI58", "CANNOT", "ACESS", "!" };
                dataGridView1.Rows.Add(row);
                dataGridView1.Rows[4].DefaultCellStyle.BackColor = Color.Red;
            }
            if (Directory.Exists(mrk))
            {
                checkmrk();
            }
            else
            {
                string[] row = new string[] { "MRK", "HMI59", "CANNOT", "ACESS", "!" };
                dataGridView1.Rows.Add(row);
                dataGridView1.Rows[5].DefaultCellStyle.BackColor = Color.Red;
            }
            if (Directory.Exists(ins))
            {
                checkins();
            }
            else
            {
                string[] row = new string[] { "INS", "HMI60", "CANNOT", "ACESS", "!" };
                dataGridView1.Rows.Add(row);
                dataGridView1.Rows[6].DefaultCellStyle.BackColor = Color.Red;
            }
            if (Directory.Exists(cl))
            {
                checkcl();
            }
            else
            {
                string[] row = new string[] { "CL", "HMI65", "CANNOT", "ACESS", "!" };
                dataGridView1.Rows.Add(row);
                dataGridView1.Rows[7].DefaultCellStyle.BackColor = Color.Red;
            }
            //checkcs();
            //checkcssch();
            //checkdss();
            //checkds();
            //checkmrk();
            //checkins();
            //checkcl();
        }
        private void checkCB()
        {
            
            int i = 0;
            //label2.Text = "asweqwqw";
            
            foreach (string de in Directory.EnumerateFiles(cb))
            {
                i++;
                if (i == 1)
                {
                    DateTime ded = File.GetCreationTime(de);
                    DirectoryInfo defg = new DirectoryInfo(cb);
                    DateTime dt = defg.LastWriteTime;
                    TimeSpan ts = dt - ded;

                    int gs = Convert.ToInt32(ts.TotalDays);
                    string fs = gs.ToString();
                    string adv = ded.ToString("dd/MM/yyyy HH:mm:ss");
                    string asd = dt.ToString("dd/MM/yyyy HH:mm:ss");
                    string[] row = new string[] { "CB", "HMI53", adv, asd, fs };
                    dataGridView1.Rows.Add(row);
                    listBox1.Items.Add("[CB][HMI53]FIST DAY :" + ded);
                    listBox1.Items.Add("[CB][HMI53]LAST DAY:" + dt + "____________________" + gs + " HARI");
                    
                    i = 0;
                    break;
                }

                Console.WriteLine(de);
            }
        }
        private void checkcs()
        {
            int i = 0;
            //label2.Text = "asweqwqw";

            bool x = System.Net.NetworkInformation.NetworkInterface.GetIsNetworkAvailable();
            foreach (string de in Directory.EnumerateFiles(cs))
            {
                i++;
                if (i == 1)
                {
                    DateTime ded = File.GetCreationTime(de);
                    DirectoryInfo defg = new DirectoryInfo(cs);
                    DateTime dt = defg.LastWriteTime;
                    TimeSpan ts = dt - ded;

                    int gs = Convert.ToInt32(ts.TotalDays);
                    string fs = gs.ToString();
                    string adv = ded.ToString("dd/MM/yyyy HH:mm:ss");
                    string asd = dt.ToString("dd/MM/yyyy HH:mm:ss");
                    string[] row = new string[] { "CS", "HMI54", adv, asd, fs };
                    dataGridView1.Rows.Add(row);

                    listBox1.Items.Add("[CS][HMI54]FIST DAY :" + ded);
                    listBox1.Items.Add("[CS][HMI54]LAST DAY:" + dt + "____________________" + gs + " HARI");
                    i = 0;
                    break;
                }

                Console.WriteLine(de);
            }
        }
        private void checkcssch()
        {
            int i = 0;
            //label2.Text = "asweqwqw";

            foreach (string de in Directory.EnumerateFiles(cssch))
            {
                i++;
                if (i == 1)
                {
                    DateTime ded = File.GetCreationTime(de);
                    DirectoryInfo defg = new DirectoryInfo(cssch);
                    DateTime dt = defg.LastWriteTime;
                    TimeSpan ts = dt - ded;

                    int gs = Convert.ToInt32(ts.TotalDays);
                    string fs = gs.ToString();
                    string adv = ded.ToString("dd/MM/yyyy HH:mm:ss");
                    string asd = dt.ToString("dd/MM/yyyy HH:mm:ss");
                    string[] row = new string[] { "CSSCH", "HMI55", adv, asd, fs };
                    dataGridView1.Rows.Add(row);

                    listBox1.Items.Add("[CSSCH][HMI55]FIST DAY :" + ded);
                    listBox1.Items.Add("[CSSCH][HMI55]LAST DAY:" + dt +"____________________"+ gs +" HARI");
                    i = 0;
                    break;
                }

                Console.WriteLine(de);
            }
            
            
            
        }
        private void checkdss()
        {
            int i = 0;
            //label2.Text = "asweqwqw";

            foreach (string de in Directory.EnumerateFiles(dss))
            {
                i++;
                if (i == 1)
                {
                    DateTime ded = File.GetCreationTime(de);
                    DirectoryInfo defg = new DirectoryInfo(dss);
                    DateTime dt = defg.LastWriteTime;
                    TimeSpan ts = dt - ded;

                    int gs = Convert.ToInt32(ts.TotalDays);
                    string fs = gs.ToString();
                    string adv = ded.ToString("dd/MM/yyyy HH:mm:ss");
                    string asd = dt.ToString("dd/MM/yyyy HH:mm:ss");
                    string[] row = new string[] { "DSS", "HMI57", adv, asd, fs };
                    dataGridView1.Rows.Add(row);

                    listBox1.Items.Add("[DSS][HMI57]FIST DAY :" + ded);
                    listBox1.Items.Add("[DSS][HMI57]LAST DAY:" + dt + "____________________" + gs + " HARI");
                    i = 0;
                    break;
                }

                Console.WriteLine(de);
            }
            
        }
        private void checkds()
        {
            int i = 0;
            //label2.Text = "asweqwqw";

            foreach (string de in Directory.EnumerateFiles(ds))
            {
                i++;
                if (i == 1)
                {
                    DateTime ded = File.GetCreationTime(de);
                    DirectoryInfo defg = new DirectoryInfo(ds);
                    DateTime dt = defg.LastWriteTime;
                    TimeSpan ts = dt - ded;

                    int gs = Convert.ToInt32(ts.TotalDays);
                    string fs = gs.ToString();
                    string adv = ded.ToString("dd/MM/yyyy HH:mm:ss");
                    string asd = dt.ToString("dd/MM/yyyy HH:mm:ss");
                    string[] row = new string[] { "DS", "HMI58", adv, asd, fs };
                    dataGridView1.Rows.Add(row);

                    listBox1.Items.Add("[DS][HMI58]FIST DAY :" + ded);
                    listBox1.Items.Add("[DS][HMI58]LAST DAY:" + dt + "____________________" + gs + " HARI");
                    i = 0;
                    break;
                }

                Console.WriteLine(de);
            }
            
        }
        private void checkmrk()
        {
            int i = 0;
            //label2.Text = "asweqwqw";

            foreach (string de in Directory.EnumerateFiles(mrk))
            {
                i++;
                if (i == 1)
                {
                    DateTime ded = File.GetCreationTime(de);
                    DirectoryInfo defg = new DirectoryInfo(mrk);
                    DateTime dt = defg.LastWriteTime;
                    TimeSpan ts = dt - ded;

                    int gs = Convert.ToInt32(ts.TotalDays);
                    string fs = gs.ToString();
                    string adv = ded.ToString("dd/MM/yyyy HH:mm:ss");
                    string asd = dt.ToString("dd/MM/yyyy HH:mm:ss");
                    string[] row = new string[] { "MRK", "HMI59", adv, asd, fs };
                    dataGridView1.Rows.Add(row);

                    listBox1.Items.Add("[MRK][HMI59]FIST DAY :" + ded);
                    listBox1.Items.Add("[MRK][HMI59]LAST DAY:" + dt + "____________________" + gs + " HARI");
                    i = 0;
                    break;
                }

                Console.WriteLine(de);
            }
        }
        private void checkins()
        {
            int i = 0;
            //label2.Text = "asweqwqw";

            foreach (string de in Directory.EnumerateFiles(ins))
            {
                i++;
                if (i == 1)
                {
                    DateTime ded = File.GetCreationTime(de);
                    DirectoryInfo defg = new DirectoryInfo(ins);
                    DateTime dt = defg.LastWriteTime;
                    TimeSpan ts = dt - ded;

                    int gs = Convert.ToInt32(ts.TotalDays);
                    string fs = gs.ToString();
                    string adv = ded.ToString("dd/MM/yyyy HH:mm:ss");
                    string asd = dt.ToString("dd/MM/yyyy HH:mm:ss");
                    string[] row = new string[] { "INS", "HMI60", adv, asd, fs };
                    dataGridView1.Rows.Add(row);

                    listBox1.Items.Add("[INS][HMI60]FIST DAY :" + ded);
                    listBox1.Items.Add("[INS][HMI60]LAST DAY:" + dt + "____________________" + gs + " HARI");
                    i = 0;
                    break;
                }

                Console.WriteLine(de);
            }
        }
        private void checkcl()
        {
            int i = 0;
            //label2.Text = "asweqwqw";

            foreach (string de in Directory.EnumerateFiles(cl))
            {
                i++;
                if (i == 1)
                {
                    DateTime ded = File.GetCreationTime(de);
                    DirectoryInfo defg = new DirectoryInfo(cl);
                    DateTime dt = defg.LastWriteTime;
                    TimeSpan ts = dt - ded;

                    int gs = Convert.ToInt32(ts.TotalDays);
                    string fs = gs.ToString();
                    string adv = ded.ToString("dd/MM/yyyy HH:mm:ss");
                    string asd = dt.ToString("dd/MM/yyyy HH:mm:ss");
                    string[] row = new string[] { "CL", "HMI65", adv, asd, fs };
                    dataGridView1.Rows.Add(row);

                    listBox1.Items.Add("[CL][HMI65]FIST DAY :" + ded);
                    listBox1.Items.Add("[CL][HMI65]LAST DAY:" + dt + "____________________" + gs + " HARI");
                    i = 0;
                    break;
                }

                Console.WriteLine(de);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            checkcs();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkcssch();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkdss();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            checkds();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            checkmrk();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            checkins();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            checkcl();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
