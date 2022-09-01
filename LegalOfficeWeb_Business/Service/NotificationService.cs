using LegalOfficeWeb_Business.Service.IService;
using LegalOfficeWeb_Models.CaseNotificationDTO;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Business.Service
{
    public class NotificationService : INotificationService
    {
        private readonly HttpClient _httpClient;
        private IConfiguration _configuration;
        public NotificationService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }
        public async Task<NotificationResponseDTO> CUDRLCaseNotification(CUDNotificationDTO objDTO)
        {
            var content = JsonConvert.SerializeObject(objDTO);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("api/Notification/CUDRLCaseNotification", bodyContent);
            string responseResult = response.Content.ReadAsStringAsync().Result;
            if (response.IsSuccessStatusCode)
            {
                var result = JsonConvert.DeserializeObject<NotificationResponseDTO>(responseResult);
                return result;
            }

            return new NotificationResponseDTO();
        }

        public async Task<NotificationResponseDTO> GetRLCaseNotification(NotificationDataDTO objDTO)
        {
            var response = await _httpClient.GetAsync($"/api/Notification/GetRLCaseNotification?CaseId={objDTO.CaseId}&UserId={objDTO.UserId}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var apcases = JsonConvert.DeserializeObject<NotificationResponseDTO>(content);

                return apcases;
            }

            return new NotificationResponseDTO();
        }

        public async Task<NotificationInvoiceDTO> GetRLCaseNotificationInvioce(NotificationDataDTO objDTO)
        {
            var response = await _httpClient.GetAsync($"/api/Notification/GetRLCaseNotificationInvioce?CaseId={objDTO.CaseId}&UserId={objDTO.UserId}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var apcases = JsonConvert.DeserializeObject<NotificationInvoiceDTO>(content);

                return apcases;
            }

            return new NotificationInvoiceDTO();
        }
    }
}
