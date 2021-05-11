using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Text;

namespace TaskMonitor.Styles
{
    public class CustomColor
    {
        [Required]
        public Color TitleColor { get; set; }
        public Color BackgoundFormColor { get; set; }
        public Color LineColor { get; set; }
        public FontAwesome.Sharp.IconChar IconChar;
        public Color IconColor;

    }
}
