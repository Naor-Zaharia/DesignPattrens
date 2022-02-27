using System;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using WindowsFacebookLogic;

namespace WindowsFacebook
{
    public partial class UserActionsForm : Form
    {
        private AppManagerFacade m_AppManagerFacade = AppManagerFacade.AppManagerFacadeInstance();

        public UserActionsForm()
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
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                string actionType = comboBoxActions.SelectedItem.ToString();
                FacebookObjectCollection<Page> actions = FacebookService.GetCollection<Page>(actionType);
                dynamic actionsData = FacebookService.GetDynamicData(actionType);
                dataGridViewActions.DataSource = actions;
            }
            catch (Exception i_E)
            {
                MessageBox.Show(string.Format("{0}{1}", UIMessages.k_RetriveErrActionMsg, i_E.Message));
            }
        }
    }
}