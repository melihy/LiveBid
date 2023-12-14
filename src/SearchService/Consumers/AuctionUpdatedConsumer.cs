using AutoMapper;
using Contracts;
using MassTransit;
using MongoDB.Entities;

namespace SearchService;

public class AuctionUpdatedConsumer : IConsumer<AuctionUpdated>
{
    private readonly IMapper _mapper;

    public AuctionUpdatedConsumer(IMapper mapper)
    {
        _mapper = mapper;
    }
    public async Task Consume(ConsumeContext<AuctionUpdated> context)
    {
        Console.WriteLine("--> Consuming auction updated:" + context.Message.Id);

        var item = _mapper.Map<Item>(context.Message);

        var result = await DB.Update<Item>()
                    // .MatchID(item.ID)
                    .Match(q => q.ID == context.Message.Id)
                    // .ModifyWith(item)
                    .ModifyOnly(q => new
                    {
                        q.Color,
                        q.Make,
                        q.Model,
                        q.Year,
                        q.Mileage
                    }, item)
                    .ExecuteAsync();

        if (!result.IsAcknowledged)
            throw new MessageException(typeof(AuctionUpdated), "Problem updating mongoDB!");
    }
}
