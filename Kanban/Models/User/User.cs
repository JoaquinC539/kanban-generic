using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Models.Teams;
namespace Models.Users;

[Index(nameof(TeamId))]
public class User:TypeUser
{
    [Key]    
    public int? Id {get;set;}

    [Required]    
    public string? Password {get;set;}

    
    [JsonIgnore]
    public int? TeamId{get;set;}    
    
    [ForeignKey("TeamId")]    
    public Team? Team {get;set;}

    public User()
    {}
    
   
}