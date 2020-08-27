using System.Collections.Generic;

namespace UniSolution.Ebsene.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
