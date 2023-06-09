using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Agro_Express.CustumValidation;
using Agro_Express.Enum;

namespace Agro_Express.Dtos.Farmer
{
    public class CreateFarmerRequestModel
    {
        [DisplayName("User Name")]
        [Required]
        public string UserName{get; set;}
         [DisplayName("Profile Picture")]
         [Required]
        public byte[] ProfilePicture {get; set;}
         [DisplayName("First Name")]
         [Required]
        public string FirstName{get; set;}
         [DisplayName("Last Name")]
         [Required]
        public string LastName{get; set;}
         [DisplayName("Phone Number")]
         [Required]
        public string PhoneNumber{get; set;}
         [DisplayName("Full Address")]
         [Required]
        public string FullAddress{get; set;}
         [DisplayName("Local Government")]
         [Required]
        public LocalGovernment LocalGovernment {get; set;}
        [Required]
        public State State {get; set;}
        [Required]
        public Gender Gender{get; set;}
         [EmailAddress]
        [Required]
        [EmailValidation]
        public string Email {get;set;}
        [DisplayName("Confirm Email")]
        [Compare("Email")]
        [EmailValidation]
        public string ConfirmEmail {get;set;}
        [Required]
        [PasswordValidation]
        public string Password{get; set;}
        [DisplayName("Confirm Password")]
        [Compare("Password")]
        [PasswordValidation]
        public string ConfirmPassword {get;set;}
    }
}