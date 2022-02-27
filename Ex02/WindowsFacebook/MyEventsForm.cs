using System;
using System.Collections.Generic;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using WindowsFacebookLogic;

namespace WindowsFacebook
{
    public partial class MyEventsForm : Form
    {
        private AppManagerFacade m_AppManagerFacade = AppManagerFacade.AppManagerFacadeInstance();
        private List<Event> m_Events;

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
            m_Events = m_AppManagerFacade.SortEvent(LogicEnums.eSortType.AlphabeticSort, m_AppManagerFacade.Events);
            fetchEvents();
        }

        private void fetchEvents()
        {
            eventBindingSource.DataSource = m_Events;
        }

        private void radioButtonAlphabetic_CheckedChanged(object sender, EventArgs e)
        {
            m_Events = m_AppManagerFacade.SortEvent(LogicEnums.eSortType.AlphabeticSort, m_AppManagerFacade.Events);
            fetchEvents();
        }

        private void radioButtonCounter_CheckedChanged(object sender, EventArgs e)
        {
            m_Events = m_AppManagerFacade.SortEvent(LogicEnums.eSortType.CounterSort, m_AppManagerFacade.Events);
            fetchEvents();
        }

        private void radioButtonDate_CheckedChanged(object sender, EventArgs e)
        {
            m_Events = m_AppManagerFacade.SortEvent(LogicEnums.eSortType.DateSort, m_AppManagerFacade.Events);
            fetchEvents();
        }
    }
}
