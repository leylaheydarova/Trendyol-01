using System.ComponentModel.DataAnnotations.Schema;
using Trendyol.Models.BaseModels;

namespace Trendyol.Models
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }
        [ForeignKey(nameof(Parent))]
        public int? ParentId { get; set; }
        public Category? Parent { get; set; }
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
