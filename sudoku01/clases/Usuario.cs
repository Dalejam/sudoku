using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sudoku01.clases
{
    public class Usuario
    {
        private string nombre;
        private string nusuario;
        private string clave;
        private int puntaje;



        public string Nombre { get; set; }
        public string Nusuario { get; set; }
        public string Clave { get; set; }
        public int Puntaje { get; set; }

        public void crearUsuario( string nombre,string Tusuario,string clave)
        {
            string Linea = "usuarios.txt";
            StreamWriter Ingresar = File.AppendText(Linea);
            Ingresar.WriteLine("{0},{1},{2},{3}", nombre,Tusuario,clave,0);
            MessageBox.Show("Usuario registrado");
            Ingresar.Close();
           
        }


    }
}
