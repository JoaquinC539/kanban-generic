using Dto;
using Microsoft.AspNetCore.Mvc;
using Services.Teams;

namespace Controllers;

[ApiController]
[Route("api/[controller]")]
public class TeamController:ControllerBase
{

    private readonly TeamService TeamService;

    public TeamController(TeamService tService)
    {
        this.TeamService=tService;
    }

    [HttpPost]
    public ActionResult<TeamCreateDto> Create([FromBody] TeamCreateDto teamCreateDto)
    {
        return Ok(TeamService.Create(teamCreateDto));
    }
}