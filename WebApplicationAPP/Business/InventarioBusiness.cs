using WebApplicationAPP.Models;
using WebApplicationAPP.Repositories;
using System.Collections.Generic;

namespace WebApplicationAPP.Business
{
    public class InventarioBusiness
    {
        private readonly IInventarioRepository _inventarioRepository;

        public InventarioBusiness(IInventarioRepository inventarioRepository)
        {
            _inventarioRepository = inventarioRepository;
        }

        public List<Inventario> GetAll()
        {
            return _inventarioRepository.GetAll();
        }

        public Inventario GetById(int id)
        {
            return _inventarioRepository.GetById(id);
        }

        public void Add(Inventario inventario)
        {
            _inventarioRepository.Add(inventario);
        }

        public void Update(Inventario inventario)
        {
            _inventarioRepository.Update(inventario);
        }

        public void Delete(int id)
        {
            _inventarioRepository.Delete(id);
        }
    }
}
