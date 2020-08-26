using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;

namespace UniSolution.Ebsene.EntityFrameworkCore
{
    using Authorization.Roles;
    using Authorization.Users;
    using MultiTenancy;
    using Tanks;

    public class EbseneDbContext : AbpZeroDbContext<Tenant, Role, User, EbseneDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public virtual DbSet<Tank> Tanks { get; set; }
        
        public EbseneDbContext(DbContextOptions<EbseneDbContext> options)
            : base(options)
        {
        }
    }
}
