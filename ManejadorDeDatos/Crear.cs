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
    public partial class Crear : Form
    {
        public Crear()
        {
            InitializeComponent();
        }

        AdmArchivos crear = new AdmArchivos();

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtNombreArchivo.Equals(null))
            {
                MessageBox.Show("No dejes los campos vacios");
            }
            else
            {
                crear.CrearArchivo(txtNombreArchivo.Text);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
