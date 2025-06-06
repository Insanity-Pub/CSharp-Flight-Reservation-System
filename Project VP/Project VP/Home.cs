﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_VP
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FlightTbl flight = new FlightTbl();
            flight.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddPassenger pass = new AddPassenger();
            pass.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ticket tick = new Ticket();
            tick.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CancellationTbl cancel = new CancellationTbl();
            cancel.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
