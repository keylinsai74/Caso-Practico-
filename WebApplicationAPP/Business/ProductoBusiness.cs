using WebApplicationAPP.Models;
using WebApplicationAPP.Repositories;

namespace WebApplicationAPP.Busines
{
    public class ProductoBusiness
    {
        private readonly IProductoRepository _productoRepository;

        public ProductoBusiness(IProductoRepository productoRepository)
        {
            _productoRepository = productoRepository;
        }

        public List<Producto> GetAll()
        {
            return _productoRepository.GetAll();
        }

        public Producto GetById(int id)
        {
            return _productoRepository.GetById(id);
        }

        public void Add(Producto producto)
        {
            _productoRepository.Add(producto);
        }

        public void Update(Producto producto)
        {
            _productoRepository.Update(producto);
        }

        public void Delete(int id)
        {
            _productoRepository.Delete(id);
        }
    }
}
