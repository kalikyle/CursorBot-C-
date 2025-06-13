namespace CursorColorDetector
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            colorDialog1 = new ColorDialog();
            btnPickColor = new Button();
            label1 = new Label();
            lblStatus = new Label();
            label3 = new Label();
            label2 = new Label();
            TolTxt1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            SleepTxt = new TextBox();
            label7 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            label5 = new Label();
            tabControl1 = new TabControl();
            tabCursorRobot = new TabPage();
            label10 = new Label();
            tabAutoClicker = new TabPage();
            label11 = new Label();
            label9 = new Label();
            cmbMouseButton = new ComboBox();
            chkHoldClick = new CheckBox();
            txtInterval = new TextBox();
            label8 = new Label();
            tabPage1 = new TabPage();
            label12 = new Label();
            label13 = new Label();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label14 = new Label();
            label15 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            tabControl1.SuspendLayout();
            tabCursorRobot.SuspendLayout();
            tabAutoClicker.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // btnPickColor
            // 
            btnPickColor.BackColor = Color.Transparent;
            btnPickColor.FlatAppearance.BorderColor = Color.Black;
            btnPickColor.Font = new Font("UniDreamLED", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnPickColor.ForeColor = Color.FromArgb(0, 64, 0);
            btnPickColor.Location = new Point(18, 17);
            btnPickColor.Name = "btnPickColor";
            btnPickColor.Size = new Size(406, 41);
            btnPickColor.TabIndex = 0;
            btnPickColor.Text = "CHOOSE A COLOR";
            btnPickColor.UseVisualStyleBackColor = false;
            btnPickColor.Click += btnPickColor_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Consolas", 9F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(8, 285);
            label1.Name = "label1";
            label1.Size = new Size(56, 14);
            label1.TabIndex = 2;
            label1.Text = "Status:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.BackColor = Color.Transparent;
            lblStatus.Font = new Font("Consolas", 9F);
            lblStatus.ForeColor = Color.White;
            lblStatus.Location = new Point(74, 285);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(49, 14);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Stats_";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 9F);
            label3.ForeColor = SystemColors.ControlText;
            label3.Location = new Point(150, 71);
            label3.Name = "label3";
            label3.Size = new Size(49, 14);
            label3.TabIndex = 4;
            label3.Text = "------";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 9F, FontStyle.Bold);
            label2.Location = new Point(18, 109);
            label2.Name = "label2";
            label2.Size = new Size(77, 14);
            label2.TabIndex = 5;
            label2.Text = "Tolerance:";
            // 
            // TolTxt1
            // 
            TolTxt1.Enabled = false;
            TolTxt1.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TolTxt1.Location = new Point(181, 103);
            TolTxt1.Name = "TolTxt1";
            TolTxt1.ReadOnly = true;
            TolTxt1.Size = new Size(46, 22);
            TolTxt1.TabIndex = 7;
            TolTxt1.Text = "1";
            TolTxt1.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(150, 98);
            button1.Name = "button1";
            button1.Size = new Size(24, 33);
            button1.TabIndex = 8;
            button1.Text = "-";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(232, 97);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.No;
            button2.Size = new Size(30, 34);
            button2.TabIndex = 9;
            button2.Text = "+";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // SleepTxt
            // 
            SleepTxt.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SleepTxt.Location = new Point(150, 147);
            SleepTxt.Name = "SleepTxt";
            SleepTxt.Size = new Size(112, 22);
            SleepTxt.TabIndex = 12;
            SleepTxt.TextChanged += SleepTxt_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Consolas", 9F, FontStyle.Bold);
            label7.Location = new Point(18, 150);
            label7.Name = "label7";
            label7.Size = new Size(49, 14);
            label7.TabIndex = 11;
            label7.Text = "Sleep:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Lime;
            label4.Location = new Point(284, 285);
            label4.Name = "label4";
            label4.Size = new Size(175, 14);
            label4.TabIndex = 10;
            label4.Text = "Press \"F6\" to Start/Stop";
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(467, 55);
            panel1.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 6);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 31);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 9F);
            label6.Location = new Point(11, 37);
            label6.Name = "label6";
            label6.Size = new Size(91, 14);
            label6.TabIndex = 11;
            label6.Text = "by Kayleskii";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(46, 8);
            label5.Name = "label5";
            label5.Size = new Size(192, 29);
            label5.TabIndex = 11;
            label5.Text = "AutoTarget Clicker";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabCursorRobot);
            tabControl1.Controls.Add(tabAutoClicker);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Font = new Font("UniDreamLED", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(8, 61);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(451, 207);
            tabControl1.TabIndex = 15;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabCursorRobot
            // 
            tabCursorRobot.BackColor = Color.MintCream;
            tabCursorRobot.Controls.Add(label10);
            tabCursorRobot.Controls.Add(SleepTxt);
            tabCursorRobot.Controls.Add(btnPickColor);
            tabCursorRobot.Controls.Add(label7);
            tabCursorRobot.Controls.Add(label2);
            tabCursorRobot.Controls.Add(label3);
            tabCursorRobot.Controls.Add(TolTxt1);
            tabCursorRobot.Controls.Add(button2);
            tabCursorRobot.Controls.Add(button1);
            tabCursorRobot.Location = new Point(4, 23);
            tabCursorRobot.Name = "tabCursorRobot";
            tabCursorRobot.Padding = new Padding(3);
            tabCursorRobot.Size = new Size(443, 180);
            tabCursorRobot.TabIndex = 0;
            tabCursorRobot.Text = "Cursor Robot";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Consolas", 9F, FontStyle.Bold);
            label10.Location = new Point(18, 71);
            label10.Name = "label10";
            label10.Size = new Size(112, 14);
            label10.TabIndex = 13;
            label10.Text = "Selected Color:";
            // 
            // tabAutoClicker
            // 
            tabAutoClicker.BackColor = Color.AliceBlue;
            tabAutoClicker.Controls.Add(label11);
            tabAutoClicker.Controls.Add(label9);
            tabAutoClicker.Controls.Add(cmbMouseButton);
            tabAutoClicker.Controls.Add(chkHoldClick);
            tabAutoClicker.Controls.Add(txtInterval);
            tabAutoClicker.Controls.Add(label8);
            tabAutoClicker.Location = new Point(4, 23);
            tabAutoClicker.Name = "tabAutoClicker";
            tabAutoClicker.Padding = new Padding(3);
            tabAutoClicker.Size = new Size(443, 180);
            tabAutoClicker.TabIndex = 1;
            tabAutoClicker.Text = "Auto Clicker";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("UniDreamLED", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Maroon;
            label11.Location = new Point(16, 17);
            label11.Name = "label11";
            label11.Size = new Size(195, 39);
            label11.TabIndex = 5;
            label11.Text = "AUTO CLICKER";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Consolas", 9F, FontStyle.Bold);
            label9.Location = new Point(16, 141);
            label9.Name = "label9";
            label9.Size = new Size(98, 14);
            label9.TabIndex = 4;
            label9.Text = "Mouse Button:";
            // 
            // cmbMouseButton
            // 
            cmbMouseButton.AutoCompleteCustomSource.AddRange(new string[] { "Left", "Right", "Middle" });
            cmbMouseButton.Font = new Font("Consolas", 9F, FontStyle.Bold);
            cmbMouseButton.FormattingEnabled = true;
            cmbMouseButton.Items.AddRange(new object[] { "Left", "Right", "Middle", "E", "F" });
            cmbMouseButton.Location = new Point(169, 132);
            cmbMouseButton.Name = "cmbMouseButton";
            cmbMouseButton.Size = new Size(119, 22);
            cmbMouseButton.TabIndex = 3;
            cmbMouseButton.Text = "Left";
            // 
            // chkHoldClick
            // 
            chkHoldClick.AutoSize = true;
            chkHoldClick.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkHoldClick.Location = new Point(171, 103);
            chkHoldClick.Name = "chkHoldClick";
            chkHoldClick.Size = new Size(117, 18);
            chkHoldClick.TabIndex = 2;
            chkHoldClick.Text = "Hold to Click";
            chkHoldClick.UseVisualStyleBackColor = true;
            // 
            // txtInterval
            // 
            txtInterval.Font = new Font("Consolas", 9F, FontStyle.Bold);
            txtInterval.Location = new Point(169, 68);
            txtInterval.Name = "txtInterval";
            txtInterval.Size = new Size(119, 22);
            txtInterval.TabIndex = 1;
            txtInterval.Text = "1000";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Consolas", 9F, FontStyle.Bold);
            label8.Location = new Point(16, 72);
            label8.Name = "label8";
            label8.Size = new Size(147, 14);
            label8.TabIndex = 0;
            label8.Text = "Click Interval (ms):";
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label15);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(button5);
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(label13);
            tabPage1.Controls.Add(label12);
            tabPage1.Location = new Point(4, 23);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(443, 180);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "ABOUT";
            tabPage1.UseVisualStyleBackColor = true;
            tabPage1.Click += tabPage1_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.Location = new Point(18, 64);
            label12.Name = "label12";
            label12.Size = new Size(154, 14);
            label12.TabIndex = 0;
            label12.Text = "Developer: @Kayleskii";
            label12.Click += label12_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label13.Location = new Point(18, 90);
            label13.Name = "label13";
            label13.Size = new Size(63, 14);
            label13.TabIndex = 1;
            label13.Text = "Socials:";
            // 
            // button3
            // 
            button3.FlatAppearance.BorderColor = Color.Blue;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(18, 115);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "Facebook";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.FlatAppearance.BorderColor = Color.FromArgb(192, 0, 192);
            button4.FlatAppearance.BorderSize = 2;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Location = new Point(112, 115);
            button4.Name = "button4";
            button4.Size = new Size(75, 23);
            button4.TabIndex = 3;
            button4.Text = "GitHub";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 192);
            button5.FlatAppearance.BorderSize = 2;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Location = new Point(207, 115);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 4;
            button5.Text = "Linkedln";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(132, 153);
            label14.Name = "label14";
            label14.Size = new Size(175, 14);
            label14.TabIndex = 5;
            label14.Text = "All Rights Received 2025";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("UniDreamLED", 26.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label15.ForeColor = Color.Navy;
            label15.Location = new Point(15, 18);
            label15.Name = "label15";
            label15.Size = new Size(135, 39);
            label15.TabIndex = 6;
            label15.Text = "CHUPAPS";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(467, 311);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Controls.Add(label4);
            Controls.Add(lblStatus);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AutoTarget By Kayleski";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            tabControl1.ResumeLayout(false);
            tabCursorRobot.ResumeLayout(false);
            tabCursorRobot.PerformLayout();
            tabAutoClicker.ResumeLayout(false);
            tabAutoClicker.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ColorDialog colorDialog1;
        private Button btnPickColor;
        private Label label1;
        private Label lblStatus;
        private Label label3;
        private Label label2;
        private TextBox TolTxt1;
        private Button button1;
        private Button button2;
        private Label label4;
        private Panel panel1;
        private Label label6;
        private Label label5;
        private TextBox SleepTxt;
        private Label label7;
        private TabControl tabControl1;
        private TabPage tabCursorRobot;
        private TabPage tabAutoClicker;
        private TextBox txtInterval;
        private Label label8;
        private Label label9;
        private ComboBox cmbMouseButton;
        private CheckBox chkHoldClick;
        private Label label10;
        private PictureBox pictureBox1;
        private Label label11;
        private TabPage tabPage1;
        private Label label12;
        private Label label13;
        private Button button3;
        private Label label15;
        private Label label14;
        private Button button5;
        private Button button4;
    }
}
