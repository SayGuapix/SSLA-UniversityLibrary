using LibreriaUniversitaria.DAL;
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

namespace UniversityLibrary.UI
{
    public partial class bookRegister : Form
    {
        public bookRegister()
        {
            InitializeComponent();
        }

        private async void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text) ||
                string.IsNullOrWhiteSpace(txtAutor.Text))
            {
                lblAviso.Text = "Por favor, completa todos los campos.";
                return;
            }

            books nuevoLibro = new books
            {
                Titulo = txtTitulo.Text,
                Autor = txtAutor.Text,
                CantidadTotal = (int)nudCantidadTotal.Value,
                CantidadDisponible = (int)nudCantidadTotal.Value
            };

            FirebaseHelper firebaseHelper = new FirebaseHelper();
            await firebaseHelper.AgregarLibroAsync(nuevoLibro);

            lblAviso.Text = "¡Libro registrado con exito!";

            // Limpiar campos después de registrar
            txtTitulo.Clear();
            txtAutor.Clear();
            nudCantidadTotal.Value = 1;
        }

    }
}
