using Microsoft.AspNetCore.Mvc;
namespace Helloasp
{
    public class HomeController: Controller
    {
        // Requests
        //localhost:5000
        [HttpGet("/")]
        public ViewResult home()
        {
            return view();
        }
        [HttpGet("/projects")]
        public ViewResult projects()
        {
            return view();
        }
        [HttpGet("/contact")]
        public ViewResult contact()
        {
            return view();
        }

    }

}