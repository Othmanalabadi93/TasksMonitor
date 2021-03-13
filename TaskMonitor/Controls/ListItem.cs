using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TaskMonitor.Controls
{
    public partial class ListItem : UserControl
    {
        public ListItem()
        {
            InitializeComponent();
        }
        private string _title;
        private string _content;
        private Image _icon;
        private Color _bgColor;
        private Color _titleColor;
        private Color _contentColor;

        #region Properties
        [Category("Costom Props")]
        public string Title
        {
            get { return _title; }
            set { _title = value; lblTitle.Text = value; }
        }

        [Category("Costom Props")]
        public string Content
        {
            get { return _content; }
            set { _content = value; lblContent.Text = value; }
        }

        [Category("Costom Props")]
        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; picImage.Image = value; }
        }

        [Category("Costom Props")]
        public Color BackGroundColor
        {
            get { return _bgColor; }
            set { _bgColor = value; }
        }

        [Category("Costom Props")]
        public Color TitleColor
        {
            get { return _titleColor; }
            set { _titleColor = value; }
        }

        [Category("Costom Props")]
        public Color ContentColor
        {
            get { return _contentColor; }
            set { _contentColor = value; }
        }
        #endregion
    }
}
