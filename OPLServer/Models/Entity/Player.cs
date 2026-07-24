namespace OPLServer.Models.Entity
{
    public class Player
    {
        public int PlayerID { get; set; }
        public required string Name { get; set; }
        public int CategoryID { get; set; }
        public int SkillID { get; set; }
        public required string BatStyle { get; set; }
        public required string BowlStyle { get; set; }
        public bool CanKeep { get; set; }
        public bool IsActive { get; set; }

    }
}
