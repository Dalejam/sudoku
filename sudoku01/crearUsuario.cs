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
    public partial class crearUsuario : Form
    {
        public crearUsuario()
        {
            InitializeComponent();
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            string Linea = "usuarios.txt";
            StreamWriter Ingresar = File.AppendText(Linea);
            Ingresar.WriteLine("{0},{1},{2}", textNombre.Text, textUsuario.Text, textClave.Text);
            MessageBox.Show("Usuario registrado");
            Ingresar.Close();
            this.Close();
        }
    }
}
