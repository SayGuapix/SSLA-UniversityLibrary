namespace UniversityLibrary.UI
{
    partial class BookCard
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDisponibilidad = new System.Windows.Forms.Label();
            this.btnPrestar = new Guna.UI2.WinForms.Guna2Button();
            this.lblAutor = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFechaDevolver = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDisponibilidad
            // 
            this.lblDisponibilidad.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblDisponibilidad.AutoSize = true;
            this.lblDisponibilidad.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.lblDisponibilidad.ForeColor = System.Drawing.Color.PeachPuff;
            this.lblDisponibilidad.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblDisponibilidad.Location = new System.Drawing.Point(22, 123);
            this.lblDisponibilidad.Name = "lblDisponibilidad";
            this.lblDisponibilidad.Size = new System.Drawing.Size(120, 32);
            this.lblDisponibilidad.TabIndex = 9;
            this.lblDisponibilidad.Text = "100 / 100";
            // 
            // btnPrestar
            // 
            this.btnPrestar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrestar.Animated = true;
            this.btnPrestar.FillColor = System.Drawing.Color.MediumAquamarine;
            this.btnPrestar.Font = new System.Drawing.Font("Segoe UI", 30F);
            this.btnPrestar.ForeColor = System.Drawing.Color.White;
            this.btnPrestar.Location = new System.Drawing.Point(584, 65);
            this.btnPrestar.Name = "btnPrestar";
            this.btnPrestar.Size = new System.Drawing.Size(88, 85);
            this.btnPrestar.TabIndex = 10;
            this.btnPrestar.Text = "-";
            this.btnPrestar.TextOffset = new System.Drawing.Point(4, -8);
            this.btnPrestar.Click += new System.EventHandler(this.btnPrestar_Click);
            this.btnPrestar.MouseLeave += new System.EventHandler(this.btnPrestar_MouseLeave);
            this.btnPrestar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnPrestar_MouseMove);
            // 
            // lblAutor
            // 
            this.lblAutor.AutoSize = true;
            this.lblAutor.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.lblAutor.ForeColor = System.Drawing.Color.Gray;
            this.lblAutor.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblAutor.Location = new System.Drawing.Point(22, 65);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(199, 32);
            this.lblAutor.TabIndex = 8;
            this.lblAutor.Text = "Autior del libro";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 25F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.White;
            this.lblTitulo.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblTitulo.Location = new System.Drawing.Point(20, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(367, 53);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Nombre del libro";
            // 
            // lblFechaDevolver
            // 
            this.lblFechaDevolver.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFechaDevolver.AutoSize = true;
            this.lblFechaDevolver.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblFechaDevolver.ForeColor = System.Drawing.Color.Gray;
            this.lblFechaDevolver.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblFechaDevolver.Location = new System.Drawing.Point(24, 98);
            this.lblFechaDevolver.Name = "lblFechaDevolver";
            this.lblFechaDevolver.Size = new System.Drawing.Size(192, 25);
            this.lblFechaDevolver.TabIndex = 11;
            this.lblFechaDevolver.Text = "Devolver en x dias";
            this.lblFechaDevolver.Visible = false;
            // 
            // BookCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(26)))));
            this.Controls.Add(this.lblFechaDevolver);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lblDisponibilidad);
            this.Controls.Add(this.btnPrestar);
            this.Controls.Add(this.lblAutor);
            this.Name = "BookCard";
            this.Size = new System.Drawing.Size(690, 165);
            this.Load += new System.EventHandler(this.BookCard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDisponibilidad;
        private Guna.UI2.WinForms.Guna2Button btnPrestar;
        private System.Windows.Forms.Label lblAutor;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFechaDevolver;
    }
}
