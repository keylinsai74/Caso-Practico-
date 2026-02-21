namespace WebApplicationAPP.Models
{
    public class Reserva
    {
        public int Id { get; set; }
        public string NombreDelAsociado { get; set; }
        public string Identificacion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Direccion { get; set; }
        public decimal MontoTotal { get; set; }
        public DateTime FechaDelServicio { get; set; }
        public DateTime FechaDeRegistro { get; set; }
        public int IdServicio { get; set; }


        //Muestra los datos en la busqueda
        public virtual Servicio Servicio { get; set; }
    }
}
