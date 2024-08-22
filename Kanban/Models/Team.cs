using System.ComponentModel.DataAnnotations;

namespace Models;

public class Team
{
    public int? Id {get;set;}

    [Required]
    [MaxLength(100)]
    public string? Name {get;set;}

    public DateTime created_at {get;set;}=DateTime.Today;

    public Team(){}

}