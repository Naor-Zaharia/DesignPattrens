using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using WindowsFacebookLogic;

namespace WindowsFacebook
{
    public partial class WritePostForm : Form
    {
        private const string k_PostedMsg = "Status Posted, post ID is: ";
        private AppManager m_AppManager = AppManager.AppManagerInstance();

        public WritePostForm()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }

        private void buttonPost_Click(object sender, EventArgs e)
        {
            Status postedStatus = m_AppManager.LoginUser().PostStatus(textBoxPost.Text);
            MessageBox.Show(string.Format("{0}{1}", k_PostedMsg, postedStatus.Id));
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
