using AlertmanagerWebhook.Model;
using AlertmanagerWebhook.Service;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace AlertmanagerWebhook.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class AlertmanagerController : ControllerBase
    {
        public AlertmanagerController(IKavehNegarService service)
        {
            Service = service;
        }

        public IKavehNegarService Service { get; }

        [HttpPost]
        public async Task<IActionResult> HandleAlert()
        {
            var requestBody = await new StreamReader(Request.Body).ReadToEndAsync();
            var alert = JsonSerializer.Deserialize<AlertManagerModel>(requestBody);
            await Service.SendSms(alert);
            return Ok();
        }
    }
}
