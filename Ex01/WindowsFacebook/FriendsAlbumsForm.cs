using System;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using WindowsFacebookLogic;

namespace WindowsFacebook
{
    public partial class FriendsAlbumsForm : Form
    {
        private const string k_NameStr = "Name";
        private const string k_NotRetriveMsg = "No Albums to retrieve";
        private const string k_IssueToRetriveMsg = "Had issues to retrive albums from facebook servers: ";
        private AppManager m_AppManager = AppManager.AppManagerInstance();
        private User m_FriendUser;
        private FacebookObjectCollection<Photo> m_AlbumPhotos;
        private int m_AmountOfPhotosOnAlbum;
        private int m_CurrentPhotoIndex;

        public FriendsAlbumsForm()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.pictureBoxAlbum.SizeMode = PictureBoxSizeMode.AutoSize;
            this.pictureBoxCurrentPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            initFriendsComboBox();
        }

        private void initFriendsComboBox()
        {
            foreach (User currentUser in m_AppManager.LoginUser().Friends)
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
            m_FriendUser = m_AppManager.GetUserByName(m_AppManager.LoginUser(), comboBoxFriends.Text);
            fetchAlbums();
        }

        private void fetchAlbums()
        {
            listBoxAlbums.Items.Clear();
            listBoxAlbums.DisplayMember = k_NameStr;
            try
            {
                if (m_FriendUser != null)
                {
                    foreach (Album album in m_FriendUser.Albums)
                    {
                        listBoxAlbums.Items.Add(album);
                    }

                    if (m_AppManager.LoginUser().Albums.Count == 0)
                    {
                        listBoxAlbums.Text = k_NotRetriveMsg;
                    }
                }
            }
            catch (Exception i_E)
            {
                MessageBox.Show(string.Format("{0}{1}", k_IssueToRetriveMsg, i_E.Message));
            }
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedAlbum();
            Album selectedAlbum = listBoxAlbums.SelectedItem as Album;
            m_AlbumPhotos = selectedAlbum.Photos;
            m_AmountOfPhotosOnAlbum = selectedAlbum.Photos.Count();
            m_CurrentPhotoIndex = 0;
            showCurrentImageOnPictureBox(m_CurrentPhotoIndex);
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

        private void buttonNext_Click(object sender, EventArgs e)
        {
            Album currentAlbum = listBoxAlbums.SelectedItem as Album;
            if (currentAlbum != null)
            {
                m_CurrentPhotoIndex = m_AppManager.GetNextPictureIndex(currentAlbum, m_CurrentPhotoIndex);
                showCurrentImageOnPictureBox(m_CurrentPhotoIndex);
            }
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            Album currentAlbum = listBoxAlbums.SelectedItem as Album;
            if (currentAlbum != null)
            {
                m_CurrentPhotoIndex = m_AppManager.GetPreviousPictureIndex(listBoxAlbums.SelectedItem as Album, m_CurrentPhotoIndex);
                showCurrentImageOnPictureBox(m_CurrentPhotoIndex);
            }
        }

        private void showCurrentImageOnPictureBox(int i_Index)
        {
            if (m_AlbumPhotos[i_Index] != null)
            {
                pictureBoxCurrentPhoto.LoadAsync(m_AlbumPhotos[i_Index].PictureNormalURL);
            }
        }
    }
}
