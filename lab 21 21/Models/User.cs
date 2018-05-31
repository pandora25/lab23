//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System.ComponentModel.DataAnnotations;
namespace lab_21_21.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        [Required]
        public string FirstName { set; get; }
        [Required]
        public string LastName { set; get; }
        [Required]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Invalid Email Format")]
        public string Email { set; get; }
        [Required]
        public string PhoneNumber { set; get; }
        [Required]
        public string Password { set; get; }
    }
}
