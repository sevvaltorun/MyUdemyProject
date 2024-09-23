using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeamController : ControllerBase
    {
        private readonly ITeamService _teamService;

        public TeamController(ITeamService teamService)
        {
            _teamService = teamService;
        }

        [HttpGet]
        public IActionResult TeamList()
        {
            var values = _teamService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddTeam(Team team)
        {
            _teamService.TInsert(team);
            return Ok();
        }
        [HttpDelete]
        public IActionResult DeleteTeam(int id)
        {
            var values = _teamService.TGetByd(id);
            _teamService.TDelete(values);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateTeam(Team team)
        {
            _teamService.TUpdate(team);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetTeam(int id)
        {
            var values = _teamService.TGetByd(id);
             return Ok(values);
        }
    }
}
