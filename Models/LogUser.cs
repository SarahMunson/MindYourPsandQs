using System;
using System.ComponentModel.DataAnnotations;

namespace MindYourPsandQs.Models
{
    public class LogUser
    {
        [Required(ErrorMessage = "Please provide an email")]
        [EmailAddress]
        public string LEmail {get;set;}
        [Required(ErrorMessage = "Please provide a Password")]
        [DataType(DataType.Password)]
        public string LPassword {get;set;}
    }
}