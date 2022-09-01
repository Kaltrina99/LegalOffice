using LegalOfficeWeb_Business.Service.IService;
using LegalOfficeWeb_Models;
using LegalOfficeWeb_Models.CaseHistoryDTO;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalOfficeWeb_Business.Service
{
    public class UsersServices : IUsersServices
    {
        private readonly HttpClient _httpClient;
        private IConfiguration _configuration;
        public UsersServices(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }
        public async void AddUsers(UserDTO userDTO)
        {
            var content = JsonConvert.SerializeObject(userDTO);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("api/User/AddUsers", bodyContent);
            string responseResult = response.Content.ReadAsStringAsync().Result;
            if (response.IsSuccessStatusCode)
            {
                var result = JsonConvert.DeserializeObject<CaseHistoryResponseDTO>(responseResult);
               // return result;
            }
        }

        public async void DeleteUsers(UserDTO userDTO)
        {
            var content = JsonConvert.SerializeObject(userDTO);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("api/User/DeleteUSer", bodyContent);
            string responseResult = response.Content.ReadAsStringAsync().Result;
            if (response.IsSuccessStatusCode)
            {
                var result = JsonConvert.DeserializeObject<CaseHistoryResponseDTO>(responseResult);
                // return result;
            }
        }

        public async Task<IEnumerable<UserDTO>> GetAllUsers()
        {
            var response = await _httpClient.GetAsync($"/api/User/GetAllUsers");
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var apcases = JsonConvert.DeserializeObject<IEnumerable<UserDTO>>(content);

                return apcases;
            }

            return new List<UserDTO>();
        }

        public async Task<UserDTO> GetUsersDatail(int? id)
        {
            var content = JsonConvert.SerializeObject(id);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync($"api/User/Id={id}", bodyContent);
            string responseResult = response.Content.ReadAsStringAsync().Result;
            if (response.IsSuccessStatusCode)
            {
                var result = JsonConvert.DeserializeObject<UserDTO>(responseResult);
                return result;
            }
            return new UserDTO();
        }

        public async void UpdateUsers(UserDTO userDTO)
        {
            var content = JsonConvert.SerializeObject(userDTO);
            var bodyContent = new StringContent(content, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("api/User/UpdateUsers", bodyContent);
            string responseResult = response.Content.ReadAsStringAsync().Result;
            if (response.IsSuccessStatusCode)
            {
                var result = JsonConvert.DeserializeObject<CaseHistoryResponseDTO>(responseResult);
                // return result;
            }
        }
    }
}
