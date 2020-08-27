using Abp.AutoMapper;
using UniSolution.Ebsene.Authentication.External;

namespace UniSolution.Ebsene.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
