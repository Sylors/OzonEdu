using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using OzonEdu.Merchandise.HttpModels;
using OzonEdu.Merchandise.HttpModels.Merch.V1.Requests;
using OzonEdu.Merchandise.HttpModels.Merch.V1.Responses;

namespace OzonEdu.Merchandise.HttpClients
{
    public interface IMerchHttpClients
    {
        Task RequestMerch(MerchRequestV1 model, CancellationToken token);
        Task<MerchItemResponseV1> GetInfoAboutIssuanceMerch(long employeeId, CancellationToken token);
    }

    public class MerchHttpClients : IMerchHttpClients
    {
        private readonly HttpClient _httpClient;

        public MerchHttpClients(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task RequestMerch(MerchRequestV1 model, CancellationToken token)
        {
            string json =  JsonSerializer.Serialize(model);
            StringContent httpContent = new StringContent(json, System.Text.Encoding.UTF8, "application/json");
            using var response = await _httpClient.PostAsync("v1/api/merch/RequestMerch", httpContent, token);
            //var body = await response.Content.ReadAsStringAsync(token);
            //  return JsonSerializer.Deserialize<List<string>>(body);
        }

        public async Task<MerchItemResponseV1> GetInfoAboutIssuanceMerch(long employeeId, CancellationToken token)
        {
            using var response = await _httpClient.GetAsync($"v1/api/merch/get-info-about-issuance-merch?employeeId={employeeId}", token);
            var body = await response.Content.ReadAsStringAsync(token);
            return JsonSerializer.Deserialize<MerchItemResponseV1>(body);
        }
    }
    
}