using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using WindowsFacebookLogic;

namespace WindowsFacebook
{
    public partial class FriendStatusForm : Form
    {
        private AppManager m_AppManager = AppManager.AppManagerInstance();

        public FriendStatusForm()
        {
            InitializeComponent();
        }

        private void FriendStatusForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            initFriendsComboBox();
        }

        private void initFriendsComboBox()
        {
            foreach (User currentUser in m_AppManager.LoginUser().Friends)
            {
                this.comboBoxFriends.Items.Add(currentUser.Name);
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            labelStatus.Text = m_AppManager.GetFriendStatus(m_AppManager.LoginUser(), comboBoxFriends.Text);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
