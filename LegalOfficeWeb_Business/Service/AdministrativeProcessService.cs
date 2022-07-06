using LegalOfficeWeb_Business.Repository;
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
    public class AdministrativeProcessService : IAdministrativeProcessService
    {
        private readonly HttpClient _httpClient;
        private IConfiguration _configuration;
        public AdministrativeProcessService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        public async Task<IEnumerable<AdministrativeProcessDTO>> GetAll()
        {
            var response = await _httpClient.GetAsync("/api/AdministrativeProcess/GetAll");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var apcases = JsonConvert.DeserializeObject<IEnumerable<AdministrativeProcessDTO>>(content);
                
                return apcases;
            }

            return new List<AdministrativeProcessDTO>();
        }
    }
}
