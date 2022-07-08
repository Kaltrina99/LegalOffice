using LegalOfficeWeb_Business.Service.IService;
using LegalOfficeWeb_Models;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Business.Service
{
    public class ReclaimLossesService : IReclaimLossesService
    {
        private readonly HttpClient _httpClient;
        private IConfiguration _configuration;
        public ReclaimLossesService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        public async Task<ReclaimLossesCaseResponseDTO> CUDRLCase(ReclaimLossesCaseDTO objDTO)
        {
            var content = JsonConvert.SerializeObject(objDTO);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("api/ReclaimLosses/CUDRLCase",bodyContent);
            string responseResult = response.Content.ReadAsStringAsync().Result;
            if (response.IsSuccessStatusCode)
            {
                var result = JsonConvert.DeserializeObject<ReclaimLossesCaseResponseDTO>(responseResult);
                return result;
            }

            return new ReclaimLossesCaseResponseDTO();
        }

        public async Task<IEnumerable<ReclaimLossesCaseResponseDTO>> GetAllRLCases()
        {
            var response = await _httpClient.GetAsync("api/ReclaimLosses/GetAllRLCase");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var apcases = JsonConvert.DeserializeObject<IEnumerable<ReclaimLossesCaseResponseDTO>>(content);

                return apcases;
            }

            return new List<ReclaimLossesCaseResponseDTO>();
        }

        public async Task<ReclaimLossesCaseResponseDTO> GetRLCase(int id)
        {
            var response = await _httpClient.GetAsync($"/api/ReclaimLosses/GetRLCase/{id}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var apcases = JsonConvert.DeserializeObject<ReclaimLossesCaseResponseDTO>(content);

                return apcases;
            }

            return new ReclaimLossesCaseResponseDTO();
        }
    }
}
