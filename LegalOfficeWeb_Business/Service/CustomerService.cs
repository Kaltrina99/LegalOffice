using LegalOfficeWeb_Business.Repository;
using LegalOfficeWeb_Business.Service.IService;
using LegalOfficeWeb_Models;
using LegalOfficeWeb_Models.CaseDTO;
using LegalOfficeWeb_Models.CustomerDTO;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Business.Service
{
    public class CustomerService : ICustomerService
    {
        private readonly HttpClient _httpClient;
        private IConfiguration _configuration;
        public CustomerService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        public async Task<IEnumerable<NameHistoryDTO>> CustomerName(CustomerNameDTO objDTO)
        {
            var response = await _httpClient.GetAsync($"api/Customer/CustomerName?UserId={objDTO.UserId}&AgencyID={objDTO.AgencyId}&EldebitorId={objDTO.EldebitorId}&AMeterId={objDTO.AMeterId}&ProcessTypeId={objDTO.ProcessTypeId}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var apcases = JsonConvert.DeserializeObject<IEnumerable<NameHistoryDTO>>(content);

                return apcases;
            }

            return new List<NameHistoryDTO>();
        }

        public async Task<CustomerResponseDTO> SearchCustomer(SearchCustomerDTO objDTO)
        {
            try
            {
                var response = await _httpClient.GetAsync($"api/Customer/SearchCustomer?UserId={objDTO.UserId}&AgencyID={objDTO.AgencyId}&EldebitorId={objDTO.EldebitorId}&AMeterId={objDTO.AMeterId}");
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    var apcases = JsonConvert.DeserializeObject<CustomerResponseDTO>(content);

                    return apcases;
                }
                return new CustomerResponseDTO();
            }
            catch (Exception ex)
            {
                return new CustomerResponseDTO();
            }
           
        }
    }
}
