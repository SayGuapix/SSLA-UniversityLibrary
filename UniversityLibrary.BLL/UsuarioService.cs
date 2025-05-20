using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibreriaUniversitaria.DAL;
using LibreriaUniversitaria.ENTITIES;
using LibreriaUniversitaria.UTIL;

namespace LibreriaUniversitaria.BLL
{
    public class UsuarioService
    {
        private FirebaseHelper firebase = new FirebaseHelper();

        public async Task<bool> CorreoExisteAsync(string correo)
        {
            var usuarios = await firebase.ReadAsync<Dictionary<string, Usuario>>("Usuarios");

            if (usuarios == null || usuarios.Count == 0)
                return false;

            return usuarios.Any(u => u.Value.correo.Equals(correo, StringComparison.OrdinalIgnoreCase));
        }


        public async Task<Usuario> ObtenerOCrearUsuario(string correo)
        {
            var usuarios = await firebase.ReadAsync<Dictionary<string, Usuario>>("Usuarios");

            if (usuarios == null || usuarios.Count == 0)
            {
                // No hay usuarios, crear el primero
                var nuevoUsuario = CrearNuevoUsuario(correo);
                await firebase.CreateAsync("Usuarios", nuevoUsuario);

                // ✅ Crear la multa inicial
                await CrearMultaInicialParaUsuario(correo);

                return nuevoUsuario;
            }

            var item = usuarios.FirstOrDefault(u => u.Value.correo.Equals(correo, StringComparison.OrdinalIgnoreCase));

            if (item.Value != null)
            {
                var usuario = item.Value;

                if (usuario.multas == null)
                    usuario.multas = Array.Empty<string>();

                if (usuario.historialPrestamos == null)
                    usuario.historialPrestamos = Array.Empty<string>();

                return usuario.tipo_usuario_id == 1 ? usuario : null;
            }

            // Usuario no existe, crearlo
            var usuarioNuevo2 = CrearNuevoUsuario(correo);
            await firebase.CreateAsync("Usuarios", usuarioNuevo2);

            // ✅ Crear la multa inicial
            await CrearMultaInicialParaUsuario(correo);

            return usuarioNuevo2;
        }


        private Usuario CrearNuevoUsuario(string correo)
        {
            return new Usuario
            {
                correo = correo,
                nombre = GenerarNombreDesdeCorreo(correo),
                tipo_usuario_id = 1,
                prestamosActivos = 0,
                historialPrestamos = Array.Empty<string>(),
                multas = Array.Empty<string>()
            };
        }

        public async Task<bool> ActualizarUsuarioAsync(Usuario usuario)
        {
            try
            {
                var usuarios = await firebase.ReadAsync<Dictionary<string, Usuario>>("Usuarios");

                if (usuarios == null || usuarios.Count == 0)
                {
                    // No hay usuarios, simplemente crea uno nuevo
                    await firebase.CreateAsync("Usuarios", usuario);
                    return true;
                }

                // Buscar la clave del usuario por correo (Firebase key)
                var item = usuarios.FirstOrDefault(u => u.Value.correo.Equals(usuario.correo, StringComparison.OrdinalIgnoreCase));

                if (item.Key != null)
                {
                    // Actualizar usando la clave (item.Key)
                    await firebase.UpdateAsync($"Usuarios/{item.Key}", usuario);
                    return true;
                }
                else
                {
                    // No encontrado, crear nuevo usuario
                    await firebase.CreateAsync("Usuarios", usuario);
                    return true;
                }
            }
            catch (Exception ex)
            {
                // Manejo de errores (puedes hacer log o throw)
                return false;
            }
        }
        public async Task<bool> ActualizarUsuarioEnProgramaAsync()
        {
            try
            {
                var usuarios = await firebase.ReadAsync<Dictionary<string, Usuario>>("Usuarios");

                if (usuarios == null || usuarios.Count == 0)
                    return false;

                var item = usuarios.FirstOrDefault(u =>
                    u.Value.correo.Equals(Datos.UsuarioActual.correo, StringComparison.OrdinalIgnoreCase));

                if (item.Value != null)
                {
                    // Compatibilidad con C# 7.3: evitar campos nulos
                    if (item.Value.historialPrestamos == null)
                        item.Value.historialPrestamos = new string[0];

                    if (item.Value.multas == null)
                        item.Value.multas = new string[0];

                    // Actualizar los datos en la clase global
                    Datos.UsuarioActual = item.Value;

                    return true;
                }

                return false;
            }
            catch
            {
                return false;
            }
        }
        private async Task CrearMultaInicialParaUsuario(string correo)
        {
            var multa = new Multa
            {
                idUsuario = correo,
                diasRetraso = 0,
                estadoPago = false,
                monto = 0
            };

            string idMulta = correo.Replace(".", "_"); // Para que sea una clave segura en Firebase

            await firebase.UpdateAsync($"Multas/{idMulta}", multa);
        }

        private string GenerarNombreDesdeCorreo(string correo)
        {
            try
            {
                string usuario = correo.Split('@')[0];
                usuario = new string(usuario.TakeWhile(c => !char.IsDigit(c)).ToArray());

                string[] partes = usuario.Split('.');
                if (partes.Length == 2)
                {
                    string nombre = char.ToUpper(partes[0][0]) + partes[0].Substring(1);
                    string apellido = char.ToUpper(partes[1][0]) + partes[1].Substring(1);
                    return $"{nombre} {apellido}";
                }

                return usuario;
            }
            catch
            {
                return correo;
            }
        }
    }
}
