using System.Diagnostics.Contracts;

namespace MVCCoreWebApp.Models
{
    public class Customer
    {

       public string id { get; set; }
        public string name { get; set; }
        public string number { get; set; }
        public string email { get; set; }
        public string password { get; set; }
    }
}
