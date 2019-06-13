using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace Assessment3_Graded.Models
{
    public class Member
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "First Name is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Please enter Firstname between 3-50 characters")]
        public String FirstName { get; set; }

        [Required(ErrorMessage = "Surname is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Please enter Surname between 3-50 characters")]
        [Display(Name = "Your Surname")]
        public String Surname { get; set; }


        [Required(ErrorMessage = "Email is required")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Please enter Email between 3-50 characters")]
        [EmailAddress(ErrorMessage = "Please enter valid email")]
        public String Email { get; set; }

       
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Please enter Mobile between 3-50 characters")]
        public String Mobile { get; set; }

       
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Please enter City between 3-50 characters")]
        public String City { get; set; }

       
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Please enter Country between 3-50 characters")]
        public String Country { get; set; }

    }

    public class MemberDBContext : DbContext
    {
        public DbSet<Member> Members { get; set; }

    }


}