using System.Net.Http;
using System.Net.Http.Json;
using System.Collections.Generic;
using System.Threading.Tasks;
using HuntILFrontEnd.Models;

namespace HuntILFrontEnd.Services;

public class SiteNameService: ISiteNameService
{
  private readonly HttpClient _httpClient;

  public SiteNameService(HttpClient httpClient){
    _httpClient = httpClient;
  }

  public async Task<List<SiteNameModel>> GetSiteNamesAsync(){
    try{
      HttpResponseMessage response = await _httpClient.GetAsync(requestUri:"http://localhost:8000/api/sites/names");

      if(response == null){
        throw new HttpRequestException("Http Response is null");
      }

      response.EnsureSuccessStatusCode();

      List<SiteNameModel>? siteNames = await response.Content.ReadFromJsonAsync<List<SiteNameModel>>();

      return siteNames ?? new List<SiteNameModel>();
      
    }
    catch (HttpRequestException ex){
      Console.WriteLine($"HTTP Request Error: {ex.Message}");
      return new List<SiteNameModel>();
    }
  }

  public async Task<SiteNameModel> GetSiteNameAsync(string SiteId){
    return new SiteNameModel();
  }
}