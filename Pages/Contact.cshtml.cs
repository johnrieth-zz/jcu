using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace jcu.Pages
{
    public class ContactModel : PageModel
    {
        [Required]
        [EmailAddress]
        [Display(Name="Email")]
        public string Email {get; set;}

        [Required]
        [Phone]
        [Display(Name="Phone")]
        public string Phone {get; set;}
    }
}
