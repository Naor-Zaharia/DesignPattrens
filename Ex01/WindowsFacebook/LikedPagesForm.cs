using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using WindowsFacebookLogic;

namespace WindowsFacebook
{
    public partial class LikedPagesForm : Form
    {
        private const string k_NameStr = "Name";
        private const string k_NotRetriveMsg = "No liked pages to retrieve";
        private const string k_IssueToRetriveMsg = "Had issues to retrive liked pages from facebook servers: ";
        private AppManager m_AppManager = AppManager.AppManagerInstance();

        public LikedPagesForm()
        {
            InitializeComponent();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fetchLikedPages();
        }

        private void fetchLikedPages()
        {
            listBoxPages.Items.Clear();
            listBoxPages.DisplayMember = k_NameStr;
            try
            {
                foreach (Page page in m_AppManager.LoginUser().LikedPages)
                {
                    listBoxPages.Items.Add(page.Name);
                }

                if (m_AppManager.LoginUser().LikedPages.Count == 0)
                {
                    listBoxPages.Items.Add(k_NotRetriveMsg);
                }
            }
            catch (Exception i_E)
            {
                listBoxPages.Items.Add(k_IssueToRetriveMsg);
                listBoxPages.Items.Add(i_E.Message);
            }
        }
    }
}
