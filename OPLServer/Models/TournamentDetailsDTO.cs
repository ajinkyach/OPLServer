using OPLServer.Models.Entity;

namespace OPLServer.Models
{
    public class TournamentDetailsDTO: Tournament
    {
        public string? WinningTeamName { get; set; }
        public string? RunnersUpName { get; set; }
    }
}
