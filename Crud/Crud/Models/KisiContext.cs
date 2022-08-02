using Microsoft.EntityFrameworkCore;

namespace Crud.Models
{
    public class KisiContext :DbContext
    {
        public KisiContext(DbContextOptions<KisiContext> options):base(options)
        {

        }
        public DbSet<Kisiler> Kisiler { get; set; }
    }
}
