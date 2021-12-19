using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using PeopleAssignmentREST.Models.Domains;

namespace PeopleAssignmentREST.Models.ViewModels
{
    public class CreatePersonViewModel
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [Display(Name = "City")]
        public int CityId { get; set; }
        [Required]
        public string Phone { get; set; }

        public List<City> Cities { get; set; }
    }
}
