using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using WindowsFacebookLogic;

namespace WindowsFacebook
{
    public partial class FriendsListForm : Form
    {
        private const string k_NameStr = "Name";
        private const string k_NotRetriveMsg = "No friends to retrieve";
        private const string k_IssueToRetriveMsg = "Had issues to retrive friends from facebook servers: ";
        private AppManager m_AppManager = AppManager.AppManagerInstance();

        public FriendsListForm()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fetchFriends();
        }

        private void fetchFriends()
        {
            listBoxMyFriends.Items.Clear();
            listBoxMyFriends.DisplayMember = k_NameStr;
            try
            {
                foreach (User friend in m_AppManager.LoginUser().Friends)
                {
                    listBoxMyFriends.Items.Add(friend.Name);
                }

                if (m_AppManager.LoginUser().Friends.Count == 0)
                {
                    listBoxMyFriends.Items.Add(k_NotRetriveMsg);
                }
            }
            catch
            {
                listBoxMyFriends.Items.Add(k_IssueToRetriveMsg);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
