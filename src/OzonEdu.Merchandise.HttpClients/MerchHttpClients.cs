using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using OzonEdu.Merchandise.HttpModels;

namespace OzonEdu.Merchandise.HttpClients
{
    public interface IMerchHttpClients
    {
        Task RequestMerch(CancellationToken token);
        Task<List<MerchItemResponse>> GetInformationAboutIssuanceMerch(CancellationToken token);
    }

    public class MerchHttpClients : IMerchHttpClients
    {
        private readonly HttpClient _httpClient;

        public MerchHttpClients(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task RequestMerch(CancellationToken token)
        {
            using var response = await _httpClient.PostAsync("v1/api/merch/RequestMerch", new StringContent(""), token);
            // using var response = await _httpClient.GetAsync("v1/api/merch/RequestMerch", token);
           // var body = await response.Content.ReadAsStringAsync(token);
          //  return JsonSerializer.Deserialize<List<string>>(body);
        }

        public async Task<List<MerchItemResponse>> GetInformationAboutIssuanceMerch(CancellationToken token) {
            using var response = await _httpClient.GetAsync("v1/api/merch/GetInformationAboutIssuanceMerch", token);
            var body = await response.Content.ReadAsStringAsync(token);
            return JsonSerializer.Deserialize<List<MerchItemResponse>>(body);
        }
    }
}