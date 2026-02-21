using WebApplicationAPP.Models;

namespace WebApplicationAPP.Repositories
{
    public interface IClienteRepository
    {
        List<Cliente> GetAll();
        Cliente GetById(int id);
        void Add(Cliente cliente);
        void Update(Cliente cliente);
        void Delete(int id);
    }
}
