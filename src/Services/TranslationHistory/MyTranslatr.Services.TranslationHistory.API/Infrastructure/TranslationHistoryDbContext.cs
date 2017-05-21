using Microsoft.EntityFrameworkCore;
using TranslationHistory.API.Models;

namespace TranslationHistory.API.Infrastructure
{
    public class TranslationHistoryDbContext : DbContext
    {
        public TranslationHistoryDbContext(DbContextOptions<TranslationHistoryDbContext> options) : base(options)
        {
        }

        public DbSet<TranslationDetail> History { get; set; }
    }
}
