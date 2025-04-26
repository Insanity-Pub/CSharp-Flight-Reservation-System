namespace Project_VP
{
    partial class ViewPassenger
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
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            PidTb = new TextBox();
            label5 = new Label();
            PpassTb = new TextBox();
            label4 = new Label();
            PnameTb = new TextBox();
            label6 = new Label();
            PaddTb = new TextBox();
            label9 = new Label();
            PphoneTb = new TextBox();
            GendCb = new ComboBox();
            label8 = new Label();
            natcb = new ComboBox();
            label7 = new Label();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            PassengerDGV = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)PassengerDGV).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(254, 79);
            label2.Name = "label2";
            label2.Size = new Size(298, 42);
            label2.TabIndex = 7;
            label2.Text = "View Passengers";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(261, 27);
            label1.Name = "label1";
            label1.Size = new Size(285, 42);
            label1.TabIndex = 6;
            label1.Text = "3 Friends Airline";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkBlue;
            label3.Location = new Point(16, 179);
            label3.Name = "label3";
            label3.Size = new Size(113, 21);
            label3.TabIndex = 27;
            label3.Text = "Passenger Id";
            // 
            // PidTb
            // 
            PidTb.Location = new Point(196, 177);
            PidTb.Name = "PidTb";
            PidTb.Size = new Size(167, 27);
            PidTb.TabIndex = 26;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkBlue;
            label5.Location = new Point(16, 242);
            label5.Name = "label5";
            label5.Size = new Size(150, 21);
            label5.TabIndex = 33;
            label5.Text = "Passport Number";
            // 
            // PpassTb
            // 
            PpassTb.Location = new Point(196, 240);
            PpassTb.Name = "PpassTb";
            PpassTb.Size = new Size(167, 27);
            PpassTb.TabIndex = 32;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkBlue;
            label4.Location = new Point(407, 181);
            label4.Name = "label4";
            label4.Size = new Size(143, 21);
            label4.TabIndex = 31;
            label4.Text = "Passenger Name";
            // 
            // PnameTb
            // 
            PnameTb.Location = new Point(587, 179);
            PnameTb.Name = "PnameTb";
            PnameTb.Size = new Size(167, 27);
            PnameTb.TabIndex = 30;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkBlue;
            label6.Location = new Point(407, 244);
            label6.Name = "label6";
            label6.Size = new Size(150, 21);
            label6.TabIndex = 35;
            label6.Text = "Passport Address";
            // 
            // PaddTb
            // 
            PaddTb.Location = new Point(587, 242);
            PaddTb.Name = "PaddTb";
            PaddTb.Size = new Size(167, 27);
            PaddTb.TabIndex = 34;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.DarkBlue;
            label9.Location = new Point(16, 372);
            label9.Name = "label9";
            label9.Size = new Size(59, 21);
            label9.TabIndex = 43;
            label9.Text = "Phone";
            // 
            // PphoneTb
            // 
            PphoneTb.Location = new Point(196, 370);
            PphoneTb.Name = "PphoneTb";
            PphoneTb.Size = new Size(167, 27);
            PphoneTb.TabIndex = 42;
            // 
            // GendCb
            // 
            GendCb.FormattingEnabled = true;
            GendCb.Items.AddRange(new object[] { "Male", "Female" });
            GendCb.Location = new Point(587, 307);
            GendCb.Name = "GendCb";
            GendCb.Size = new Size(167, 28);
            GendCb.TabIndex = 41;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DarkBlue;
            label8.Location = new Point(407, 309);
            label8.Name = "label8";
            label8.Size = new Size(69, 21);
            label8.TabIndex = 40;
            label8.Text = "Gender";
            // 
            // natcb
            // 
            natcb.FormattingEnabled = true;
            natcb.Items.AddRange(new object[] { "Pakistani", "Chinese", "American", "Indian", "British", "Spanish", "Turkish", "Arabian", "Ejyptian" });
            natcb.Location = new Point(196, 307);
            natcb.Name = "natcb";
            natcb.Size = new Size(167, 28);
            natcb.TabIndex = 39;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkBlue;
            label7.Location = new Point(16, 309);
            label7.Name = "label7";
            label7.Size = new Size(99, 21);
            label7.TabIndex = 38;
            label7.Text = "Nationality";
            // 
            // button4
            // 
            button4.BackColor = Color.DarkBlue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(577, 414);
            button4.Name = "button4";
            button4.Size = new Size(108, 41);
            button4.TabIndex = 48;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(449, 414);
            button3.Name = "button3";
            button3.Size = new Size(108, 41);
            button3.TabIndex = 47;
            button3.Text = "Reset";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(321, 414);
            button2.Name = "button2";
            button2.Size = new Size(108, 41);
            button2.TabIndex = 46;
            button2.Text = "Delete";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(193, 414);
            button1.Name = "button1";
            button1.Size = new Size(108, 41);
            button1.TabIndex = 45;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // PassengerDGV
            // 
            PassengerDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            PassengerDGV.Location = new Point(-4, 461);
            PassengerDGV.Name = "PassengerDGV";
            PassengerDGV.RowHeadersWidth = 51;
            PassengerDGV.Size = new Size(812, 174);
            PassengerDGV.TabIndex = 44;
            PassengerDGV.CellContentClick += PassengerDGV_CellContentClick;
            // 
            // ViewPassenger
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 637);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(PassengerDGV);
            Controls.Add(label9);
            Controls.Add(PphoneTb);
            Controls.Add(GendCb);
            Controls.Add(label8);
            Controls.Add(natcb);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(PaddTb);
            Controls.Add(label5);
            Controls.Add(PpassTb);
            Controls.Add(label4);
            Controls.Add(PnameTb);
            Controls.Add(label3);
            Controls.Add(PidTb);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ViewPassenger";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ViewPassenger";
            Load += ViewPassenger_Load;
            ((System.ComponentModel.ISupportInitialize)PassengerDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox PidTb;
        private Label label5;
        private TextBox PpassTb;
        private Label label4;
        private TextBox PnameTb;
        private Label label6;
        private TextBox PaddTb;
        private Label label9;
        private TextBox PphoneTb;
        private ComboBox GendCb;
        private Label label8;
        private ComboBox natcb;
        private Label label7;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private DataGridView PassengerDGV;
    }
}