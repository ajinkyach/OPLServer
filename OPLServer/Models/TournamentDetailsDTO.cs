using OPLServer.Models.Entity;

namespace OPLServer.Models
{
    public class TournamentDetailsDTO: Tournament
    {
        public string? WinningTeamName { get; set; }
        public string? RunnersUpName { get; set; }
        public string? OrangeCapName { get; set; }
        public string? PurpleCapName { get; set; }
        public string? PlayerOfTheSeriesName { get; set; }


    }
}
