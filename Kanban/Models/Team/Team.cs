using System.ComponentModel.DataAnnotations;

namespace Models.Teams;

public class Team
{
    [Key]
    public int? Id {get;set;}

    [Required]
    [MaxLength(100)]
    public string? Name {get;set;}

    public DateTime? created_at {get;set;}=DateTime.Today;

    public Team(){}
    
}