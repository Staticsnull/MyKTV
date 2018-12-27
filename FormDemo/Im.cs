using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormDemo
{
    public partial class Im : DataGridView
    {
        public Im()
        {
            InitializeComponent();
        }
        public Image BackImage { get; set; }
        //重新此方法为DataGridView 添加背景色

        protected override void PaintBackground(Graphics graphics, Rectangle clipBounds, Rectangle gridBounds)
        {
            base.PaintBackground(graphics, clipBounds, gridBounds);
            if(BackImage != null)
            {
                graphics.DrawImage(BackImage, gridBounds);
            }
        }

    }
}
