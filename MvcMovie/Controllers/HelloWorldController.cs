using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public string Index()
        {
            return "Helloworld";
        }
        public string welcome()
        {
            return "Helloworld welcome!!";
        }
    }
}
