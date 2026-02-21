using WebApplicationAPP.Models;
using System.Collections.Generic;

namespace WebApplicationAPP.Repositories
{
    public interface IInventarioRepository
    {
        List<Inventario> GetAll();
        Inventario GetById(int id);
        void Add(Inventario inventario);
        void Update(Inventario inventario);
        void Delete(int id);
    }
}
