

using Microsoft.EntityFrameworkCore;
using progect_Larning.Mudels;

namespace progect_Larning
{
    public class EfIntorDbContext:DbContext
    {
        public DbSet<Person> People {  get; set; }
        public object people { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;initial catalog=SampleDB01;" +
                "Integrated Security=True;Trust Server Certificate=True");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
