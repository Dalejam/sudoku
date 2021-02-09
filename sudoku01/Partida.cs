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
           /* for(int fila = 0; fila<9; fila++)
            {
                for(int columna= 0; columna < 9; columna++)
                {
                    dataTablero.Rows[fila].Cells[columna].Value = tablero[fila, columna];
                }
            }*/
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
                            dataTablero.Rows[fila].Cells[columna].Value = tablero[fila, columna];
                            tablero[fila, columna] = datos[posicion];
                            posicion++;
                        }
                    }
                }


            }
        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
