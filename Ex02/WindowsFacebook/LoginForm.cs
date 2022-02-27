using System;
using System.Windows.Forms;
using FacebookWrapper;
using WindowsFacebookLogic;

namespace WindowsFacebook
{
    public partial class LoginForm : Form
    {
        private const string k_AppIDToken = "300984557640514";
        private LoginResult m_LoginResult;

        public LoginForm()
        {
            InitializeComponent();
            checkForQuickLogin();
        }

        private void checkForQuickLogin()
        {
            AppSettings appSettings = AppSettings.LoadFromFile();
            AppManagerFacade appManager = AppManagerFacade.AppManagerFacadeInstance();
            m_LoginResult = appManager.CheckForQuickLogin();
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
                AppManagerFacade appManager = AppManagerFacade.AppManagerFacadeInstance();
                m_LoginResult = appManager.LoginAndInit(k_AppIDToken);
                if (m_LoginResult.AccessToken != null)
                {
                    showMainMenu();
                }
            }
            catch (Exception i_E)
            {
                MessageBox.Show(string.Format("{0}{1}", UIMessages.k_ConnectErrMsg, i_E.Message));
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