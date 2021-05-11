using System.Drawing;

namespace TaskMonitor.Styles
{
    public class TaskExclamationStyle : CustomColor
    {
        public TaskExclamationStyle(Color FormBackColor)
        {
            Color clr = Color.FromArgb(255, 255, 128);
            TitleColor = clr;
            BackgoundFormColor = FormBackColor;
            LineColor = clr;
            IconColor = clr;
            IconChar = FontAwesome.Sharp.IconChar.CheckCircle;
        }
    }
}
