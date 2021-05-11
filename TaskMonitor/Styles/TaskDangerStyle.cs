using System.Drawing;

namespace TaskMonitor.Styles
{
    public class TaskDangerStyle : CustomColor
    {
        public TaskDangerStyle(Color FormBackColor)
        {
            Color clr = Color.Red;
            TitleColor = clr;
            BackgoundFormColor = FormBackColor;
            LineColor = clr;
            IconColor = clr;
            IconChar = FontAwesome.Sharp.IconChar.Circle;
        }
    }
}
