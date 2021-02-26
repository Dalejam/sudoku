
namespace sudoku01
{
    partial class Estadistica
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
            this.dataEstadistica = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataEstadistica)).BeginInit();
            this.SuspendLayout();
            // 
            // dataEstadistica
            // 
            this.dataEstadistica.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEstadistica.Location = new System.Drawing.Point(20, 44);
            this.dataEstadistica.Name = "dataEstadistica";
            this.dataEstadistica.Size = new System.Drawing.Size(476, 274);
            this.dataEstadistica.TabIndex = 0;
            this.dataEstadistica.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataEstadistica_CellContentClick);
            // 
            // Estadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 380);
            this.Controls.Add(this.dataEstadistica);
            this.Name = "Estadistica";
            this.Text = "Estadistica";
            ((System.ComponentModel.ISupportInitialize)(this.dataEstadistica)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataEstadistica;
    }
}