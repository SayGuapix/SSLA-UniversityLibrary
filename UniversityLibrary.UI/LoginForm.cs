using LibreriaUniversitaria.BLL;
using LibreriaUniversitaria.ENTITIES;
using LibreriaUniversitaria.UTIL;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TheArtOfDevHtmlRenderer.Adapters.RGraphicsPath;

namespace UniversityLibrary.UI
{
    public partial class LoginForm : Form
    {
        private readonly UsuarioService usuarioService = new UsuarioService();
        private string textoCompleto = "¿Quien leera hoy?";
        private int indice = 0;

        public LoginForm()
        {
            InitializeComponent();
            lblBienvenida.Text = "";
            tmrBienvenida.Start();
        }

        private void SiguienteForm(Form formularioActual, Form formularioSiguiente)
        {
            Point posicionActual = formularioActual.Location;

            formularioSiguiente.StartPosition = FormStartPosition.Manual;
            formularioSiguiente.Location = posicionActual;

            formularioSiguiente.Show();
            formularioActual.Hide();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string correoIngresado = txtCorreo.Text.Trim();

            if (correoIngresado == "admin1a2b3c")
            {
                lblAviso.Text = "Bienvenido [admin]";

                bookRegister Form = new bookRegister();
                SiguienteForm(this, Form);
            }

            // Validación con expresión regular para correo institucional válido
            bool esInstitucional = Regex.IsMatch(
                correoIngresado,
                @"^[a-zA-Z0-9._%+-]+@(pascualbravo|otrauniversidad)\.edu\.co$",
                RegexOptions.IgnoreCase
            );

            if (correoIngresado == "")
            {
                lblAviso.Text = "Ingresa un correo institucional primero.";
                return;
            }
            else if (!esInstitucional)
            {
                lblAviso.Text = "Correo no válido. Use su correo institucional.";
                return;
            }

            var usuario = await usuarioService.ObtenerOCrearUsuario(correoIngresado);

            if (usuario == null)
            {
                lblAviso.Text = "No tiene permiso para acceder.";
                return;
            }

            Datos.UsuarioActual = usuario;

            MainForm form = new MainForm();
            SiguienteForm(this, form);
        }

        private CancellationTokenSource _correoCts;

        private async void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text.Trim();

            // Validación con expresión regular para correo institucional válido
            bool esInstitucional = Regex.IsMatch(
                correo,
                @"^[a-zA-Z0-9._%+-]+@(pascualbravo|otrauniversidad)\.edu\.co$",
                RegexOptions.IgnoreCase
            );

            // Cancelar verificación anterior
            _correoCts?.Cancel();
            _correoCts = new CancellationTokenSource();
            var token = _correoCts.Token;

            try
            {
                UsuarioService usuarioService = new UsuarioService();
                bool existe = await usuarioService.CorreoExisteAsync(correo);

                if (token.IsCancellationRequested) return;

                if (existe)
                {
                    lblAviso.Text = "¡Bienvenido de nuevo!";
                }
                else if (esInstitucional)
                {
                    lblAviso.Text = "Perfecto!";
                }
                else
                {
                    lblAviso.Text = "Por favor, ingrese su correo institucional.";
                }
                if(correo == "admin1a2b3c")
                {
                    lblAviso.Text = "Bienvenido [admin]";
                }
            }
            catch
            {
                lblAviso.Text = "Error al verificar el correo.";
                lblAviso.ForeColor = Color.Red;
            }
        }

        private void tmrBienvenida_Tick(object sender, EventArgs e)
        {
            if (indice < textoCompleto.Length)
            {
                lblBienvenida.Text += textoCompleto[indice];
                indice++;
            }
            else
            {
                tmrBienvenida.Stop();
            }
        }
    }
}
