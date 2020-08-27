using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace UniSolution.Ebsene.Controllers
{
    public abstract class EbseneControllerBase: AbpController
    {
        protected EbseneControllerBase()
        {
            LocalizationSourceName = EbseneConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
