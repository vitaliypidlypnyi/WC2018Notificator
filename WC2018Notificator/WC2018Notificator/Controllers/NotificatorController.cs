using Microsoft.AspNetCore.Mvc;
using WC2018Notificator.Models;
using WC2018Notificator.Services;

namespace WC2018Notificator.Controllers
{
    [Route("api/notification")]
    [ApiController]
    public class NotificatorController : ControllerBase
    {
        private readonly IPlayerService _playerService;

        public NotificatorController(IPlayerService playerService)
        {
            _playerService = playerService;
        }

        [HttpGet("players")]
        public IActionResult Get()
        {
            return Ok(_playerService.GetPlayers());
        }

        [HttpPost("players/add")]
        public IActionResult Add(Player model)
        {
            _playerService.AddPlayer(model);
            return NoContent();
        }
    }
}