using System;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace WindowsFacebook
{
    public class GalleryPanel : Panel
    {
        private const string k_FontName = "Microsoft Sans Serif";
        private const string k_BackButtonText = "Back";
        private const string k_NextButtonText = "Next";
        private const int k_PanelWidth = 400;
        private const int k_PanelHeight = 300;
        private const int k_PictureBoxWidth = 345;
        private const int k_PictureBoxHeight = 235;
        private const int k_ButtonWidth = 80;
        private const int k_ButtonHeight = 30;
        private const int k_ButtonBackXLocation = 105;
        private const int k_ButtonBackYLocation = 260;
        private const int k_ButtonNextXLocation = 205;
        private const int k_ButtonNextYLocation = 260;
        private const int k_PictureBoxXLocation = 28;
        private const int k_PictureBoxYLocation = 20;
        private const int k_FontSize = 10;
        private Album m_AlbumPhotos;
        private PictureBox m_GalleryPictureBox;
        private int m_AlbumCurrentIndex;

        public GalleryPanel()
        {
            generatePanel();
            generatePictureBox();
            generateGalleryButtons();
            this.m_AlbumCurrentIndex = 0;
        }

        public void LoadPhotosToGallery(Album i_AlbumsPhotos)
        {
            this.m_AlbumPhotos = i_AlbumsPhotos;
            showCurrentImageOnPictureBox();
        }

        private void generatePanel()
        {
            this.Size = new Size(k_PanelWidth, k_PanelHeight);
            this.BackColor = Color.RoyalBlue;
        }

        private void generateGalleryButtons()
        {
            Button backButton = createDesignButton(k_BackButtonText);
            Button nextButton = createDesignButton(k_NextButtonText);
            backButton.Location = new Point(k_ButtonBackXLocation, k_ButtonBackYLocation);
            nextButton.Location = new Point(k_ButtonNextXLocation, k_ButtonNextYLocation);
            backButton.Click += backButton_Click;
            nextButton.Click += nextButton_Click;
            Controls.Add(backButton);
            Controls.Add(nextButton);
        }

        private Button createDesignButton(string i_ButtonText)
        {
            Button resultButton = new Button();
            resultButton.Text = i_ButtonText;
            resultButton.FlatStyle = FlatStyle.Flat;
            resultButton.Size = new Size(k_ButtonWidth, k_ButtonHeight);
            resultButton.BackColor = Color.CornflowerBlue;
            resultButton.Font = new Font(k_FontName, k_FontSize, FontStyle.Bold);

            return resultButton;
        }

        private void generatePictureBox()
        {
            m_GalleryPictureBox = new PictureBox();
            m_GalleryPictureBox.Size = new Size(k_PictureBoxWidth, k_PictureBoxHeight);
            m_GalleryPictureBox.Location = new Point(k_PictureBoxXLocation, k_PictureBoxYLocation);
            m_GalleryPictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            m_GalleryPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            m_GalleryPictureBox.BackColor = Color.CornflowerBlue;
            Controls.Add(m_GalleryPictureBox);
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            m_AlbumCurrentIndex = updateNextPictureIndex();
            showCurrentImageOnPictureBox();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            m_AlbumCurrentIndex = updatePreviousPictureIndex();
            showCurrentImageOnPictureBox();
        }

        private void showCurrentImageOnPictureBox()
        {
            m_GalleryPictureBox.LoadAsync(m_AlbumPhotos.Photos[m_AlbumCurrentIndex].PictureNormalURL);
        }

        private int updateNextPictureIndex()
        {
            return (m_AlbumCurrentIndex + 1) % m_AlbumPhotos.Photos.Count;
        }

        private int updatePreviousPictureIndex()
        {
            int index = m_AlbumCurrentIndex - 1;

            if (index < 0)
            {
                index = m_AlbumPhotos.Photos.Count - 1;
            }

            return index;
        }
    }
}