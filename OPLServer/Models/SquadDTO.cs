namespace OPLServer.Models
{
    public class SquadDTO
    {
        public int AuctionPickID { get; set; }
        public int TeamID { get; set; }
        public int TournamentID { get; set; }
        public int PlayerID { get; set; }
        public required string PlayerName { get; set; }
        public int CategoryID { get; set; }
        public required string Category { get; set; }
        public int SkillID { get; set; }
        public int Rating { get; set; }
        public required string BatStyle { get; set; }
        public required string BowlStyle { get; set; }
        public bool CanKeep { get; set; }
        public int BasePrice { get; set; }
        public int AuctionedPrice { get; set; }
        public bool IsDraftPick { get; set; }
        public int PickNumber { get; set; }
        public int RoundNumber { get; set; }
        public bool IsTraded { get; set; }
        public string? TradedWithName { get; set; }
        public bool IsActive { get; set; }
    }
}
