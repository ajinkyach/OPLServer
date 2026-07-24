using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.OpenApi;
using Microsoft.EntityFrameworkCore;
using OPLServer.Database;
using System.ComponentModel.DataAnnotations;

namespace OPLServer.Models.Entity
{
    public class Matches
    {
        [Key]
        public int MatchID { get; set; }
        public int TournamentID { get; set; }
        public int MatchNumber { get; set; }
        public int HomeTeamID { get; set; }
        public int AwayTeamID { get; set; }
        public DateTime MatchDate { get; set; }
        public int WinningTeamID { get; set; }
        public int PlayerOfTheMatchID { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsActive { get; set; }

    }
}
        