
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuNivel = new System.Windows.Forms.ToolStripMenuItem();
            this.mUYFACILToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fACILToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nORMALToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dIFICILToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mUYDIFICILToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eXTREMOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // checkBoxTiempo
            // 
            this.checkBoxTiempo.AutoSize = true;
            this.checkBoxTiempo.Location = new System.Drawing.Point(87, 7);
            this.checkBoxTiempo.Name = "checkBoxTiempo";
            this.checkBoxTiempo.Size = new System.Drawing.Size(132, 17);
            this.checkBoxTiempo.TabIndex = 0;
            this.checkBoxTiempo.Text = "JUGAR CON TIEMPO";
            this.checkBoxTiempo.UseVisualStyleBackColor = true;
            // 
            // textUsuario
            // 
            this.textUsuario.Location = new System.Drawing.Point(116, 135);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(183, 20);
            this.textUsuario.TabIndex = 1;
            // 
            // textClave
            // 
            this.textClave.Location = new System.Drawing.Point(116, 180);
            this.textClave.Name = "textClave";
            this.textClave.Size = new System.Drawing.Size(183, 20);
            this.textClave.TabIndex = 2;
            // 
            // usuarioLb
            // 
            this.usuarioLb.AutoSize = true;
            this.usuarioLb.Location = new System.Drawing.Point(34, 142);
            this.usuarioLb.Name = "usuarioLb";
            this.usuarioLb.Size = new System.Drawing.Size(56, 13);
            this.usuarioLb.TabIndex = 3;
            this.usuarioLb.Text = "USUARIO";
            // 
            // claveLb
            // 
            this.claveLb.AutoSize = true;
            this.claveLb.Location = new System.Drawing.Point(34, 187);
            this.claveLb.Name = "claveLb";
            this.claveLb.Size = new System.Drawing.Size(41, 13);
            this.claveLb.TabIndex = 4;
            this.claveLb.Text = "CLAVE";
            // 
            // btIniciar
            // 
            this.btIniciar.Location = new System.Drawing.Point(135, 226);
            this.btIniciar.Name = "btIniciar";
            this.btIniciar.Size = new System.Drawing.Size(124, 41);
            this.btIniciar.TabIndex = 5;
            this.btIniciar.Text = "INICIAR PARTIDA";
            this.btIniciar.UseVisualStyleBackColor = true;
            this.btIniciar.Click += new System.EventHandler(this.btIniciar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(135, 273);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "CREAR USUARIO";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuNivel});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(311, 24);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuNivel
            // 
            this.menuNivel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuNivel.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mUYFACILToolStripMenuItem,
            this.fACILToolStripMenuItem,
            this.nORMALToolStripMenuItem,
            this.dIFICILToolStripMenuItem,
            this.mUYDIFICILToolStripMenuItem,
            this.eXTREMOToolStripMenuItem});
            this.menuNivel.Name = "menuNivel";
            this.menuNivel.Size = new System.Drawing.Size(50, 20);
            this.menuNivel.Text = "NIVEL";
            // 
            // mUYFACILToolStripMenuItem
            // 
            this.mUYFACILToolStripMenuItem.Name = "mUYFACILToolStripMenuItem";
            this.mUYFACILToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mUYFACILToolStripMenuItem.Text = "MUY FACIL";
            // 
            // fACILToolStripMenuItem
            // 
            this.fACILToolStripMenuItem.Name = "fACILToolStripMenuItem";
            this.fACILToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fACILToolStripMenuItem.Text = "FACIL";
            // 
            // nORMALToolStripMenuItem
            // 
            this.nORMALToolStripMenuItem.Name = "nORMALToolStripMenuItem";
            this.nORMALToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nORMALToolStripMenuItem.Text = "NORMAL";
            // 
            // dIFICILToolStripMenuItem
            // 
            this.dIFICILToolStripMenuItem.Name = "dIFICILToolStripMenuItem";
            this.dIFICILToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dIFICILToolStripMenuItem.Text = "DIFICIL";
            // 
            // mUYDIFICILToolStripMenuItem
            // 
            this.mUYDIFICILToolStripMenuItem.Name = "mUYDIFICILToolStripMenuItem";
            this.mUYDIFICILToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mUYDIFICILToolStripMenuItem.Text = "MUY DIFICIL";
            // 
            // eXTREMOToolStripMenuItem
            // 
            this.eXTREMOToolStripMenuItem.Name = "eXTREMOToolStripMenuItem";
            this.eXTREMOToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.eXTREMOToolStripMenuItem.Text = "EXTREMO";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(311, 340);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btIniciar);
            this.Controls.Add(this.claveLb);
            this.Controls.Add(this.usuarioLb);
            this.Controls.Add(this.textClave);
            this.Controls.Add(this.textUsuario);
            this.Controls.Add(this.checkBoxTiempo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuNivel;
        private System.Windows.Forms.ToolStripMenuItem mUYFACILToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fACILToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nORMALToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dIFICILToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mUYDIFICILToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eXTREMOToolStripMenuItem;
    }
}

