using HouseRentingSystem.Core.Constrains;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HouseRentingSystem.Core.Data
{
    public class House
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(HouseConstrain.TitleMaxLenght, MinimumLength = HouseConstrain.TitleMinLenght)]
        public string Title { get; set; } = null!;

        [Required]
        [StringLength(HouseConstrain.AddressMaxLenght, MinimumLength = HouseConstrain.AddressMinLenght)]
        public string Address { get; set; } = null!;

        [Required]
        [StringLength(HouseConstrain.DescriptionMaxLenght, MinimumLength = HouseConstrain.DescriptionMinLenght)]
        public string Description { get; set; } = null!;

        [Required]
        public string ImageUrl { get; set; } = null!;

        [Required]
        [Range(typeof(decimal), HouseConstrain.PricePerMonthMinLenght, HouseConstrain.PricePerMonthMaxLenght)]
        [Precision(18,2)]
        public decimal PricePerMonth { get; set; }

        [Required]
        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        [Required]
        [ForeignKey(nameof(Agent))]
        public int AgentId { get; set; }
        public Agent Agent { get; set; } = null!;

        public string? RenterId { get; set; } = null!;

    }
}



//· AgentId – an integer (required)

//· Agent – an Agent object

//· RenterId – a string
