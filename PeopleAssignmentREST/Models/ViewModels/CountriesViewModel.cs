using System.Collections.Generic;
using PeopleAssignmentREST.Models.Domains;

namespace PeopleAssignmentREST.Models.ViewModels
{
    public class CountriesViewModel
    {
        public CountriesViewModel()
        {
            Result = new List<Country>();
        }

        public string Search { get; set; }
        public List<Country> Result { get; }
    }
}
