using System.ComponentModel.DataAnnotations;

/*
    DTOs neccecary for User related operations
*/

namespace UrlShortenerAPI.DTOs
{
    public class CreateUserDto
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;
        
        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;
        
        [Required]
        [MinLength(8)]
        public string Password { get; set; } = string.Empty;
        
        [StringLength(500)]
        public string? Description { get; set; }
    }
    
    public class UpdateUserDto
    {
        [StringLength(100)]
        public string? Name { get; set; }
        
        [EmailAddress]
        public string? Email { get; set; }
        
        [StringLength(500)]
        public string? Description { get; set; }
    }

    public class UserResponseDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string? Description { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? DeactivatedAt { get; set; }
    }
}