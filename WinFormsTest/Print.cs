using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Forms;

namespace WinFormsTest
{
    public partial class Print : UserControl
    {
        public Print()
        {
            InitializeComponent();
            this.dy.Click += uiLabel17_Click;
            
        }

        /// <summary>
        /// 打印事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
           // Image image;
            Bitmap image = new Bitmap(this.Width,this.Height);
            Graphics g = Graphics.FromImage(image);
            Print print = new Print();
            print.Margin = new Padding(10); //new Thickness(5);
            print.DrawToBitmap(image,new Rectangle(0,0,image.Width,image.Height));
            e.Graphics.DrawImage(image,0,0,image.Width,image.Height);
            
        }

        private void uiLabel17_Click(object sender, EventArgs e)
        {

        }

        private void uiLabel10_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 打印设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dysz_Click(object sender, EventArgs e)
        {

            
            this.pageSetupDialog.ShowDialog();
        }

        /// <summary>
        /// 打印预览
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dyyl_Click(object sender, EventArgs e)
        {
            this.printPreviewDialog.ShowDialog();
        }

        /// <summary>
        /// 打印
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dy_Click(object sender, EventArgs e)
        {
            var t = 0;
            foreach (var item in this.Controls)
            {
                if (item is Label)
                {
                    t++;
                }
            }
            if (this.printDialog.ShowDialog() ==DialogResult.OK)
            {
                this.printDocument.Print();
            }
        }
    }
}
