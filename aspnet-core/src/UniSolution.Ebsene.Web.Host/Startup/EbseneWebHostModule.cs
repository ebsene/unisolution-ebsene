using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using UniSolution.Ebsene.Configuration;

namespace UniSolution.Ebsene.Web.Host.Startup
{
    [DependsOn(
       typeof(EbseneWebCoreModule))]
    public class EbseneWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public EbseneWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(EbseneWebHostModule).GetAssembly());
        }
    }
}
