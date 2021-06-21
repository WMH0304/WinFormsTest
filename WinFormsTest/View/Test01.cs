using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinFormsTest.View
{
    public partial class Test01 : Form
    {
        public Test01()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 自适应函数
        /// </summary>
        /// <param name="levent"></param>
        protected override void OnLayout(LayoutEventArgs levent)
        {
            base.OnLayout(levent);
            int w = this.Width;
            int h = this.Height;

        }

        System.Collections.DictionaryBase t;
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("大王叫我来巡山");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="senger"></param>
        /// <param name="s"></param>
        private void test01(object senger,EventArgs s)
        {

        }

        private void Test01_Load(object sender, EventArgs e)
        {
            foreach ( var item in panel1.Controls)
            {
                if (item is Label)
                {
                    MessageBox.Show("werwr");
                }
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
