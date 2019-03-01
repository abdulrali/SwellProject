using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hl7.Fhir.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RazorPagesTerm.ApiHandlers;

namespace RazorPagesTerm.Pages.Terms
{
    public class EditModel : PageModel
    {

        [BindProperty]
        public Library Library { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Library = await FhirClientHandler.GetLibraryAsync(id);

            if (Library == null)
            {
                return NotFound();
            }

            return Page();
        }

        public async Task<IActionResult> OnPutAsync(string id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            if (!string.IsNullOrEmpty(id))
            {
                await EditLibrary.EditLibraryAsync(Library, id);
            }
            return RedirectToPage("./Index");
        }
    }
}
