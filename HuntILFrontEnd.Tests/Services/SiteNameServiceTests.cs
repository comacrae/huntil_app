using Xunit;
using Moq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Text.Json;
using System.Text;

public class SiteNameServiceTests
{
  private readonly Mock<HttpMessageHandler> _mockHttpMessageHandler;
  private readonly HttpClient _mockHttpClient;
  private readonly SiteNameService;
}