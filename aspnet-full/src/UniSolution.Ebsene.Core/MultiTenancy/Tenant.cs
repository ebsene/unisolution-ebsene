using Abp.MultiTenancy;
using UniSolution.Ebsene.Authorization.Users;

namespace UniSolution.Ebsene.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
