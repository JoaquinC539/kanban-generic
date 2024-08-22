using System.ComponentModel.DataAnnotations;

namespace Models.Users;

public class TypeUser
{
    [Required]
    [MaxLength(100)]
    public string? Name {get;set;}    
    
    public DateTime? created_at {get;set;}=DateTime.Now;
}