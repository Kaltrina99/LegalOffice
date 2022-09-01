using LegalOfficeWeb_Business.Service.IService;
using LegalOfficeWeb_Models.AgreementExtrasDTO;
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
    public class AgreementExtrasService : IAgreementExtrasService
    {
        private readonly HttpClient _httpClient;
        private IConfiguration _configuration;
        public AgreementExtrasService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }
        public async Task<IEnumerable<AgreemeentInvoicePaymentsResponseDTO>> AgreemeentInvoicePayments(AgreementFilterDataDTO objDTO)
        {
            var response = await _httpClient.GetAsync($"api/AgreementExtras/AgreemeentInvoicePayments?UserId={objDTO.UserId}&AgreementId={objDTO.AgreementId}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var apcases = JsonConvert.DeserializeObject<IEnumerable<AgreemeentInvoicePaymentsResponseDTO>>(content);

                return apcases;
            }

            return new List<AgreemeentInvoicePaymentsResponseDTO>();
        }

        public async Task<IEnumerable<AgreementInstallmentResponseDTO>> AgreementInstallmentResponseDTOs(AgreementFilterDataDTO objDTO)
        {
            var response = await _httpClient.GetAsync($"api/AgreementExtras/AgreementInstallmentResponseDTOs?UserId={objDTO.UserId}&CaseId={objDTO.CaseId}&AgreementId={objDTO.AgreementId}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var apcases = JsonConvert.DeserializeObject<IEnumerable<AgreementInstallmentResponseDTO>>(content);

                return apcases;
            }

            return new List<AgreementInstallmentResponseDTO>();
        }

        public async Task<IEnumerable<AgreementInvoiceResponseDTO>> AgreementInvoices(AgreementFilterDataDTO objDTO)
        {
            var response = await _httpClient.GetAsync($"api/AgreementExtras/AgreementInvoices?UserId={objDTO.UserId}&CaseId={objDTO.CaseId}&AgreementId={objDTO.AgreementId}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var apcases = JsonConvert.DeserializeObject<IEnumerable<AgreementInvoiceResponseDTO>>(content);

                return apcases;
            }

            return new List<AgreementInvoiceResponseDTO>();
        }

        public async Task<IEnumerable<AgreementNotificationResponseDTO>> AgreementNotification(AgreementFilterDataDTO objDTO)
        {
            var response = await _httpClient.GetAsync($"api/AgreementExtras/AgreementNotification?UserId={objDTO.UserId}&AgreementId={objDTO.AgreementId}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var apcases = JsonConvert.DeserializeObject<IEnumerable<AgreementNotificationResponseDTO>>(content);

                return apcases;
            }

            return new List<AgreementNotificationResponseDTO>();
        }
    }
}
