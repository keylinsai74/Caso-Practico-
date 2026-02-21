using WebApplicationAPP.Models;
using WebApplicationAPP.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace WebApplicationAPP.Data
{
    public class InventarioRepository : IInventarioRepository
    {
        private readonly AppDbContext _context;

        public InventarioRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<Inventario> GetAll()
        {
            return _context.Inventarios.ToList();
        }

        public Inventario GetById(int id)
        {
            return _context.Inventarios.Find(id);
        }

        public void Add(Inventario inventario)
        {
            _context.Inventarios.Add(inventario);
            _context.SaveChanges();
        }

        public void Update(Inventario inventario)
        {
            _context.Inventarios.Update(inventario);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var inventario = _context.Inventarios.Find(id);
            if (inventario != null)
            {
                _context.Inventarios.Remove(inventario);
                _context.SaveChanges();
            }
        }
    }
}
