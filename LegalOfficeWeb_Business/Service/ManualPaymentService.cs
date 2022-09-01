using LegalOfficeWeb_Business.Service.IService;
using LegalOfficeWeb_Models.CaseDTO;
using LegalOfficeWeb_Models.ManualPaymentDTO;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Business.Service
{
    public class ManualPaymentService : IManualPaymentService
    {
        private readonly HttpClient _httpClient;
        private IConfiguration _configuration;
        public ManualPaymentService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }
        public async Task CUDManualPayment(CUDManualPaymentDTO objDTO)
        {
            var content = JsonConvert.SerializeObject(objDTO);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("api/ManualPayment/CUDRLManualPayment", bodyContent);
            string responseResult = response.Content.ReadAsStringAsync().Result;
            if (response.IsSuccessStatusCode)
            {
               var result = JsonConvert.DeserializeObject<Task>(responseResult);
               return;
            }

            return;
        }
    }
}
