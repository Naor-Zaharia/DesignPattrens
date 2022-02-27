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
            m_AppManagerFacade.ThemeChanged += appManagerFacadeThemeChanged;
        }

        private void appManagerFacadeThemeChanged(LogicEnums.eThemeColor i_ThemeColor)
        {
            ThemeExecuter.ChangeControlsThemeColor(i_ThemeColor, Controls);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ThemeExecuter.ChangeControlsThemeColor(m_AppManagerFacade.ThemeColor, Controls);
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