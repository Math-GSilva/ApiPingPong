using Microsoft.AspNetCore.Mvc;


namespace PingPong.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PingPongController : ControllerBase
    {

        [HttpGet("{pingOrPong}")]
        public String Get(String pingOrPong)
        {
            String var = pingOrPong.ToLower();
            return var == "ping" ? "Pong" : var == "pong" ? "Ping" : "Only Ping or Pong, Motherf%$#";
        }
    }
}