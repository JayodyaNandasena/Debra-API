using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Debra_API.Entities
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = null!;
        [Required]
        public string Mobile { get; set; } = null!;
        [Required]
        public string Email { get; set; } = null!;
        public ICollection<Ticket> Tickets { get; } = [];
    }
}
