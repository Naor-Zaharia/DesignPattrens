using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using WindowsFacebookLogic;
using static FacebookWrapper.ObjectModel.User;

namespace WindowsFacebook
{
    public partial class SoulMateForm : Form
    {
        private const string k_RetriveErrMsg = "Cann't retrive - soul mate due to facebook security issues";
        private AppManager m_AppManager = AppManager.AppManagerInstance();
        private eGender m_SoulMateGender;

        public SoulMateForm()
        {
            InitializeComponent();
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            pictureBoxSoulMate.SizeMode = PictureBoxSizeMode.StretchImage;
            initSoulMateGender();
        }

        private void initSoulMateGender()
        {
            if (radioButtonFemale.Checked)
            {
                m_SoulMateGender = eGender.female;
            }
            else
            {
                m_SoulMateGender = eGender.male;
            }
        }

        private User getUserSoulMate()
        {
            User user = null;
            int maximalUserScore = -1;

            foreach (User currentUser in m_AppManager.LoginUser().Friends)
            {
                if (currentUser.Gender == m_SoulMateGender)
                {
                    int currentUserScore = SoulMateLogic.GetUserScore(m_AppManager.LoginUser(), currentUser);
                    if (currentUserScore > maximalUserScore)
                    {
                        maximalUserScore = currentUserScore;
                        user = currentUser;
                    }
                }
            }

            return user;
        }

        private void buttonSubmit_Click(object sender, EventArgs e)
        {
            User soulMateUser = getUserSoulMate();
            if (soulMateUser != null)
            {
                labelSoulMateName.Text = soulMateUser.Name;
                pictureBoxSoulMate.LoadAsync(soulMateUser.PictureNormalURL);
            }
            else
            {
                labelSoulMateName.Text = k_RetriveErrMsg;
            }
        }

        private void radioButtonMale_CheckedChanged(object sender, EventArgs e)
        {
            m_SoulMateGender = eGender.male;
        }

        private void radioButtonFemale_CheckedChanged(object sender, EventArgs e)
        {
            m_SoulMateGender = eGender.female;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
