using System;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using WindowsFacebookLogic;

namespace WindowsFacebook
{
    public partial class MyAlbumsForm : Form
    {
        private const string k_NameStr = "Name";
        private const string k_NotRetriveMsg = "No albums to retrieve";
        private const string k_IssueToRetriveAlbumMsg = "Had issues to retrive albums from facebook servers: ";
        private const string k_IssueToRetrivePhotoMsg = "Had issues to retrive photo from facebook servers: ";
        private AppManager m_AppManager = AppManager.AppManagerInstance();
        private FacebookObjectCollection<Photo> m_AlbumPhotos;
        private int m_AmountOfPhotosOnAlbum;
        private int m_CurrentPhotoIndex;

        public MyAlbumsForm()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            pictureBoxAlbumsCover.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxCurrentPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
            fetchAlbums();
        }

        private void fetchAlbums()
        {
            listBoxMyAlbums.Items.Clear();
            listBoxMyAlbums.DisplayMember = k_NameStr;
            try
            {
                foreach (Album album in m_AppManager.LoginUser().Albums)
                {
                    listBoxMyAlbums.Items.Add(album);
                }

                if (m_AppManager.LoginUser().Albums.Count == 0)
                {
                    listBoxMyAlbums.Text = k_NotRetriveMsg;
                }
            }
            catch (Exception i_E)
            {
                listBoxMyAlbums.Text = string.Format("{0}{1}", k_IssueToRetriveAlbumMsg, i_E.Message);
            }
        }

        private void listBoxMyAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedAlbum();
            Album selectedAlbum = listBoxMyAlbums.SelectedItem as Album;
            m_AlbumPhotos = selectedAlbum.Photos;
            m_AmountOfPhotosOnAlbum = selectedAlbum.Photos.Count();
            m_CurrentPhotoIndex = 0;
            showCurrentImageOnPictureBox(m_CurrentPhotoIndex);
        }

        private void displaySelectedAlbum()
        {
            if (listBoxMyAlbums.SelectedItems.Count == 1)
            {
                Album selectedAlbum = listBoxMyAlbums.SelectedItem as Album;
                if (selectedAlbum.PictureAlbumURL != null)
                {
                    try
                    {
                        pictureBoxAlbumsCover.LoadAsync(selectedAlbum.PictureAlbumURL);
                    }
                    catch (Exception i_E)
                    {
                        listBoxMyAlbums.Text = string.Format("{0}{1}", k_IssueToRetrivePhotoMsg, i_E.Message);
                    }
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            Album currentAlbum = listBoxMyAlbums.SelectedItem as Album;
            if (currentAlbum != null)
            {
                m_CurrentPhotoIndex = m_AppManager.GetNextPictureIndex(listBoxMyAlbums.SelectedItem as Album, m_CurrentPhotoIndex);
                showCurrentImageOnPictureBox(m_CurrentPhotoIndex);
            }
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            Album currentAlbum = listBoxMyAlbums.SelectedItem as Album;
            if (currentAlbum != null)
            {
                m_CurrentPhotoIndex = m_AppManager.GetPreviousPictureIndex(listBoxMyAlbums.SelectedItem as Album, m_CurrentPhotoIndex);
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
