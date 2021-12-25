
using System.ComponentModel.DataAnnotations;


namespace SecureShop.Models
{
    public class RegisterUser
    {

        [Required(ErrorMessage = "Please Enter your First Name")]
        [Display(Name = "First Name")]
        [DataType(DataType.Text)]
        public string fname { get; set; }


        [Display(Name = "Last Name")]
        [DataType(DataType.Text)]
        public string lname { get; set; }


        [Display(Name = "Company Name")]
        [DataType(DataType.Text)]
        public string company { get; set; }

        [Display(Name = "Your Address")]
        [Required(ErrorMessage = "Please Enter your Address")]
        [DataType(DataType.Text)]
        public string address { get; set; }

        [Display(Name = "City")]
        [Required(ErrorMessage = "Please Enter City Name")]
        [DataType(DataType.Text)]
        public string city { get; set; }

        [Display(Name = "Country")]
        [Required(ErrorMessage = "Please Enter your Country")]
        [DataType(DataType.Text)]
        public string country { get; set; }

        [Display(Name = "Postal Code")]
        [Required(ErrorMessage = "Please Enter your Postal Code")]
        [DataType(DataType.PostalCode)]
        public string postalcode { get; set; }



        [Required(ErrorMessage = "Please Enter Phone Number")]
        [Display(Name = "Phone Number")]
        //[Phone(ErrorMessage = "Please enter valid mobile number")]
        //[DataType(DataType.PhoneNumber)]
        public string phone { get; set; }



        [Required(ErrorMessage = "Please Enter Email")]
        [Display (Name = "Enter Email")]
        [EmailAddress(ErrorMessage = "Enter a Valid Email")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }




        [Required(ErrorMessage = "Please Enter Password")]
        [Display(Name = "Enter Password")]
        [Compare("confirmpassword" , ErrorMessage = "Password Does not Match")]
        [DataType(DataType.Password)]
        public string password { get; set; }



        [Required(ErrorMessage = "Please Enter Confirm Password")]
        [Display(Name = "Repeat Password")]
        [DataType(DataType.Password)]
        public string confirmpassword { get; set; }
    }
}
