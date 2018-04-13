using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Core
{
    public class FriendDTO
    {

        public FriendDTO()
        {
            Id = null;
        }

        public string Id { get; private set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Gender { get; set; }
        public string BirthDate { get; set; }

    }

}
