using ClanChat.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClanChat.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClanController : ControllerBase
    {
        public ClanController()
        {
        }

        [HttpPost]
        public async Task<IActionResult> CreateClan()
        {

            return Ok();
        }

    }
}
