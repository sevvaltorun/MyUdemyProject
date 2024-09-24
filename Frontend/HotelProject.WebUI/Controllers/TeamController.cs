using HotelProject.WebUI.Models.Team;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace HotelProject.WebUI.Controllers
{
    public class TeamController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public TeamController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client= _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("http://localhost:5093/api/Team");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<TeamViewModel>>(jsonData);
                return View(values);
            }
            return View();
        }
    }
}
