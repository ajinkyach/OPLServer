using Microsoft.EntityFrameworkCore;
using OPLServer.Models;
using OPLServer.Models.Entity;

namespace OPLServer.Database
{
    public class OPLDBContext : DbContext
    {
        // IF MULTIPLE DATABASE CONTEXT
        //public OPLDBContext(DbContextOptions<OPLDBContext> options) : base(options)
        //{

        //}
        public OPLDBContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<SquadDTO>(
                    eb =>
                    {
                        eb.HasNoKey();
                        eb.ToView("vw_Squads");
                    });

            modelBuilder
                .Entity<TournamentDetailsDTO>(
                    eb =>
                    {
                        eb.ToView("vw_TournamentDetails");
                    });
        }

        public DbSet<AuctionPick> AuctionPicks { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Tournament> Tournaments { get; set; }
        public DbSet<SquadDTO> Squads { get; set; }
        public DbSet<TournamentDetailsDTO> TournamentDetails { get; set; }
        public DbSet<OPLServer.Models.Entity.Matches> Matches { get; set; } = default!;


    }
}
