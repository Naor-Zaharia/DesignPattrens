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
        private readonly Point r_InitPictureBoxLocation = new Point(465, 120);
        private readonly List<PictureBox> r_CollagePictureBoxes = new List<PictureBox>();
        private Album m_AlbumsPhotos;
        private AppManagerFacade m_AppManagerFacade = AppManagerFacade.AppManagerFacadeInstance();

        public CollageForm()
        {
            InitializeComponent();
            generatePictureBoxesForCollage();
            m_AppManagerFacade.ThemeChanged += appManagerFacadeThemeChanged;
        }

        private void appManagerFacadeThemeChanged(LogicEnums.eThemeColor i_ThemeColor)
        {
            ThemeExecuter.ChangeControlsThemeColor(i_ThemeColor, Controls);
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
            ThemeExecuter.ChangeControlsThemeColor(m_AppManagerFacade.ThemeColor, Controls);
            fetchAlbums();
        }

        private void fetchAlbums()
        {
            listBoxCurrentAlbum.Items.Clear();
            listBoxCurrentAlbum.DisplayMember = UIMessages.k_NameStr;
            try
            {
                foreach (Album album in m_AppManagerFacade.Albums)
                {
                    listBoxCurrentAlbum.Items.Add(album);
                }

                if (m_AppManagerFacade.Albums.Count == 0)
                {
                    listBoxCurrentAlbum.Items.Add(UIMessages.k_NotRetriveAlbumsMsg);
                }
            }
            catch (Exception i_E)
            {
                listBoxCurrentAlbum.Items.Add(UIMessages.k_IssueToRetriveAlbumsMsg);
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
                m_AlbumsPhotos = listBoxCurrentAlbum.SelectedItem as Album;
                if (m_AlbumsPhotos.PictureAlbumURL != null)
                {
                    try
                    {
                        pictureBoxCurrentAlbum.LoadAsync(m_AlbumsPhotos.PictureAlbumURL);
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
                photos = m_AppManagerFacade.GetMostLikedPhotosFromAlbum(m_AlbumsPhotos, k_SizeOfCollageSquare * k_SizeOfCollageSquare);
            }
            else
            {
                photos = m_AppManagerFacade.GetRandomPhotosFromAlbum(m_AlbumsPhotos, k_SizeOfCollageSquare * k_SizeOfCollageSquare);
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
            foreach (PictureBox currentPictureBox in r_CollagePictureBoxes)
            {
                currentPictureBox.Image = null;
            }
        }
    }
}