using ASP.Net_Core_Final_Project_Web_API.ViewModel;

namespace ASP.Net_Core_Final_Project_Web_API.IServices
{
    public interface IUserService
    {
        List<LoginModel> Login(LoginModel login);
    }
}
