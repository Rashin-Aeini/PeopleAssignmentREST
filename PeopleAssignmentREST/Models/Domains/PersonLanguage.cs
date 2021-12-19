using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PeopleAssignmentREST.Models.Domains
{
    public class PersonLanguage
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey(nameof(Language))]
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        [ForeignKey(nameof(Person))]
        public int PersonId { get; set; }
        public Person Person { get; set; }
    }
}
