using System;
using System.Diagnostics;
using System.Text.Json;
using coreApi.Models;
//using Newtonsoft.Json;

namespace coreApi.DataServices
{
	public class RestDataService:IRestDataService
	{
        private readonly HttpClient _httpClient;
        private readonly string _baseAddress;
        private readonly string _url;
        private readonly JsonSerializerOptions _josnSerializerOptions;

        public RestDataService()
		{
            _httpClient = new HttpClient();
            _baseAddress = DeviceInfo.Platform == DevicePlatform.Android?
                "http://10.0.2.2:7001": "http://localhost:7001" ;
            _url = $"{_baseAddress}/api/employee";
            _josnSerializerOptions = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };

		}


        public async Task<List<Employees>> GetAllEmployees()
        {
            List<Employees> empList = new List<Employees>();
            if (Connectivity.Current.NetworkAccess != NetworkAccess.Internet)
            {
                Debug.WriteLine("----> No internet access ...");
                return empList;
            }
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync($"http://10.0.2.2:7001/api/employee");
                string content = await response.Content.ReadAsStringAsync();
                var empLists = JsonSerializer.Deserialize<Dictionary<string, object>>(content, _josnSerializerOptions)["result"];

                if (response.IsSuccessStatusCode)
                {

                    //empList = JsonSerializer.Deserialize<List<Employees>>(content, _josnSerializerOptions);
                    string serialList = JsonSerializer.Serialize(empLists);
                    //empList = JsonSerializer.Deserialize<List<Employees>>(serialList);
                    empList = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Employees>>(serialList);
                }
                else
                {
                    Debug.WriteLine("-----> Non http response");
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine("exception: " + ex.Message);
            }

            return empList;
        }

        public Task<Employees> GetEmployeeAsync(int id)
        {
            throw new NotImplementedException();
        }
        public Task AddEmployeeAsync(Employees employee)
        {
            throw new NotImplementedException();
        }

        public Task DeleteEmployeeAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateEmployeeAsync(Employees employee)
        {
            throw new NotImplementedException();
        }
    }
}

