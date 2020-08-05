using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using LolWebApp.DTO;
using System.Collections.Generic;
using LolWebApp.Service;
using System.Text.RegularExpressions;
using System.Threading;
using System.Text;
using System;
using System.Net.Http.Headers;
using System.Web;

namespace WebApplication1.Controllers
{
    [Route("amigood/{userId}")]
    [ApiController]
    public class LOLController : ControllerBase
    {
        private readonly IHttpClientFactory _clientFactory;

        private AmIGoodService amIGoodService;

        public LOLController(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }

        [HttpGet]
        public async Task<ContentResult> get(string userId)
        {
            amIGoodService = new AmIGoodService(_clientFactory);
            float result = await amIGoodService.getAverageScore(userId);
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("<body><h1>Oi " + userId + "!</h1><span>");
            stringBuilder.Append(HttpUtility.HtmlEncode("Nas últimas 10 partidas, você teve uma classificação média de "));
            stringBuilder.Append(String.Format("{0:P2}.", result));
            stringBuilder.Append("</span></body>");

            String response = stringBuilder.ToString();

            return base.Content(response, "text/html");
        }
    }
}