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
    public partial class Abrir : Form
    {
        public Abrir()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            System.IO.StreamReader file =
             //   string direccion=textBox1.Text
 


    new System.IO.StreamReader(@"c:\test.txt");
            
        }
    }
}
