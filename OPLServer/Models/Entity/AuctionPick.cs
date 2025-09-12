using OPLServer.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.AspNetCore.Http.HttpResults;
namespace OPLServer.Models.Entity
{
    public class AuctionPick
    {
        public int Id { get; set; }
        public int PlayerID { get; set; }
        public int TeamID { get; set; }
        public int TournamentID { get; set; }
        public int BasePrice { get; set; }
        public int AuctionedPrice { get; set; }
        public bool IsDraftPick { get; set; }
        public int PickNumber { get; set; }
        public int RoundNumber { get; set; }
        public bool IsTraded { get; set; }
        public int? TradedWithID { get; set; }
        public bool IsActive { get; set; }

    }
}