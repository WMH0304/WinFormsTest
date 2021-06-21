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
    public partial class comBox : Form
    {
        public comBox()
        {
            InitializeComponent();
        }
        class Test
        {
            public int id { get; set; }

            public string name { get; set; }

        }


        /// <summary>
        /// 加载时间
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ucCombox1_SelectedChangedEvent(object sender, EventArgs e)
        {
            List<Test> tests = new List<Test>()
            {
                new Test(){ id =1,name="11111"},
                new Test(){id =2,name ="22222"},
                new Test(){id =3,name ="33333"},
                new Test(){id =4,name ="44444"},
                new Test(){id =5,name ="55555"}
            };
            comboBox1.DataSource = tests;
            comboBox1.ValueMember = "id";
            comboBox1.DisplayMember = "name";
            Test test = comboBox1.SelectedItem as Test;


            



        }
    }
}
