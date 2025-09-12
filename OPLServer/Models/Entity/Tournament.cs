namespace OPLServer.Models.Entity
{
    public class Tournament
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public int Year { get; set; }
        public int TeamsCount { get; set; }
        public bool IsRoundRobin { get; set; }
        public int Rounds { get; set; }
        public int WinningTeamID { get; set; }
        public int RunnersUpID { get; set; }
        public bool IsActive { get; set; }

    }
}
