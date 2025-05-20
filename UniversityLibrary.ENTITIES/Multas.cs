namespace LibreriaUniversitaria.ENTITIES
{
    public class Multa
    {
        public string idUsuario { get; set; }
        public int diasRetraso { get; set; }
        public bool estadoPago { get; set; }
        public int monto { get; set; }
    }
}
