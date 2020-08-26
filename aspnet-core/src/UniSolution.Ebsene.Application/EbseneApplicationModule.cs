using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using UniSolution.Ebsene.Authorization;

namespace UniSolution.Ebsene
{
    [DependsOn(
        typeof(EbseneCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class EbseneApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<EbseneAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(EbseneApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
