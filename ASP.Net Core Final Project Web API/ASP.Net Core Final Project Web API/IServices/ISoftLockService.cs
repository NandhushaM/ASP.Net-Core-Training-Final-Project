using ASP.Net_Core_Final_Project_Web_API.ViewModel;

namespace ASP.Net_Core_Final_Project_Web_API.IServices
{
    public interface ISoftLockService
    {
        Task<List<SoftLockModel>> GetSoftLocks();

        string AddSoftLock(SoftLockModel softLock);

        string UpdateSoftLockStatus(int id, SoftLockModel softLock);
    }
}
