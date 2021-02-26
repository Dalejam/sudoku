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
        



        public string Nombre { get; set; }
        public string Nusuario { get; set; }
        public string Clave { get; set; }
        public int Puntaje { get; set; }

        public void crearUsuario( string nombre,string Tusuario,string clave)
        {
            string Linea = "usuarios.txt";
            StreamWriter Ingresar = File.AppendText(Linea);
            Ingresar.WriteLine("{0},{1},{2}", nombre,Tusuario,clave);
            MessageBox.Show("Usuario registrado","SUDOKU");
            Ingresar.Close();
           
        }

        public void guardarPuntaje(string usuario, string nivel , string puntaje)
        {
            int valorT = Convert.ToInt32(puntaje);
            string origina = "estadisticas.txt";
            string copia = "estadisticas - copia.txt";
            StreamWriter escribir = File.AppendText(origina);
            StreamReader leer = File.OpenText(copia);
            int suma;

            while (!leer.EndOfStream)
            {
                string lineaActual = leer.ReadLine();
                string[] vector = lineaActual.Split(',');
                if (vector[0] == usuario && vector[1] ==nivel)
                {
                    suma = (Convert.ToInt32(vector[2])) + valorT;
                    escribir.WriteLine("{0},{1},{2}", vector[0], vector[1], suma);

                }
                else
                {
                    escribir.WriteLine(lineaActual);
                }

            }
            escribir.Close();
            leer.Close();

        }




    }
}
