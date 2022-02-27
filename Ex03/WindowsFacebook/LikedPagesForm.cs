using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using WindowsFacebookLogic;

namespace WindowsFacebook
{
    public partial class LikedPagesForm : Form
    {
        private AppManagerFacade m_AppManagerFacade = AppManagerFacade.AppManagerFacadeInstance();

        public LikedPagesForm()
        {
            InitializeComponent();
            m_AppManagerFacade.ThemeChanged += appManagerFacadeThemeChanged;
        }

        private void appManagerFacadeThemeChanged(LogicEnums.eThemeColor i_ThemeColor)
        {
            ThemeExecuter.ChangeControlsThemeColor(i_ThemeColor, Controls);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            ThemeExecuter.ChangeControlsThemeColor(m_AppManagerFacade.ThemeColor, Controls);
            fetchLikedPages();
        }

        private void fetchLikedPages()
        {
            listBoxPages.Items.Clear();
            listBoxPages.DisplayMember = UIMessages.k_NameStr;
            try
            {
                foreach (Page page in m_AppManagerFacade.LoginUser().LikedPages)
                {
                    listBoxPages.Items.Add(page.Name);
                }

                if (m_AppManagerFacade.LoginUser().LikedPages.Count == 0)
                {
                    listBoxPages.Items.Add(UIMessages.k_NotRetriveLikedPagesMsg);
                }
            }
            catch (Exception i_E)
            {
                listBoxPages.Items.Add(UIMessages.k_IssueToRetriveLikedPagesMsg);
                listBoxPages.Items.Add(i_E.Message);
            }
        }
    }
}