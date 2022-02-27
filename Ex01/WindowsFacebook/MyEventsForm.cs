using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using WindowsFacebookLogic;

namespace WindowsFacebook
{
    public partial class MyEventsForm : Form
    {
        private const string k_NameStr = "Name";
        private const string k_NotRetriveMsg = "No events to retrieve";
        private const string k_IssueToRetriveMsg = "Had issues to retrive events from facebook servers: ";
        private AppManager m_AppManager = AppManager.AppManagerInstance();

        public MyEventsForm()
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
            fetchEvents();
        }

        private void fetchEvents()
        {
            listBoxEvents.Items.Clear();
            listBoxEvents.DisplayMember = k_NameStr;
            try
            {
                foreach (Event currentEvent in m_AppManager.LoginUser().Events)
                {
                    listBoxEvents.Items.Add(currentEvent.Name);
                }

                if (m_AppManager.LoginUser().Events.Count == 0)
                {
                    listBoxEvents.Items.Add(k_NotRetriveMsg);
                }
            }
            catch (Exception i_E)
            {
                listBoxEvents.Items.Add(k_IssueToRetriveMsg);
                listBoxEvents.Items.Add(i_E.Message);
            }
        }
    }
}
