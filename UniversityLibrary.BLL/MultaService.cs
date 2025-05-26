using LibreriaUniversitaria.DAL;
using LibreriaUniversitaria.ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibreriaUniversitaria.BLL
{
    public class MultaService
    {
        private readonly FirebaseHelper firebase = new FirebaseHelper();

        /// Verifica si hay retraso en la devolución y genera/actualiza la multa del usuario. [trigger]
        public async Task VerificarYGenerarMultaAsync(string correoUsuario, DateTime fechaDevolucion)
        {
            int diasRetraso = (DateTime.Now - fechaDevolucion).Days;

            if (diasRetraso > 0)
            {
                string idMulta = correoUsuario.Replace(".", "_");

                var multaExistente = await firebase.ReadAsync<Multa>($"Multas/{idMulta}");

                if (multaExistente == null)
                {
                    multaExistente = new Multa
                    {
                        idUsuario = correoUsuario,
                        diasRetraso = diasRetraso,
                        monto = diasRetraso * 500, // 500 por día de retraso
                        estadoPago = false
                    };
                }
                else
                {
                    multaExistente = CalcularMulta(multaExistente, diasRetraso);
                }

                await firebase.UpdateAsync($"Multas/{idMulta}", multaExistente);
            }
        }

        /// Calcula el nuevo estado de una multa sumando nuevos días de retraso. [Procedimiento almacenado]
        public Multa CalcularMulta(Multa multa, int diasRetraso)
        {
            multa.diasRetraso += diasRetraso;
            multa.monto += diasRetraso * 500;
            multa.estadoPago = false;
            return multa;
        }

        /// Actualiza las multas pagadas, reiniciando su valor. [Evento]
        public async Task ActualizarMultasPagadasAsync()
        {
            var multas = await firebase.ObtenerMultasAsync();

            foreach (var item in multas)
            {
                var multa = item.Value;

                if (multa.estadoPago && multa.monto > 0)
                {
                    multa.diasRetraso = 0;
                    multa.monto = 0;
                    multa.estadoPago = false;

                    await firebase.UpdateAsync($"Multas/{item.Key}", multa);
                }
            }
        }

        /// Obtiene la multa actual del usuario.
        public async Task<Multa> ObtenerMultaUsuarioAsync(string correoUsuario)
        {
            string idMulta = correoUsuario.Replace(".", "_");
            return await firebase.ReadAsync<Multa>($"Multas/{idMulta}");
        }
    }
}
