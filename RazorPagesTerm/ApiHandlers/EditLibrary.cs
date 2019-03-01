using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hl7.Fhir.Model;

namespace RazorPagesTerm.ApiHandlers
{
    public class EditLibrary
    {
        Library library   { get; set; }

        public static async System.Threading.Tasks.Task EditLibraryAsync(Library library, string id)
        {
            await FhirClientHandler.PutLibraryAsync(library, id);
        }
    }
}
