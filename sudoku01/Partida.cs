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
                            
                            tablero[fila, columna] = datos[posicion];
                            dataTablero.Rows[fila].Cells[columna].Value = tablero[fila, columna];
                            posicion++;
                        }
                    }
                }


            }
            leer.Close();

            string numeroIngresado = this.dataTablero.CurrentCell.Value.ToString();
            int X, Y;
            X = dataTablero.CurrentCellAddress.X;
            Y = dataTablero.CurrentCellAddress.Y;
            bool comparaFila, comparaColumna;
            if (dataTablero.Rows[X].Cells.ToString().Contains(numeroIngresado))
            {
                comparaFila = true;
            }
            else
            {
                comparaFila = false;
            }
            if (dataTablero.Columns[Y].ToString().Contains(numeroIngresado))
            {
                comparaColumna = true;
            }
            else
            {
                comparaColumna = false;
            }
            if (comparaColumna == true || comparaFila == true)
            {
                dataTablero.CurrentCell.Style.BackColor = Color.Red;
            }


        }

        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btValidar_Click(object sender, EventArgs e)
        {
            string numeroIngresado = this.dataTablero.CurrentCell.Value.ToString();
            int fila, columna;
            fila =Convert.ToInt32( dataTablero.CurrentCellAddress.X);
            columna = dataTablero.CurrentCellAddress.Y;
            string infFila, infColumna;
            char[] vectorFila = new char[9];
            char[] vectorColumna = new char[9];
            infFila = ;
            infColumna = dataTablero.CurrentRow.Cells[columna].Value.ToString();
            vectorFila = infFila.ToCharArray();

            //MessageBox.Show("la fila tiene " + fila + "La Columna es: " + columna +"\n el dato que esta en la casilla es:" + numeroIngresado);
            MessageBox.Show("el vector" + infFila);
            
        }

    }
}
