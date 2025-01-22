using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;

public class ApiController : Controller
{
  private readonly HttpClient _httpClient;

  public ApiController(HttpClient httpClient)
  {
    _httpClient = httpClient;
  }

  public async Task<IActionResult> Index()
  {
    //Make an HTTP request to FastAPI backend
    var response = await _httpClient.GetStringAsync("http://localhost:8000/api/");

    ViewData["ApiResponse"] = response;
    return View();
  }
}