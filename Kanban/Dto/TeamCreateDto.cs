using System.ComponentModel.DataAnnotations;
using Models.Users;
using Models.Teams;

namespace Dto;

public class TeamCreateDto
{
    [Required]
    public Team? Team {get;set;}

    [Required]
    public User? User {get;set;}

    public TeamCreateDto()
    {}
    
}