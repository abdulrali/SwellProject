using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesTerm.ApiHandlers;
using Hl7.Fhir.Model;

namespace RazorPagesTerm.Pages.Terms
{
    public class CreateModel : PageModel
    {
     
        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Library Library { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var library = Library;
            await CreateLibrary.CreateLibraryAndPostAsync(library);


            return RedirectToPage("./Index");
        }
    }
}