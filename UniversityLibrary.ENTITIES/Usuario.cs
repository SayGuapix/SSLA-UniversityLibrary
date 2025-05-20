namespace LibreriaUniversitaria.ENTITIES
{
    public class Usuario
    {
        public string nombre { get; set; }
        public string correo { get; set; }
        public int tipo_usuario_id { get; set; }
        public int prestamosActivos { get; set; }
        public int id { get; set; }
        public string[] historialPrestamos { get; set; }
        public string[] multas { get; set; }
    }
}
