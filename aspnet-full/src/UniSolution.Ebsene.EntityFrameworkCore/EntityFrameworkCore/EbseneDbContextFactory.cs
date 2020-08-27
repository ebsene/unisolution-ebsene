using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using UniSolution.Ebsene.Configuration;
using UniSolution.Ebsene.Web;

namespace UniSolution.Ebsene.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class EbseneDbContextFactory : IDesignTimeDbContextFactory<EbseneDbContext>
    {
        public EbseneDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<EbseneDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            EbseneDbContextConfigurer.Configure(builder, configuration.GetConnectionString(EbseneConsts.ConnectionStringName));

            return new EbseneDbContext(builder.Options);
        }
    }
}
