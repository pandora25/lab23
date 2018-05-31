using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace lab_21_21.Models
{
    public class UserInfo
    {

        [Required]
        public string FirstName { set; get; }
        [Required]
        public string LastName { set; get; }
        [Required]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$",ErrorMessage ="Invalid Email Format")]
        public string Email { set; get; }
        [Required]
        public string PhoneNumber { set; get; }
        [Required]
        public string Password { set; get; }

        public UserInfo()
        {

        }

        public UserInfo(string firstName, string lastname, string email, string phonenumber, string password)
        {
            FirstName = firstName;
            LastName = lastname;
            Email = email;
            PhoneNumber = phonenumber;
            Password = password;
        }








    }
}