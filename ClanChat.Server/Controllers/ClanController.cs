using ClanChat.Application.DTO;
using ClanChat.Domain.Interfaces;
using ClanChat.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClanChat.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClanController : ControllerBase
    {
        private readonly IRepository<Clan> _clanRepository;
        public ClanController(IRepository<Clan> clanRepository)
        {
            _clanRepository = clanRepository;
        }

        [HttpPost]
        public async Task<IActionResult> CreateClan(ClanDTO clanDto)
        {
            Clan clan = new Clan()
            {
                Name = clanDto.Name,
            };
            await _clanRepository.Create(clan);
            return Ok();
        }

    }
}
