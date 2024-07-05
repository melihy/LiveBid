using AuctionService.Data;
using AuctionService.DTOs;
using AuctionService.Entities;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;

namespace AuctionService
{
    public class AuctionRepository : IAuctionRepository
    {
        private readonly AuctionDbContext _context;
        private readonly IMapper _mapper;

        public AuctionRepository(AuctionDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public void AddAuction(Auction auction)
        {
            _context.Auctions.Add(auction);
        }

        public async Task<AuctionDto> GetAuctionByIdAsync(Guid id)
        {
            return await _context.Auctions
            .ProjectTo<AuctionDto>(_mapper.ConfigurationProvider)
            .FirstOrDefaultAsync(q => q.Id == id);
        }

        public async Task<Auction> GetAuctionEntityById(Guid id)
        {
            return await _context.Auctions
            .Include(q => q.Item)
           .FirstOrDefaultAsync(q => q.Id == id);
        }

        public async Task<List<AuctionDto>> GetAuctionsAsync(string date)
        {
            var auctions = await _context.Auctions
                    .Include(z => z.Item)
                    .OrderBy(q => q.Item.Make)
                    .ToListAsync();


            var query = _context.Auctions.Where(q => q.Item != null).OrderBy(q => q.Item.Make).AsQueryable();

            if (!string.IsNullOrEmpty(date))
            {
                query = query.Where(q => q.UpdatedAt.CompareTo(DateTime.Parse(date).ToUniversalTime()) > 0);
            }

            return await query.ProjectTo<AuctionDto>(_mapper.ConfigurationProvider).ToListAsync();
        }

        public void RemoveAuction(Auction auction)
        {
            _context.Auctions.Remove(auction);
        }

        public async Task<bool> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync() > 0;
        }
    }
}