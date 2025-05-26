using LibreriaUniversitaria.BLL;
using LibreriaUniversitaria.DAL;
using LibreriaUniversitaria.ENTITIES;
using LibreriaUniversitaria.UTIL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UniversityLibrary.ENTITIES;
using static Guna.UI2.Native.WinApi;

namespace UniversityLibrary.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private async void MainForm_Load(object sender, EventArgs e)
        {
            await RefrescarDatos();
            await CargarLibrosPrestados();
        }
        private void AjustarTamañoBookCards()
        {
            int margen = 20; // Ajusta este valor según cuánto margen lateral quieres

            foreach (Control control in flpInicio.Controls)
            {
                if (control is BookCard card)
                {
                    card.Width = flpInicio.ClientSize.Width - margen;
                    // La altura puede ser fija o también proporcional si quisieras
                }
            }
            foreach (Control control in flpColeccion.Controls)
            {
                if (control is BookCard card)
                {
                    card.Width = flpColeccion.ClientSize.Width - margen;
                    // La altura puede ser fija o también proporcional si quisieras
                }
            }
        }

        private async void btnInicio_Click(object sender, EventArgs e)
        {
            TabControl.SelectedIndex = 0;
            spInicio.Visible = true;
            spColeccion.Visible = false;
            spMultas.Visible = false;
            spCuenta.Visible = false;
            await RefrescarDatos();
        }

        private async void btnColeccion_Click(object sender, EventArgs e)
        {
            TabControl.SelectedIndex = 1;
            spInicio.Visible = false;
            spColeccion.Visible = true;
            spMultas.Visible = false;
            spCuenta.Visible = false;
            await CargarLibrosPrestados();
        }

        private async void btnMultas_Click(object sender, EventArgs e)
        {
            TabControl.SelectedIndex = 2;
            spInicio.Visible = false;
            spColeccion.Visible = false;
            spMultas.Visible = true;
            spCuenta.Visible = false;
            await RefrescarDatos();
        }

        private async void btnCuenta_Click(object sender, EventArgs e)
        {
            TabControl.SelectedIndex = 3;
            spInicio.Visible = false;
            spColeccion.Visible = false;
            spMultas.Visible = false;
            spCuenta.Visible = true;
            await RefrescarDatos();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            AjustarTamañoBookCards();
        }

        // cargar las multas
        private async Task CargarMultasPendientes()
        {
            var usuario = Datos.UsuarioActual;

            if (usuario == null || string.IsNullOrWhiteSpace(usuario.correo))
            {
                lblMultas.Text = "Usuario no válido.";
                lblTotalMultas.Text = string.Empty;
                btnPagar.Visible = false;
                return;
            }

            var multaService = new MultaService();
            var multa = await multaService.ObtenerMultaUsuarioAsync(usuario.correo);
            await multaService.ActualizarMultasPagadasAsync();

            if (multa != null && multa.monto > 0 && !multa.estadoPago)
            {
                lblMultas.Text = $"Multa pendiente: 1 | Monto: ${multa.monto:F2}";
                lblTotalMultas.Text = $"Tienes una multa pendiente de ${multa.monto:F2} con {multa.diasRetraso} día(s) de retraso.";
                btnPagar.Text = $"Pagar ${multa.monto}";
                btnPagar.Visible = true;
            }
            else
            {
                lblMultas.Text = "No tienes ninguna multa pendiente";
                lblTotalMultas.Text = "Aún no tienes multas por pagar. ¡Sigue así!";
                btnPagar.Visible = false;
            }
        }


        // refrescar los datos
        private async Task RefrescarDatos()
        {
            Usuario usuario = Datos.UsuarioActual;

            if (usuario != null)
            {
                UsuarioService usuarioService = new UsuarioService();

                // Actualiza Datos.UsuarioActual desde Firebase y espera que termine
                bool actualizado = await usuarioService.ActualizarUsuarioEnProgramaAsync();

                if (!actualizado)
                {
                    MessageBox.Show("No se pudo actualizar la información del usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Actualizar referencias al usuario actual tras sincronización
                usuario = Datos.UsuarioActual;

                lblNombre.Text = usuario.nombre;
                lblTipo.Text = "Estudiante";
                lblPrestamos.Text = $"Préstamos activos: {usuario.prestamosActivos}";
                lblCorreo.Text = usuario.correo;

                await CargarMultasPendientes();
            }
            else
            {
                MessageBox.Show("Usuario no identificado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }

            FirebaseHelper firebaseHelper = new FirebaseHelper();

            var libros = await firebaseHelper.ObtenerLibrosAsync();

            flpInicio.Controls.Clear();

            if (libros != null && libros.Count > 0)
            {
                foreach (var item in libros)
                {
                    BookCard card = new BookCard(item.Key, item.Value);
                    flpInicio.Controls.Add(card);
                    AjustarTamañoBookCards();
                }
            }
        }

        private async void btnPagar_Click(object sender, EventArgs e)
        {
            var usuario = Datos.UsuarioActual;
            if (usuario == null) return;

            var multaService = new MultaService();
            var multa = await multaService.ObtenerMultaUsuarioAsync(usuario.correo);

            if (multa != null && multa.monto > 0 && !multa.estadoPago)
            {
                // Marcar como pagada
                multa.estadoPago = true;

                // Guardar cambios
                string idMulta = usuario.correo.Replace(".", "_");
                var firebase = new FirebaseHelper();
                await firebase.UpdateAsync($"Multas/{idMulta}", multa);

                MessageBox.Show("¡Multa pagada exitosamente!");

                // Refrescar la vista
                await CargarMultasPendientes();
            }
        }


        private async Task CargarLibrosPrestados()
        {
            FirebaseHelper firebaseHelper = new FirebaseHelper();

            var prestamos = await firebaseHelper.ObtenerPrestamosAsync();

            flpColeccion.Controls.Clear();

            if (prestamos != null && prestamos.Count > 0)
            {
                foreach (var item in prestamos)
                {
                    var prestamo = item.Value;

                    // Filtrar SOLO los préstamos del usuario actual (por correo)
                    if (prestamo.id_usuario == Datos.UsuarioActual.correo && prestamo.estado == "activo")
                    {
                        var libro = await firebaseHelper.ReadAsync<books>($"libros/{prestamo.id_libro}");

                        if (libro != null)
                        {
                            BookCard card = new BookCard(prestamo.id_libro, libro, prestamo.fecha_devolucion);
                            flpColeccion.Controls.Add(card);

                            AjustarTamañoBookCards();
                            
                        }
                    }
                }
            }
        }
    }
}
