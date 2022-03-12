using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkillCampAPI.Models
{
    public class context : DbContext
    {
        public context(DbContextOptions<context> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<LoyaltyCard> LoyaltyCards { get; set; }
        public DbSet<CameraLoad> CameraLoads { get; set; }
        public DbSet<DepositCard> DepositCards { get; set; }
        public DbSet<CardType> CardTypes { get; set; }
        public DbSet<CarFillingStation> CarFillingStations { get; set; }
        public DbSet<GasStation> GasStations { get; set; }
        public DbSet<Purchase> Purchases { get; set; }
        public DbSet<Pay> Pays { get; set; }
        public DbSet<Refund> Refunds { get; set; }
    }
}
