using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace TextTemplatingTest.EntityFrameworkCore
{
    /* This class is needed for EF Core console commands
     * (like Add-Migration and Update-Database commands) */
    public class TextTemplatingTestMigrationsDbContextFactory : IDesignTimeDbContextFactory<TextTemplatingTestMigrationsDbContext>
    {
        public TextTemplatingTestMigrationsDbContext CreateDbContext(string[] args)
        {
            TextTemplatingTestEfCoreEntityExtensionMappings.Configure();

            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<TextTemplatingTestMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("Default"));

            return new TextTemplatingTestMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../TextTemplatingTest.DbMigrator/"))
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
