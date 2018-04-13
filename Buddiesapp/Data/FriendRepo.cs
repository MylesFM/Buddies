using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core;
using System.Threading.Tasks;

namespace Data
{
    public class FriendRepo : IRepository<FriendDTO>
    {
        public FriendRepo()
        {
            DataConnect = new DataConnectionTextFile();
        }
        public void Create(FriendDTO friend)
        {

            throw new NotImplementedException();
        }
        public FriendDTO Read(String ID)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<FriendDTO> ReadAll()
        {
            throw new NotImplementedException();
        }
        public void Update(FriendDTO Friend)
        {
            throw new NotImplementedException();
        }
        public void Delete(String Id)
        {
            throw new NotImplementedException();
        }
        private DataConnectionTextFile DataConnect;
    

    
    }
}
