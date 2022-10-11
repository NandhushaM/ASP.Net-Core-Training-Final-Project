namespace ASP.Net_Core_Final_Project_Web_API.ViewModel
{
    public class EmployeeModel
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string LockStatus { get; set; }

        public string Manager { get; set; }

        public string Wfm_Manager { get; set; }
        public string Email { get; set; }
        public int Experience { get; set; }

        public List<string> Skills { get; set; }
    }
}
