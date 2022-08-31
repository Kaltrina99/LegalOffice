using LegalOfficeWeb_Business.Service.IService;
using LegalOfficeWeb_Models.CaseHistoryDTO;
using LegalOfficeWeb_Models.ReclaimLossesDTO;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Business.Service
{
    public class CaseHistoryService : ICaseHistoryService
    {
        private readonly HttpClient _httpClient;
        private IConfiguration _configuration;
        public CaseHistoryService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        public async Task<CaseHistoryResponseDTO> CUDRLCaseHistory(CUDCaseHistoryDTO objDTO)
        {
            var content = JsonConvert.SerializeObject(objDTO);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("api/CaseHistory/CUDRLCaseHistory", bodyContent);
            string responseResult = response.Content.ReadAsStringAsync().Result;
            if (response.IsSuccessStatusCode)
            {
                var result = JsonConvert.DeserializeObject<CaseHistoryResponseDTO>(responseResult);
                return result;
            }
            return new CaseHistoryResponseDTO();
        }

        public async Task<IEnumerable<CaseHistoryResponseDTO>> GetRLCaseHistory(CaseHistoryDataDTO objDTO)
        {
            var response = await _httpClient.GetAsync($"/api/CaseHistory/GetRLCaseHistory?CaseId={objDTO.CaseId}&UserId={objDTO.UserId}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var apcases = JsonConvert.DeserializeObject<IEnumerable<CaseHistoryResponseDTO>>(content);

                return apcases;
            }

            return new List<CaseHistoryResponseDTO>();
        }
    }
}
