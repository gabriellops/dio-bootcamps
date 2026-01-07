using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MinimalAPI.Domain.Entities
{
    public class VehicleEntity : BaseEntity
    {
        [Required]
        public string Nome { get; set; }

        [Required]
        public string? Marca { get; set; }

        [Required]
        public int Ano { get; set; }


        [Required]
        public int AdministratorId { get; set; }

        [ForeignKey(nameof(AdministratorId))]
        public AdministratorEntity Administrator { get; set; }
    }
}
