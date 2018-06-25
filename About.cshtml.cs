using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AzureTrainingLinks.Pages
{
    public class AboutModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "This is a collection of recommended training links for ITPros who are looking to onbaord their Microsoft Azure skill set.";
            Message = "This site is owned and maintained by the author";
        }
    }
}
