using System;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace WindowsFacebook
{
    public partial class UserActionsForm : Form
    {
        private const string k_RetriveErrMsg = "Had issues to connect facebook server: ";

        public UserActionsForm()
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
                MessageBox.Show(string.Format("{0}{1}", k_RetriveErrMsg, i_E.Message));
            }
        }
    }
}
