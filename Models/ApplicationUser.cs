using Microsoft.AspNetCore.Identity;


namespace SecureShopAPI.Models
{
    public class ApplicationUser: IdentityUser
    {

        public string fname { get; set; }

        public string lname { get; set; }
        public string company { get; set; }

        public string address { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string postalcode { get; set; }
        

    }
}
