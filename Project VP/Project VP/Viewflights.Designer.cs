namespace Project_VP
{
    partial class Viewflights
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
            FDate = new DateTimePicker();
            label7 = new Label();
            DstCb = new ComboBox();
            SrcCb = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            Seatnum = new TextBox();
            FcodeTb = new TextBox();
            FlightDGV = new DataGridView();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)FlightDGV).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(197, 81);
            label2.Name = "label2";
            label2.Size = new Size(401, 42);
            label2.TabIndex = 5;
            label2.Text = "View Scheduled Flights";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(237, 29);
            label1.Name = "label1";
            label1.Size = new Size(285, 42);
            label1.TabIndex = 4;
            label1.Text = "3 Friends Airline";
            // 
            // FDate
            // 
            FDate.Location = new Point(505, 247);
            FDate.Name = "FDate";
            FDate.Size = new Size(167, 27);
            FDate.TabIndex = 30;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkBlue;
            label7.Location = new Point(390, 253);
            label7.Name = "label7";
            label7.Size = new Size(109, 21);
            label7.TabIndex = 29;
            label7.Text = "Take of date";
            // 
            // DstCb
            // 
            DstCb.FormattingEnabled = true;
            DstCb.Items.AddRange(new object[] { "Rawalpindi", "Islamabad", "Karachi", "Lahore", "Skardu", "Kashmir", "Dubai", "Qatar", "America", "Sydney", "Tokyo" });
            DstCb.Location = new Point(192, 249);
            DstCb.Name = "DstCb";
            DstCb.Size = new Size(167, 28);
            DstCb.TabIndex = 28;
            // 
            // SrcCb
            // 
            SrcCb.FormattingEnabled = true;
            SrcCb.Items.AddRange(new object[] { "Rawalpindi", "Islamabad", "Karachi", "Lahore", "Skardu", "Kashmir", "Dubai", "Qatar", "America", "Sydney", "Tokyo" });
            SrcCb.Location = new Point(505, 190);
            SrcCb.Name = "SrcCb";
            SrcCb.Size = new Size(167, 28);
            SrcCb.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkBlue;
            label6.Location = new Point(12, 251);
            label6.Name = "label6";
            label6.Size = new Size(102, 21);
            label6.TabIndex = 26;
            label6.Text = "Destination";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkBlue;
            label5.Location = new Point(409, 193);
            label5.Name = "label5";
            label5.Size = new Size(65, 21);
            label5.TabIndex = 25;
            label5.Text = "Source";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkBlue;
            label4.Location = new Point(12, 307);
            label4.Name = "label4";
            label4.Size = new Size(115, 21);
            label4.TabIndex = 24;
            label4.Text = "Num of seats";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkBlue;
            label3.Location = new Point(12, 193);
            label3.Name = "label3";
            label3.Size = new Size(102, 21);
            label3.TabIndex = 23;
            label3.Text = "Flight Code";
            // 
            // Seatnum
            // 
            Seatnum.Location = new Point(192, 307);
            Seatnum.Name = "Seatnum";
            Seatnum.Size = new Size(167, 27);
            Seatnum.TabIndex = 22;
            // 
            // FcodeTb
            // 
            FcodeTb.Location = new Point(192, 191);
            FcodeTb.Name = "FcodeTb";
            FcodeTb.Size = new Size(167, 27);
            FcodeTb.TabIndex = 21;
            // 
            // FlightDGV
            // 
            FlightDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            FlightDGV.Location = new Point(1, 411);
            FlightDGV.Name = "FlightDGV";
            FlightDGV.RowHeadersWidth = 51;
            FlightDGV.Size = new Size(804, 214);
            FlightDGV.TabIndex = 31;
            FlightDGV.CellContentClick += FlightDGV_CellContentClick;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(298, 354);
            button2.Name = "button2";
            button2.Size = new Size(108, 41);
            button2.TabIndex = 33;
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
            button1.Location = new Point(170, 354);
            button1.Name = "button1";
            button1.Size = new Size(108, 41);
            button1.TabIndex = 32;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.DarkBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(426, 354);
            button3.Name = "button3";
            button3.Size = new Size(108, 41);
            button3.TabIndex = 34;
            button3.Text = "Reset";
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
            button4.Location = new Point(554, 354);
            button4.Name = "button4";
            button4.Size = new Size(108, 41);
            button4.TabIndex = 35;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // Viewflights
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(807, 637);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(FlightDGV);
            Controls.Add(FDate);
            Controls.Add(label7);
            Controls.Add(DstCb);
            Controls.Add(SrcCb);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(Seatnum);
            Controls.Add(FcodeTb);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Viewflights";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Viewflights";
            Load += Viewflights_Load;
            ((System.ComponentModel.ISupportInitialize)FlightDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private DateTimePicker FDate;
        private Label label7;
        private ComboBox DstCb;
        private ComboBox SrcCb;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox Seatnum;
        private TextBox FcodeTb;
        private DataGridView FlightDGV;
        private Button button2;
        private Button button1;
        private Button button3;
        private Button button4;
    }
}