using System.Collections.Generic;
using PeopleAssignmentREST.Models.Domains;

namespace PeopleAssignmentREST.Models.ViewModels
{
    public class PeopleViewModel
    {
        public PeopleViewModel()
        {
            Result = new List<Person>();
        }

        public string Search { get; set; }
        public List<Person> Result { get; }
    }
}
