using OPLServer.Models.Entity;

namespace OPLServer.Models
{
    public class TeamSquadDTO : Team
    {
        public List<SquadDTO>? Squad { get; set; }
        public List<Tournament>? Winnings { get; set; }
        public List<Tournament>? RunnerUps { get; set; }

    }
}
