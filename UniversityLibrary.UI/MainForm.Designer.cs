namespace UniversityLibrary.UI
{
    partial class MainForm
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblMultas = new System.Windows.Forms.Label();
            this.lblTipo = new System.Windows.Forms.Label();
            this.lblPrestamos = new System.Windows.Forms.Label();
            this.TabControl = new Guna.UI2.WinForms.Guna2TabControl();
            this.tabPageBiblioteca = new System.Windows.Forms.TabPage();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tabPageColeccion = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.flpColeccion = new System.Windows.Forms.FlowLayoutPanel();
            this.btnDevolver = new Guna.UI2.WinForms.Guna2GradientButton();
            this.tabPageMultas = new System.Windows.Forms.TabPage();
            this.lblTotalMultas = new System.Windows.Forms.Label();
            this.lblAvisoMultas = new System.Windows.Forms.Label();
            this.btnPagar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.tabPageCuenta = new System.Windows.Forms.TabPage();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.Separator3 = new Guna.UI2.WinForms.Guna2Separator();
            this.Separator2 = new Guna.UI2.WinForms.Guna2Separator();
            this.Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCuenta = new Guna.UI2.WinForms.Guna2Button();
            this.btnMultas = new Guna.UI2.WinForms.Guna2Button();
            this.btnColeccion = new Guna.UI2.WinForms.Guna2Button();
            this.btnInicio = new Guna.UI2.WinForms.Guna2Button();
            this.spCuenta = new Guna.UI2.WinForms.Guna2Separator();
            this.spMultas = new Guna.UI2.WinForms.Guna2Separator();
            this.spColeccion = new Guna.UI2.WinForms.Guna2Separator();
            this.flpInicio = new System.Windows.Forms.FlowLayoutPanel();
            this.spInicio = new Guna.UI2.WinForms.Guna2Separator();
            this.TabControl.SuspendLayout();
            this.tabPageBiblioteca.SuspendLayout();
            this.tabPageColeccion.SuspendLayout();
            this.tabPageMultas.SuspendLayout();
            this.tabPageCuenta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNombre.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold);
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(18, 157);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(771, 48);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre Estudiante";
            this.lblNombre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMultas
            // 
            this.lblMultas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMultas.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold);
            this.lblMultas.ForeColor = System.Drawing.Color.White;
            this.lblMultas.Location = new System.Drawing.Point(55, 390);
            this.lblMultas.Name = "lblMultas";
            this.lblMultas.Size = new System.Drawing.Size(699, 48);
            this.lblMultas.TabIndex = 4;
            this.lblMultas.Text = "Multas";
            this.lblMultas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTipo
            // 
            this.lblTipo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTipo.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lblTipo.ForeColor = System.Drawing.Color.Gray;
            this.lblTipo.Location = new System.Drawing.Point(30, 205);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(743, 26);
            this.lblTipo.TabIndex = 3;
            this.lblTipo.Text = "Tipo de usuario";
            this.lblTipo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblPrestamos
            // 
            this.lblPrestamos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPrestamos.Font = new System.Drawing.Font("Times New Roman", 17F, System.Drawing.FontStyle.Bold);
            this.lblPrestamos.ForeColor = System.Drawing.Color.White;
            this.lblPrestamos.Location = new System.Drawing.Point(52, 310);
            this.lblPrestamos.Name = "lblPrestamos";
            this.lblPrestamos.Size = new System.Drawing.Size(702, 38);
            this.lblPrestamos.TabIndex = 2;
            this.lblPrestamos.Text = "Libros prestados";
            this.lblPrestamos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TabControl
            // 
            this.TabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControl.Controls.Add(this.tabPageBiblioteca);
            this.TabControl.Controls.Add(this.tabPageColeccion);
            this.TabControl.Controls.Add(this.tabPageMultas);
            this.TabControl.Controls.Add(this.tabPageCuenta);
            this.TabControl.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.TabControl.ItemSize = new System.Drawing.Size(202, 3);
            this.TabControl.Location = new System.Drawing.Point(-8, 118);
            this.TabControl.Margin = new System.Windows.Forms.Padding(4);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(815, 571);
            this.TabControl.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.TabControl.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(35)))));
            this.TabControl.TabButtonHoverState.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.TabControl.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.TabControl.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(35)))));
            this.TabControl.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.TabControl.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(35)))));
            this.TabControl.TabButtonIdleState.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.TabControl.TabButtonIdleState.ForeColor = System.Drawing.Color.White;
            this.TabControl.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(35)))));
            this.TabControl.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.TabControl.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(16)))));
            this.TabControl.TabButtonSelectedState.Font = new System.Drawing.Font("Times New Roman", 16F);
            this.TabControl.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.TabControl.TabButtonSelectedState.InnerColor = System.Drawing.Color.White;
            this.TabControl.TabButtonSize = new System.Drawing.Size(202, 3);
            this.TabControl.TabIndex = 7;
            this.TabControl.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(35)))));
            this.TabControl.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            this.TabControl.TabMenuVisible = false;
            // 
            // tabPageBiblioteca
            // 
            this.tabPageBiblioteca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(16)))));
            this.tabPageBiblioteca.Controls.Add(this.lblTitulo);
            this.tabPageBiblioteca.Controls.Add(this.flpInicio);
            this.tabPageBiblioteca.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageBiblioteca.Location = new System.Drawing.Point(4, 5);
            this.tabPageBiblioteca.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageBiblioteca.Name = "tabPageBiblioteca";
            this.tabPageBiblioteca.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageBiblioteca.Size = new System.Drawing.Size(807, 562);
            this.tabPageBiblioteca.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lblTitulo.ForeColor = System.Drawing.Color.Gray;
            this.lblTitulo.Location = new System.Drawing.Point(30, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(743, 32);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "Galeria de Libros";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPageColeccion
            // 
            this.tabPageColeccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(16)))));
            this.tabPageColeccion.Controls.Add(this.label1);
            this.tabPageColeccion.Controls.Add(this.flpColeccion);
            this.tabPageColeccion.Controls.Add(this.btnDevolver);
            this.tabPageColeccion.Location = new System.Drawing.Point(4, 5);
            this.tabPageColeccion.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageColeccion.Name = "tabPageColeccion";
            this.tabPageColeccion.Size = new System.Drawing.Size(807, 562);
            this.tabPageColeccion.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(32, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(743, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Coleccion";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // flpColeccion
            // 
            this.flpColeccion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpColeccion.AutoScroll = true;
            this.flpColeccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(16)))));
            this.flpColeccion.Location = new System.Drawing.Point(-11, 60);
            this.flpColeccion.Name = "flpColeccion";
            this.flpColeccion.Size = new System.Drawing.Size(841, 535);
            this.flpColeccion.TabIndex = 7;
            // 
            // btnDevolver
            // 
            this.btnDevolver.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDevolver.Animated = true;
            this.btnDevolver.BackColor = System.Drawing.Color.Transparent;
            this.btnDevolver.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDevolver.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDevolver.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDevolver.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDevolver.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDevolver.FillColor = System.Drawing.Color.Empty;
            this.btnDevolver.FillColor2 = System.Drawing.Color.Empty;
            this.btnDevolver.Font = new System.Drawing.Font("Times New Roman", 17F);
            this.btnDevolver.ForeColor = System.Drawing.Color.White;
            this.btnDevolver.HoverState.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnDevolver.HoverState.FillColor2 = System.Drawing.Color.BlueViolet;
            this.btnDevolver.Location = new System.Drawing.Point(16, 421);
            this.btnDevolver.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDevolver.Name = "btnDevolver";
            this.btnDevolver.Size = new System.Drawing.Size(771, 134);
            this.btnDevolver.TabIndex = 6;
            this.btnDevolver.Text = "Devolver Libro";
            this.btnDevolver.UseTransparentBackground = true;
            // 
            // tabPageMultas
            // 
            this.tabPageMultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(16)))));
            this.tabPageMultas.Controls.Add(this.lblTotalMultas);
            this.tabPageMultas.Controls.Add(this.lblAvisoMultas);
            this.tabPageMultas.Controls.Add(this.btnPagar);
            this.tabPageMultas.Location = new System.Drawing.Point(4, 5);
            this.tabPageMultas.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageMultas.Name = "tabPageMultas";
            this.tabPageMultas.Size = new System.Drawing.Size(807, 562);
            this.tabPageMultas.TabIndex = 3;
            // 
            // lblTotalMultas
            // 
            this.lblTotalMultas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotalMultas.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalMultas.ForeColor = System.Drawing.Color.Gray;
            this.lblTotalMultas.Location = new System.Drawing.Point(30, 201);
            this.lblTotalMultas.Name = "lblTotalMultas";
            this.lblTotalMultas.Size = new System.Drawing.Size(743, 77);
            this.lblTotalMultas.TabIndex = 9;
            this.lblTotalMultas.Text = "tienes...";
            this.lblTotalMultas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblAvisoMultas
            // 
            this.lblAvisoMultas.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAvisoMultas.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lblAvisoMultas.ForeColor = System.Drawing.Color.Gray;
            this.lblAvisoMultas.Location = new System.Drawing.Point(30, 38);
            this.lblAvisoMultas.Name = "lblAvisoMultas";
            this.lblAvisoMultas.Size = new System.Drawing.Size(743, 32);
            this.lblAvisoMultas.TabIndex = 8;
            this.lblAvisoMultas.Text = "¡Paga tus multas a tiempo!";
            this.lblAvisoMultas.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnPagar
            // 
            this.btnPagar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPagar.Animated = true;
            this.btnPagar.BackColor = System.Drawing.Color.Transparent;
            this.btnPagar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPagar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPagar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPagar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPagar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPagar.FillColor = System.Drawing.Color.Empty;
            this.btnPagar.FillColor2 = System.Drawing.Color.Empty;
            this.btnPagar.Font = new System.Drawing.Font("Times New Roman", 17F);
            this.btnPagar.ForeColor = System.Drawing.Color.White;
            this.btnPagar.HoverState.FillColor = System.Drawing.Color.RoyalBlue;
            this.btnPagar.HoverState.FillColor2 = System.Drawing.Color.BlueViolet;
            this.btnPagar.Location = new System.Drawing.Point(3, 339);
            this.btnPagar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(801, 129);
            this.btnPagar.TabIndex = 7;
            this.btnPagar.Text = "Pagar Multas";
            this.btnPagar.UseTransparentBackground = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // tabPageCuenta
            // 
            this.tabPageCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(16)))));
            this.tabPageCuenta.Controls.Add(this.lblCorreo);
            this.tabPageCuenta.Controls.Add(this.Separator3);
            this.tabPageCuenta.Controls.Add(this.Separator2);
            this.tabPageCuenta.Controls.Add(this.Separator1);
            this.tabPageCuenta.Controls.Add(this.lblNombre);
            this.tabPageCuenta.Controls.Add(this.lblMultas);
            this.tabPageCuenta.Controls.Add(this.lblTipo);
            this.tabPageCuenta.Controls.Add(this.lblPrestamos);
            this.tabPageCuenta.Controls.Add(this.pictureBox1);
            this.tabPageCuenta.Location = new System.Drawing.Point(4, 5);
            this.tabPageCuenta.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageCuenta.Name = "tabPageCuenta";
            this.tabPageCuenta.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageCuenta.Size = new System.Drawing.Size(807, 562);
            this.tabPageCuenta.TabIndex = 0;
            // 
            // lblCorreo
            // 
            this.lblCorreo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCorreo.Font = new System.Drawing.Font("Times New Roman", 17.19403F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.DimGray;
            this.lblCorreo.Location = new System.Drawing.Point(55, 480);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(699, 48);
            this.lblCorreo.TabIndex = 9;
            this.lblCorreo.Text = "Correo";
            this.lblCorreo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Separator3
            // 
            this.Separator3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Separator3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.Separator3.Location = new System.Drawing.Point(26, 451);
            this.Separator3.Margin = new System.Windows.Forms.Padding(4);
            this.Separator3.Name = "Separator3";
            this.Separator3.Size = new System.Drawing.Size(747, 10);
            this.Separator3.TabIndex = 8;
            // 
            // Separator2
            // 
            this.Separator2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Separator2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.Separator2.Location = new System.Drawing.Point(26, 366);
            this.Separator2.Margin = new System.Windows.Forms.Padding(4);
            this.Separator2.Name = "Separator2";
            this.Separator2.Size = new System.Drawing.Size(747, 10);
            this.Separator2.TabIndex = 7;
            // 
            // Separator1
            // 
            this.Separator1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(60)))));
            this.Separator1.Location = new System.Drawing.Point(26, 283);
            this.Separator1.Margin = new System.Windows.Forms.Padding(4);
            this.Separator1.Name = "Separator1";
            this.Separator1.Size = new System.Drawing.Size(747, 10);
            this.Separator1.TabIndex = 6;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.Image = global::UniversityLibrary.UI.Properties.Resources.User;
            this.pictureBox1.Location = new System.Drawing.Point(331, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(147, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnCuenta
            // 
            this.btnCuenta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnCuenta.Animated = true;
            this.btnCuenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(20)))));
            this.btnCuenta.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.btnCuenta.BorderThickness = 2;
            this.btnCuenta.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCuenta.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCuenta.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCuenta.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCuenta.FillColor = System.Drawing.Color.Transparent;
            this.btnCuenta.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCuenta.ForeColor = System.Drawing.Color.White;
            this.btnCuenta.Image = global::UniversityLibrary.UI.Properties.Resources.cuenta;
            this.btnCuenta.ImageSize = new System.Drawing.Size(50, 50);
            this.btnCuenta.Location = new System.Drawing.Point(599, -2);
            this.btnCuenta.Name = "btnCuenta";
            this.btnCuenta.Size = new System.Drawing.Size(202, 118);
            this.btnCuenta.TabIndex = 8;
            this.btnCuenta.Click += new System.EventHandler(this.btnCuenta_Click);
            // 
            // btnMultas
            // 
            this.btnMultas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnMultas.Animated = true;
            this.btnMultas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(20)))));
            this.btnMultas.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.btnMultas.BorderThickness = 2;
            this.btnMultas.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMultas.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMultas.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMultas.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMultas.FillColor = System.Drawing.Color.Transparent;
            this.btnMultas.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMultas.ForeColor = System.Drawing.Color.White;
            this.btnMultas.Image = global::UniversityLibrary.UI.Properties.Resources.multa;
            this.btnMultas.ImageSize = new System.Drawing.Size(50, 50);
            this.btnMultas.Location = new System.Drawing.Point(397, -2);
            this.btnMultas.Name = "btnMultas";
            this.btnMultas.Size = new System.Drawing.Size(202, 118);
            this.btnMultas.TabIndex = 7;
            this.btnMultas.Click += new System.EventHandler(this.btnMultas_Click);
            // 
            // btnColeccion
            // 
            this.btnColeccion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnColeccion.Animated = true;
            this.btnColeccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(20)))));
            this.btnColeccion.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.btnColeccion.BorderThickness = 2;
            this.btnColeccion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnColeccion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnColeccion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnColeccion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnColeccion.FillColor = System.Drawing.Color.Transparent;
            this.btnColeccion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnColeccion.ForeColor = System.Drawing.Color.White;
            this.btnColeccion.Image = global::UniversityLibrary.UI.Properties.Resources.libros;
            this.btnColeccion.ImageSize = new System.Drawing.Size(50, 50);
            this.btnColeccion.Location = new System.Drawing.Point(195, -2);
            this.btnColeccion.Name = "btnColeccion";
            this.btnColeccion.Size = new System.Drawing.Size(202, 118);
            this.btnColeccion.TabIndex = 6;
            this.btnColeccion.Click += new System.EventHandler(this.btnColeccion_Click);
            // 
            // btnInicio
            // 
            this.btnInicio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnInicio.Animated = true;
            this.btnInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(11)))), ((int)(((byte)(20)))));
            this.btnInicio.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(55)))));
            this.btnInicio.BorderThickness = 2;
            this.btnInicio.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnInicio.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnInicio.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnInicio.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnInicio.FillColor = System.Drawing.Color.Transparent;
            this.btnInicio.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnInicio.ForeColor = System.Drawing.Color.White;
            this.btnInicio.Image = global::UniversityLibrary.UI.Properties.Resources.inicio;
            this.btnInicio.ImageSize = new System.Drawing.Size(50, 50);
            this.btnInicio.Location = new System.Drawing.Point(-7, -2);
            this.btnInicio.Name = "btnInicio";
            this.btnInicio.Size = new System.Drawing.Size(202, 118);
            this.btnInicio.TabIndex = 5;
            this.btnInicio.Click += new System.EventHandler(this.btnInicio_Click);
            // 
            // spCuenta
            // 
            this.spCuenta.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.spCuenta.Location = new System.Drawing.Point(599, 106);
            this.spCuenta.Name = "spCuenta";
            this.spCuenta.Size = new System.Drawing.Size(200, 10);
            this.spCuenta.TabIndex = 10;
            this.spCuenta.Visible = false;
            // 
            // spMultas
            // 
            this.spMultas.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.spMultas.Location = new System.Drawing.Point(397, 106);
            this.spMultas.Name = "spMultas";
            this.spMultas.Size = new System.Drawing.Size(200, 10);
            this.spMultas.TabIndex = 11;
            this.spMultas.Visible = false;
            // 
            // spColeccion
            // 
            this.spColeccion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.spColeccion.Location = new System.Drawing.Point(195, 106);
            this.spColeccion.Name = "spColeccion";
            this.spColeccion.Size = new System.Drawing.Size(200, 10);
            this.spColeccion.TabIndex = 12;
            this.spColeccion.Visible = false;
            // 
            // flpInicio
            // 
            this.flpInicio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flpInicio.AutoScroll = true;
            this.flpInicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(16)))));
            this.flpInicio.Location = new System.Drawing.Point(-12, 66);
            this.flpInicio.Name = "flpInicio";
            this.flpInicio.Size = new System.Drawing.Size(847, 527);
            this.flpInicio.TabIndex = 0;
            // 
            // spInicio
            // 
            this.spInicio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.spInicio.Location = new System.Drawing.Point(-4, 106);
            this.spInicio.Name = "spInicio";
            this.spInicio.Size = new System.Drawing.Size(200, 10);
            this.spInicio.TabIndex = 11;
            this.spInicio.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(795, 692);
            this.Controls.Add(this.spInicio);
            this.Controls.Add(this.spColeccion);
            this.Controls.Add(this.spMultas);
            this.Controls.Add(this.spCuenta);
            this.Controls.Add(this.btnCuenta);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.btnMultas);
            this.Controls.Add(this.btnColeccion);
            this.Controls.Add(this.btnInicio);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SSLA University Library";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.TabControl.ResumeLayout(false);
            this.tabPageBiblioteca.ResumeLayout(false);
            this.tabPageColeccion.ResumeLayout(false);
            this.tabPageMultas.ResumeLayout(false);
            this.tabPageCuenta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblPrestamos;
        private System.Windows.Forms.Label lblMultas;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2TabControl TabControl;
        private System.Windows.Forms.TabPage tabPageCuenta;
        private System.Windows.Forms.TabPage tabPageBiblioteca;
        private System.Windows.Forms.TabPage tabPageColeccion;
        private System.Windows.Forms.TabPage tabPageMultas;
        private Guna.UI2.WinForms.Guna2Separator Separator1;
        private Guna.UI2.WinForms.Guna2GradientButton btnPagar;
        private Guna.UI2.WinForms.Guna2Button btnInicio;
        private Guna.UI2.WinForms.Guna2Button btnCuenta;
        private Guna.UI2.WinForms.Guna2Button btnMultas;
        private Guna.UI2.WinForms.Guna2Button btnColeccion;
        private Guna.UI2.WinForms.Guna2Separator Separator3;
        private Guna.UI2.WinForms.Guna2Separator Separator2;
        private Guna.UI2.WinForms.Guna2GradientButton btnDevolver;
        private System.Windows.Forms.FlowLayoutPanel flpColeccion;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalMultas;
        private System.Windows.Forms.Label lblAvisoMultas;
        private System.Windows.Forms.Label lblCorreo;
        private Guna.UI2.WinForms.Guna2Separator spCuenta;
        private Guna.UI2.WinForms.Guna2Separator spMultas;
        private Guna.UI2.WinForms.Guna2Separator spColeccion;
        private System.Windows.Forms.FlowLayoutPanel flpInicio;
        private Guna.UI2.WinForms.Guna2Separator spInicio;
    }
}