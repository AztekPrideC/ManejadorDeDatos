﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManejadorDeDatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            MessageBox.Show("Bienvenido");
        }

        private void nuevaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // wireframes





        }

        private void button1_Click(object sender, EventArgs e)
        {

            Crear pestañaNueva = new Crear();
            pestañaNueva.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
           Menu pestañaNueva = new Menu();
            pestañaNueva.Show();
        }
    }
}
