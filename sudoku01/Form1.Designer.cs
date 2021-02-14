
namespace sudoku01
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxTiempo = new System.Windows.Forms.CheckBox();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.textClave = new System.Windows.Forms.TextBox();
            this.usuarioLb = new System.Windows.Forms.Label();
            this.claveLb = new System.Windows.Forms.Label();
            this.btIniciar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // checkBoxTiempo
            // 
            this.checkBoxTiempo.AutoSize = true;
            this.checkBoxTiempo.Location = new System.Drawing.Point(0, 322);
            this.checkBoxTiempo.Name = "checkBoxTiempo";
            this.checkBoxTiempo.Size = new System.Drawing.Size(132, 17);
            this.checkBoxTiempo.TabIndex = 0;
            this.checkBoxTiempo.Text = "JUGAR CON TIEMPO";
            this.checkBoxTiempo.UseVisualStyleBackColor = true;
            // 
            // textUsuario
            // 
            this.textUsuario.Location = new System.Drawing.Point(69, 3);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(126, 20);
            this.textUsuario.TabIndex = 1;
            // 
            // textClave
            // 
            this.textClave.Location = new System.Drawing.Point(69, 33);
            this.textClave.Name = "textClave";
            this.textClave.Size = new System.Drawing.Size(126, 20);
            this.textClave.TabIndex = 2;
            // 
            // usuarioLb
            // 
            this.usuarioLb.AutoSize = true;
            this.usuarioLb.Location = new System.Drawing.Point(7, 3);
            this.usuarioLb.Name = "usuarioLb";
            this.usuarioLb.Size = new System.Drawing.Size(56, 13);
            this.usuarioLb.TabIndex = 3;
            this.usuarioLb.Text = "USUARIO";
            // 
            // claveLb
            // 
            this.claveLb.AutoSize = true;
            this.claveLb.Location = new System.Drawing.Point(12, 33);
            this.claveLb.Name = "claveLb";
            this.claveLb.Size = new System.Drawing.Size(41, 13);
            this.claveLb.TabIndex = 4;
            this.claveLb.Text = "CLAVE";
            // 
            // btIniciar
            // 
            this.btIniciar.Location = new System.Drawing.Point(191, 269);
            this.btIniciar.Name = "btIniciar";
            this.btIniciar.Size = new System.Drawing.Size(108, 28);
            this.btIniciar.TabIndex = 5;
            this.btIniciar.Text = "INICIAR PARTIDA";
            this.btIniciar.UseVisualStyleBackColor = true;
            this.btIniciar.Click += new System.EventHandler(this.btIniciar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(191, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 26);
            this.button1.TabIndex = 6;
            this.button1.Text = "CREAR USUARIO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(0, 201);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(71, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Muy Facil";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(0, 224);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(48, 17);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.Text = "Facil";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(0, 247);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(59, 17);
            this.checkBox3.TabIndex = 10;
            this.checkBox3.Text = "Normal";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(0, 270);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(51, 17);
            this.checkBox4.TabIndex = 11;
            this.checkBox4.Text = "Dificil";
            this.checkBox4.UseVisualStyleBackColor = true;
            this.checkBox4.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(0, 293);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(72, 17);
            this.checkBox5.TabIndex = 12;
            this.checkBox5.Text = "Muy dificil";
            this.checkBox5.UseVisualStyleBackColor = true;
            this.checkBox5.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 340);
            this.Controls.Add(this.checkBox5);
            this.Controls.Add(this.checkBox4);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btIniciar);
            this.Controls.Add(this.claveLb);
            this.Controls.Add(this.usuarioLb);
            this.Controls.Add(this.textClave);
            this.Controls.Add(this.textUsuario);
            this.Controls.Add(this.checkBoxTiempo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxTiempo;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.TextBox textClave;
        private System.Windows.Forms.Label usuarioLb;
        private System.Windows.Forms.Label claveLb;
        private System.Windows.Forms.Button btIniciar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox5;
    }
}

