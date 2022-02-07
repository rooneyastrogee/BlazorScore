
using Microsoft.AspNetCore.Components;
using Scores.DataModels.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Score.UI.Service
{
    public class FrontEndservice : IFrontEndservice
    {
        private readonly HttpClient _httpClient = null;

        public FrontEndservice(HttpClient _httpClient)
        {
            this._httpClient = _httpClient;
        }

        public async Task<List<Product>> getProducts()
        {
            return await _httpClient.GetJsonAsync<List<Product>>("api/product/getProducts");
        }
    }
}
