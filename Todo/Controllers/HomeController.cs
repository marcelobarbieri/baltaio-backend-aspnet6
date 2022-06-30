using Microsoft.AspNetCore.Mvc;

namespace Todo.Controllers
{
    [ApiController]
    [Route("home")] // prefixo de rota
    public class HomeController : ControllerBase
    {
        //[HttpGet("/")]
        [HttpGet]
        [Route("/")]
        public string Get()
        {
            return "Hello 1 World!";
        }
    }
}