namespace Project_VP
{
    partial class Ticket
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
            Tid = new TextBox();
            PIdCb = new ComboBox();
            label5 = new Label();
            FCodeCb = new ComboBox();
            label4 = new Label();
            label6 = new Label();
            PNameTb = new TextBox();
            label7 = new Label();
            PPassTb = new TextBox();
            label8 = new Label();
            PNatTb = new TextBox();
            label10 = new Label();
            PAmtTb = new TextBox();
            TicketDGV = new DataGridView();
            label11 = new Label();
            button3 = new Button();
            button1 = new Button();
            button4 = new Button();
            button5 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)TicketDGV).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(299, 63);
            label2.Name = "label2";
            label2.Size = new Size(264, 42);
            label2.TabIndex = 7;
            label2.Text = "Ticket Booking";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(291, 21);
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
            label3.Location = new Point(12, 142);
            label3.Name = "label3";
            label3.Size = new Size(82, 21);
            label3.TabIndex = 27;
            label3.Text = "Ticket Id";
            // 
            // Tid
            // 
            Tid.Location = new Point(192, 140);
            Tid.Name = "Tid";
            Tid.Size = new Size(167, 27);
            Tid.TabIndex = 26;
            // 
            // PIdCb
            // 
            PIdCb.FormattingEnabled = true;
            PIdCb.Location = new Point(192, 203);
            PIdCb.Name = "PIdCb";
            PIdCb.Size = new Size(167, 28);
            PIdCb.TabIndex = 44;
            PIdCb.SelectionChangeCommitted += PIdCb_SelectionChangeCommitted;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkBlue;
            label5.Location = new Point(12, 205);
            label5.Name = "label5";
            label5.Size = new Size(113, 21);
            label5.TabIndex = 43;
            label5.Text = "Passenger Id";
            // 
            // FCodeCb
            // 
            FCodeCb.FormattingEnabled = true;
            FCodeCb.Location = new Point(593, 140);
            FCodeCb.Name = "FCodeCb";
            FCodeCb.Size = new Size(167, 28);
            FCodeCb.TabIndex = 46;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkBlue;
            label4.Location = new Point(413, 142);
            label4.Name = "label4";
            label4.Size = new Size(102, 21);
            label4.TabIndex = 45;
            label4.Text = "Flight Code";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkBlue;
            label6.Location = new Point(413, 207);
            label6.Name = "label6";
            label6.Size = new Size(57, 21);
            label6.TabIndex = 48;
            label6.Text = "Name";
            // 
            // PNameTb
            // 
            PNameTb.Location = new Point(593, 205);
            PNameTb.Name = "PNameTb";
            PNameTb.Size = new Size(167, 27);
            PNameTb.TabIndex = 47;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.DarkBlue;
            label7.Location = new Point(12, 270);
            label7.Name = "label7";
            label7.Size = new Size(80, 21);
            label7.TabIndex = 50;
            label7.Text = "Passport";
            // 
            // PPassTb
            // 
            PPassTb.Location = new Point(192, 268);
            PPassTb.Name = "PPassTb";
            PPassTb.Size = new Size(167, 27);
            PPassTb.TabIndex = 49;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.DarkBlue;
            label8.Location = new Point(413, 272);
            label8.Name = "label8";
            label8.Size = new Size(99, 21);
            label8.TabIndex = 52;
            label8.Text = "Nationality";
            // 
            // PNatTb
            // 
            PNatTb.Location = new Point(593, 270);
            PNatTb.Name = "PNatTb";
            PNatTb.Size = new Size(167, 27);
            PNatTb.TabIndex = 51;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.DarkBlue;
            label10.Location = new Point(12, 333);
            label10.Name = "label10";
            label10.Size = new Size(73, 21);
            label10.TabIndex = 56;
            label10.Text = "Amount";
            // 
            // PAmtTb
            // 
            PAmtTb.Location = new Point(192, 331);
            PAmtTb.Name = "PAmtTb";
            PAmtTb.Size = new Size(167, 27);
            PAmtTb.TabIndex = 55;
            // 
            // TicketDGV
            // 
            TicketDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TicketDGV.Location = new Point(3, 529);
            TicketDGV.Name = "TicketDGV";
            TicketDGV.RowHeadersWidth = 51;
            TicketDGV.Size = new Size(946, 218);
            TicketDGV.TabIndex = 57;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Bookman Old Style", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(411, 484);
            label11.Name = "label11";
            label11.Size = new Size(121, 28);
            label11.TabIndex = 58;
            label11.Text = "Bookings";
            // 
            // button3
            // 
            button3.BackColor = Color.DarkBlue;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(391, 400);
            button3.Name = "button3";
            button3.Size = new Size(108, 41);
            button3.TabIndex = 61;
            button3.Text = "Reset";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.DarkBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(210, 400);
            button1.Name = "button1";
            button1.Size = new Size(108, 41);
            button1.TabIndex = 59;
            button1.Text = "Book";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkBlue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(561, 400);
            button4.Name = "button4";
            button4.Size = new Size(108, 41);
            button4.TabIndex = 62;
            button4.Text = "Back";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkBlue;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.ForeColor = Color.White;
            button5.Location = new Point(391, 400);
            button5.Name = "button5";
            button5.Size = new Size(108, 41);
            button5.TabIndex = 61;
            button5.Text = "Reset";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(210, 400);
            button2.Name = "button2";
            button2.Size = new Size(108, 41);
            button2.TabIndex = 59;
            button2.Text = "Book";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button1_Click;
            // 
            // Ticket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 748);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label11);
            Controls.Add(TicketDGV);
            Controls.Add(label10);
            Controls.Add(PAmtTb);
            Controls.Add(label8);
            Controls.Add(PNatTb);
            Controls.Add(label7);
            Controls.Add(PPassTb);
            Controls.Add(label6);
            Controls.Add(PNameTb);
            Controls.Add(FCodeCb);
            Controls.Add(label4);
            Controls.Add(PIdCb);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(Tid);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Ticket";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ticket";
            Load += Ticket_Load;
            ((System.ComponentModel.ISupportInitialize)TicketDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox Tid;
        private ComboBox PIdCb;
        private Label label5;
        private ComboBox FCodeCb;
        private Label label4;
        private Label label6;
        private TextBox PNameTb;
        private Label label7;
        private TextBox PPassTb;
        private Label label8;
        private TextBox PNatTb;
        private Label label10;
        private TextBox PAmtTb;
        private DataGridView TicketDGV;
        private Label label11;
        private Button button3;
        private Button button1;
        private Button button4;
        private Button button5;
        private Button button2;
    }
}