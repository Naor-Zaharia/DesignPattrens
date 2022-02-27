using System;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using WindowsFacebookLogic;

namespace WindowsFacebook
{
    public partial class MyProfileForm : Form
    {
        private const string k_MaleStr = "Male";
        private const string k_FemaleStr = "Female";
        private AppManager m_AppManager = AppManager.AppManagerInstance();

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
            User loggedInUser = m_AppManager.LoginUser();
            textBoxFirstName.Text = loggedInUser.FirstName;
            textBoxLastName.Text = loggedInUser.LastName;
            textBoxGender.Text = loggedInUser.Gender == User.eGender.male ? k_MaleStr : k_FemaleStr;
            textBoxBirthday.Text = loggedInUser.Birthday;
            textBoxEmail.Text = loggedInUser.Email;
            textBoxLocation.Text = loggedInUser.Location.Name;
            try
            {
                if (loggedInUser.Educations != null)
                {
                    textBoxEducation.Text = getEducationString(loggedInUser.Educations);
                }
            }
            catch
            { 
            }

            textBoxAbout.Text = loggedInUser.About;
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

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            User loggedInUser = m_AppManager.LoginUser();
            loggedInUser.FirstName = textBoxFirstName.Text;
            loggedInUser.LastName = textBoxLastName.Text;
            loggedInUser.Birthday = textBoxBirthday.Text;
            loggedInUser.Email = textBoxEmail.Text;
            loggedInUser.About = textBoxAbout.Text;
        }
    }
}
