using Microsoft.EntityFrameworkCore;
using INTACSAdmin.Models;
using Microsoft.Extensions.Configuration;

namespace INTACSAdmin.Data
{
    public class INTSystemDbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public INTSystemDbContext(DbContextOptions<INTSystemDbContext> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        public DbSet<Client> Clients { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>(entity =>
            {
                entity.Property(e => e.ClientName).HasColumnType("nvarchar(200)").IsRequired();
                entity.Property(e => e.Address).HasColumnType("nvarchar(500)");
                entity.Property(e => e.MainBusiness).HasColumnType("nvarchar(200)");
                entity.Property(e => e.Website).HasColumnType("nvarchar(200)");
                entity.Property(e => e.ContactPerson).HasColumnType("nvarchar(200)");
                entity.Property(e => e.Email).HasColumnType("nvarchar(200)");
                entity.Property(e => e.MobileNo).HasColumnType("nvarchar(50)");
                entity.Property(e => e.Active).HasColumnType("bit");
            });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connectionString = _configuration.GetConnectionString("INTSystemConnection");
                if (!string.IsNullOrEmpty(connectionString))
                {
                    optionsBuilder.UseSqlServer(connectionString);
                }
            }
        }
    }
}
