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
            colorDialog1 = new ColorDialog();
            btnPickColor = new Button();
            btnToggle = new Button();
            label1 = new Label();
            lblStatus = new Label();
            label3 = new Label();
            label2 = new Label();
            TolTxt1 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            groupBox1 = new GroupBox();
            SleepTxt = new TextBox();
            label7 = new Label();
            label4 = new Label();
            panel1 = new Panel();
            label6 = new Label();
            label5 = new Label();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnPickColor
            // 
            btnPickColor.BackColor = Color.DodgerBlue;
            btnPickColor.FlatStyle = FlatStyle.Flat;
            btnPickColor.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPickColor.Location = new Point(9, 24);
            btnPickColor.Name = "btnPickColor";
            btnPickColor.Size = new Size(109, 31);
            btnPickColor.TabIndex = 0;
            btnPickColor.Text = "PICK A COLOR";
            btnPickColor.UseVisualStyleBackColor = false;
            btnPickColor.Click += btnPickColor_Click;
            // 
            // btnToggle
            // 
            btnToggle.BackColor = Color.DodgerBlue;
            btnToggle.FlatStyle = FlatStyle.Flat;
            btnToggle.Font = new Font("Impact", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnToggle.Location = new Point(349, 134);
            btnToggle.Name = "btnToggle";
            btnToggle.Size = new Size(109, 31);
            btnToggle.TabIndex = 1;
            btnToggle.Text = "START/STOP";
            btnToggle.UseVisualStyleBackColor = false;
            btnToggle.Click += btnToggle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Consolas", 9F);
            label1.Location = new Point(13, 169);
            label1.Name = "label1";
            label1.Size = new Size(56, 14);
            label1.TabIndex = 2;
            label1.Text = "Status:";
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Consolas", 9F);
            lblStatus.Location = new Point(75, 169);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(49, 14);
            lblStatus.TabIndex = 3;
            lblStatus.Text = "Stats_";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Consolas", 9F);
            label3.Location = new Point(132, 36);
            label3.Name = "label3";
            label3.Size = new Size(105, 14);
            label3.TabIndex = 4;
            label3.Text = "Choose a Color";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Consolas", 9F);
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Size = new Size(77, 14);
            label2.TabIndex = 5;
            label2.Text = "Tolerance:";
            // 
            // TolTxt1
            // 
            TolTxt1.Enabled = false;
            TolTxt1.Font = new Font("Consolas", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TolTxt1.Location = new Point(162, 66);
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
            button1.Location = new Point(131, 61);
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
            button2.Location = new Point(213, 60);
            button2.Name = "button2";
            button2.RightToLeft = RightToLeft.No;
            button2.Size = new Size(30, 34);
            button2.TabIndex = 9;
            button2.Text = "+";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(SleepTxt);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnToggle);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(btnPickColor);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(TolTxt1);
            groupBox1.Controls.Add(lblStatus);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(0, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(470, 198);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // SleepTxt
            // 
            SleepTxt.Location = new Point(131, 115);
            SleepTxt.Name = "SleepTxt";
            SleepTxt.Size = new Size(112, 23);
            SleepTxt.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Consolas", 9F);
            label7.Location = new Point(16, 121);
            label7.Name = "label7";
            label7.Size = new Size(49, 14);
            label7.TabIndex = 11;
            label7.Text = "Sleep:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(283, 169);
            label4.Name = "label4";
            label4.Size = new Size(175, 14);
            label4.TabIndex = 10;
            label4.Text = "Press \"F6\" to Start/Stop";
            label4.Click += label4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.DodgerBlue;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(470, 55);
            panel1.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Consolas", 9F);
            label6.Location = new Point(7, 32);
            label6.Name = "label6";
            label6.Size = new Size(84, 14);
            label6.TabIndex = 11;
            label6.Text = "by Kayleski";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Impact", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 7);
            label5.Name = "label5";
            label5.Size = new Size(172, 29);
            label5.TabIndex = 11;
            label5.Text = "Cursor Color Bot";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(470, 255);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ColorBot";
            FormClosing += Form1_FormClosing;
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ColorDialog colorDialog1;
        private Button btnPickColor;
        private Button btnToggle;
        private Label label1;
        private Label lblStatus;
        private Label label3;
        private Label label2;
        private TextBox TolTxt1;
        private Button button1;
        private Button button2;
        private GroupBox groupBox1;
        private Label label4;
        private Panel panel1;
        private Label label6;
        private Label label5;
        private TextBox SleepTxt;
        private Label label7;
    }
}
