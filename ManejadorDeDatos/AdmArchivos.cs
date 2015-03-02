using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejadorDeDatos
{
    class AdmArchivos
    {
        private string rutaArchivo;
        private string archivo;
        public AdmArchivos()
        {

        }

        public AdmArchivos(string ruta, string archivo)
        {
            this.rutaArchivo = ruta;
            this.archivo = archivo;

        }

        //crud
        public void CrearArchivo(string nombreArchivo)
        {
           
            var BD = File.CreateText(nombreArchivo+".txt");
            BD.Close();
        
        }


        public void reNombrar(string nombreArchivo,string nuevoNombre) 
        {
            File.Move(nombreArchivo, nuevoNombre);
        
        }


    }
}
