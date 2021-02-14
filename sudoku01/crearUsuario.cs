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
    

    public partial class crearUsuario : Form
    {
        Usuario NuevoU = new Usuario();
        public crearUsuario()
        {
            InitializeComponent();
            Bitmap img = new Bitmap(Application.StartupPath + @"\Img\FondoAdministrador.png");
            this.BackgroundImage = img;
            Bitmap BotonCrearUsuario = new Bitmap(Application.StartupPath + @"\Img\AgregarUsuario.png");
            btGuardar.Image = BotonCrearUsuario;
        }

        private void btGuardar_Click(object sender, EventArgs e)
        {
            NuevoU.crearUsuario(textNombre.Text, textUsuario.Text, textClave.Text);
            this.Close();
        }
    }
}
