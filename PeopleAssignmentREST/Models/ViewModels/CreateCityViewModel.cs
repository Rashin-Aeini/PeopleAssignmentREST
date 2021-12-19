using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PeopleAssignmentREST.Models.Domains;

namespace PeopleAssignmentREST.Models.ViewModels
{
    public class CreateCityViewModel
    {
        [Required]
        public string Name { get; set; }

        [Display(Name = "Country")]
        [Required]
        public int CountryId { get; set; }

        public List<Country> Countries { get; set; }
    }
}
