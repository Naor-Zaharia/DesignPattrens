using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using WindowsFacebookLogic;

namespace WindowsFacebook
{
    public partial class FriendStatusForm : Form
    {
        private AppManagerFacade m_AppManagerFacade = AppManagerFacade.AppManagerFacadeInstance();

        public FriendStatusForm()
        {
            InitializeComponent();
        }

        private void friendStatusForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            initFriendsComboBox();
        }

        private void initFriendsComboBox()
        {
            foreach (User currentUser in m_AppManagerFacade.LoginUser().Friends)
            {
                this.comboBoxFriends.Items.Add(currentUser.Name);
            }
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            labelStatus.Text = m_AppManagerFacade.GetFriendStatus(m_AppManagerFacade.LoginUser(), comboBoxFriends.Text);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
