using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Data.Context
{
    public class ContextFactory : IDesignTimeDbContextFactory<SistemaAcaiContext>
    {
        public SistemaAcaiContext CreateDbContext(string[] args)
        {
            var connectionString = "Server=localhost;Database=SistemaAcai;Uid=root;Pwd=root;";
            var optionsBuilder = new DbContextOptionsBuilder<SistemaAcaiContext>();
            optionsBuilder.UseMySql(connectionString);
            return new SistemaAcaiContext(optionsBuilder.Options);
        }
    }
}