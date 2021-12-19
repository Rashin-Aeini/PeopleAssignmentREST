using System.Collections.Generic;
using PeopleAssignmentREST.Models.Domains;

namespace PeopleAssignmentREST.Models.ViewModels
{
    public class LanguagesViewModel
    {
        public LanguagesViewModel()
        {
            Result = new List<Language>();
        }

        public string Search { get; set; }
        public List<Language> Result { get; }
    }
}
