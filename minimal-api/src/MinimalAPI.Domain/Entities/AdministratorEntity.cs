using MinimalAPI.Domain.Enums;
using System.ComponentModel.DataAnnotations;

namespace MinimalAPI.Domain.Entities
{
    public class AdministratorEntity : BaseEntity
    {
        [Required]
        public string Email { get; set; }

        [Required]
        public string Senha { get; set; }

        [Required]
        public ERole Role { get; set; }


        public ICollection<VehicleEntity> Vehicles { get; set; } = [];
    }
}
