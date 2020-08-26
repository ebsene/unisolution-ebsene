using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace UniSolution.Ebsene.EntityFrameworkCore
{
    public static class EbseneDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<EbseneDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<EbseneDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
