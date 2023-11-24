using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using coreApi.DataServices;
using coreApi.Models;
using Newtonsoft.Json;
using System.Text.Json;

namespace coreApi;

public partial class MainPage : ContentPage
{
    private readonly IRestDataService _dataService;
    private readonly JsonSerializerOptions _josnSerializerOptions;

    public MainPage(IRestDataService dataService)
    {
        InitializeComponent();
        _dataService = dataService;
        _josnSerializerOptions = new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };
    }






    protected async override void OnAppearing()
    {
        List<Employees> employeesList = new List<Employees>();

        var httpClient = new HttpClient();
        //var baseurl = DeviceInfo.Platform == DevicePlatform.Android ? "http://10.0.2.2:7001":"http://localhost:7001";
        var baseurl = "http://localhost:7001";
        var response = await httpClient.GetAsync($"{baseurl}/api/employee");

        string data = await response.Content.ReadAsStringAsync();


        /***************************/
        
       
        //object[] req = data;
        var empList = JsonConvert.DeserializeObject<Dictionary<string, object>>(data)["result"];
        string jsonEmp = JsonConvert.SerializeObject(empList);
        List<Employees> employesList = JsonConvert.DeserializeObject<List<Employees>>(jsonEmp);

        
		base.OnAppearing();
        var v = await _dataService.GetAllEmployees();
        //collectionView.ItemsSource = await _dataService.GetAllEmployees();
        collectionView.ItemsSource = employesList;
	}







	async void OnEmployeesListClicked(object sender, EventArgs e)
	{
        Debug.WriteLine("----> No internet access ...");
    }

	async void OnSelectionChanged(object sender, SelectionChangedEventArgs e)
	{
        Debug.WriteLine("----> No internet access ...");
    }


}


