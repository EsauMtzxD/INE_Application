using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class INEContext : DbContext
    {

        public INEContext(): base("INEContext")
        {
            //Vacio.
        }

        public DbSet<Address> Addresses { get; set; }
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Citizen> Citizens { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<CountryRegion> CountryRegions { get; set; }
        public DbSet<PoliticalParty> PoliticalParties { get; set; }
        public DbSet<PositionCandidate> PositionCandidates { get; set; }
        public DbSet<StateProvince> StateProvinces { get; set; }
        public DbSet<TypeVote> TypeVotes { get; set; }
        public DbSet<Vote> Votes { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //De plural -> singular y viceversa.
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}