﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace LolWebApp.Repository
{
    public class BaseRepository
    {
        private readonly IHttpClientFactory _clientFactory;
        private string baseUrl = "https://br1.api.riotgames.com/lol/";
        private string apiKey = "RGAPI-997478b5-a114-47af-8d83-f3efabafa47e";

        public BaseRepository(IHttpClientFactory clientFactory)
        {
            _clientFactory = clientFactory;
        }
        public async Task<Stream> HttpGet(String route)
        {
            var client = _clientFactory.CreateClient();
            string url = baseUrl + route + "&api_key=" + apiKey;

            var response = await client.GetAsync(url);
            return await response.Content.ReadAsStreamAsync();
        }
    }
}
