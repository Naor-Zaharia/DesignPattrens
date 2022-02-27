using System.Drawing;
using System.Windows.Forms;
using WindowsFacebookLogic;
using static System.Windows.Forms.Control;

namespace WindowsFacebook
{
    public static class ThemeExecuter
    {
        private const string k_BackColorProp = "BackColor";
        private static readonly Color sr_DarkBlueTheme = SystemColors.Highlight;
        private static readonly Color sr_LightBlueTheme = Color.PowderBlue;
        private static readonly Color sr_DarkRedTheme = Color.LightCoral;
        private static readonly Color sr_LightRedTheme = Color.LightPink;
        private static readonly Color sr_DarkYellowTheme = Color.Yellow;
        private static readonly Color sr_LightYellowTheme = Color.LemonChiffon;

        public static void ChangeControlsThemeColor(LogicEnums.eThemeColor i_ThemeColor, ControlCollection i_ControlCollection)
        {
            switch (i_ThemeColor)
            {
                case LogicEnums.eThemeColor.Blue:
                    changeControlsThemeColor(i_ControlCollection, sr_DarkBlueTheme, sr_LightBlueTheme);
                    break;
                case LogicEnums.eThemeColor.Red:
                    changeControlsThemeColor(i_ControlCollection, sr_DarkRedTheme, sr_LightRedTheme);
                    break;
                case LogicEnums.eThemeColor.Yellow:
                    changeControlsThemeColor(i_ControlCollection, sr_DarkYellowTheme, sr_LightYellowTheme);
                    break;
            }
        }

        private static void changeControlsThemeColor(ControlCollection i_ControlCollection, Color i_DarkThemeColor, Color i_LightThemeColor)
        {
            foreach (Control currentControl in i_ControlCollection)
            {
                if (currentControl.GetType().GetProperty(k_BackColorProp) != null && !(currentControl is Button))
                {
                    currentControl.BackColor = i_LightThemeColor;
                }
                else
                {
                    currentControl.BackColor = i_DarkThemeColor;
                }
            }
        }
    }
}