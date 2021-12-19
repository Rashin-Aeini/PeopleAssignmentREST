using System.ComponentModel.DataAnnotations;

namespace PeopleAssignmentREST.Models.ViewModels
{
    public class CreateCountryViewModel
    {
        [Required]
        public string Name { get; set; }
    }
}
