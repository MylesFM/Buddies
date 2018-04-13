using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Controller;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsUserInterface
{
    class ViewControl
    {

        FriendsManager App;
        public ViewControl()
        {
            App = new FriendsManager();
        }
        public void ListAllFriends(object friendList)
        {
            // List<Friend> AllFriends = (List<Friend>)App.GetAllFriends();
            ListBox myFriendList = (ListBox)friendList;
            string outPut = "";
            myFriendList.Items.Add("Sam Agosta, Male, 18");
            myFriendList.Items.Add("Johnny Smith, Male, 19");
            myFriendList.Items.Add("Chad Brad, Male, 23");
            myFriendList.Items.Add("Chelsey Raine, Female, 19");

            //foreach(Friend F in AllFriends)
            {
                //outPut = F.GetFullName() + ", " + F.GetGender() + ", " + F.GetAge().ToString ;
                //myFriendList.ItemHeight.Add(outPut);
            }
            // throw new NotImplementedException();
        }

    }
}
