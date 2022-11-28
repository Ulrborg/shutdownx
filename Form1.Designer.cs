namespace ShutdownX
{
    partial class shutdownxMain
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(shutdownxMain));
            this.textboxHours = new System.Windows.Forms.ComboBox();
            this.textboxMinutes = new System.Windows.Forms.ComboBox();
            this.startTimerShutdown = new System.Windows.Forms.Button();
            this.timerLocalTime = new System.Windows.Forms.Timer(this.components);
            this.timerCheckShutdownRules = new System.Windows.Forms.Timer(this.components);
            this.labelShutdownTxt = new System.Windows.Forms.Label();
            this.labelShutdownClock = new System.Windows.Forms.Label();
            this.comptactTimeVisual = new System.Windows.Forms.Label();
            this.appTopPanel = new System.Windows.Forms.Panel();
            this.appName = new System.Windows.Forms.Label();
            this.appMinimise = new System.Windows.Forms.Button();
            this.appExit = new System.Windows.Forms.Button();
            this.labelHours = new System.Windows.Forms.Label();
            this.labelMinutes = new System.Windows.Forms.Label();
            this.checkBox24hClock = new System.Windows.Forms.CheckBox();
            this.checkBox12hClock = new System.Windows.Forms.CheckBox();
            this.checkboxShutdownAM = new System.Windows.Forms.CheckBox();
            this.checkboxShutdownPM = new System.Windows.Forms.CheckBox();
            this.DO_NOT_CHANGE = new System.Windows.Forms.Label();
            this.appTopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // textboxHours
            // 
            this.textboxHours.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textboxHours.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxHours.FormattingEnabled = true;
            this.textboxHours.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23"});
            this.textboxHours.Location = new System.Drawing.Point(32, 130);
            this.textboxHours.Name = "textboxHours";
            this.textboxHours.Size = new System.Drawing.Size(141, 29);
            this.textboxHours.TabIndex = 0;
            // 
            // textboxMinutes
            // 
            this.textboxMinutes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.textboxMinutes.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F);
            this.textboxMinutes.FormattingEnabled = true;
            this.textboxMinutes.Items.AddRange(new object[] {
            "00",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52",
            "53",
            "54",
            "55",
            "56",
            "57",
            "58",
            "59\t"});
            this.textboxMinutes.Location = new System.Drawing.Point(209, 130);
            this.textboxMinutes.Name = "textboxMinutes";
            this.textboxMinutes.Size = new System.Drawing.Size(141, 29);
            this.textboxMinutes.TabIndex = 1;
            // 
            // startTimerShutdown
            // 
            this.startTimerShutdown.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.startTimerShutdown.FlatAppearance.BorderSize = 0;
            this.startTimerShutdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startTimerShutdown.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startTimerShutdown.ForeColor = System.Drawing.Color.White;
            this.startTimerShutdown.Location = new System.Drawing.Point(253, 370);
            this.startTimerShutdown.Name = "startTimerShutdown";
            this.startTimerShutdown.Size = new System.Drawing.Size(123, 30);
            this.startTimerShutdown.TabIndex = 3;
            this.startTimerShutdown.Text = "Start";
            this.startTimerShutdown.UseVisualStyleBackColor = false;
            this.startTimerShutdown.Click += new System.EventHandler(this.startTimerShutdown_Click);
            // 
            // timerLocalTime
            // 
            this.timerLocalTime.Interval = 1;
            this.timerLocalTime.Tick += new System.EventHandler(this.timerLocalTime_Tick);
            // 
            // timerCheckShutdownRules
            // 
            this.timerCheckShutdownRules.Interval = 1;
            this.timerCheckShutdownRules.Tick += new System.EventHandler(this.timerCheckShutdownRules_Tick);
            // 
            // labelShutdownTxt
            // 
            this.labelShutdownTxt.AutoSize = true;
            this.labelShutdownTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShutdownTxt.ForeColor = System.Drawing.Color.White;
            this.labelShutdownTxt.Location = new System.Drawing.Point(5, 384);
            this.labelShutdownTxt.Name = "labelShutdownTxt";
            this.labelShutdownTxt.Size = new System.Drawing.Size(147, 16);
            this.labelShutdownTxt.TabIndex = 4;
            this.labelShutdownTxt.Text = "Your pc will shutdown at";
            // 
            // labelShutdownClock
            // 
            this.labelShutdownClock.AutoSize = true;
            this.labelShutdownClock.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelShutdownClock.ForeColor = System.Drawing.Color.White;
            this.labelShutdownClock.Location = new System.Drawing.Point(151, 384);
            this.labelShutdownClock.Name = "labelShutdownClock";
            this.labelShutdownClock.Size = new System.Drawing.Size(38, 16);
            this.labelShutdownClock.TabIndex = 5;
            this.labelShutdownClock.Text = "11:05";
            // 
            // comptactTimeVisual
            // 
            this.comptactTimeVisual.AutoSize = true;
            this.comptactTimeVisual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.comptactTimeVisual.Location = new System.Drawing.Point(303, 57);
            this.comptactTimeVisual.Name = "comptactTimeVisual";
            this.comptactTimeVisual.Size = new System.Drawing.Size(54, 13);
            this.comptactTimeVisual.TabIndex = 6;
            this.comptactTimeVisual.Text = "local_time";
            // 
            // appTopPanel
            // 
            this.appTopPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appTopPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.appTopPanel.Controls.Add(this.appName);
            this.appTopPanel.Controls.Add(this.appMinimise);
            this.appTopPanel.Controls.Add(this.appExit);
            this.appTopPanel.Location = new System.Drawing.Point(-2, -1);
            this.appTopPanel.Name = "appTopPanel";
            this.appTopPanel.Size = new System.Drawing.Size(388, 31);
            this.appTopPanel.TabIndex = 7;
            this.appTopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.appTopPanel_MouseDown);
            this.appTopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.appTopPanel_MouseMove);
            this.appTopPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.appTopPanel_MouseUp);
            // 
            // appName
            // 
            this.appName.AutoSize = true;
            this.appName.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appName.ForeColor = System.Drawing.Color.White;
            this.appName.Location = new System.Drawing.Point(7, 7);
            this.appName.Name = "appName";
            this.appName.Size = new System.Drawing.Size(70, 17);
            this.appName.TabIndex = 8;
            this.appName.Text = "ShutdownX";
            // 
            // appMinimise
            // 
            this.appMinimise.FlatAppearance.BorderSize = 0;
            this.appMinimise.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appMinimise.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appMinimise.ForeColor = System.Drawing.Color.White;
            this.appMinimise.Location = new System.Drawing.Point(308, 2);
            this.appMinimise.Name = "appMinimise";
            this.appMinimise.Size = new System.Drawing.Size(32, 26);
            this.appMinimise.TabIndex = 9;
            this.appMinimise.Text = "-";
            this.appMinimise.UseVisualStyleBackColor = true;
            this.appMinimise.Click += new System.EventHandler(this.appMinimise_Click);
            // 
            // appExit
            // 
            this.appExit.FlatAppearance.BorderSize = 0;
            this.appExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.appExit.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appExit.ForeColor = System.Drawing.Color.Red;
            this.appExit.Location = new System.Drawing.Point(350, 2);
            this.appExit.Name = "appExit";
            this.appExit.Size = new System.Drawing.Size(32, 26);
            this.appExit.TabIndex = 8;
            this.appExit.Text = "X";
            this.appExit.UseVisualStyleBackColor = true;
            this.appExit.Click += new System.EventHandler(this.appExit_Click);
            // 
            // labelHours
            // 
            this.labelHours.AutoSize = true;
            this.labelHours.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHours.ForeColor = System.Drawing.Color.White;
            this.labelHours.Location = new System.Drawing.Point(29, 101);
            this.labelHours.Name = "labelHours";
            this.labelHours.Size = new System.Drawing.Size(40, 17);
            this.labelHours.TabIndex = 8;
            this.labelHours.Text = "Hours";
            // 
            // labelMinutes
            // 
            this.labelMinutes.AutoSize = true;
            this.labelMinutes.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMinutes.ForeColor = System.Drawing.Color.White;
            this.labelMinutes.Location = new System.Drawing.Point(206, 101);
            this.labelMinutes.Name = "labelMinutes";
            this.labelMinutes.Size = new System.Drawing.Size(52, 17);
            this.labelMinutes.TabIndex = 9;
            this.labelMinutes.Text = "Minutes";
            // 
            // checkBox24hClock
            // 
            this.checkBox24hClock.AutoSize = true;
            this.checkBox24hClock.ForeColor = System.Drawing.Color.White;
            this.checkBox24hClock.Location = new System.Drawing.Point(12, 309);
            this.checkBox24hClock.Name = "checkBox24hClock";
            this.checkBox24hClock.Size = new System.Drawing.Size(91, 17);
            this.checkBox24hClock.TabIndex = 10;
            this.checkBox24hClock.Text = "24-hour clock";
            this.checkBox24hClock.UseVisualStyleBackColor = true;
            this.checkBox24hClock.CheckedChanged += new System.EventHandler(this.checkBox24hClock_CheckedChanged);
            // 
            // checkBox12hClock
            // 
            this.checkBox12hClock.AutoSize = true;
            this.checkBox12hClock.ForeColor = System.Drawing.Color.White;
            this.checkBox12hClock.Location = new System.Drawing.Point(12, 334);
            this.checkBox12hClock.Name = "checkBox12hClock";
            this.checkBox12hClock.Size = new System.Drawing.Size(91, 17);
            this.checkBox12hClock.TabIndex = 11;
            this.checkBox12hClock.Text = "12-hour clock";
            this.checkBox12hClock.UseVisualStyleBackColor = true;
            this.checkBox12hClock.CheckedChanged += new System.EventHandler(this.checkBox12hClock_CheckedChanged);
            // 
            // checkboxShutdownAM
            // 
            this.checkboxShutdownAM.AutoSize = true;
            this.checkboxShutdownAM.ForeColor = System.Drawing.Color.White;
            this.checkboxShutdownAM.Location = new System.Drawing.Point(12, 357);
            this.checkboxShutdownAM.Name = "checkboxShutdownAM";
            this.checkboxShutdownAM.Size = new System.Drawing.Size(42, 17);
            this.checkboxShutdownAM.TabIndex = 12;
            this.checkboxShutdownAM.Text = "AM";
            this.checkboxShutdownAM.UseVisualStyleBackColor = true;
            // 
            // checkboxShutdownPM
            // 
            this.checkboxShutdownPM.AutoSize = true;
            this.checkboxShutdownPM.ForeColor = System.Drawing.Color.White;
            this.checkboxShutdownPM.Location = new System.Drawing.Point(57, 357);
            this.checkboxShutdownPM.Name = "checkboxShutdownPM";
            this.checkboxShutdownPM.Size = new System.Drawing.Size(42, 17);
            this.checkboxShutdownPM.TabIndex = 13;
            this.checkboxShutdownPM.Text = "PM";
            this.checkboxShutdownPM.UseVisualStyleBackColor = true;
            // 
            // DO_NOT_CHANGE
            // 
            this.DO_NOT_CHANGE.AutoSize = true;
            this.DO_NOT_CHANGE.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DO_NOT_CHANGE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DO_NOT_CHANGE.Location = new System.Drawing.Point(307, 342);
            this.DO_NOT_CHANGE.Name = "DO_NOT_CHANGE";
            this.DO_NOT_CHANGE.Size = new System.Drawing.Size(66, 17);
            this.DO_NOT_CHANGE.TabIndex = 10;
            this.DO_NOT_CHANGE.Text = "@ulrborgtv";
            // 
            // shutdownxMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(382, 406);
            this.Controls.Add(this.DO_NOT_CHANGE);
            this.Controls.Add(this.checkboxShutdownPM);
            this.Controls.Add(this.checkboxShutdownAM);
            this.Controls.Add(this.checkBox12hClock);
            this.Controls.Add(this.checkBox24hClock);
            this.Controls.Add(this.labelMinutes);
            this.Controls.Add(this.labelHours);
            this.Controls.Add(this.appTopPanel);
            this.Controls.Add(this.comptactTimeVisual);
            this.Controls.Add(this.labelShutdownClock);
            this.Controls.Add(this.labelShutdownTxt);
            this.Controls.Add(this.startTimerShutdown);
            this.Controls.Add(this.textboxMinutes);
            this.Controls.Add(this.textboxHours);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "shutdownxMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ShutdownX";
            this.Load += new System.EventHandler(this.shutdownxMain_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.appTopPanel_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.appTopPanel_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.appTopPanel_MouseUp);
            this.appTopPanel.ResumeLayout(false);
            this.appTopPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox textboxHours;
        private System.Windows.Forms.ComboBox textboxMinutes;
        private System.Windows.Forms.Button startTimerShutdown;
        private System.Windows.Forms.Timer timerLocalTime;
        private System.Windows.Forms.Timer timerCheckShutdownRules;
        private System.Windows.Forms.Label labelShutdownTxt;
        private System.Windows.Forms.Label labelShutdownClock;
        private System.Windows.Forms.Label comptactTimeVisual;
        private System.Windows.Forms.Panel appTopPanel;
        private System.Windows.Forms.Button appExit;
        private System.Windows.Forms.Button appMinimise;
        private System.Windows.Forms.Label appName;
        private System.Windows.Forms.Label labelHours;
        private System.Windows.Forms.Label labelMinutes;
        private System.Windows.Forms.CheckBox checkBox24hClock;
        private System.Windows.Forms.CheckBox checkBox12hClock;
        private System.Windows.Forms.CheckBox checkboxShutdownAM;
        private System.Windows.Forms.CheckBox checkboxShutdownPM;
        private System.Windows.Forms.Label DO_NOT_CHANGE;
    }
}

