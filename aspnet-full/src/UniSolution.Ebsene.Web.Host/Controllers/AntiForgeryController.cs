using Microsoft.AspNetCore.Antiforgery;
using UniSolution.Ebsene.Controllers;

namespace UniSolution.Ebsene.Web.Host.Controllers
{
    public class AntiForgeryController : EbseneControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
