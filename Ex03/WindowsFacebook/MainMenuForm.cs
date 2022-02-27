using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using WindowsFacebookLogic;

namespace WindowsFacebook
{
    public partial class MainMenuForm : Form
    {
        private const string k_MenuTitle = "Main Menu";
        private const string k_ProfileOperations = "Profile Operations";
        private const string k_MyProfile = "My Profile";
        private const string k_LikedPages = "Liked Pages";
        private const string k_Events = "Events";
        private const string k_Groups = "Groups";
        private const string k_Actions = "Actions";
        private const string k_FriendsStatus = "Friends Status";
        private const string k_AlbumsOperations = "Albums Operations";
        private const string k_MyAlbums = "My Albums";
        private const string k_FriendsAlbums = "Friends Albums";
        private const string k_UniqeFeatures = "Uniqe Features";
        private const string k_MySoulMate = "My Soul Mate";
        private const string k_Collage = "Collage";
        private const string k_Logout = "Logout";
        private Dictionary<int, string> m_PostsPhotos = new Dictionary<int, string>();
        private AppSettings m_AppSettings;
        private MenuUI m_Menu;
        private AppManagerFacade m_AppManagerFacade = AppManagerFacade.AppManagerFacadeInstance();

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
                MessageBox.Show(UIMessages.k_SettingsRestoreErrMsg);
                m_AppSettings.SaveToFile();
            }

