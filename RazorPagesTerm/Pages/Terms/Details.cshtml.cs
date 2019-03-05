using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesTerm.ApiHandlers;
using Hl7.Fhir.Model;

namespace RazorPagesTerm.Pages.Terms
{
    public class DetailsModel : PageModel
    {
        //public Term Term { get; set; }
        public Library Library { get; set; }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            //Term = await GetLibrary.GetTermAsync(id);
            Library = await FhirClientHandler.GetLibraryAsync(id);

            if (Library == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
