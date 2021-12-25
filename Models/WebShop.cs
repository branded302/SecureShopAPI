
using System.ComponentModel.DataAnnotations;


namespace SecureShopAPI.Models
{
    public class WebShop
    {
        [Key]
        public int id { get; set; }

        [Required(ErrorMessage = "Please Enter your Name")]
        [Display(Name = "Enter your Name")]
        [DataType(DataType.Text)]
        public string name { get; set; }

        [Display(Name = "Enter your Address")]
        [DataType(DataType.Text)]
        public string address { get; set; }


        [Required(ErrorMessage = "Please Enter Postal Code")]
        [Display(Name = "Postal Code")]
        [DataType(DataType.PostalCode)]
        public int postalCode { get; set; }


        [Required(ErrorMessage = "Please Enter your Mobile Number")]
        [Display(Name = "Enter Mobile Number")]
        [DataType(DataType.PhoneNumber)]
        public int number { get; set; }



        [Required(ErrorMessage = "Please Enter City Name")]
        [Display(Name = "Enter City Name")]
        [DataType(DataType.Text)]
        public string city { get; set; }




        [Required(ErrorMessage = "Please Enter Email")]
        [EmailAddress(ErrorMessage = "Enter a Valid Email")]
        [Display(Name = "Enter Email")]
        [DataType(DataType.EmailAddress)]
        public string email { get; set; }


        [Required(ErrorMessage = "Please Enter your Website url")]
        [DataType(DataType.Url)]
        public string website { get; set; }

        [Display(Name = "Description about your business")]
        [DataType(DataType.Text)]
        public string description { get; set; }

    }
}
