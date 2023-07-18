using Microsoft.AspNetCore.Authorization;
using System;
using System.ComponentModel.DataAnnotations;
namespace ContactsAPI.Models
{
    public class AddContactRequest
    {
        [StringLength(10, ErrorMessage ="Name lenght should be 10 characters")]
        public string FullName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"^\d{10}$", ErrorMessage = "Invalid phone number. Please use 10 digits format ##########.")]
        public long Phone { get; set; }

        [Required(AllowEmptyStrings=true)]
        public string Address { get; set; }
    }
}