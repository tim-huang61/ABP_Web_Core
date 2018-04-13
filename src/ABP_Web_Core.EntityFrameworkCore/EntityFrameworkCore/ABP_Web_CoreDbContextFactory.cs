using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ABP_Web_Core.Configuration;
using ABP_Web_Core.Web;

namespace ABP_Web_Core.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ABP_Web_CoreDbContextFactory : IDesignTimeDbContextFactory<ABP_Web_CoreDbContext>
    {
        public ABP_Web_CoreDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ABP_Web_CoreDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ABP_Web_CoreDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ABP_Web_CoreConsts.ConnectionStringName));

            return new ABP_Web_CoreDbContext(builder.Options);
        }
    }
}
