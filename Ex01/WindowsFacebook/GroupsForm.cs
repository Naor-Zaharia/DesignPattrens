using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using WindowsFacebookLogic;

namespace WindowsFacebook
{
    public partial class GroupsForm : Form
    {
        private const string k_NameStr = "Name";
        private const string k_NotRetriveMsg = "No groups to retrieve";
        private const string k_IssueToRetriveMsg = "Had issues to retrive groups from facebook servers: ";
        private AppManager m_AppManager = AppManager.AppManagerInstance();

        public GroupsForm()
        {
            InitializeComponent();
        }

        private void fetchGroups()
        {
            listBoxGroups.Items.Clear();
            listBoxGroups.DisplayMember = k_NameStr;
            try
            {
                foreach (Group group in m_AppManager.LoginUser().Groups)
                {
                    listBoxGroups.Items.Add(group);
                }

                if (m_AppManager.LoginUser().Groups.Count == 0)
                {
                    listBoxGroups.Items.Add(k_NotRetriveMsg);
                }
            }
            catch (Exception i_E)
            {
                listBoxGroups.Items.Add(k_IssueToRetriveMsg);
                listBoxGroups.Items.Add(i_E.Message);
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fetchGroups();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBoxGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxGroups.SelectedItems.Count == 1)
            {
                Group selectedGroup = listBoxGroups.SelectedItem as Group;
                pictureBoxGroup.LoadAsync(selectedGroup.PictureNormalURL);
            }
        }
    }
}
