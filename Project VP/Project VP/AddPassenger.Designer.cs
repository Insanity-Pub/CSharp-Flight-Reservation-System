namespace Project_VP
{
    partial class AddPassenger
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddPassenger));
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            Passid = new TextBox();
            label4 = new Label();
            PassName = new TextBox();
            label5 = new Label();
            PassportTb = new TextBox();
            label6 = new Label();
            PassAd = new TextBox();
            NationalityCb = new ComboBox();
            label7 = new Label();
            GenderCb = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            PhoneTb = new TextBox();
            button2 = new Button();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            button3 = new Button();
            button4 = new Button();
            panel1 = new Panel();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(214, 72);
            label2.Name = "label2";
            label2.Size = new Size(333, 42);
            label2.TabIndex = 5;
            label2.Text = "Record Passengers";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(234, 20);
            label1.Name = "label1";
            label1.Size = new Size(285, 42);
            label1.TabIndex = 4;
            label1.Text = "3 Friends Airline";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkBlue;
            label3.Location = new Point(12, 176);
            label3.Name = "label3";
            label3.Size = new Size(113, 21);
            label3.TabIndex = 25;
            label3.Text = "Passenger Id";
            // 
            // Passid
            // 
            Passid.Location = new Point(192, 174);
            Passid.Name = "Passid";
            Passid.Size = new Size(167, 27);
            Passid.TabIndex = 24;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkBlue;
            label4.Location = new Point(12, 230);
            label4.Name = "label4";
            label4.Size = new Size(143, 21);
            label4.TabIndex = 27;
            label4.Text = "Passenger Name";
            // 
            // PassName
            // 
            PassName.Location = new Point(192, 228);
            PassName.Name = "PassName";
            PassName.Size = new Size(167, 27);
            PassName.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkBlue;
            label5.Location = new Point(12, 289);
            label5.Name = "label5";
            label5.Size = new Size(150, 21);
            label5.TabIndex = 29;
            label5.Text = "Passport Number";
            // 
            // PassportTb
            // 
            PassportTb.Location = new Point(192, 287);
            PassportTb.Name = "PassportTb";
            PassportTb.Size = new Size(167, 27);
            PassportTb.TabIndex = 28;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkBlue;
            label6.Location = new Point(12, 347);
            label6.Name = "label6";
            label6.Size = new Size(150, 21);
            label6.TabIndex = 31;
            label6.Text = "Passport Address";
            // 
            // PassAd
            // 
            PassAd.Location = new Point(192, 345);
            PassAd.Name = "PassAd";
            PassAd.Size = new Size(167, 27);
            PassAd.TabIndex = 30;
            // 
            // NationalityCb
            // 
            NationalityCb.FormattingEnabled = true;
            NationalityCb.Items.AddRange(new object[] { "Pakistani", "Chinese", "American", "Indian", "British", "Spanish", "Turkish", "Arabian", "Ejyptian" });
            NationalityCb.Location = new Point(192, 405);
            NationalityCb.Name = "NationalityCb";
            NationalityCb.Size = new Size(167, 28);
            NationalityCb.TabIndex = 33;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkBlue;
            label7.Location = new Point(12, 407);
            label7.Name = "label7";
            label7.Size = new Size(99, 21);
            label7.TabIndex = 32;
            label7.Text = "Nationality";
            // 
            // GenderCb
            // 
            GenderCb.FormattingEnabled = true;
            GenderCb.Items.AddRange(new object[] { "Male", "Female" });
            GenderCb.Location = new Point(192, 464);
            GenderCb.Name = "GenderCb";
            GenderCb.Size = new Size(167, 28);
            GenderCb.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DarkBlue;
            label8.Location = new Point(12, 466);
            label8.Name = "label8";
            label8.Size = new Size(69, 21);
            label8.TabIndex = 34;
            label8.Text = "Gender";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DarkBlue;
            label9.Location = new Point(12, 523);
            label9.Name = "label9";
            label9.Size = new Size(59, 21);
            label9.TabIndex = 37;
            label9.Text = "Phone";
            // 
            // PhoneTb
            // 
            PhoneTb.Location = new Point(192, 521);
            PhoneTb.Name = "PhoneTb";
            PhoneTb.Size = new Size(167, 27);
            PhoneTb.TabIndex = 36;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(215, 584);
            button2.Name = "button2";
            button2.Size = new Size(108, 41);
            button2.TabIndex = 39;
            button2.Text = "Reset";
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(79, 584);
            button1.Name = "button1";
            button1.Size = new Size(108, 41);
            button1.TabIndex = 38;
            button1.Text = "Record";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(413, 218);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(371, 229);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 41;
            pictureBox1.TabStop = false;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(481, 584);
            button3.Name = "button3";
            button3.Size = new Size(181, 41);
            button3.TabIndex = 42;
            button3.Text = "View Passengers";
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
            button4.Location = new Point(352, 584);
            button4.Name = "button4";
            button4.Size = new Size(108, 41);
            button4.TabIndex = 43;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(label10);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(807, 23);
            panel1.TabIndex = 44;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(784, 0);
            label10.Name = "label10";
            label10.Size = new Size(20, 19);
            label10.TabIndex = 45;
            label10.Text = "X";
            label10.Click += label10_Click_1;
            // 
            // AddPassenger
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 637);
            Controls.Add(panel1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label9);
            Controls.Add(PhoneTb);
            Controls.Add(GenderCb);
            Controls.Add(label8);
            Controls.Add(NationalityCb);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(PassAd);
            Controls.Add(label5);
            Controls.Add(PassportTb);
            Controls.Add(label4);
            Controls.Add(PassName);
            Controls.Add(label3);
            Controls.Add(Passid);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddPassenger";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddPassenger";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox Passid;
        private Label label4;
        private TextBox PassName;
        private Label label5;
        private TextBox PassportTb;
        private Label label6;
        private TextBox PassAd;
        private ComboBox NationalityCb;
        private Label label7;
        private ComboBox GenderCb;
        private Label label8;
        private Label label9;
        private TextBox PhoneTb;
        private Button button2;
        private Button button1;
        private PictureBox pictureBox1;
        private Button button3;
        private Button button4;
        private Panel panel1;
        private Label label10;
    }
}