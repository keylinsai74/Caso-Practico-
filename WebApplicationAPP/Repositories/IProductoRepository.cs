using WebApplicationAPP.Models;

namespace WebApplicationAPP.Repositories
{
    public interface IProductoRepository
    {
        List<Producto> GetAll();
        Producto GetById(int id);
        void Add(Producto producto);
        void Update(Producto producto);
        void Delete(int id);
    }
}
