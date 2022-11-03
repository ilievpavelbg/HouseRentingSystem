using HouseRentingSystem.Core.Constrains;
using System.ComponentModel.DataAnnotations;

namespace HouseRentingSystem.Core.Data
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(CategoryConstrain.NameMaxLenght)]
        public string Name { get; set; } = null!;

        public ICollection<House> Houses { get; set; } = new List<House>();
    }
}

