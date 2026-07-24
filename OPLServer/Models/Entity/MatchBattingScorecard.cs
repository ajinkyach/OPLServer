using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.EntityFrameworkCore;
using OPLServer.Database;
using System.ComponentModel.DataAnnotations;

namespace OPLServer.Models.Entity
{
    public class MatchBattingScorecard
    {
        [Key]
        public int BattingScoreID { get; set; }
        public int MatchID { get; set; }
        public int InningsID { get; set; }
        public int TeamID { get; set; }
        public int PlayerID { get; set; }
        public int RunsScored { get; set; }
        public int BallsFaced { get; set; }
        public bool IsOut { get; set; }
        public bool IsActive { get; set; }

    }
}
        