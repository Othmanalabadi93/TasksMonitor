using System.Drawing;

namespace TaskMonitor.Styles
{
    public class TaskSuccessfulyStyle : CustomColor
    {
        public TaskSuccessfulyStyle(Color FormBackColor)
        {
            Color clr= Color.FromArgb(128, 255, 128);
            TitleColor = clr;
            BackgoundFormColor = FormBackColor;
            LineColor = clr;
            IconColor = clr;
            IconChar = FontAwesome.Sharp.IconChar.Check;
        }
    }
}
