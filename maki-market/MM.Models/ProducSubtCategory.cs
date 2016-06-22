using System.ComponentModel.DataAnnotations;

namespace MM.Models
{
    public class ProducSubCategory
    {
        [Key]
        public int Id { get; set; }
        public int ProductCategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}