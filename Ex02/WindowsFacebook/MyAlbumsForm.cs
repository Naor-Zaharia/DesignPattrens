using System;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using WindowsFacebookLogic;

namespace WindowsFacebook
{
    public partial class MyAlbumsForm : Form
    {
        private AppManagerFacade m_AppManagerFacade = AppManagerFacade.AppManagerFacadeInstance();
        private FacebookObjectCollection<Photo> m_AlbumPhotos;
        private int m_AmountOfPhotosOnAlbum;

        public MyAlbumsForm()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.pictureBoxAlbumsCover.SizeMode = PictureBoxSizeMode.AutoSize;
            fetchAlbums();
        }

        private void fetchAlbums()
        {
            listBoxMyAlbums.Items.Clear();
            listBoxMyAlbums.DisplayMember = UIMessages.k_NameStr;
            try
            {
                foreach (Album album in m_AppManagerFacade.Albums)
                {
                    listBoxMyAlbums.Items.Add(album);
                }

                if (m_AppManagerFacade.Albums.Count == 0)
                {
                    listBoxMyAlbums.Text = UIMessages.k_NotRetriveAlbumsMsg;
                }
            }
            catch (Exception i_E)
            {
                listBoxMyAlbums.Text = string.Format("{0}{1}", UIMessages.k_IssueToRetriveAlbumsMsg, i_E.Message);
            }
        }

        private void listBoxMyAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedAlbum();
            Album selectedAlbum = listBoxMyAlbums.SelectedItem as Album;
            m_AlbumPhotos = selectedAlbum.Photos;
            m_AmountOfPhotosOnAlbum = selectedAlbum.Photos.Count();
            galleryPanelMyAlbums.LoadPhotosToGallery(selectedAlbum);
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
                        listBoxMyAlbums.Text = string.Format("{0}{1}", UIMessages.k_IssueToRetrivePhotoMsg, i_E.Message);
                    }
                }
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}