using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Core;
using System.Threading.Tasks;
using Data;

namespace Controller
{
    public class FriendsManager
    {
        private IRepository<FriendDTO> AppData;
        public FriendsManager()
        {
            AppData = new FriendRepo();
        }
        public void AddFriend(Friend Friend)
        {
            throw new NotImplementedException();
        }
        public void EditFriend(Friend Friend)
        {
            throw new NotImplementedException();
        }
        public void DeleteFriend(string Id)
        {
            throw new NotImplementedException();
        }
        public IEnumerable<string> GetGendersList()
        {
            throw new NotImplementedException();
        }
        public IEnumerable<Friend> GetAllFreinds()
        {
            throw new NotImplementedException();
        }

    
    }
}
