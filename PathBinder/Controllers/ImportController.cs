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
            public string Url { get; set; }
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
                    return BadRequest(ex.Message);
                }
            }
        }
    }
}
