using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationAPP.Models
{
    [Table("inventario_keilyn")]  
    public class Inventario
    {
        [Key]
        public int Id { get; set; }

        public int ProductoId { get; set; }

        public int Stock { get; set; }
    }
}
