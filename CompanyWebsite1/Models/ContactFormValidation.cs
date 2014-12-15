using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace CompanyWebsite1.Models
{
    [MetadataType(typeof(CompanyContactPageValidation))]
    public partial class CompanyContactPage
    {

    }
    public class CompanyContactPageValidation
    {
        [Required, Display(Name = "First Name")]
        public string FirstName { get; set; }
        [Required, Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required, Display(Name = "Email"), EmailAddress]
        public string Email { get; set; }
        [Required, Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; }
        [Required, Display(Name = "Company Name")]
        public string CompanyName { get; set; }
        [Required, Display(Name = "Project Description")]
        public string ProjectDescription { get; set; }
        [Required, Display(Name = "Comment")]
        public string Comment { get; set; }
    }

}