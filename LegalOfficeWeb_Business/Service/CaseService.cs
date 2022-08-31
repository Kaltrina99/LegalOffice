using LegalOfficeWeb_Business.Service.IService;
using LegalOfficeWeb_Models;
using LegalOfficeWeb_Models.CaseDTO;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Business.Service
{
    public class CaseService : ICaseService
    {
        private readonly HttpClient _httpClient;
        private IConfiguration _configuration;
        public CaseService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }
        public async Task<CasesResponseDTO> CUDRLCase(CUDCaseDTO objDTO)
        {
            var content = JsonConvert.SerializeObject(objDTO);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("api/Cases/CUDRLCase", bodyContent);
            string responseResult = response.Content.ReadAsStringAsync().Result;
            if (response.IsSuccessStatusCode)
            {
                var result = JsonConvert.DeserializeObject<CasesResponseDTO>(responseResult);
                return result;
            }

            return new CasesResponseDTO();
        }

        public async Task<IEnumerable<CasesResponseDTO>> GetAllRLCases(CaseDataDTO objDTO)
        {
            var response = await _httpClient.GetAsync($"api/Cases/GetAllRLCase?UserId={objDTO.UserId}&District={objDTO.District}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var apcases = JsonConvert.DeserializeObject<IEnumerable<CasesResponseDTO>>(content);

                return apcases;
            }

            return new List<CasesResponseDTO>();
        }

        public async Task<CasesResponseDTO> GetRLCase(CaseDataDTO objDTO)
        {
            var response = await _httpClient.GetAsync($"/api/Cases/GetRLCase?CaseId={objDTO.CaseId}&UserId={objDTO.UserId}&District={objDTO.District}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var apcases = JsonConvert.DeserializeObject<CasesResponseDTO>(content);

                return apcases;
            }

            return new CasesResponseDTO();
        }

        public async Task<CaseInputResponseDTO> GetRLCaseInputs(CaseInputDataDTO objDTO)
        {
            var response = await _httpClient.GetAsync($"/api/Cases/GetRLCaseInputs?CaseId={objDTO.CaseId}&UserId={objDTO.UserId}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var apcases = JsonConvert.DeserializeObject<CaseInputResponseDTO>(content);

                return apcases;
            }

            return new CaseInputResponseDTO();
        }
    }
}
