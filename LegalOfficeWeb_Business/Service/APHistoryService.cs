using LegalOfficeWeb_Business.Service.IService;
using LegalOfficeWeb_Models.CaseHistoryDTO;
using LegalOfficeWeb_Models.HistoryDTO;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Business.Service
{
    public class APHistoryService : IAPHistoryService
    {
        private readonly HttpClient _httpClient;
        private IConfiguration _configuration;
        public APHistoryService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }
        public async Task<HistoryResponseDTO> CUDAPHistory(CUDHistoryDTO objDTO)
        {
            var content = JsonConvert.SerializeObject(objDTO);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("api/APHistory/CUDAPHistory", bodyContent);
            string responseResult = response.Content.ReadAsStringAsync().Result;
            if (response.IsSuccessStatusCode)
            {
                var result = JsonConvert.DeserializeObject<HistoryResponseDTO>(responseResult);
                return result;
            }
            return new HistoryResponseDTO();
        }

        public async Task<IEnumerable<HistoryResponseDTO>> GetAPHistory(HistoryDataDTO objDTO)
        {
            var response = await _httpClient.GetAsync($"/api/APHistory/GetAPHistory?CaseId={objDTO.APMainId}&UserId={objDTO.UserId}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var apcases = JsonConvert.DeserializeObject<IEnumerable<HistoryResponseDTO>>(content);

                return apcases;
            }

            return new List<HistoryResponseDTO>();
        }
    }
}
