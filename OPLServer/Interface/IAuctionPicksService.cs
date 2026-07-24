using OPLServer.Models.Entity;

namespace OPLServer.Interface
{
    public interface IAuctionPicksService
    {
        Task<AuctionPick> GetAuctionPicks();
        Task<AuctionPick> GetAuctionPick(int id);


    }
}
