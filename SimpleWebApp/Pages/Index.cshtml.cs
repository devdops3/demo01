using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace SimpleWebApp.Pages
{
    public class IndexModel : PageModel
    {
        public string Message { get; private set; } = "PageModel in C#";

        // This method runs when the page is accessed with a GET request
        public void OnGet()
        {
            Message += $" Server time is {DateTime.Now}";
        }
    }
}
