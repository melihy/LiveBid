using MongoDB.Entities;

namespace SearchService.Services
{
    public class AuctionSvcHttpClient
    {
        private readonly HttpClient _client;
        private readonly IConfiguration _config;

        public AuctionSvcHttpClient(HttpClient client, IConfiguration config)
        {
            _client = client;
            _config = config;
        }

        public async Task<List<Item>> GetItemsForSearchDb()
        {
            Console.WriteLine("GetItemsForSearchDb running..");
            var lastUpdated = await DB.Find<Item, string>()
            .Sort(q => q.Descending(x => x.UpdatedAt))
            .Project(x => x.UpdatedAt.ToString())
            .ExecuteFirstAsync();

            Console.WriteLine("lastUpdate:" + lastUpdated);

            return await _client.GetFromJsonAsync<List<Item>>(_config["AuctionServiceUrl"]
            + "/api/auctions?date=" + lastUpdated);
        }
    }
}