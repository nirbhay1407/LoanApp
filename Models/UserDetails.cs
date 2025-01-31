using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace LoanApplication.Models
{
    public class UserDetails
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        public string? Email { get; set; }
        public string? PhoneNumber { get; set; }
        [DisplayName("Table Ready")]
        public bool TableReady { get; set; } = false;
        public string? Description { get; set; }
        
    }
}
