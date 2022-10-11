using ASP.Net_Core_Final_Project_Web_API.ViewModel;
using System.Threading.Tasks;

namespace ASP.Net_Core_Final_Project_Web_API.IServices
{
    public interface IEmployeeService
    {
        Task<List<EmployeeModel>> GetAllEmployees();
        Task<List<EmployeeModel>> UpdateEmployee(EmployeeModel employee);
    }
}
