using Context;
using Dto;
using Models.Users;
using Services.Users;


namespace Services.Teams;

public class TeamService
{
    private readonly KanbanContext _context;
    private readonly UserService UserService;

    public TeamService(KanbanContext context,UserService userService)
    {
        UserService=userService;
        _context=context;
    }

    public TeamCreateDto Create (TeamCreateDto teamCreateDto)
    {
        _context.Teams.Add(teamCreateDto.Team!);
        _context.SaveChanges();
        teamCreateDto.User!.TeamId=teamCreateDto.Team!.Id;
        User userSaved=UserService.Create(teamCreateDto.User);
        teamCreateDto.User=userSaved;
        return teamCreateDto;
    }
}