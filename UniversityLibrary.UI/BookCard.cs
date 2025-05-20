using LibreriaUniversitaria.BLL;
using LibreriaUniversitaria.DAL;
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
    public partial class BookCard : UserControl
    {
        public string BookId { get; set; }
        private books _bookData;

        public BookCard(string id, books libro)
        {
            InitializeComponent();

            BookId = id;
            _bookData = libro;

            btnPrestar.FillColor = ColorRandom();
            lblTitulo.Text = libro.Titulo;
            lblAutor.Text = libro.Autor;
            lblDisponibilidad.Text = $"{libro.CantidadDisponible} / {libro.CantidadTotal}";
        }

        public async void btnPrestar_Click(object sender, EventArgs e)
        {
            // Buscar el TabPage contenedor
            TabPage parentTab = this.Parent?.Parent as TabPage;

            if (parentTab != null && parentTab.Parent is TabControl tabControl)
            {
                int tabIndex = tabControl.TabPages.IndexOf(parentTab);

                if (tabIndex == 1)
                {
                    // ✅ Estamos en la pestaña de colección → devolver libro
                    await DevolverLibro();
                }
                else
                {
                    // ✅ Estamos en la pestaña de inicio → validar antes de prestar

                    FirebaseHelper firebaseHelper = new FirebaseHelper();
                    var prestamos = await firebaseHelper.ObtenerPrestamosAsync();

                    if (prestamos != null)
                    {
                        bool yaPrestado = prestamos.Any(p =>
                            p.Value.id_usuario == Datos.UsuarioActual.correo &&
                            p.Value.id_libro == BookId &&
                            p.Value.estado == "activo");

                        if (yaPrestado)
                        {
                            MessageBox.Show("Ya tienes este libro prestado.");
                            return;
                        }
                    }

                    // Prestar si no lo tiene activo
                    await PrestarLibro();
                }
            }
        }


        private async Task PrestarLibro()
        {
            if (_bookData.CantidadDisponible > 0)
            {
                FirebaseHelper firebaseHelper = new FirebaseHelper();
                UsuarioService usuarioService = new UsuarioService();

                // 1. Actualizar cantidad disponible del libro
                _bookData.CantidadDisponible--;
                lblDisponibilidad.Text = $"{_bookData.CantidadDisponible} / {_bookData.CantidadTotal}";
                await firebaseHelper.UpdateLibroAsync(BookId, _bookData);

                // 2. Obtener usuario actual
                var usuario = await usuarioService.ObtenerOCrearUsuario(Datos.UsuarioActual.correo);

                if (usuario != null)
                {
                    // 3. Incrementar prestamosActivos
                    usuario.prestamosActivos++;

                    // 4. Actualizar el usuario en Firebase con el nuevo método
                    bool exito = await usuarioService.ActualizarUsuarioAsync(usuario);

                    if (!exito)
                    {
                        MessageBox.Show("Error al actualizar el usuario.");
                        return; // Salir si no se pudo actualizar el usuario
                    }

                    // 5. Registrar el préstamo en tabla prestamos
                    var nuevoPrestamo = new Prestamo
                    {
                        id_usuario = Datos.UsuarioActual.correo, // CORREO como string
                        id_libro = BookId,
                        estado = "activo",
                        fecha_prestamo = DateTime.Now.ToString("yyyy-MM-dd"),
                        fecha_devolucion = DateTime.Now.AddDays(7).ToString("yyyy-MM-dd")
                    };

                    btnPrestar.Text = "✔";
                    await firebaseHelper.CreateAsync("prestamos", nuevoPrestamo);
                }
                else
                {
                    MessageBox.Show("Error: No se encontró el usuario.");
                }
            }
            else
            {
                MessageBox.Show("No hay ejemplares disponibles.");
            }
        }
        private async Task DevolverLibro()
        {
            FirebaseHelper firebaseHelper = new FirebaseHelper();
            UsuarioService usuarioService = new UsuarioService();

            // Aumentar stock
            _bookData.CantidadDisponible++;
            await firebaseHelper.UpdateLibroAsync(BookId, _bookData);

            // Actualizar usuario
            var usuario = await usuarioService.ObtenerOCrearUsuario(Datos.UsuarioActual.correo);
            usuario.prestamosActivos = Math.Max(0, usuario.prestamosActivos - 1);
            await usuarioService.ActualizarUsuarioAsync(usuario);

            // Cambiar estado del préstamo a "devuelto"
            var prestamos = await firebaseHelper.ObtenerPrestamosAsync();
            var prestamo = prestamos.FirstOrDefault(p =>
                p.Value.id_usuario == Datos.UsuarioActual.correo &&
                p.Value.id_libro == BookId &&
                p.Value.estado == "activo");

            if (prestamo.Key != null)
            {
                prestamo.Value.estado = "devuelto";
                await firebaseHelper.UpdateAsync($"prestamos/{prestamo.Key}", prestamo.Value);
            }

            this.Parent?.Controls.Remove(this);
        }


        private Color ColorRandom()
        {
            Random rand = new Random();
            int rojo = rand.Next(180, 256);
            int verde = rand.Next(180, 256);
            int azul = rand.Next(180, 256);
            int alfa = rand.Next(50, 101);

            return Color.FromArgb(alfa, rojo, verde, azul);
        }

        private void BookCard_Load(object sender, EventArgs e)
        {
            // Verifica si el BookCard está dentro de un TabPage
            TabPage parentTab = this.Parent?.Parent as TabPage;

            if (parentTab != null && parentTab.Parent is TabControl tabControl)
            {
                int tabIndex = tabControl.TabPages.IndexOf(parentTab);

                if (tabIndex == 1)
                {
                    // Estamos en la pestaña de colección → cambiar el texto del botón
                    btnPrestar.Text = "-";
                }
                else
                {
                    // Estamos en la pestaña de inicio
                    btnPrestar.Text = "+";
                }
            }
        }

        private void btnPrestar_MouseMove(object sender, MouseEventArgs e)
        {
            TabPage parentTab = this.Parent?.Parent as TabPage;

            if (parentTab != null && parentTab.Parent is TabControl tabControl)
            {
                int tabIndex = tabControl.TabPages.IndexOf(parentTab);

                if (tabIndex == 1)
                {
                    btnPrestar.Text = "Devolver";
                    btnPrestar.Font = new Font("Segoe UI", 15);
                }
                else
                {
                    btnPrestar.Text = "Prestar";
                    btnPrestar.Font = new Font("Segoe UI", 15);
                }
            }
        }

        private void btnPrestar_MouseLeave(object sender, EventArgs e)
        {
            TabPage parentTab = this.Parent?.Parent as TabPage;

            if (parentTab != null && parentTab.Parent is TabControl tabControl)
            {
                int tabIndex = tabControl.TabPages.IndexOf(parentTab);

                if (tabIndex == 1)
                {
                    btnPrestar.Text = "-";
                    btnPrestar.Font = new Font("Segoe UI", 30);
                }
                else
                {
                    btnPrestar.Text = "+";
                    btnPrestar.Font = new Font("Segoe UI", 30);
                }
            }
        }

    }
}
