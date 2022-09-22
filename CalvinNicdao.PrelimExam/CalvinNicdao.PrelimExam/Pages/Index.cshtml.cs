using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CalvinNicdao.PrelimExam.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public Index? ViewModel { get; set; }
        public IActionResult(string? firstName)

        {
            this.ViewModel = new Index();
            this ViewModel.FirstName = firstName;
            return Page();

        }

        public IActionResult OnPost()
        {
            var firstName = this.ViewModel?.FirstName;
            return Page();
        }
        
        
        {
        public string? FirstName { get; set; }

       
        }
    }
}