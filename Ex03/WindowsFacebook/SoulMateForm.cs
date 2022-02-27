using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using WindowsFacebookLogic;
using static FacebookWrapper.ObjectModel.User;

namespace WindowsFacebook
{
    public partial class SoulMateForm : Form
    {
        private AppManagerFacade m_AppManagerFacade = AppManagerFacade.AppManagerFacadeInstance();
        private eGender m_SoulMateGender;

        public SoulMateForm()
        {
            InitializeComponent();
            m_AppManagerFacade.ThemeChanged += appManagerFacadeThemeChanged;
        }

        private void appManagerFacadeThemeChanged(LogicEnums.eThemeColor i_ThemeColor)
        {
            ThemeExecuter.ChangeControlsThemeColor(i_ThemeColor, Controls);
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            pictureBoxSoulMate.SizeMode = PictureBoxSizeMode.StretchImage;
            ThemeExecuter.ChangeControlsThemeColor(m_AppManagerFacade.ThemeColor, Controls);
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

            foreach (User currentUser in m_AppManagerFacade.Friends)
            {
                if (currentUser.Gender == m_SoulMateGender)
                {
                    int currentUserScore = m_AppManagerFacade.GetUserScore(m_AppManagerFacade.LoginUser(), currentUser);
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
                labelSoulMateName.Text = UIMessages.k_RetriveErrSoulMateMsg;
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