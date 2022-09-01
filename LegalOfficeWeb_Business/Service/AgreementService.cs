using LegalOfficeWeb_Business.Service.IService;
using LegalOfficeWeb_Models;
using LegalOfficeWeb_Models.AgreementDTO;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Business.Service
{
    public class AgreementService : IAgreementService
    {
        private readonly HttpClient _httpClient;
        private IConfiguration _configuration;
        public AgreementService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        public async Task<AgreementResponseDTO> CUDRLAgreement(CUDAgreementDTO objDTO)
        {
            var content = JsonConvert.SerializeObject(objDTO);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("api/Agreement/CUDRLAgreement", bodyContent);
            string responseResult = response.Content.ReadAsStringAsync().Result;
            if (response.IsSuccessStatusCode)
            {
                var result = JsonConvert.DeserializeObject<AgreementResponseDTO>(responseResult);
                return result;
            }

            return new AgreementResponseDTO();
        }

        public async Task<IEnumerable<AgreementResponseDTO>> GetAllRLAgreements(AgreementDataDTO objDTO)
        {
            var response = await _httpClient.GetAsync($"api/Agreement/GetAllRLCase?UserId={objDTO.UserId}&District={objDTO.District}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var apcases = JsonConvert.DeserializeObject<IEnumerable<AgreementResponseDTO>>(content);

                return apcases;
            }

            return new List<AgreementResponseDTO>();
           
        }

        public async Task<AgreementResponseDTO> GetRLAgreement(AgreementDataDTO objDTO)
        {
            var response = await _httpClient.GetAsync($"/api/Agreement/GetRLCaseInputs?CaseId={objDTO.CaseId}&UserId={objDTO.UserId}&AgreementId={objDTO.AgreementId}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var apcases = JsonConvert.DeserializeObject<AgreementResponseDTO>(content);

                return apcases;
            }
            return new AgreementResponseDTO();
        }
    }
}
