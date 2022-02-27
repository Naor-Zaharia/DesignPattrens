using System;

namespace WindowsFacebookLogic
{
    public class MenuItem
    {
        public MenuItem(Action i_Action, string i_MenuItemText)
        {
            this.Text = i_MenuItemText;
            this.ActionDelegate = i_Action;
        }

        public Action ActionDelegate { get; set; }

        public string Text { get; set; }

        protected virtual void OnSelect()
        {
            if (ActionDelegate != null)
            {
                ActionDelegate.Invoke();
            }
        }

        public void Select()
        {
            OnSelect();
        }
    }
}