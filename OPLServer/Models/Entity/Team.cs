namespace OPLServer.Models.Entity
{
    public class Team
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Owner { get; set; }
        public required string FullName { get; set; }
        public int CaptainID { get; set; }
        public bool IsActive { get; set; }
    }
}
