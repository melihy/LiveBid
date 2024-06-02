using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BiddingService
{
    public class BidDto
    {
       public string Id { get; set; }
    public string AuctionId { get; set; }
    public string Bidder { get; set; }
    public DateTime BidTime { get; set; }
    public int Amount { get; set; }
    public string BidStatus { get; set; }
    }
}