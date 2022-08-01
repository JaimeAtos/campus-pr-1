using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceReviewI.src
{
    public class Methods
    {
        public List<string> OnlyEmails(List<Persona> personaList)
        {
            List<string> Emails = new List<string>();
            foreach (Persona person in personaList)
                Emails.Add(person.Email);
            return Emails;
        }

        public string FilteredByBirthday(List<Persona> personaList, DateTime dateToCompare)
        {
            string PersonName = personaList.Where(date => date.Birthday > dateToCompare).First().Name;
            return PersonName;
        }
    }
}
