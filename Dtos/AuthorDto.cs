using System.ComponentModel.DataAnnotations;

namespace WebAssignment_Quiz_.Dtos
{
    public class AuthorDto
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is required")]
        public string? Name { get; set; }
        [Required]
        public int? PhoneNumber { get; set; }
        [Required]
        [EmailAddress(ErrorMessage = "Must be valid email")]
        public string? Email { get; set; }
    }
}
