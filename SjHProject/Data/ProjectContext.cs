using Microsoft.EntityFrameworkCore;
using SjHProject.DataModel;

namespace SjHProject.DataFront
{
    public class ProjectContext:DbContext
    {
        public ProjectContext(DbContextOptions<ProjectContext> options):
            base(options)
        {

        }
        public DbSet<Contact> Contactt { get; set; } = default!;   
    }
}
