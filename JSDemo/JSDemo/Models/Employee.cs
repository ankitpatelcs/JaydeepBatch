using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JSDemo.Models
{
    public class Employee
    {
        [Required(ErrorMessage ="First Name is Required.")]
        [RegularExpression("[a-zA-Z]+",ErrorMessage ="Only alphabets.!")]
        [Display(Name ="First Name")]
        public string fname { get; set; }

        [Required]
        [RegularExpression(@"[0-9]+",ErrorMessage ="Invalid salary.")]
        public int salary { get; set; }

        [Required]
        [EmailAddress(ErrorMessage ="Invalid Email.!")]
        public string email { get; set; }

        [Required]
        [RegularExpression(@"[6789]\d{9}",ErrorMessage ="Invalid Mobile No.")]
        public long mobile { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public string dob { get; set; }

        [Required]
        public string pfile { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [RegularExpression(@"(?=.*\d)(?=.*[A-Z])(?=.*[a-z])(?=.*[a-zA-Z!#$%&? ])[a-zA-Z0-9!#$%&?]{8,20}",ErrorMessage ="Password is weak.")]
        public string password { get; set; }

        [Compare("password",ErrorMessage ="Passwords mismatch.!")]
        [DataType(DataType.Password)]
        public string cnfpassword { get; set; }

    }
}