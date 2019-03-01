using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Hl7.Fhir.Model;

namespace RazorPagesTerm.ApiHandlers
{
    public class GetAllLibraries
    {
        public static async Task<IList<Library>> GetLibraryFromListAsync()
        {
            var bundle = await FhirClientHandler.GetBundleAsync();

            var listOfLibrary = GetAllLibrariesFromBundle(bundle);

            return listOfLibrary;

        }

        private static List<Library> GetAllLibrariesFromBundle(Bundle bundle)
        {
            var listOfLibraries = new List<Library>();

            foreach (var entry in bundle.Entry)
            {
                if (entry.Resource.ResourceType == ResourceType.Library)
                {
                    listOfLibraries.Add((Library)entry.Resource);
                }
            }

            return listOfLibraries;
        }
    }
}
