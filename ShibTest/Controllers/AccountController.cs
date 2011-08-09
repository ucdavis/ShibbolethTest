using System.Security;
using System.Web.Mvc;
using System.Web.Security;

namespace ShibTest.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/

        public void Logon()
        {
            var user = Request.ServerVariables["HTTP_REMOTEUSER"];

            if (string.IsNullOrWhiteSpace(user))
            {
                throw new SecurityException("You need to be logged in with Shibboleth!");
            }

            FormsAuthentication.RedirectFromLoginPage(user, false);
        }

    }
}
