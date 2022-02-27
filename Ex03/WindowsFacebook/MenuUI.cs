using System.Drawing;
using System.Windows.Forms;
using WindowsFacebookLogic;

namespace WindowsFacebook
{
    public class MenuUI : Panel
    {
        private const string k_DefaultFont = "Microsoft Sans Serif";
        private const int k_GapFromTop = 10;
        private const int k_MenuDefaultWidth = 170;
        private const int k_MenuDefaultHeight = 500;
        private const int k_GapBetweenMenuItems = 7;
        private const int k_GapBetweenNewSection = 15;
        private const int k_GapFromMenuTitle = 15;        
        private const int k_DefaultTitleFontSize = 12;
        private const int k_DefaultSectionFontSize = 10;
        private const int k_DefaultMenuItemSize = 9;
        private readonly Color r_DefaultBackgroundColor = Color.PowderBlue;
        private readonly Color r_DefaultColorTitles = Color.RoyalBlue;
        private WindowsFacebookLogic.Menu m_Menu;
        private int m_CurrentMenuItemHightPosition;
        private int m_TitleBottom;

        public MenuUI(WindowsFacebookLogic.Menu i_Menu) : this()
        {
            this.m_Menu = i_Menu;
        }

        public MenuUI()
        {
            this.Height = k_MenuDefaultHeight;
            this.Width = k_MenuDefaultWidth;
            this.m_TitleBottom = 0;
            this.BackColor = r_DefaultBackgroundColor;            
        }

        public WindowsFacebookLogic.Menu Menu
        {
            get
            {
                return m_Menu;
            }

            set
            {
                m_Menu = value;
                GenerateUIMenu();
            }
        }

        public void SetLocation(int i_X, int i_Y)
        {
            Location = new Point(i_X, i_Y);
        }

        public void GenerateUIMenu()
        {
            cleanPanel();
            addMenuTitle();
            addMenuItems();
        }

        private void addMenuTitle()
        {
            Label menuTitle = new Label();
            menuTitle.Text = m_Menu.MenuTitle;
            menuTitle.Font = new Font(k_DefaultFont, k_DefaultTitleFontSize, FontStyle.Bold | FontStyle.Underline);
            menuTitle.ForeColor = r_DefaultColorTitles;
            menuTitle.Location = new Point(0, k_GapFromTop);
            this.m_TitleBottom = menuTitle.Bottom;
            m_CurrentMenuItemHightPosition += m_TitleBottom + k_GapFromMenuTitle;
            menuTitle.Width = Width;
            menuTitle.TextAlign = ContentAlignment.MiddleCenter;
            this.Controls.Add(menuTitle);
        }

        private void addMenuItem(WindowsFacebookLogic.MenuItem i_MenuItem)
        {
            MenuItemUI currentMenuItemUI = new MenuItemUI(i_MenuItem);
            if(i_MenuItem is MenuItemSection)
            {
                currentMenuItemUI.Font = new Font(currentMenuItemUI.Font, FontStyle.Bold | FontStyle.Underline);
                currentMenuItemUI.ForeColor = r_DefaultColorTitles;
                currentMenuItemUI.Location = new Point(0, m_CurrentMenuItemHightPosition + k_GapBetweenNewSection);
                m_CurrentMenuItemHightPosition += currentMenuItemUI.Height + k_GapBetweenMenuItems;
            }
            else
            {
                currentMenuItemUI.Font = new Font(currentMenuItemUI.Font, FontStyle.Bold);
                currentMenuItemUI.Location = new Point(0, m_CurrentMenuItemHightPosition + k_GapBetweenMenuItems);
                m_CurrentMenuItemHightPosition += currentMenuItemUI.Height + k_GapBetweenMenuItems;
            }
            
            addControlToMenu(currentMenuItemUI);
        }

        private void addControlToMenu(MenuItemUI i_MenuItem)
        {
            i_MenuItem.Width = Width;
            i_MenuItem.TextAlign = ContentAlignment.MiddleCenter;            
            this.Controls.Add(i_MenuItem);
        }

        private void addMenuItems()
        {
            foreach (WindowsFacebookLogic.MenuItem currentMenuItem in m_Menu)
            {
                addMenuItem(currentMenuItem);
            }
        }

        public void RemoveMenuItem(WindowsFacebookLogic.MenuItem i_MenuItem)
        {
            m_Menu.Remove(i_MenuItem);
            GenerateUIMenu();
        }

        private int getXPositionForMenuItem(MenuItemUI i_MenuItem)
        {
            int centerOfMenuItem = i_MenuItem.Width / 2;
            int centerOfMenu = this.Width / 2;

            return centerOfMenu - centerOfMenuItem;
        }

        private int getYPositionForMenuItem()
        {
            return m_CurrentMenuItemHightPosition;
        }

        private void cleanPanel()
        {
            this.Controls.Clear();
        }
    }
}