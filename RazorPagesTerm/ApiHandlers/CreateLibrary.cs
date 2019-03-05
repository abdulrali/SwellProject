using Hl7.Fhir.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorPagesTerm.ApiHandlers
{
    public static class CreateLibrary
    {
        public static async System.Threading.Tasks.Task CreateLibraryAndPostAsync(Library library)
        {
            await FhirClientHandler.PostLibraryAsync(library);
        }
    }
}
