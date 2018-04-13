using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FormsUserInterface
{
    public partial class frmBuddiesHome : Form
    {
        ViewControl ViewControl;
        public frmBuddiesHome()
        {
            ViewControl = new ViewControl();
            InitializeComponent();
        }

        private void frmBuddiesHome_Load(object sender, EventArgs e)
        {
            ViewControl.ListAllFriends(lstFriendList);
        }
    }
}
