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
    public partial class Form1 : Form
    {
        byte nivel ;
        JugarPartida iniciarPartida = new JugarPartida();
        public Form1()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\Img\Login.png");
            this.BackgroundImage = img;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            crearUsuario abrir = new crearUsuario();
            abrir.Show();
        }

        private void btIniciar_Click(object sender, EventArgs e)
        {
            if ((textUsuario.Text != " ") && (textClave.Text != ""))
            {
                string validacion = "usuarios.txt";
                string usuario = textUsuario.Text;
                string clave = textClave.Text;
                int contar = 0;
                StreamReader leer = File.OpenText(validacion);
                while (!leer.EndOfStream)
                {
                    string Lactual = leer.ReadLine();
                    string[] datos = Lactual.Split(',');
                    string[] linea = File.ReadAllLines(validacion);
                    int calin = linea.Length;
                    if ((datos[1] == usuario) && (datos[2] == clave))
                    {
                        MessageBox.Show("Usuario Valido");
                        Partida abrir = new Partida();
                        abrir.lbUsuario.Text = datos[1].ToString();
                        abrir.lbNivel.Text = nivel.ToString();
                        abrir.Show();
                        //iniciarPartida.llenarTablero(nivel.ToString());

                    }
                    else
                    {
                        contar++;
                        if (contar == calin)
                        {
                            MessageBox.Show("El usuario y/o contraseña no es correcta", "Informacion del sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }


                    }
                }
                leer.Close();
            }
            textUsuario.Clear();
            textClave.Clear();
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            nivel = 1;
            PasarDatos(nivel);

        }
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            nivel = 2;
            PasarDatos(nivel);
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            nivel = 3;
            PasarDatos(nivel);
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            nivel = 4;
            PasarDatos(nivel);
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            nivel = 5;
            PasarDatos(nivel);
        }
        private void PasarDatos(byte nivel)
        {

            if (nivel == 1)
            {
                checkBox2.Visible = false;
                checkBox3.Visible = false;
                checkBox4.Visible = false;
                checkBox5.Visible = false;
                
            }
            if (nivel == 2)
            { 
                checkBox1.Visible = false;
                checkBox3.Visible = false;
                checkBox4.Visible = false;
                checkBox5.Visible = false;
                
            }
            if (nivel == 3)
            {
                checkBox2.Visible = false;
                checkBox1.Visible = false;
                checkBox4.Visible = false;
                checkBox5.Visible = false;
                
            }
            if (nivel == 4)
            {
                checkBox2.Visible = false;
                checkBox1.Visible = false;
                checkBox3.Visible = false;
                checkBox5.Visible = false;
                
            }
            if (nivel == 5)
            {
                checkBox2.Visible = false;
                checkBox1.Visible = false;
                checkBox3.Visible = false;
                checkBox4.Visible = false;
                
            }
            
        }

        private void textClave_TextChanged(object sender, EventArgs e)
        {
            textClave.PasswordChar = '*';
        }
    }
}
    
