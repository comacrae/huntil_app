using HuntILFrontEnd.Models;

public interface ISiteNameService {

  Task<List<SiteNameModel>> GetSiteNamesAsync();
  Task<SiteNameModel> GetSiteNameAsync(string SiteId);
}