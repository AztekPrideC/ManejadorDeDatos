using System;
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
    public partial class Modificar : Form
    {
        public Modificar()
        {
            InitializeComponent();
        }
        
        AdmArchivos modificar = new AdmArchivos();
        
        private void button1_Click(object sender, EventArgs e)
        {
            modificar.reNombrar(textBox1.Text,textBox2.Text);
        }
    }
}
