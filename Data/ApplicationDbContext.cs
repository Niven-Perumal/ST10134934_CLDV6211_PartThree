using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ST10134934_CLDV6211_PartThree.Models;

namespace ST10134934_CLDV6211_PartThree.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ST10134934_CLDV6211_PartThree.Models.Product> Product { get; set; } = default!;

        public DbSet<ST10134934_CLDV6211_PartThree.Models.Transaction> Transaction { get; set; } = default!;

        public DbSet<ST10134934_CLDV6211_PartThree.Models.Kuser> Kuser { get; set; } = default!;

        public DbSet<ST10134934_CLDV6211_PartThree.Models.TransactionHistory> TransactionHistory { get; set; } = default!;




    }
}
