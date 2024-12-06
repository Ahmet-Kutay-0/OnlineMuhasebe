using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using OnlineMuhasebeServer.Domain.Abstractions;
using OnlineMuhasebeServer.Domain.AppEntities;
using System.Reflection.Metadata;

namespace OnlineMuhasebeServer.Persistance.Context
{
    public sealed class CompanyDbContext : DbContext
    {
        private string ConnectionString = "";
        public CompanyDbContext(Company company = null)
        {
            if (company != null)
            {
                if (String.IsNullOrEmpty(company.ServerUserId))
                    ConnectionString = $"" +
                        $"Data Source={company.ServerName};" +
                        $"Initial Catalog={company.DatabaseName};" +
                        $"Integrated Security=True;" +
                        $"Connect Timeout=30;" +
                        $"Encrypt=False;" +
                        $"TrustServerCertificate=False;" +
                        $"ApplicationIntent=ReadWrite;" +
                        $"MultiSubnetFailover=False";
                else
                    ConnectionString = $"" +
                        $"Data Source={company.ServerName};" +
                        $"Initial Catalog={company.DatabaseName};" +
                        $"User Id={company.ServerUserId};" +
                        $"Password={company.ServerPassword};" +
                        $"Integrated Security=True;" +
                        $"Connect Timeout=30;" +
                        $"Encrypt=False;" +
                        $"TrustServerCertificate=False;" +
                        $"ApplicationIntent=ReadWrite;" +
                        $"MultiSubnetFailover=False";
            }

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) =>
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(AssemblyReference).Assembly);

        public class CompanyDbContextFactory : IDesignTimeDbContextFactory<CompanyDbContext>
        {
            public CompanyDbContext CreateDbContext(string[] args)
            {
                return new CompanyDbContext();
            }
        }

    }
}