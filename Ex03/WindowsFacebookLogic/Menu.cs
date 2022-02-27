using System.Collections.Generic;

namespace WindowsFacebookLogic
{
   public class Menu : List<MenuItem>
    {
        public Menu()
        {
        }

        public string MenuTitle { get; set; }

        public void AddMenuItems(List<MenuItem> i_MenuItems)
        {
            foreach (MenuItem currentMenuItem in i_MenuItems)
            {
                AddMenuItem(currentMenuItem);
            }
        }

        public void AddMenuItem(MenuItem i_MenuItem)
        {
            this.Add(i_MenuItem);
        }

        public void RemoveFromMenu(MenuItem i_MenuItem)
        {
            this.Remove(i_MenuItem);
        }
    }
}