using System;
using System.Windows.Forms;
using HZH_Controls.Controls;
using System.Collections.Generic;
namespace WinFormsTest.View
{
    public partial class DataGridTest : Form
    {

        class DataTest
        {
            public int id { get; set; }
            public string name { get; set; }

            public string old { get; set; }

            public string sex { get; set; }

            public string addSet { get; set; }
            
        }

        
        public DataGridTest()
        {
            for (int i = 0; i < 10; i++)
            {
                dt.Add(new DataTest() { id= i ,name = "小米" + i, old = "5岁" + i, sex = i % 2 == 0 ? "公的" : "母的", addSet = i + "号快乐星球" });
            }
            InitializeComponent();
        }
        System.Collections.Generic.List<DataTest> dt = new System.Collections.Generic.List<DataTest>();
        /// <summary>
        /// 页面加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataGridTest_Load(object sender, EventArgs e)
        {
            //原生 
            dataGridView1.DataSource = dt;

            // hzh
            List<DataGridViewColumnEntity> lstCulumns = new List<DataGridViewColumnEntity>();
            lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "id", HeadText = "id", Width = 50, WidthType = SizeType.Percent });
            lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "name", HeadText = "name", Width = 50, WidthType = SizeType.Percent });
            lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "old", HeadText = "old", Width = 50, WidthType = SizeType.Percent });
            lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "sex", HeadText = "sex", Width = 50, WidthType = SizeType.Percent });
            lstCulumns.Add(new DataGridViewColumnEntity() { DataField = "addSet", HeadText = "addSet", Width = 50, WidthType = SizeType.Percent });
            this.ucDataGridView1.Columns = lstCulumns;
            this.ucDataGridView1.IsShowCheckBox = true;
            
            ucDataGridView1.DataSource = dt;

            //sunnyui
            uiDataGridView1.DataSource = dt;

            //
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
     
        private void DataGridView1_MouseEnter(object sender, System.EventArgs e)
        {
            int it = this.dataGridView1.CurrentRow.Index;
            var t = dt[it];
            MessageBox.Show($"{t.id},{t.name},{t.old}");
        }

        private void DataGridView1_CellMouseClick(object sender, System.Windows.Forms.DataGridViewCellMouseEventArgs e)
        {
            int it = this.dataGridView1.CurrentRow.Index;
            var t = dt[it];
            MessageBox.Show($"{t.id},{t.name},{t.old}");
        }

    }
}
