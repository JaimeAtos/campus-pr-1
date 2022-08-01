using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerformanceReviewI.src
{
    public class Persona
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Birthday { get; set; }
        public Persona(string name, string email, DateTime birthday)
        {
            Name=name;
            Email=email;
            Birthday=birthday;
        }


    }

}
