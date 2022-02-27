using System;
using System.Windows.Forms;
using FacebookWrapper;
using WindowsFacebookLogic;

namespace WindowsFacebook
{
    public partial class LoginForm : Form
    {
        private const string k_AppIDToken = "300984557640514";
        private const string k_ConnectErrMsg = "Had issue to connect facebook: ";
        private LoginResult m_LoginResult;

        public LoginForm()
        {
            InitializeComponent();
            checkForQuickLogin();
        }

        private void checkForQuickLogin()
        {
            AppSettings m_AppSettings = AppSettings.LoadFromFile();
            m_LoginResult = FacebookLoginLogic.CheckForQuickLogin();
            if (m_LoginResult != null)
            {
                showMainMenu();
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            exitApp();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            loginAndInit();
        }

        private void loginAndInit()
        {
            try
            {
                m_LoginResult = FacebookLoginLogic.LoginAndInit(k_AppIDToken);
                if (m_LoginResult.AccessToken != null)
                {
                    showMainMenu();
                }
            }
            catch (Exception i_E)
            {
                MessageBox.Show(string.Format("{0}{1}", k_ConnectErrMsg, i_E.Message));
                this.Close();
            }
        }

        private void showMainMenu()
        {
            MainMenuForm mainMenuForm = new MainMenuForm();
            this.Hide();
            mainMenuForm.ShowDialog();
            this.Close();
        }

        private void exitApp()
        {
            this.Close();
        }
    }
}
