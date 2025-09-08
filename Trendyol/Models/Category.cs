using System.ComponentModel.DataAnnotations.Schema;

namespace Trendyol.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        [ForeignKey(nameof(Parent))]
        public int? ParentId { get; set; }
        public Category? Parent { get; set; }
        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
