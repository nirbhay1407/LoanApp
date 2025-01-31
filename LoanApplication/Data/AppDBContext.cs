using LoanApplication.Models;
using Microsoft.EntityFrameworkCore;

namespace LoanApplication.Data
{
    public class AppDBContext : DbContext   
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }
        public DbSet<UserDetails> UserDetails { get; set; }
    }
}
