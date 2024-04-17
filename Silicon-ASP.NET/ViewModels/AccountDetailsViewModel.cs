using Infrastructure.Entities;
using System.ComponentModel.DataAnnotations;

namespace Silicon_ASP.NET.ViewModels
{
    public class AccountDetailsViewModel
    {
        public UserEntity User { get; set; } = null!;
        public ProfileInfoViewModel ProfileInfo { get; set; } = null!;
        public BasicInfoViewModel BasicInfo { get; set; } = null!;
        public AddressInfoViewModel AddressInfo { get; set; } = null!;
    }

    public class BasicInfoViewModel
    {
        [DataType(DataType.Text)]
        [Display(Name = "First name")]
        [Required(ErrorMessage = "A valid first name is required")]
        public string FirstName { get; set; } = null!;


        [DataType(DataType.Text)]
        [Display(Name = "Last name")]
        [Required(ErrorMessage = "A valid last name is required")]
        public string LastName { get; set; } = null!;


        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        [Required(ErrorMessage = "A valid email address is required")]
        public string Email { get; set; } = null!;


        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone", Prompt = "Enter your phone number") ]
        public string? PhoneNumber { get; set; }


        [DataType(DataType.MultilineText)]
        [Display(Name = "Bio (optional)", Prompt = "Add a short bio...")]
        public string? Biography { get; set; }




    }

    public class AddressInfoViewModel
    {
        [Display(Name = "Address Line 1")]
        [Required(ErrorMessage = "Address line 1 is required")]
        public string? AddressLine_1 { get; set; }

        [Display(Name = "Address Line 2")]
        public string? AddressLine_2 { get; set; }

        [Display(Name = "Postal Code")]
        [Required(ErrorMessage = "Postal code is required")]
        public string? PostalCode { get; set; }

        [Display(Name = "City")]
        [Required(ErrorMessage = "City is required")]
        public string? City { get; set; }
    }

    public class ProfileInfoViewModel
    {

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Email { get; set; } = null!;

        public string? ProfileImage { get; set; } = "avatar.png";
    }
}
