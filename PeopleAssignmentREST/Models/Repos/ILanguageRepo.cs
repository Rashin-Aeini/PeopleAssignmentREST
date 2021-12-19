using System.Collections.Generic;
using PeopleAssignmentREST.Models.Domains;

namespace PeopleAssignmentREST.Models.Repos
{
    public interface ILanguageRepo
    {
        List<Language> Read();
        Language Read(int id);
        Language Create(Language entry);
        bool Update(Language entry);
        bool Delete(Language entry);
    }
}
