using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace PathBinder.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImportController : ControllerBase
    {
        public class UrlRequest
        {
            public string 
                Url { get; set; }
        }

        [HttpPost("import")]
        public async Task<IActionResult> PostImport([FromBody] UrlRequest request)
        {
            if (request == null || string.IsNullOrWhiteSpace(request.Url))
            {
                return BadRequest("Invalid URL provided.");
            }

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.UserAgent.ParseAdd("Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/58.0.3029.110 Safari/537.3");
                client.DefaultRequestHeaders.Accept.ParseAdd("text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8");
                client.DefaultRequestHeaders.AcceptLanguage.ParseAdd("en-US,en;q=0.5");
                try
                {
                    string response = await client.GetStringAsync(request.Url);
                    return new ContentResult
                    {
                        ContentType = "text/html",
                        StatusCode = (int)HttpStatusCode.OK,
                        Content = response
                    };
                }
                catch (Exception ex)
                {
                    return BadRequest("It failed: " + ex.Message);
                }
            }
        }
    }
}
