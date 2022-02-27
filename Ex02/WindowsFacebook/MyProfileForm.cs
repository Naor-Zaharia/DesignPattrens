using System;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using WindowsFacebookLogic;

namespace WindowsFacebook
{
    public partial class MyProfileForm : Form
    {
        private AppManagerFacade m_AppManagerFacade = AppManagerFacade.AppManagerFacadeInstance();

        public MyProfileForm()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            fetchProfile();
        }

        private void fetchProfile()
        {
            User loggedInUser = m_AppManagerFacade.LoginUser();
            userBindingSource.DataSource = loggedInUser;
        }

        private string getEducationString(Education[] i_Educations)
        {
            StringBuilder educationString = new StringBuilder();
            foreach (Education currentEducation in i_Educations)
            {
                educationString.AppendFormat("{0}, ", currentEducation.School.Name);
            }

            return educationString.ToString();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
