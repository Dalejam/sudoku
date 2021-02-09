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
        public Form1()
        {
            InitializeComponent();
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
                        
                        abrir.Show();

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
    }
    
}
