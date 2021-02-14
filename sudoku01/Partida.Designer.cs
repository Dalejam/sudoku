
namespace sudoku01
{
    partial class Partida
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btValidar = new System.Windows.Forms.Button();
            this.btTerminar = new System.Windows.Forms.Button();
            this.btSalir = new System.Windows.Forms.Button();
            this.btEstadistica = new System.Windows.Forms.Button();
            this.dataTablero = new System.Windows.Forms.DataGridView();
            this.btIniciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataTablero)).BeginInit();
            this.SuspendLayout();
            // 
            // btValidar
            // 
            this.btValidar.Location = new System.Drawing.Point(161, 318);
            this.btValidar.Name = "btValidar";
            this.btValidar.Size = new System.Drawing.Size(133, 38);
            this.btValidar.TabIndex = 0;
            this.btValidar.Text = "VALIDAR";
            this.btValidar.UseVisualStyleBackColor = true;
            this.btValidar.Click += new System.EventHandler(this.btValidar_Click);
            // 
            // btTerminar
            // 
            this.btTerminar.Location = new System.Drawing.Point(316, 317);
            this.btTerminar.Name = "btTerminar";
            this.btTerminar.Size = new System.Drawing.Size(133, 39);
            this.btTerminar.TabIndex = 1;
            this.btTerminar.Text = "TERMINAR";
            this.btTerminar.UseVisualStyleBackColor = true;
            // 
            // btSalir
            // 
            this.btSalir.Location = new System.Drawing.Point(161, 370);
            this.btSalir.Name = "btSalir";
            this.btSalir.Size = new System.Drawing.Size(133, 39);
            this.btSalir.TabIndex = 2;
            this.btSalir.Text = "SALIR";
            this.btSalir.UseVisualStyleBackColor = true;
            this.btSalir.Click += new System.EventHandler(this.btSalir_Click);
            // 
            // btEstadistica
            // 
            this.btEstadistica.Location = new System.Drawing.Point(12, 371);
            this.btEstadistica.Name = "btEstadistica";
            this.btEstadistica.Size = new System.Drawing.Size(133, 38);
            this.btEstadistica.TabIndex = 3;
            this.btEstadistica.Text = "ESTADISTICA";
            this.btEstadistica.UseVisualStyleBackColor = true;
            // 
            // dataTablero
            // 
            this.dataTablero.AllowUserToAddRows = false;
            this.dataTablero.AllowUserToDeleteRows = false;
            this.dataTablero.AllowUserToResizeColumns = false;
            this.dataTablero.AllowUserToResizeRows = false;
            this.dataTablero.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTablero.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataTablero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTablero.ColumnHeadersVisible = false;
            this.dataTablero.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dataTablero.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataTablero.Location = new System.Drawing.Point(38, 42);
            this.dataTablero.Name = "dataTablero";
            this.dataTablero.RowHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.dataTablero.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataTablero.ShowEditingIcon = false;
            this.dataTablero.ShowRowErrors = false;
            this.dataTablero.Size = new System.Drawing.Size(396, 204);
            this.dataTablero.TabIndex = 4;
            // 
            // btIniciar
            // 
            this.btIniciar.Location = new System.Drawing.Point(12, 317);
            this.btIniciar.Name = "btIniciar";
            this.btIniciar.Size = new System.Drawing.Size(133, 39);
            this.btIniciar.TabIndex = 5;
            this.btIniciar.Text = "INICIAR";
            this.btIniciar.UseVisualStyleBackColor = true;
            this.btIniciar.Click += new System.EventHandler(this.btIniciar_Click);
            // 
            // Partida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 441);
            this.Controls.Add(this.btIniciar);
            this.Controls.Add(this.dataTablero);
            this.Controls.Add(this.btEstadistica);
            this.Controls.Add(this.btSalir);
            this.Controls.Add(this.btTerminar);
            this.Controls.Add(this.btValidar);
            this.Name = "Partida";
            this.Text = "Partida";
            ((System.ComponentModel.ISupportInitialize)(this.dataTablero)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btValidar;
        private System.Windows.Forms.Button btTerminar;
        private System.Windows.Forms.Button btSalir;
        private System.Windows.Forms.Button btEstadistica;
        private System.Windows.Forms.DataGridView dataTablero;
        private System.Windows.Forms.Button btIniciar;
    }
}