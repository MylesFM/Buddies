using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Controller
{
    public class Friend
    {

        public Friend()
        {
            Id = 0; ToString();
            BirthDate = new DateTime();
        }

        public int Id { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Gender { get; set; }
        public DateTime BirthDate { get; set; }

        internal void SetId() { }
        public AppDomainSetup GetAge()
        {
            throw new NotImplementedException();
        }
        public string GetGender()
        {
            throw new NotImplementedException();
        }

    }
}
