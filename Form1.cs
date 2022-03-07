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

namespace ShutdownX
{
    public partial class Form1 : Form
    {
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public int Time;
        
        public string CompactTime = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.Text == "" && comboBox2.Text == "")
            {
                MessageBox.Show("Veuillez selectioner une date", "ShutdownX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                 
                if(button1.Text == "Cancel Shutdown")
                {
                    Process.Start("shutdown", "/a");
                    MessageBox.Show("Shutdown cancelled", "ShutdownX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    button1.Text = "Start";
                    timer2.Enabled = false;
                    label1.Visible = false;
                    label2.Visible = false;
                }
                else
                {
                    if (checkBox2.Checked)
                    {
                        if (checkBox3.Checked) { label2.Text = comboBox1.Text + ":" + comboBox2.Text + " AM"; }
                        else { label2.Text = comboBox1.Text + ":" + comboBox2.Text + " PM"; }
                        timer2.Enabled = true;
                        label1.Visible = true;
                        label2.Visible = true;
                        button1.Text = "Cancel Shutdown";
                    }
                    else
                    {
                        label2.Text = comboBox1.Text + ":" + comboBox2.Text;
                        timer2.Enabled = true;
                        label1.Visible = true;
                        label2.Visible = true;
                        button1.Text = "Cancel Shutdown";
                    }
                }
                 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            label1.Visible = false;
            label2.Visible = false;
            checkBox3.Visible = false;
            checkBox4.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (checkBox2.Checked) { CompactTime = DateTime.Now.ToString("h:mm tt"); }
            else { CompactTime = DateTime.Now.ToString("HH:mm tt"); }
            label3.Text = CompactTime;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if(label2.Text.Trim() == label3.Text.Trim())
            {
                timer2.Enabled = false;
                Process.Start("shutdown", "/s /t 60");
                MessageBox.Show("Your pc will shutdown in one minute", "ShutdownX", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            comboBox1.Items.Clear();
            checkBox3.Visible = true;
            checkBox4.Visible = true;
            comboBox1.Items.Add("1");
            comboBox1.Items.Add("2");
            comboBox1.Items.Add("3");
            comboBox1.Items.Add("4");
            comboBox1.Items.Add("5");
            comboBox1.Items.Add("6");
            comboBox1.Items.Add("7");
            comboBox1.Items.Add("8");
            comboBox1.Items.Add("9");
            comboBox1.Items.Add("10");
            comboBox1.Items.Add("11");
            comboBox1.Items.Add("12");

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox2.Checked = false;
            checkBox3.Visible = false;
            checkBox4.Visible = false;
            comboBox1.Items.Clear();
            comboBox1.Items.Add("00");
            comboBox1.Items.Add("01");
            comboBox1.Items.Add("02");
            comboBox1.Items.Add("03");
            comboBox1.Items.Add("04");
            comboBox1.Items.Add("05");
            comboBox1.Items.Add("06");
            comboBox1.Items.Add("07");
            comboBox1.Items.Add("08");
            comboBox1.Items.Add("09");
            comboBox1.Items.Add("10");
            comboBox1.Items.Add("11");
            comboBox1.Items.Add("12");
            comboBox1.Items.Add("13");
            comboBox1.Items.Add("14");
            comboBox1.Items.Add("15");
            comboBox1.Items.Add("16");
            comboBox1.Items.Add("17");
            comboBox1.Items.Add("18");
            comboBox1.Items.Add("19");
            comboBox1.Items.Add("20");
            comboBox1.Items.Add("21");
            comboBox1.Items.Add("22");
            comboBox1.Items.Add("23");
            
            

        }
    }
}
