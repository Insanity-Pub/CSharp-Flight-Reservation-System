namespace Project_VP
{
    partial class CancellationTbl
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
            CancelDGV = new DataGridView();
            label6 = new Label();
            TidCb = new ComboBox();
            label4 = new Label();
            FcodeTb = new ComboBox();
            label5 = new Label();
            label3 = new Label();
            CanId = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label11 = new Label();
            button4 = new Button();
            button5 = new Button();
            button2 = new Button();
            CancDate = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)CancelDGV).BeginInit();
            SuspendLayout();
            // 
            // CancelDGV
            // 
            CancelDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CancelDGV.Location = new Point(12, 498);
            CancelDGV.Name = "CancelDGV";
            CancelDGV.RowHeadersWidth = 51;
            CancelDGV.Size = new Size(940, 247);
            CancelDGV.TabIndex = 76;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.DarkBlue;
            label6.Location = new Point(482, 215);
            label6.Name = "label6";
            label6.Size = new Size(48, 21);
            label6.TabIndex = 67;
            label6.Text = "Date";
            // 
            // TidCb
            // 
            TidCb.FormattingEnabled = true;
            TidCb.Location = new Point(662, 148);
            TidCb.Name = "TidCb";
            TidCb.Size = new Size(167, 28);
            TidCb.TabIndex = 65;
            TidCb.SelectionChangeCommitted += TidCb_SelectionChangeCommitted;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.DarkBlue;
            label4.Location = new Point(482, 150);
            label4.Name = "label4";
            label4.Size = new Size(82, 21);
            label4.TabIndex = 64;
            label4.Text = "Ticket Id";
            // 
            // FcodeTb
            // 
            FcodeTb.FormattingEnabled = true;
            FcodeTb.Location = new Point(261, 211);
            FcodeTb.Name = "FcodeTb";
            FcodeTb.Size = new Size(167, 28);
            FcodeTb.TabIndex = 63;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.DarkBlue;
            label5.Location = new Point(81, 213);
            label5.Name = "label5";
            label5.Size = new Size(102, 21);
            label5.TabIndex = 62;
            label5.Text = "Flight Code";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.DarkBlue;
            label3.Location = new Point(81, 150);
            label3.Name = "label3";
            label3.Size = new Size(87, 21);
            label3.TabIndex = 61;
            label3.Text = "Cancelled";
            // 
            // CanId
            // 
            CanId.Location = new Point(261, 148);
            CanId.Name = "CanId";
            CanId.Size = new Size(167, 27);
            CanId.TabIndex = 60;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(312, 56);
            label2.Name = "label2";
            label2.Size = new Size(336, 42);
            label2.TabIndex = 59;
            label2.Text = "Ticket Cancellation";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(339, 14);
            label1.Name = "label1";
            label1.Size = new Size(285, 42);
            label1.TabIndex = 58;
            label1.Text = "3 Friends Airline";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(312, 420);
            label11.Name = "label11";
            label11.Size = new Size(312, 42);
            label11.TabIndex = 77;
            label11.Text = "Cancellations List";
            // 
            // button4
            // 
            button4.BackColor = Color.DarkBlue;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(576, 312);
            button4.Name = "button4";
            button4.Size = new Size(108, 41);
            button4.TabIndex = 80;
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
            button5.Location = new Point(406, 312);
            button5.Name = "button5";
            button5.Size = new Size(108, 41);
            button5.TabIndex = 79;
            button5.Text = "Clear";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.DarkBlue;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Sylfaen", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(225, 312);
            button2.Name = "button2";
            button2.Size = new Size(108, 41);
            button2.TabIndex = 78;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // CancDate
            // 
            CancDate.Location = new Point(662, 211);
            CancDate.Name = "CancDate";
            CancDate.Size = new Size(167, 27);
            CancDate.TabIndex = 81;
            // 
            // CancellationTbl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 748);
            Controls.Add(CancDate);
            Controls.Add(button4);
            Controls.Add(button5);
            Controls.Add(button2);
            Controls.Add(label11);
            Controls.Add(CancelDGV);
            Controls.Add(label6);
            Controls.Add(TidCb);
            Controls.Add(label4);
            Controls.Add(FcodeTb);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(CanId);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CancellationTbl";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CancellationTbl";
            Load += CancellationTbl_Load;
            ((System.ComponentModel.ISupportInitialize)CancelDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView CancelDGV;
        private Label label6;
        private ComboBox TidCb;
        private Label label4;
        private ComboBox FcodeTb;
        private Label label5;
        private Label label3;
        private TextBox CanId;
        private Label label2;
        private Label label1;
        private Label label11;
        private Button button4;
        private Button button5;
        private Button button2;
        private DateTimePicker CancDate;
    }
}