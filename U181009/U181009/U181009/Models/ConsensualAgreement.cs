using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace U181009.Models
{
    public class ConsensualAgreement
    {
        [Required(ErrorMessage ="Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please enter your number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please select your consent")]
        public bool Approved { get; set; }
    }
}