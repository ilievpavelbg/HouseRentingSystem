using HouseRentingSystem.Core.Constrains;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace HouseRentingSystem.Core.Data
{
    public class Agent
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(AgentConstrain.PhoneNumberMaxLenght, MinimumLength = AgentConstrain.PhoneNumberMinLenght)]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        public string UserId { get; set; } = null!;

        public IdentityUser User { get; set; } = null!;
    }
}


