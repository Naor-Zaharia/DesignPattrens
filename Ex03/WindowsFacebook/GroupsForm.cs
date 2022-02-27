using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using WindowsFacebookLogic;

namespace WindowsFacebook
{
    public partial class GroupsForm : Form
    {
        private AppManagerFacade m_AppManagerFacade = AppManagerFacade.AppManagerFacadeInstance();

        public GroupsForm()
        {
            InitializeComponent();
            m_AppManagerFacade.ThemeChanged += appManagerFacadeThemeChanged;
        }

        private void appManagerFacadeThemeChanged(LogicEnums.eThemeColor i_ThemeColor)
        {
            ThemeExecuter.ChangeControlsThemeColor(i_ThemeColor, Controls);
        }

        private void fetchGroups()
        {
            listBoxGroups.Items.Clear();
            listBoxGroups.DisplayMember = UIMessages.k_NameStr;
            try
            {
                foreach (Group group in m_AppManagerFacade.LoginUser().Groups)
                {
                    listBoxGroups.Items.Add(group);
                }

                if (m_AppManagerFacade.LoginUser().Groups.Count == 0)
                {
                    listBoxGroups.Items.Add(UIMessages.k_NotRetriveGroupMsg);
                }
            }
            catch (Exception i_E)
            {
                listBoxGroups.Items.Add(UIMessages.k_IssueToRetriveGroupMsg);
                listBoxGroups.Items.Add(i_E.Message);
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ThemeExecuter.ChangeControlsThemeColor(m_AppManagerFacade.ThemeColor, Controls);
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