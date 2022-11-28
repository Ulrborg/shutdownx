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
    public partial class shutdownxMain : Form
    {
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;
        public int Time;
        
        public string CompactTime = "";
        public shutdownxMain()
        {
            InitializeComponent();
        }

        private void startTimerShutdown_Click(object sender, EventArgs e)
        {
            if(textboxHours.Text == "" && textboxMinutes.Text == "")
            {
                MessageBox.Show("Please select your custom shutdown time.", "ShutdownX", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                 
                if(startTimerShutdown.Text == "Cancel Shutdown")
                {
                    Process.Start("shutdown", "/a");
                    MessageBox.Show("Shutdown cancelled", "ShutdownX", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    startTimerShutdown.Text = "Start";
                    timerCheckShutdownRules.Enabled = false;
                    labelShutdownTxt.Visible = false;
                    labelShutdownClock.Visible = false;
                }
                else
                {
                    if (checkBox12hClock.Checked)
                    {
                        checkBox24hClock.Checked = false;
                        if (checkboxShutdownAM.Checked) { labelShutdownClock.Text = textboxHours.Text + ":" + textboxMinutes.Text + " AM"; }
                        else { labelShutdownClock.Text = textboxHours.Text + ":" + textboxMinutes.Text + " PM"; }
                        timerCheckShutdownRules.Enabled = true;
                        labelShutdownTxt.Visible = true;
                        labelShutdownClock.Visible = true;
                        startTimerShutdown.Text = "Cancel Shutdown";
                    }
                    else
                    {
                        checkBox12hClock.Checked = false;
                        checkBox24hClock.Checked = true;
                        labelShutdownClock.Text = textboxHours.Text + ":" + textboxMinutes.Text;
                        timerCheckShutdownRules.Enabled = true;
                        labelShutdownTxt.Visible = true;
                        labelShutdownClock.Visible = true;
                        startTimerShutdown.Text = "Cancel Shutdown";
                    }
                }
                 
            }
        }

        private void shutdownxMain_Load(object sender, EventArgs e)
        {
            timerLocalTime.Enabled = true;
            labelShutdownTxt.Visible = false;
            labelShutdownClock.Visible = false;
            checkboxShutdownAM.Visible = false;
            checkboxShutdownPM.Visible = false;
        }

        private void timerLocalTime_Tick(object sender, EventArgs e)
        {
            if (checkBox12hClock.Checked) { CompactTime = DateTime.Now.ToString("h:mm tt"); }
            else { CompactTime = DateTime.Now.ToString("HH:mm tt"); }
            comptactTimeVisual.Text = CompactTime;
        }

        private void timerCheckShutdownRules_Tick(object sender, EventArgs e)
        {
            if(labelShutdownClock.Text.Trim() == comptactTimeVisual.Text.Trim())
            {
                timerCheckShutdownRules.Enabled = false;
                Process.Start("shutdown", "/s /t 60");
                MessageBox.Show("Your pc will shutdown in one minute", "ShutdownX", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void appExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Close the app when the 'X' is clicked 
        }

        private void appMinimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void appTopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void appTopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void appTopPanel_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void checkBox12hClock_CheckedChanged(object sender, EventArgs e) // checkBox12hClock
        {
             
            checkBox24hClock.Checked = false;
            textboxHours.Items.Clear();
            checkboxShutdownAM.Visible = true;
            checkboxShutdownPM.Visible = true;
            textboxHours.Items.Add("1"); 
            textboxHours.Items.Add("2");
            textboxHours.Items.Add("3");
            textboxHours.Items.Add("4");
            textboxHours.Items.Add("5");
            textboxHours.Items.Add("6");
            textboxHours.Items.Add("7");
            textboxHours.Items.Add("8");
            textboxHours.Items.Add("9");
            textboxHours.Items.Add("10");
            textboxHours.Items.Add("11");
            textboxHours.Items.Add("12");
        }

        private void checkBox24hClock_CheckedChanged(object sender, EventArgs e) // checkBox24hClock
        {  
            checkBox12hClock.Checked = false;
            checkboxShutdownAM.Visible = false;
            checkboxShutdownPM.Visible = false;
            textboxHours.Items.Clear();
            textboxHours.Items.Add("00");
            textboxHours.Items.Add("01");
            textboxHours.Items.Add("02");
            textboxHours.Items.Add("03");
            textboxHours.Items.Add("04");
            textboxHours.Items.Add("05");
            textboxHours.Items.Add("06");
            textboxHours.Items.Add("07");
            textboxHours.Items.Add("08");
            textboxHours.Items.Add("09");
            textboxHours.Items.Add("10");
            textboxHours.Items.Add("11");
            textboxHours.Items.Add("12");
            textboxHours.Items.Add("13");
            textboxHours.Items.Add("14");
            textboxHours.Items.Add("15");
            textboxHours.Items.Add("16");
            textboxHours.Items.Add("17");
            textboxHours.Items.Add("18");
            textboxHours.Items.Add("19");
            textboxHours.Items.Add("20");
            textboxHours.Items.Add("21");
            textboxHours.Items.Add("22");
            textboxHours.Items.Add("23");
        }
    }
}
