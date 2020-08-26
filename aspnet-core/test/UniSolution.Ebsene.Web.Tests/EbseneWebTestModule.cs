using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using UniSolution.Ebsene.EntityFrameworkCore;
using UniSolution.Ebsene.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace UniSolution.Ebsene.Web.Tests
{
    [DependsOn(
        typeof(EbseneWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class EbseneWebTestModule : AbpModule
    {
        public EbseneWebTestModule(EbseneEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(EbseneWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(EbseneWebMvcModule).Assembly);
        }
    }
}