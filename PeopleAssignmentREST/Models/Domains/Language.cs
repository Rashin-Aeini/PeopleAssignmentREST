using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PeopleAssignmentREST.Models.Domains
{
    public class Language
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public List<PersonLanguage> People { get; set; }
    }
}
