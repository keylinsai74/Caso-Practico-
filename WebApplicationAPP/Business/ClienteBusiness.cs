using WebApplicationAPP.Models;
using WebApplicationAPP.Repositories;

namespace WebApplicationAPP.Busines
{
    public class ClienteBusiness
    {
        private readonly IClienteRepository _clienteRepository;

        public ClienteBusiness(IClienteRepository clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public IEnumerable<Cliente> GetAll()
        {
            return _clienteRepository.GetAll();
        }

        public Cliente GetById(int id)
        {
            return _clienteRepository.GetById(id);
        }

        public void Add(Cliente cliente)
        {
            _clienteRepository.Add(cliente);
        }

        public void Update(Cliente cliente)
        {
            _clienteRepository.Update(cliente);
        }

        public void Delete(int id)
        {
            _clienteRepository.Delete(id);
        }
    }
}
