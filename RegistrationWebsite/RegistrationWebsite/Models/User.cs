using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RegistrationWebsite.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        [DisplayName("User Name")]
        public string UserName { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(20)")]
        [DisplayName("Password")]
        public string Password { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        [DisplayName("Display Name")]
        public string DisplayName { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(255)")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DisplayName("Mobile No.")]
        public string MobileNo { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public string City { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public string State { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(20)")]
        public string Country { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(255)")]
        [DisplayName("Address")]
        public string Address { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(255)")]
        [DisplayName("Shipping Address")]
        public string ShippingAddress { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(50)")]
        [DisplayName("Pin Code")]
        public string PinCode { get; set; }
    }
}
