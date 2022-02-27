using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFacebook
{
    public class MenuItemUI : Label
    {
        private readonly Color r_ColorMouseHover = Color.Red;
        private readonly Color r_ColorMouseLeave = Color.Black;
        private WindowsFacebookLogic.MenuItem m_MenuItem;        

        public MenuItemUI(WindowsFacebookLogic.MenuItem i_MenuItem)
        {
            this.m_MenuItem = i_MenuItem;
            this.Text = i_MenuItem.Text;
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            m_MenuItem.Select();            
        }    

        protected override void OnMouseHover(EventArgs e)
        {
            if (m_MenuItem.ActionDelegate != null)
            {
                base.OnMouseHover(e);
                this.Font = new Font(this.Font, FontStyle.Bold | FontStyle.Underline);
                this.ForeColor = r_ColorMouseHover;
            }
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            if (m_MenuItem.ActionDelegate != null)
            {
                base.OnMouseLeave(e);
                this.Font = new Font(this.Font, FontStyle.Bold);
                this.ForeColor = r_ColorMouseLeave;
            }
        }
    }
}