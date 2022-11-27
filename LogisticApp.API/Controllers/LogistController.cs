using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LogisticApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LogistController : ControllerBase
    {
        // POST
        [HttpPost]
        public IActionResult Create(List<Logistics> logist)
        {
            foreach (var item in logist)
            {
                
                item.AllRasxod = Math.Round(((item.Distance / 100.0) * item.RasxodTopliva) * item.PriceTopliva, 2);
            }

            return CreatedAtAction(nameof(Create), logist);
        }

    }
}
