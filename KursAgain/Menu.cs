﻿using System;
using System.Windows.Forms;

namespace KursAgain
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Spravka spravka = new Spravka();
            spravka.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form form = new SimulationFormV2();
            form.ShowDialog();
        }
    }
}