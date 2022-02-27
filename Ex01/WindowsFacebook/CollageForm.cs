using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using WindowsFacebookLogic;

namespace WindowsFacebook
{
    public partial class CollageForm : Form
    {
        private const int k_SizeOfCollageSquare = 3;
        private const int k_PictureBoxSquareSize = 80;
        private const string k_NameStr = "Name";
        private const string k_NotRetriveMsg = "No Albums to retrieve";
        private const string k_IssueToRetriveMsg = "Had issues to retrive albums from facebook servers";
        private readonly Point r_InitPictureBoxLocation = new Point(465, 120);
        private readonly List<PictureBox> r_CollagePictureBoxes = new List<PictureBox>();
        private FacebookObjectCollection<Photo> m_AlbumsPhotos;
        private AppManager m_AppManager = AppManager.AppManagerInstance();

        public CollageForm()
        {
            InitializeComponent();
            generatePictureBoxesForCollage();
        }

        private void generatePictureBoxesForCollage()
        {
            for (int row = 0; row < k_SizeOfCollageSquare; row++)
            {
                for (int col = 0; col < k_SizeOfCollageSquare; col++)
                {
                    PictureBox pictureBox = createPictureBox(row, col, k_SizeOfCollageSquare);
                    r_CollagePictureBoxes.Add(pictureBox);
                    this.Controls.Add(pictureBox);
                }
            }
        }

        private PictureBox createPictureBox(int i_Row, int i_Col, int i_SquareSize)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Location = new Point(r_InitPictureBoxLocation.X + (k_PictureBoxSquareSize * i_Col), r_InitPictureBoxLocation.Y + (k_PictureBoxSquareSize * i_Row));
            pictureBox.Size = new Size(k_PictureBoxSquareSize, k_PictureBoxSquareSize);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            return pictureBox;
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            pictureBoxCurrentAlbum.SizeMode = PictureBoxSizeMode.StretchImage;
            fetchAlbums();
        }

        private void fetchAlbums()
        {
            listBoxCurrentAlbum.Items.Clear();
            listBoxCurrentAlbum.DisplayMember = k_NameStr;
            try
            {
                foreach (Album album in m_AppManager.LoginUser().Albums)
                {
                    listBoxCurrentAlbum.Items.Add(album);
                }

                if (m_AppManager.LoginUser().Albums.Count == 0)
                {
                    listBoxCurrentAlbum.Items.Add(k_NotRetriveMsg);
                }
            }
            catch (Exception i_E)
            {
                listBoxCurrentAlbum.Items.Add(k_IssueToRetriveMsg);
                listBoxCurrentAlbum.Items.Add(i_E.Message);
            }
        }

        private void listBoxMyAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            displaySelectedAlbum();
        }

        private void displaySelectedAlbum()
        {
            if (listBoxCurrentAlbum.SelectedItems.Count == 1)
            {
                Album selectedAlbum = listBoxCurrentAlbum.SelectedItem as Album;
                if (selectedAlbum.PictureAlbumURL != null)
                {
                    try
                    {
                        pictureBoxCurrentAlbum.LoadAsync(selectedAlbum.PictureAlbumURL);
                        m_AlbumsPhotos = selectedAlbum.Photos;
                    }
                    catch
                    {
                    }
                }
            }
        }

        private void fetchCollage()
        {
            List<Photo> photos;

            if (radioButtonMostLikedPhotos.Checked)
            {
                photos = CollageLogic.GetMostLikedPhotosFromAlbum(m_AlbumsPhotos, k_SizeOfCollageSquare * k_SizeOfCollageSquare);
            }
            else
            {
                photos = CollageLogic.GetRandomPhotosFromAlbum(m_AlbumsPhotos, k_SizeOfCollageSquare * k_SizeOfCollageSquare);
            }

            int currentPhotoIndex = 0;

            foreach (Photo currentPhoto in photos)
            {
                if (currentPhoto != null)
                {
                    r_CollagePictureBoxes[currentPhotoIndex].LoadAsync(currentPhoto.PictureNormalURL);
                }

                currentPhotoIndex++;
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            cleanPictureBox();
            fetchCollage();
        }

        private void cleanPictureBox()
        {
            foreach(PictureBox currentPictureBox in r_CollagePictureBoxes)
            {
                currentPictureBox.Image = null;
            }
        }
    }
}
