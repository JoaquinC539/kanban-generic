using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using Microsoft.EntityFrameworkCore;

namespace Models;

[Index(nameof(TeamId))]
public class User
{
    [Key]    
    public int Id {get;set;}

    [Required]
    [MaxLength(100)]
    public string Name {get;set;}

    [Required]
    [JsonIgnore]
    public string Password {get;set;}

    
    [JsonIgnore]
    public int TeamId{get;set;}    
    
    [ForeignKey("TeamId")]
    
    public Team? Team {get;set;}

    public DateTime created_at {get;set;}=DateTime.Now;


    public User(string name,string password, int teamId)
    {
        Name=name;
        Password=password;
        TeamId = teamId;
    }
}