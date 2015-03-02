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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void nombreDelArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Modificar pestañaNueva = new Modificar();
            pestañaNueva.Show();
        }

        private void abrirArchivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
