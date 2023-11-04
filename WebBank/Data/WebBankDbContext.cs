namespace WebBank.Data
{
    using Microsoft.EntityFrameworkCore;
    using WebBank.Data.Models;

    public class WebBankDbContext : DbContext
    {
        public WebBankDbContext()
        {
        }

        public WebBankDbContext(DbContextOptions<WebBankDbContext> options)
            : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Credit> Credits { get; set; }
        public DbSet<RepaymentInstallment> RepaymentInstallments { get; set; }
        public DbSet<RepaymentSchedule> RepaymentSchedules { get; set; }
        public DbSet<Transfer> Transfers { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer(Configuration.ConnectionString);
            }
        }
    }
}
