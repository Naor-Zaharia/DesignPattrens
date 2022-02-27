using System;
using System.ComponentModel;
using System.Windows.Forms;
using FacebookWrapper;
using WindowsFacebookLogic;

namespace WindowsFacebook
{
    public partial class MainMenuForm : Form
    {
        private const string k_SettingsRestoreErrMsg = "Had issues restore you previous settings";
        private const string k_LoginErrMsg = "You must be logged in before you can logout";
        private const string k_LoginMsg = "Logged-In as: ";
        private AppSettings m_AppSettings;
        private AppManager m_AppManager = AppManager.AppManagerInstance();

        public MainMenuForm()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            try
            {
                m_AppSettings = AppSettings.LoadFromFile();
                this.Size = m_AppSettings.LastWindowSize;
                this.Location = m_AppSettings.LastWindowLocation;
                this.checkBoxRememberMe.Checked = m_AppSettings.RememberUser;
            }
            catch
            {
                MessageBox.Show(k_SettingsRestoreErrMsg);
                m_AppSettings.SaveToFile();
            }
        }

        private void lookOnYourProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkIfFormOpen(typeof(MyProfileForm)))
            {
                focusOpenForm(getOpenForm(typeof(MyProfileForm)));
            }
            else
            {
                MyProfileForm myProfileForm = new MyProfileForm();
                initInnerForm(myProfileForm);
                myProfileForm.Show();
            }
        }

        private void MainMenuForm_Load(object sender, EventArgs e)
        {
            fetchLoggedInUser();
        }

        private void fetchLoggedInUser()
        {
            if (m_AppManager.LoginResult != null)
            {
                labelCurrentUsername.Text = m_AppManager.LoginResult.LoggedInUser.Name;
                pictureBoxProfile.ImageLocation = m_AppManager.LoginResult.LoggedInUser.PictureLargeURL;
                pictureBoxProfile.SizeMode = PictureBoxSizeMode.StretchImage;
                Text = string.Format("{0}{1}", k_LoginMsg, m_AppManager.LoginResult.LoggedInUser.Name);
            }
        }

        private void getYouFriendsListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkIfFormOpen(typeof(FriendsListForm)))
            {
                focusOpenForm(getOpenForm(typeof(FriendsListForm)));
            }
            else
            {
                FriendsListForm watchYourFriendsListForm = new FriendsListForm();
                initInnerForm(watchYourFriendsListForm);
                watchYourFriendsListForm.Show();
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (m_AppManager.LoginResult.LoggedInUser == null || string.IsNullOrEmpty(m_AppManager.LoginResult.AccessToken))
            {
                MessageBox.Show(k_LoginErrMsg);
            }
            else
            {
                FacebookService.Logout(new Action(loggedOutFinished));
            }
        }

        private void loggedOutFinished()
        {
            this.Hide();
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
        }

        private void MainMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void watchYourFeedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkIfFormOpen(typeof(WatchFeedForm)))
            {
                focusOpenForm(getOpenForm(typeof(WatchFeedForm)));
            }
            else
            {
                WatchFeedForm watchFeedForm = new WatchFeedForm();
                initInnerForm(watchFeedForm);
                watchFeedForm.Show();
            }
        }

        private void writeNewPostToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkIfFormOpen(typeof(WritePostForm)))
            {
                focusOpenForm(getOpenForm(typeof(WritePostForm)));
            }
            else
            {
                WritePostForm writePostForm = new WritePostForm();
                initInnerForm(writePostForm);
                writePostForm.Show();
            }
        }

        private void lookOnYourAlbumsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkIfFormOpen(typeof(MyAlbumsForm)))
            {
                focusOpenForm(getOpenForm(typeof(MyAlbumsForm)));
            }
            else
            {
                MyAlbumsForm myAlbumsForm = new MyAlbumsForm();
                initInnerForm(myAlbumsForm);
                myAlbumsForm.Show();
            }
        }

        private void likedPagesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkIfFormOpen(typeof(LikedPagesForm)))
            {
                focusOpenForm(getOpenForm(typeof(LikedPagesForm)));
            }
            else
            {
                LikedPagesForm likedPagesForm = new LikedPagesForm();
                initInnerForm(likedPagesForm);
                likedPagesForm.Show();
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            m_AppSettings.LastWindowLocation = this.Location;
            m_AppSettings.LastWindowSize = this.Size;
            if (checkBoxRememberMe.Checked)
            {
                m_AppSettings.LastAccessToken = this.m_AppManager.LoginResult.AccessToken;
            }
            else
            {
                m_AppSettings.LastAccessToken = null;
            }

            m_AppSettings.SaveToFile();
        }

        private void eventsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkIfFormOpen(typeof(MyEventsForm)))
            {
                focusOpenForm(getOpenForm(typeof(MyEventsForm)));
            }
            else
            {
                MyEventsForm eventsForm = new MyEventsForm();
                initInnerForm(eventsForm);
                eventsForm.Show();
            }
        }

        private void initInnerForm(Form i_InnerForm)
        {
            i_InnerForm.MdiParent = this;
            i_InnerForm.StartPosition = FormStartPosition.Manual;
            i_InnerForm.Location = new System.Drawing.Point(200, 50);
        }

        private void checkBoxRememberMe_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRememberMe.Checked)
            {
                m_AppSettings.RememberUser = true;
            }
            else
            {
                m_AppSettings.RememberUser = false;
            }
        }

        private void focusOpenForm(Form i_Form)
        {
            i_Form.Focus();
        }

        private bool checkIfFormOpen(Type i_FormType)
        {
            bool isOpen = false;

            foreach (Form currentForm in Application.OpenForms)
            {
                if (currentForm.GetType().Equals(i_FormType))
                {
                    isOpen = true;
                    break;
                }
            }

            return isOpen;
        }

        private Form getOpenForm(Type i_FormType)
        {
            Form form = null;

            foreach (Form currentForm in Application.OpenForms)
            {
                if (currentForm.GetType().Equals(i_FormType))
                {
                    form = currentForm;
                    break;
                }
            }

            return form;
        }

        private void collageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkIfFormOpen(typeof(CollageForm)))
            {
                focusOpenForm(getOpenForm(typeof(CollageForm)));
            }
            else
            {
                CollageForm collageForm = new CollageForm();
                initInnerForm(collageForm);
                collageForm.Show();
            }
        }

        private void soulMateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkIfFormOpen(typeof(SoulMateForm)))
            {
                focusOpenForm(getOpenForm(typeof(SoulMateForm)));
            }
            else
            {
                SoulMateForm soulMateForm = new SoulMateForm();
                initInnerForm(soulMateForm);
                soulMateForm.Show();
            }
        }

        private void userActionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkIfFormOpen(typeof(UserActionsForm)))
            {
                focusOpenForm(getOpenForm(typeof(UserActionsForm)));
            }
            else
            {
                UserActionsForm userActionsForm = new UserActionsForm();
                initInnerForm(userActionsForm);
                userActionsForm.Show();
            }
        }

        private void groupsOperationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkIfFormOpen(typeof(GroupsForm)))
            {
                focusOpenForm(getOpenForm(typeof(GroupsForm)));
            }
            else
            {
                GroupsForm watchYourGroupsForm = new GroupsForm();
                initInnerForm(watchYourGroupsForm);
                watchYourGroupsForm.Show();
            }
        }

        private void lookOnFriendsAlbumsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkIfFormOpen(typeof(FriendsAlbumsForm)))
            {
                focusOpenForm(getOpenForm(typeof(FriendsAlbumsForm)));
            }
            else
            {
                FriendsAlbumsForm friendsAlbumsForm = new FriendsAlbumsForm();
                initInnerForm(friendsAlbumsForm);
                friendsAlbumsForm.Show();
            }
        }

        private void checkFriendStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (checkIfFormOpen(typeof(FriendStatusForm)))
            {
                focusOpenForm(getOpenForm(typeof(FriendStatusForm)));
            }
            else
            {
                FriendStatusForm friendStatusForm = new FriendStatusForm();
                initInnerForm(friendStatusForm);
                friendStatusForm.Show();
            }
        }
    }
}
