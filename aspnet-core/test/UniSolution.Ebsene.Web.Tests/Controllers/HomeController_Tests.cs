using System.Threading.Tasks;
using UniSolution.Ebsene.Models.TokenAuth;
using UniSolution.Ebsene.Web.Controllers;
using Shouldly;
using Xunit;

namespace UniSolution.Ebsene.Web.Tests.Controllers
{
    public class HomeController_Tests: EbseneWebTestBase
    {
        [Fact]
        public async Task Index_Test()
        {
            await AuthenticateAsync(null, new AuthenticateModel
            {
                UserNameOrEmailAddress = "admin",
                Password = "123qwe"
            });

            //Act
            var response = await GetResponseAsStringAsync(
                GetUrl<HomeController>(nameof(HomeController.Index))
            );

            //Assert
            response.ShouldNotBeNullOrEmpty();
        }
    }
}