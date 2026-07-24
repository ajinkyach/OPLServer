using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.EntityFrameworkCore;
using OPLServer.Database;
using System.ComponentModel.DataAnnotations;

namespace OPLServer.Models.Entity
{
    public class MatchInnings
    {
        [Key]
        public int InningsID { get; set; }
        public int MatchID { get; set; }
        public int BattingTeamID { get; set; }
        public int BowlingTeamID { get; set; }
        public int InningsNumber { get; set; }
        public int RunsScored { get; set; }
        public int WicketsLost { get; set; }
        public decimal OversBowled { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsSuperOver { get; set; }
        public bool IsActive { get; set; }

    }
}
        