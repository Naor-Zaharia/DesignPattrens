using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using WindowsFacebookLogic;

namespace WindowsFacebook
{
    public partial class WatchFeedForm : Form
    {        
        private const string k_NotRetriveMsg = "No posts to retrieve";
        private const string k_IssueToRetriveMsg = "Had issues to retrive posts from facebook servers: ";      
        private AppManager m_AppManager = AppManager.AppManagerInstance();
        private Dictionary<int, string> m_PostsPhotos = new Dictionary<int, string>();

        public WatchFeedForm()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            pictureBoxFeed.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxFeed.Visible = false;
            fetchPosts();
        }

        private void fetchPosts()
        {
            int postKey = 0;
            try
            {
                foreach (Post post in m_AppManager.LoginUser().Posts)
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

                if (m_AppManager.LoginUser().Posts.Count == 0)
                {
                    MessageBox.Show(k_NotRetriveMsg);
                }
            }
            catch (Exception i_E)
            {
                listBoxMyFeed.Items.Add(k_IssueToRetriveMsg);
                listBoxMyFeed.Items.Add(i_E.Message);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
