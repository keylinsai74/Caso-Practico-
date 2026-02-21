using WebApplicationAPP.Models;

namespace WebApplicationAPP.Repositories
{
    public interface ICooperativaRepository
    {
        // Servicios
        Task<IEnumerable<Servicio>> GetAllServicios();
        Task<Servicio> GetServicioById(int id);
        Task AddServicio(Servicio servicio);
        Task UpdateServicio(Servicio servicio);


        // Reservas
        Task AddReserva(Reserva reserva);
        Task<IEnumerable<Reserva>> GetReservas(int? idServicio = null);
        Task<Reserva> GetReservaById(int id);
    }
}
