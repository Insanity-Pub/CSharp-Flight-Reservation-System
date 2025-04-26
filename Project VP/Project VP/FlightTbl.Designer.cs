namespace Project_VP
{
    partial class FlightTbl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightTbl));
            label1 = new Label();
            label2 = new Label();
            FcodeTb = new TextBox();
            SeatNum = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            Fsrc = new ComboBox();
            FDest = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            label7 = new Label();
            FDate = new DateTimePicker();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(244, 22);
            label1.Name = "label1";
            label1.Size = new Size(285, 42);
            label1.TabIndex = 2;
            label1.Text = "3 Friends Airline";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(224, 74);
            label2.Name = "label2";
            label2.Size = new Size(338, 42);
            label2.TabIndex = 3;
            label2.Text = "Record New Flights";
            // 
            // FcodeTb
            // 
            FcodeTb.Location = new Point(192, 189);
            FcodeTb.Name = "FcodeTb";
            FcodeTb.Size = new Size(167, 27);
            FcodeTb.TabIndex = 8;
            // 
            // SeatNum
            // 
            SeatNum.Location = new Point(192, 418);
            SeatNum.Name = "SeatNum";
            SeatNum.Size = new Size(167, 27);
            SeatNum.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkBlue;
            label3.Location = new Point(12, 191);
            label3.Name = "label3";
            label3.Size = new Size(102, 21);
            label3.TabIndex = 10;
            label3.Text = "Flight Code";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkBlue;
            label4.Location = new Point(12, 420);
            label4.Name = "label4";
            label4.Size = new Size(115, 21);
            label4.TabIndex = 11;
            label4.Text = "Num of seats";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkBlue;
            label5.Location = new Point(12, 248);
            label5.Name = "label5";
            label5.Size = new Size(65, 21);
            label5.TabIndex = 12;
            label5.Text = "Source";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkBlue;
            label6.Location = new Point(12, 304);
            label6.Name = "label6";
            label6.Size = new Size(102, 21);
            label6.TabIndex = 13;
            label6.Text = "Destination";
            // 
            // Fsrc
            // 
            Fsrc.FormattingEnabled = true;
            Fsrc.Items.AddRange(new object[] { "Rawalpindi", "Islamabad", "Karachi", "Lahore", "Skardu", "Kashmir", "Dubai", "Qatar", "America", "Sydney", "Tokyo" });
            Fsrc.Location = new Point(192, 246);
            Fsrc.Name = "Fsrc";
            Fsrc.Size = new Size(167, 28);
            Fsrc.TabIndex = 14;
            // 
            // FDest
            // 
            FDest.FormattingEnabled = true;
            FDest.Items.AddRange(new object[] { "Rawalpindi", "Islamabad", "Karachi", "Lahore", "Skardu", "Kashmir", "Dubai", "Qatar", "America", "Sydney", "Tokyo" });
            FDest.Location = new Point(192, 302);
            FDest.Name = "FDest";
            FDest.Size = new Size(167, 28);
            FDest.TabIndex = 15;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(46, 496);
            button1.Name = "button1";
            button1.Size = new Size(108, 41);
            button1.TabIndex = 16;
            button1.Text = "Record";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(182, 496);
            button2.Name = "button2";
            button2.Size = new Size(108, 41);
            button2.TabIndex = 17;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(424, 189);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(371, 229);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 18;
            pictureBox1.TabStop = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkBlue;
            label7.Location = new Point(12, 366);
            label7.Name = "label7";
            label7.Size = new Size(109, 21);
            label7.TabIndex = 19;
            label7.Text = "Take of date";
            // 
            // FDate
            // 
            FDate.Location = new Point(192, 365);
            FDate.Name = "FDate";
            FDate.Size = new Size(167, 27);
            FDate.TabIndex = 20;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(151, 559);
            button3.Name = "button3";
            button3.Size = new Size(171, 41);
            button3.TabIndex = 21;
            button3.Text = "View Flights";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkBlue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(325, 496);
            button4.Name = "button4";
            button4.Size = new Size(108, 41);
            button4.TabIndex = 22;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // FlightTbl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoValidate = AutoValidate.EnablePreventFocusChange;
            ClientSize = new Size(807, 637);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(FDate);
            Controls.Add(label7);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(FDest);
            Controls.Add(Fsrc);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(SeatNum);
            Controls.Add(FcodeTb);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FlightTbl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FlightTbl";
            Load += FlightTbl_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox FcodeTb;
        private TextBox SeatNum;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox Fsrc;
        private ComboBox FDest;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private Label label7;
        private DateTimePicker FDate;
        private Button button3;
        private Button button4;
    }
}