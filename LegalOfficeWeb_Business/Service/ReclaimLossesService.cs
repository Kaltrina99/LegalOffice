using LegalOfficeWeb_Business.Service.IService;
using LegalOfficeWeb_Models;
using LegalOfficeWeb_Models.ReclaimLossesDTO;
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
        public async Task<ReclaimLossesCaseResponseDTO> GetRLCase(ReclaimLossesGetCaseDTO objDTO)
        {
            var response = await _httpClient.GetAsync($"/api/ReclaimLosses/GetRLCase?CaseId={objDTO.CaseId}&UserId={objDTO.UserId}&District={objDTO.District}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var apcases = JsonConvert.DeserializeObject<ReclaimLossesCaseResponseDTO>(content);

                return apcases;
            }

            return new ReclaimLossesCaseResponseDTO();
        }
        public async Task<IEnumerable<ReclaimLossesGetAllCasesResponseDTO>> GetAllRLCases(ReclaimLossesGetAllCasesDTO objDTO)
        {
            var response = await _httpClient.GetAsync($"api/ReclaimLosses/GetAllRLCase?UserId={objDTO.UserId}&District={objDTO.District}&PageIndex={objDTO.PageIndex}&PageSize={objDTO.PageSize}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var apcases = JsonConvert.DeserializeObject<IEnumerable<ReclaimLossesGetAllCasesResponseDTO>>(content);

                return apcases;
            }

            return new List<ReclaimLossesGetAllCasesResponseDTO>();
        }
        public async Task<ReclaimLossesCaseInputResponseDTO> GetRLCaseInputs(ReclaimLossesGetCaseInputDTO objDTO)
        {
            var response = await _httpClient.GetAsync($"/api/ReclaimLosses/GetRLCaseInputs?CaseId={objDTO.CaseId}&UserId={objDTO.UserId}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var apcases = JsonConvert.DeserializeObject<ReclaimLossesCaseInputResponseDTO>(content);

                return apcases;
            }

            return new ReclaimLossesCaseInputResponseDTO();
        }

        public async Task<ReclaimLossesCaseHistoryResponseDTO> CUDRLCaseHistory(ReclaimLossesCaseHistoryDTO objDTO)
        {
            var content = JsonConvert.SerializeObject(objDTO);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("api/ReclaimLosses/CUDRLCaseHistory", bodyContent);
            string responseResult = response.Content.ReadAsStringAsync().Result;
            if (response.IsSuccessStatusCode)
            {
                var result = JsonConvert.DeserializeObject<ReclaimLossesCaseHistoryResponseDTO>(responseResult);
                return result;
            }

            return new ReclaimLossesCaseHistoryResponseDTO();
        }
        public async Task<IEnumerable<ReclaimLossesCaseHistoryResponseDTO>> GetRLCaseHistory(ReclaimLossesGetCaseHistoryDTO objDTO)
        {
            var response = await _httpClient.GetAsync($"/api/ReclaimLosses/GetRLCaseHistory?CaseId={objDTO.CaseId}&UserId={objDTO.UserId}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var apcases = JsonConvert.DeserializeObject<IEnumerable<ReclaimLossesCaseHistoryResponseDTO>>(content);

                return apcases;
            }

            return new List<ReclaimLossesCaseHistoryResponseDTO>();
        }

        public async Task<ReclaimLossesCaseNotificationResponseDTO> CUDRLCaseNotification(ReclaimLossesCaseNotificationDTO objDTO)
        {
            var content = JsonConvert.SerializeObject(objDTO);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("api/ReclaimLosses/CUDRLCaseNotification", bodyContent);
            string responseResult = response.Content.ReadAsStringAsync().Result;
            if (response.IsSuccessStatusCode)
            {
                var result = JsonConvert.DeserializeObject<ReclaimLossesCaseNotificationResponseDTO>(responseResult);
                return result;
            }

            return new ReclaimLossesCaseNotificationResponseDTO();
        }
        public async Task<ReclaimLossesCaseNotificationResponseDTO> GetRLCaseNotification(ReclaimLossesGetCaseNotificationsDTO objDTO)
        {
            var response = await _httpClient.GetAsync($"/api/ReclaimLosses/GetRLCaseNotification?CaseId={objDTO.CaseId}&UserId={objDTO.UserId}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var apcases = JsonConvert.DeserializeObject<ReclaimLossesCaseNotificationResponseDTO>(content);

                return apcases;
            }

            return new ReclaimLossesCaseNotificationResponseDTO();
        }
        public async Task<ReclaimLossesCaseNotificationInvoicesResponseDTO> GetRLCaseNotificationInvioce(ReclaimLossesGetCaseNotificationsDTO objDTO)
        {
            var response = await _httpClient.GetAsync($"/api/ReclaimLosses/GetRLCaseNotificationInvioce?CaseId={objDTO.CaseId}&UserId={objDTO.UserId}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var apcases = JsonConvert.DeserializeObject<ReclaimLossesCaseNotificationInvoicesResponseDTO>(content);

                return apcases;
            }

            return new ReclaimLossesCaseNotificationInvoicesResponseDTO();
        }
    }
}
