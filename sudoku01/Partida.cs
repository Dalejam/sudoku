using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sudoku01
{
    public partial class Partida : Form
    {
        public Partida()
        {
            InitializeComponent();
        }

        string[,] tablero;
        private void btIniciar_Click(object sender, EventArgs e)
        {
            tablero = new string[9, 9];
            dataTablero.ColumnCount = 9;
            dataTablero.RowCount = 9;
           
            string validacion = "datos.txt";
            StreamReader leer = File.OpenText(validacion);
            while (!leer.EndOfStream)
            {
                string Lactual = leer.ReadLine();
                string[] datos = Lactual.Split(',');
                string[] linea = File.ReadAllLines(validacion);
                int calin = linea.Length;
                int posicion = 0;
                int espacio=0;
                while (posicion < 81)
                {
                    for (int fila = 0; fila < 9; fila++)
                    {
                        for (int columna = 0; columna < 9; columna++)
                        {
                            
                            if (espacio>=5)
                            {
                                tablero[fila, columna] = datos[posicion];
                                dataTablero.Rows[fila].Cells[columna].Value = tablero[fila, columna];
                                posicion++;
                                espacio--;
                            }
                            else
                            {
                                tablero[fila, columna] = "";
                                dataTablero.Rows[fila].Cells[columna].Value = tablero[fila, columna];
                                posicion++;
                                espacio++;

                            }
                            
                        }
                    }
                }


            }
            leer.Close();

            


        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btValidar_Click(object sender, EventArgs e)
        {
            string numeroIngresado = this.dataTablero.CurrentCell.Value.ToString();
            int fila, columna;
            fila =Convert.ToInt32(dataTablero.CurrentCellAddress.Y );
            columna = dataTablero.CurrentCellAddress.X;
            string infFila, infColumna;
            char[] vectorFila = new char[9];
            char[] vectorColumna = new char[9];
            infFila = valoresFila(columna);
            infColumna = valoresColumna(columna);
            
        }

        private string valoresFila(int numeroFila)
        {
            string datos = "";
            for (int i = 0; i < 9; i++)
            {
                datos = datos + tablero[numeroFila, i];

            }
            return datos;
        }
        private string valoresColumna(int numeroColumna)
        {
            string datos = "";
            for (int i = 0; i < 9; i++)
            {
                datos = datos + tablero[i, numeroColumna];
            }
            return datos;
        }
        private int aleatorio()
        {
            int numero;
            Random random = new Random();
            numero = random.Next(1, 2);
            return numero;

        }

        private void btEstadistica_Click(object sender, EventArgs e)
        {
            Estadistica abrir = new Estadistica();
            abrir.Show();

            tablero = new string[9, 9];
            abrir.dataEstadistica.ColumnCount = 9;
            abrir.dataEstadistica.RowCount = 9;

            string validacion = "datos.txt";
            StreamReader leer = File.OpenText(validacion);
            string Lactual = leer.ReadLine();
            string[] datos = Lactual.Split(',');
            string[] linea = File.ReadAllLines(validacion);
            int calin = linea.Length;
            int posicion = 0;
            int espacio = 0;
            while (posicion < 81)
            {
                for (int fila = 0; fila < 9; fila++)
                {
                    for (int columna = 0; columna < 9; columna++)
                    {

                        tablero[fila, columna] = datos[posicion];
                        abrir.dataEstadistica.Rows[fila].Cells[columna].Value = tablero[fila, columna];
                        posicion++;

                    }
                }
            }


        }
    }
}
