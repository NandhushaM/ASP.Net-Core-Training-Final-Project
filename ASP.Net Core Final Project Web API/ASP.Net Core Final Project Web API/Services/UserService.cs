using ASP.Net_Core_Final_Project_Web_API.IServices;
using ASP.Net_Core_Final_Project_Web_API.Models;
using ASP.Net_Core_Final_Project_Web_API.ViewModel;

namespace ASP.Net_Core_Final_Project_Web_API.Services
{
    public class UserService : IUserService
    {
        private readonly ProjectDbContext _dbContext;
   

        public UserService(ProjectDbContext dbContext)
        {
            _dbContext = dbContext;

           
        }
        public  List<LoginModel> Login(LoginModel login)
        {
            List<LoginModel> users =  _dbContext.Users.Where(x => x.UserName == login.UserName && x.Password == login.Password).Select(x => new LoginModel
            {
                UserName = login.UserName,
                Password = login.Password,
            }).ToList();
            return users;
        }
    }
}
