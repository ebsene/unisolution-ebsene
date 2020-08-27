using Abp.Authorization;
using UniSolution.Ebsene.Authorization.Roles;
using UniSolution.Ebsene.Authorization.Users;

namespace UniSolution.Ebsene.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
