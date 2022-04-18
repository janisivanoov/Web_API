using System.Web;
using System.Web.Http;

namespace WebAPIProject.Controllers
{
    public class WelcomeController : ApiController
    {
        public string Get()
        {
            string strWelcome = "Hello World";
            return strWelcome;
        }
    }
}