            m_AppManagerFacade.ThemeChanged += appManagerFacadeThemeChanged;
        }

        private void appManagerFacadeThemeChanged(LogicEnums.eThemeColor i_ThemeColor)
        {
            ThemeExecuter.ChangeControlsThemeColor(i_ThemeColor, Controls);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            createMenu();
            fetchLoggedInUser();
            listBoxMyFeed.Invoke(new Action(() =>
            {
                fetchPosts();
            }));

            listBoxMyFriends.Invoke(new Action(() =>
            {
                fetchFriends();
            }));
        }

        private void createMenu()
        {
            WindowsFacebookLogic.Menu menu = new WindowsFacebookLogic.Menu();
            menu.MenuTitle = k_MenuTitle;
            menu.AddMenuItems(new List<WindowsFacebookLogic.MenuItem>
            {
            createMenuItemSection(k_ProfileOperations),
            createMenuItem(openMyProfileForm, k_MyProfile),
            createMenuItem(openLikedPagesForm, k_LikedPages),
            createMenuItem(openEventsForm, k_Events),
            createMenuItem(openGroupsForm, k_Groups),
            createMenuItem(openActionsForm, k_Actions),
            createMenuItem(openFriendsStatusForm, k_FriendsStatus),
            createMenuItemSection(k_AlbumsOperations),
            createMenuItem(openMyAlbumsForm, k_MyAlbums),
            createMenuItem(openFriendsAlbumsForm, k_FriendsAlbums),
            createMenuItemSection(k_UniqeFeatures),
            createMenuItem(openSoulMateForm, k_MySoulMate),
            createMenuItem(openCollageForm, k_Collage),
            createMenuItemSection(string.Empty),
            createMenuItem(logout, k_Logout)
            });

            m_Menu = new MenuUI(menu);
            m_Menu.GenerateUIMenu();
            m_Menu.SetLocation(15, 40);
            this.Controls.Add(m_Menu);
        }

        private WindowsFacebookLogic.MenuItem createMenuItem(Action i_Action, string i_MenuItemText)
        {
            return new WindowsFacebookLogic.MenuItem(i_Action, i_MenuItemText);
        }

        private MenuItemSection createMenuItemSection(string i_MenuSectionText)
        {
            return new MenuItemSection(i_MenuSectionText);
        }

        private void fetchLoggedInUser()
        {
            if (m_AppManagerFacade.LoginResult != null)
            {
                labelCurrentUsername.Invoke(new Action(() =>
                {
                    labelCurrentUsername.Text = m_AppManagerFacade.LoginResult.LoggedInUser.Name;
                }));
                pictureBoxProfile.Invoke(new Action(() =>
                {
                    pictureBoxProfile.ImageLocation = m_AppManagerFacade.LoginResult.LoggedInUser.PictureLargeURL;
                    pictureBoxProfile.SizeMode = PictureBoxSizeMode.StretchImage;
                }));
                this.Invoke(new Action(() =>
                {
                    Text = string.Format("{0}{1}", UIMessages.k_LoginMsg, m_AppManagerFacade.LoginResult.LoggedInUser.Name);
                }));
            }
        }

        private void loggedOutFinished()
        {
            this.Hide();
            FormsGenerator.GenerateForm(UIEnums.eFormType.Login).ShowDialog();
        }

        private void mainMenuForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);

            m_AppSettings.LastWindowLocation = this.Location;
            m_AppSettings.LastWindowSize = this.Size;
            if (checkBoxRememberMe.Checked)
            {
                m_AppSettings.LastAccessToken = this.m_AppManagerFacade.LoginResult.AccessToken;
            }
            else
            {
                m_AppSettings.LastAccessToken = null;
            }

            m_AppSettings.SaveToFile();
        }

        private void initInnerForm(Form i_InnerForm)
        {
            i_InnerForm.MdiParent = this;
            i_InnerForm.StartPosition = FormStartPosition.Manual;
            i_InnerForm.Location = new System.Drawing.Point(350, 80);
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

        private void fetchFriends()
        {
            listBoxMyFriends.Items.Clear();
            listBoxMyFriends.DisplayMember = UIMessages.k_NameStr;
            try
            {
                foreach (User friend in m_AppManagerFacade.Friends)
                {
                    listBoxMyFriends.Items.Add(friend.Name);
                }

                if (m_AppManagerFacade.Friends.Count == 0)
                {
                    listBoxMyFriends.Items.Add(UIMessages.k_NotFriendsRetriveMsg);
                }
            }
            catch
            {
                listBoxMyFriends.Items.Add(UIMessages.k_IssueToRetriveFriendsMsg);
            }
        }

        private void fetchPosts()
        {
            int postKey = 0;
            initFeedPictureBox();
            try
            {
                foreach (Post post in m_AppManagerFacade.Posts)
                {
                    if (post.Message != null)
                    {
                        listBoxMyFeed.Items.Add(post.Message);
                    }
                    else if (post.Caption != null)
                    {
                        listBoxMyFeed.Items.Add(post.Caption);
                    }
                    else
                    {
                        listBoxMyFeed.Items.Add(string.Format("{0}", post.Type));
                        if (post.PictureURL != string.Empty)
                        {
                            m_PostsPhotos.Add(postKey, post.PictureURL);
                        }
                    }

                    postKey++;
                }

                if (m_AppManagerFacade.Posts.Count == 0)
                {
                    MessageBox.Show(UIMessages.k_NotPostsRetriveMsg);
                }
            }
            catch (Exception i_E)
            {
                listBoxMyFeed.Items.Add(UIMessages.k_IssueToRetrivePostsMsg);
                listBoxMyFeed.Items.Add(i_E.Message);
            }
        }

        private void listBoxMyFeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            int key = listBoxMyFeed.SelectedIndex;
            try
            {
                if (m_PostsPhotos.ContainsKey(key))
                {
                    string urlValue = m_PostsPhotos[key];
                    if (urlValue != string.Empty)
                    {
                        pictureBoxFeed.Visible = true;
                        pictureBoxFeed.LoadAsync(urlValue);
                    }
                }
                else
                {
                    pictureBoxFeed.Visible = false;
                }
            }
            catch
            {
            }
        }

        private void initFeedPictureBox()
        {
            pictureBoxFeed.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxFeed.Visible = false;
        }

        private void buttonRefreshFriendsList_Click(object sender, EventArgs e)
        {
            listBoxMyFriends.Items.Clear();
            fetchFriends();
        }

        private void buttonRefreshFeeds_Click(object sender, EventArgs e)
        {
            m_PostsPhotos.Clear();
            listBoxMyFeed.Items.Clear();
            fetchPosts();
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            Status postedStatus = m_AppManagerFacade.LoginUser().PostStatus(textBoxPost.Text);
            MessageBox.Show(string.Format("{0}{1}", UIMessages.k_PostedMsg, postedStatus.Id));
        }

        private void focusOpenForm(Form i_Form)
        {
            i_Form.Focus();
        }

        private void openForm(Form i_FormToOpen)
        {
            if (i_FormToOpen != null)
            {
                initInnerForm(i_FormToOpen);
                i_FormToOpen.Show();
                i_FormToOpen.Focus();
            }
            else
            {
                focusOpenForm(FormsGenerator.GetOpenForm(i_FormToOpen.GetType()));
            }
        }

        private void openMyProfileForm()
        {
            openForm(FormsGenerator.GenerateForm(UIEnums.eFormType.MyProfile));
        }

        private void openLikedPagesForm()
        {
            openForm(FormsGenerator.GenerateForm(UIEnums.eFormType.LikedPages));
        }

        private void openEventsForm()
        {
            openForm(FormsGenerator.GenerateForm(UIEnums.eFormType.MyEvents));
        }

        private void openGroupsForm()
        {
            openForm(FormsGenerator.GenerateForm(UIEnums.eFormType.Groups));
        }

        private void openActionsForm()
        {
            openForm(FormsGenerator.GenerateForm(UIEnums.eFormType.UserActions));
        }

        private void openFriendsStatusForm()
        {
            openForm(FormsGenerator.GenerateForm(UIEnums.eFormType.FriendsStatus));
        }

        private void openMyAlbumsForm()
        {
            openForm(FormsGenerator.GenerateForm(UIEnums.eFormType.MyAlbums));
        }

        private void openFriendsAlbumsForm()
        {
            openForm(FormsGenerator.GenerateForm(UIEnums.eFormType.FriendsAlbums));
        }

        private void openSoulMateForm()
        {
            openForm(FormsGenerator.GenerateForm(UIEnums.eFormType.SoulMate));
        }

        private void openCollageForm()
        {
            openForm(FormsGenerator.GenerateForm(UIEnums.eFormType.Collage));
        }

        private void logout()
        {
            if (m_AppManagerFacade.LoginResult.LoggedInUser == null || string.IsNullOrEmpty(m_AppManagerFacade.LoginResult.AccessToken))
            {
                MessageBox.Show(UIMessages.k_LoginErrMsg);
            }
            else
            {
                FacebookService.Logout(new Action(loggedOutFinished));
            }
        }

        private void radioButtonThemeBlue_CheckedChanged(object sender, EventArgs e)
        {
            m_AppManagerFacade.ThemeColor = LogicEnums.eThemeColor.Blue;
        }

        private void radioButtonThemeRed_CheckedChanged(object sender, EventArgs e)
        {
            m_AppManagerFacade.ThemeColor = LogicEnums.eThemeColor.Red;
        }

        private void radioButtonThemeYellow_CheckedChanged(object sender, EventArgs e)
        {
            m_AppManagerFacade.ThemeColor = LogicEnums.eThemeColor.Yellow;
        }
    }
}