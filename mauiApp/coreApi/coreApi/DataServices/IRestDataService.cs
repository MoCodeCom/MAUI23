using System;
using coreApi.Models;

namespace coreApi.DataServices
{
	public interface IRestDataService
	{
		Task<List<Employees>> GetAllEmployees();
		Task <Employees> GetEmployeeAsync(int id);
		Task AddEmployeeAsync(Employees employee);
		Task UpdateEmployeeAsync(Employees employee);
		Task DeleteEmployeeAsync(int id);
	}
}

