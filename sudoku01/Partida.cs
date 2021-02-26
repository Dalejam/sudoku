using sudoku01.clases;
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
        Usuario Nusuario = new Usuario();
        public Partida()
        {
            InitializeComponent();
            llenarTablero();
            
        }

        string[,] tablero;
        private void btIniciar_Click(object sender, EventArgs e)
        {
            llenarTablero();

            

        }
        private void btValidar_Click(object sender, EventArgs e)
        {
            bool color=false;
            string tono = "verde";
            validacionTablero();
            while (tono == "verde" && color == false)
            {
                for (int f = 0; f < 9; f++)
                {
                    for (int c = 0; c < 9; c++)
                    {
                        if (dataTablero.Rows[f].Cells[c].Style.BackColor == Color.Coral)
                        {
                            color = true;
                            tono = "Rojo";
                            lbPuntaje.Text = "0";
                            c = 9;
                            f = 9;

                        }

                    }

                }
            }
            if (tono == "verde")
            {
                lbPuntaje.Text = "500";
            }
           
            Nusuario.guardarPuntaje(lbUsuario.Text,lbNivel.Text,lbPuntaje.Text);
            vaciarTablero();

        }

        public void llenarTablero()
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
                int espacio = 0;
                while (posicion < 81)
                {
                    for (int fila = 0; fila < 9; fila++)
                    {
                        for (int columna = 0; columna < 9; columna++)
                        {

                            if (espacio >= 5)
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
        public void validacionTablero()
        {
            dataTablero.ColumnCount = 9;
            dataTablero.RowCount = 9;
            string validacionJuego = "datos.txt";
            StreamReader leer = File.OpenText(validacionJuego);
            while (!leer.EndOfStream)
            {
                string Lactual = leer.ReadLine();
                string[] datos = Lactual.Split(',');
                string[] linea = File.ReadAllLines(validacionJuego);
                int calin = linea.Length;
                int posicion = 0;
                string celda;
                while (posicion < 81)
                {
                    for (int fila = 0; fila < 9; fila++)
                    {
                        for (int columna = 0; columna < 9; columna++)
                        {
                            celda = tablero[fila, columna];
                            if (celda == datos[posicion])
                            {
                                this.dataTablero.Rows[fila].Cells[columna].Style.BackColor = Color.Green;
                            }
                            else
                            {
                                this.dataTablero.Rows[fila].Cells[columna].Style.BackColor = Color.Coral;
                            }
                            posicion++;

                        }
                    }
                }

            }

        }
        public void validacionCelda()
        {
            string numeroIngresado = this.dataTablero.CurrentCell.Value.ToString();
            int fila, columna;
            bool validacionFila, validacionColumna,validacionC;
            fila = Convert.ToInt32(dataTablero.CurrentCellAddress.Y);
            columna = dataTablero.CurrentCellAddress.X;
            string infFila, infColumna;
            char[] vectorFila = new char[9];
            char[] vectorColumna = new char[9];
            infFila = valoresFila(fila);
            infColumna = valoresColumna(columna);
            validacionColumna = infColumna.Contains(numeroIngresado);
            validacionFila = infFila.Contains(numeroIngresado);
            validacionC = validacionCuadrante(fila,columna);
            while (validacionFila == true || validacionColumna == true||validacionC)
            {
                dataTablero.Rows[fila].Cells[columna].Style.BackColor = Color.IndianRed;
            }


        }

        public bool validacionCuadrante(int fila, int columna)
        {
            string posicionDato = this.dataTablero.CurrentCell.Value.ToString();
            string cuadrante="";
            bool validaCuadrante;
            
            if(posicionDato=="1" || posicionDato == "2"|| posicionDato == "3"
                || posicionDato == "10"|| posicionDato == "11"|| posicionDato == "12"
                || posicionDato == "19"|| posicionDato == "20"|| posicionDato == "21")
            {
                for(int f = 0; f <= 2; f++)
                {
                    for(int c = 0; f <= 2; c++)
                    {
                        cuadrante = cuadrante + tablero[f, c].ToString();
                    }
                }

            }
            validaCuadrante = cuadrante.Contains(posicionDato);
            return validaCuadrante;
        }

        public void vaciarTablero()
        {
            dataTablero.Rows.Clear();
            
        }

        
        private void btSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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

            tablero = new string[10, 4];
            abrir.dataEstadistica.ColumnCount = 4;
            abrir.dataEstadistica.RowCount = 10;

            string validacion = "estadisticas.txt";
            StreamReader leer = File.OpenText(validacion);
            string Lactual = leer.ReadLine();
            string[] datos = Lactual.Split(',');
            string[] linea = File.ReadAllLines(validacion);
            int calin = linea.Length;
            int casilla = 0;
            while (lbUsuario.Text == datos[1]&&casilla<=4)
            {

                for (int fila = 0; fila < calin; fila++)
                {
                    for (int columna = 0; columna < calin; columna++)
                    {

                        tablero[fila, columna] = datos[casilla];
                        abrir.dataEstadistica.Rows[fila].Cells[columna].Value = tablero[fila, columna];
                        casilla++;


                    }
                }

            }


        }
    }
}
