namespace UniversityLibrary.UI
{
    partial class bookRegister
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
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtTitulo = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblAutor = new System.Windows.Forms.Label();
            this.txtAutor = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.nudCantidadTotal = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.btnRegistrar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.lblAviso = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.ForeColor = System.Drawing.Color.White;
            this.lblBienvenida.Location = new System.Drawing.Point(115, 35);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(501, 52);
            this.lblBienvenida.TabIndex = 1;
            this.lblBienvenida.Text = "¡Registra un nuevo libro!";
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.Gray;
            this.lblTitulo.Location = new System.Drawing.Point(133, 129);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(467, 26);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Titulo";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTitulo
            // 
            this.txtTitulo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTitulo.Animated = true;
            this.txtTitulo.AutoRoundedCorners = true;
            this.txtTitulo.BackColor = System.Drawing.Color.Transparent;
            this.txtTitulo.BorderThickness = 0;
            this.txtTitulo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitulo.DefaultText = "";
            this.txtTitulo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTitulo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTitulo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitulo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitulo.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtTitulo.ForeColor = System.Drawing.Color.Black;
            this.txtTitulo.Location = new System.Drawing.Point(137, 161);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtTitulo.PlaceholderText = "";
            this.txtTitulo.SelectedText = "";
            this.txtTitulo.Size = new System.Drawing.Size(467, 46);
            this.txtTitulo.TabIndex = 3;
            this.txtTitulo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAutor
            // 
            this.lblAutor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAutor.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.lblAutor.ForeColor = System.Drawing.Color.Gray;
            this.lblAutor.Location = new System.Drawing.Point(133, 222);
            this.lblAutor.Name = "lblAutor";
            this.lblAutor.Size = new System.Drawing.Size(467, 26);
            this.lblAutor.TabIndex = 6;
            this.lblAutor.Text = "Autor";
            this.lblAutor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtAutor
            // 
            this.txtAutor.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAutor.Animated = true;
            this.txtAutor.AutoRoundedCorners = true;
            this.txtAutor.BackColor = System.Drawing.Color.Transparent;
            this.txtAutor.BorderThickness = 0;
            this.txtAutor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAutor.DefaultText = "";
            this.txtAutor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAutor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAutor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAutor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAutor.Font = new System.Drawing.Font("Times New Roman", 15F);
            this.txtAutor.ForeColor = System.Drawing.Color.Black;
            this.txtAutor.Location = new System.Drawing.Point(137, 253);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtAutor.PlaceholderText = "";
            this.txtAutor.SelectedText = "";
            this.txtAutor.Size = new System.Drawing.Size(467, 46);
            this.txtAutor.TabIndex = 5;
            this.txtAutor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCantidad
            // 
            this.lblCantidad.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCantidad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblCantidad.ForeColor = System.Drawing.Color.Gray;
            this.lblCantidad.Location = new System.Drawing.Point(51, 369);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(467, 26);
            this.lblCantidad.TabIndex = 8;
            this.lblCantidad.Text = "Cantidad:";
            this.lblCantidad.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // nudCantidadTotal
            // 
            this.nudCantidadTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nudCantidadTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.nudCantidadTotal.BorderThickness = 0;
            this.nudCantidadTotal.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudCantidadTotal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.nudCantidadTotal.Font = new System.Drawing.Font("Times New Roman", 22.02985F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCantidadTotal.ForeColor = System.Drawing.Color.White;
            this.nudCantidadTotal.Location = new System.Drawing.Point(370, 346);
            this.nudCantidadTotal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudCantidadTotal.Name = "nudCantidadTotal";
            this.nudCantidadTotal.Size = new System.Drawing.Size(160, 70);
            this.nudCantidadTotal.TabIndex = 9;
            this.nudCantidadTotal.UpDownButtonFillColor = System.Drawing.Color.CornflowerBlue;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRegistrar.Animated = true;
            this.btnRegistrar.AutoRoundedCorners = true;
            this.btnRegistrar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegistrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRegistrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRegistrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRegistrar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRegistrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRegistrar.FillColor = System.Drawing.Color.BlueViolet;
            this.btnRegistrar.FillColor2 = System.Drawing.Color.RoyalBlue;
            this.btnRegistrar.Font = new System.Drawing.Font("Times New Roman", 17F);
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.HoverState.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnRegistrar.HoverState.FillColor2 = System.Drawing.Color.BlueViolet;
            this.btnRegistrar.Location = new System.Drawing.Point(270, 486);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(204, 50);
            this.btnRegistrar.TabIndex = 10;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseTransparentBackground = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblAviso
            // 
            this.lblAviso.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblAviso.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold);
            this.lblAviso.ForeColor = System.Drawing.Color.Gray;
            this.lblAviso.Location = new System.Drawing.Point(133, 600);
            this.lblAviso.Name = "lblAviso";
            this.lblAviso.Size = new System.Drawing.Size(467, 26);
            this.lblAviso.TabIndex = 11;
            this.lblAviso.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bookRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(736, 635);
            this.Controls.Add(this.lblAviso);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.nudCantidadTotal);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblAutor);
            this.Controls.Add(this.txtAutor);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtTitulo);
            this.Controls.Add(this.lblBienvenida);
            this.Name = "bookRegister";
            this.Text = "bookRegister";
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidadTotal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Label lblTitulo;
        private Guna.UI2.WinForms.Guna2TextBox txtTitulo;
        private System.Windows.Forms.Label lblAutor;
        private Guna.UI2.WinForms.Guna2TextBox txtAutor;
        private System.Windows.Forms.Label lblCantidad;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudCantidadTotal;
        private Guna.UI2.WinForms.Guna2GradientButton btnRegistrar;
        private System.Windows.Forms.Label lblAviso;
    }
}