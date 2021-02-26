using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sudoku01.clases
{
    public class JugarPartida
    {
        private string[,] matriz;
        
        public string Matriz { get; set; }

        public void llenarTablero(string nivel)
        {
            switch (nivel)
            {
                case "facil":
                    string validacion = "datos.txt";
                    StreamReader leer = File.OpenText(validacion);
                    while (!leer.EndOfStream)
                    {
                        string Lactual = leer.ReadLine();
                        string[] datos = Lactual.Split(',');
                        string[] linea = File.ReadAllLines(validacion);
                        int calin = linea.Length;
                        int posicion = 0;
                        while (posicion < 81)
                        {
                            for (int fila = 0; fila < 9; fila++)
                            {
                                for (int columna = 0; columna < 9; columna++)
                                {
                                    if(posicion%2==0)
                                    {
                                        matriz[fila, columna] = datos[posicion];
                                    }
                                    else
                                    {
                                        matriz[fila, columna] = " ";
                                    }
                                    
                                    posicion++;
                                }
                            }
                        }

                    }
                    break;
                default:
                    MessageBox.Show("Ingresar Nivel para poder Iniciar");
                    break;
            }
        }

        

    }
}
