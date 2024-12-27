using ClanChat.Application.DTO;
using ClanChat.DAL.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace ClanChat.API.Features.Clans.Commands
{
    public class GetClanByIdRequest : IRequest<ClanDto>
    {
        public Guid ClanId { get; set; }   
    }

    public class GetClanByIdRequestHandler : IRequestHandler<GetClanByIdRequest, ClanDto>
    {
        private readonly ApplicationDbContext _dbContext;

        public GetClanByIdRequestHandler(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<ClanDto> Handle(GetClanByIdRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var clan = await _dbContext.Clans.FirstOrDefaultAsync(c => c.Id == request.ClanId);



                ClanDto clanDto = new ClanDto();
                return clanDto;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
