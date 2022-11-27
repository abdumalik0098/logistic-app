using LogisticApp.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http.Json;

namespace LogisticApp.Web.Controllers
{
    public class LogisController : Controller
    {
        private readonly ILogger<LogisController> _logger;

        public LogisController(ILogger<LogisController> logger)
        {
            _logger = logger;
            
        }

        private HttpClient client = new HttpClient();
        private List<Logistics> _logistics = new List<Logistics>();
        
        public async Task GetList()
        {
            List<Logistics>? logistics = await client.GetFromJsonAsync<List<Logistics>>("http://127.0.0.1:8000/api/autos");
            _logistics = logistics!;
        }

        public async Task<IActionResult> Index()
        {
            await GetList();
            ViewBag.Auto = _logistics;
            return View();
        }

        [HttpGet]
        public IActionResult Calc()
        {
            return View();
        }
        async Task SendMethod()
        {
            using var response = await client.PostAsJsonAsync("https://localhost:7106/api/logist", 
               _logistics);
            // считываем ответ и десериализуем данные в объект
            _logistics = await response.Content.ReadFromJsonAsync<List<Logistics>>();
        }
        public  async Task GetAllRasxod(double price)
        {
            await GetList();
            foreach (var item in _logistics)
            {
                item.PriceTopliva = price;
            }
            await SendMethod();
        }

        [HttpPost]
        public async Task<IActionResult> AllRasxod()
        {
            double price = Convert.ToDouble(Request.Form["price"]);
            await GetAllRasxod(price);
            ViewBag.Rasxody = _logistics;
            return View();
        }

    }
}
