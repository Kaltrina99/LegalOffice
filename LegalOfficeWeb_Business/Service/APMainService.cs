using LegalOfficeWeb_Business.Service.IService;
using LegalOfficeWeb_Models.CaseHistoryDTO;
using LegalOfficeWeb_Models.MainDTO;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Business.Service
{
    public class APMainService : IAPMainService
    {
        private readonly HttpClient _httpClient;
        private IConfiguration _configuration;
        public APMainService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }
        public async Task<MainResponseDTO> CUDMain(CUDMainDTO objDTO)
        {
            var content = JsonConvert.SerializeObject(objDTO);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("api/APMain/CUDMain", bodyContent);
            string responseResult = response.Content.ReadAsStringAsync().Result;
            if (response.IsSuccessStatusCode)
            {
                var result = JsonConvert.DeserializeObject<MainResponseDTO>(responseResult);
                return result;
            }
            return new MainResponseDTO();
        }

        public async Task<IEnumerable<MainResponseDTO>> GetMain(MainDataDTO objDTO)
        {
            var response = await _httpClient.GetAsync($"/api/APMain/GetMain?CaseId={objDTO.CaseId}&UserId={objDTO.UserId}&APMainId={objDTO.APMainId}");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var apcases = JsonConvert.DeserializeObject<IEnumerable<MainResponseDTO>>(content);

                return apcases;
            }

            return new List<MainResponseDTO>();
        }
    }
}
