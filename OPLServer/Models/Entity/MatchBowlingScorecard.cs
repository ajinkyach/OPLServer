using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.EntityFrameworkCore;
using OPLServer.Database;
using System.ComponentModel.DataAnnotations;

namespace OPLServer.Models.Entity
{
    public class MatchBowlingScorecard
    {
        [Key]
        public int BowlingScoreID { get; set; }
        public int MatchID { get; set; }
        public int InningsID { get; set; }
        public int TeamID { get; set; }
        public int PlayerID { get; set; }
        public int OversBowled { get; set; }
        public int RunsGiven { get; set; }
        public int WicketsTaken { get; set; }
        public bool IsActive { get; set; }

    }
}
        