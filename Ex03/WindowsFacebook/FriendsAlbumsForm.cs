using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using WindowsFacebookLogic;

namespace WindowsFacebook
{
    public partial class FriendsAlbumsForm : Form
    {
        private AppManagerFacade m_AppManagerFacade = AppManagerFacade.AppManagerFacadeInstance();
        private User m_FriendUser;
        private FacebookObjectCollection<Photo> m_AlbumPhotos;

        public FriendsAlbumsForm()
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
            this.pictureBoxAlbum.SizeMode = PictureBoxSizeMode.AutoSize;
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

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            m_FriendUser = m_AppManagerFacade.GetUserByName(m_AppManagerFacade.LoginUser(), comboBoxFriends.Text);
            fetchAlbums();
        }

        private void fetchAlbums()
        {
            listBoxAlbums.Items.Clear();
            listBoxAlbums.DisplayMember = UIMessages.k_NameStr;
            try
            {
                if (m_FriendUser != null)
                {
                    foreach (Album album in m_FriendUser.Albums)
                    {
                        listBoxAlbums.Items.Add(album);
                    }

                    if (m_FriendUser.Albums.Count == 0)
                    {
                        listBoxAlbums.Text = UIMessages.k_NotRetriveAlbumsMsg;
                    }
                }
            }
            catch (Exception i_E)
            {
                MessageBox.Show(string.Format("{0}{1}", UIMessages.k_IssueToRetriveAlbumsMsg, i_E.Message));
            }
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedAlbum();
            Album selectedAlbum = listBoxAlbums.SelectedItem as Album;
            m_AlbumPhotos = selectedAlbum.Photos;           
            galleryPanelFriendsAlbum.LoadPhotosToGallery(selectedAlbum);
        }

        private void displaySelectedAlbum()
        {
            if (listBoxAlbums.SelectedItems.Count == 1)
            {
                Album selectedAlbum = listBoxAlbums.SelectedItem as Album;
                if (selectedAlbum.PictureAlbumURL != null)
                {
                    try
                    {
                        pictureBoxAlbum.LoadAsync(selectedAlbum.PictureAlbumURL);
                    }
                    catch
                    {
                    }
                }
            }
        }
    }
}