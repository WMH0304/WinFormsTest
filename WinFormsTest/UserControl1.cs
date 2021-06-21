using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsTest
{
    public partial class UserControl1 : UserControl
    {
        private FarPoint.Win.Spread.FpSpread fpSpread2;
        private FarPoint.Win.Spread.SheetView sheet_test;
        private FarPoint.Win.Spread.FpSpread fpSpread1;

        public UserControl1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            FarPoint.Win.Spread.TipAppearance tipAppearance1 = new FarPoint.Win.Spread.TipAppearance();
            FarPoint.Win.Spread.TipAppearance tipAppearance2 = new FarPoint.Win.Spread.TipAppearance();
            FarPoint.Win.Spread.CellType.TextCellType textCellType1 = new FarPoint.Win.Spread.CellType.TextCellType();
            this.fpSpread1 = new FarPoint.Win.Spread.FpSpread();
            this.fpSpread2 = new FarPoint.Win.Spread.FpSpread();
            this.sheet_test = new FarPoint.Win.Spread.SheetView();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheet_test)).BeginInit();
            this.SuspendLayout();
            // 
            // fpSpread1
            // 
            this.fpSpread1.About = "3.0.2004.2005";
            this.fpSpread1.AccessibleDescription = "fpSpread1, Sheet, Row 0, Column 0, ";
            this.fpSpread1.BackColor = System.Drawing.SystemColors.Control;
            this.fpSpread1.Location = new System.Drawing.Point(0, 95);
            this.fpSpread1.Name = "fpSpread1";
            this.fpSpread1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fpSpread1.Size = new System.Drawing.Size(693, 455);
            this.fpSpread1.TabIndex = 0;
            tipAppearance1.BackColor = System.Drawing.SystemColors.Info;
            tipAppearance1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            tipAppearance1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.fpSpread1.TextTipAppearance = tipAppearance1;
            this.fpSpread1.ActiveSheetIndex = -1;
            // 
            // fpSpread2
            // 
            this.fpSpread2.About = "3.0.2004.2005";
            this.fpSpread2.AccessibleDescription = "fpSpread2, Sheet1, Row 0, Column 0, 收费项目";
            this.fpSpread2.BackColor = System.Drawing.SystemColors.Control;
            this.fpSpread2.Location = new System.Drawing.Point(3, 95);
            this.fpSpread2.Name = "fpSpread2";
            this.fpSpread2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.fpSpread2.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.sheet_test});
            this.fpSpread2.Size = new System.Drawing.Size(690, 455);
            this.fpSpread2.TabIndex = 1;
            tipAppearance2.BackColor = System.Drawing.SystemColors.Info;
            tipAppearance2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            tipAppearance2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.fpSpread2.TextTipAppearance = tipAppearance2;
            // 
            // sheet_test
            // 
            this.sheet_test.Reset();
            this.sheet_test.SheetName = "Sheet1";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.sheet_test.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            this.sheet_test.ColumnCount = 15;
            this.sheet_test.RowCount = 8;
            this.sheet_test.Cells.Get(0, 0).CellType = textCellType1;
            this.sheet_test.Cells.Get(0, 0).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.sheet_test.Cells.Get(0, 0).Locked = true;
            this.sheet_test.Cells.Get(0, 0).RowSpan = 2;
            this.sheet_test.Cells.Get(0, 0).Value = "收费项目";
            this.sheet_test.Cells.Get(0, 0).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.sheet_test.Cells.Get(0, 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.sheet_test.Cells.Get(0, 1).RowSpan = 2;
            this.sheet_test.Cells.Get(0, 1).Value = "单价";
            this.sheet_test.Cells.Get(0, 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.sheet_test.Cells.Get(0, 2).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.sheet_test.Cells.Get(0, 2).RowSpan = 2;
            this.sheet_test.Cells.Get(0, 2).Value = "数量";
            this.sheet_test.Cells.Get(0, 2).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.sheet_test.Cells.Get(0, 3).ColumnSpan = 10;
            this.sheet_test.Cells.Get(0, 3).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.sheet_test.Cells.Get(0, 3).Value = "金额";
            this.sheet_test.Cells.Get(0, 3).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.sheet_test.Cells.Get(1, 3).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.sheet_test.Cells.Get(1, 3).Value = "百";
            this.sheet_test.Cells.Get(1, 3).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.sheet_test.Cells.Get(1, 4).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.sheet_test.Cells.Get(1, 4).Value = "十";
            this.sheet_test.Cells.Get(1, 4).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.sheet_test.Cells.Get(1, 5).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.sheet_test.Cells.Get(1, 5).Value = "千";
            this.sheet_test.Cells.Get(1, 5).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.sheet_test.Cells.Get(1, 6).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.sheet_test.Cells.Get(1, 6).Value = "万";
            this.sheet_test.Cells.Get(1, 6).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.sheet_test.Cells.Get(1, 7).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.sheet_test.Cells.Get(1, 7).Value = "千";
            this.sheet_test.Cells.Get(1, 7).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.sheet_test.Cells.Get(1, 8).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.sheet_test.Cells.Get(1, 8).Value = "百";
            this.sheet_test.Cells.Get(1, 8).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.sheet_test.Cells.Get(1, 9).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
            this.sheet_test.Cells.Get(1, 9).Value = "十";
            this.sheet_test.Cells.Get(1, 9).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
            this.sheet_test.Cells.Get(1, 10).Value = "元";
            this.sheet_test.Cells.Get(1, 11).Value = "角";
            this.sheet_test.Cells.Get(1, 12).Value = "分";
            this.sheet_test.Columns.Get(0).Width = 164F;
            this.sheet_test.Columns.Get(1).Width = 81F;
            this.sheet_test.Columns.Get(2).Width = 99F;
            this.sheet_test.Columns.Get(3).Width = 36F;
            this.sheet_test.Columns.Get(4).Width = 30F;
            this.sheet_test.Columns.Get(5).Width = 30F;
            this.sheet_test.Columns.Get(6).Width = 31F;
            this.sheet_test.Columns.Get(7).Width = 26F;
            this.sheet_test.Columns.Get(8).Width = 23F;
            this.sheet_test.Columns.Get(9).Width = 23F;
            this.sheet_test.Columns.Get(10).Width = 24F;
            this.sheet_test.Columns.Get(11).Width = 23F;
            this.sheet_test.Columns.Get(12).Width = 23F;
            this.sheet_test.RowHeader.Columns.Default.Resizable = false;
            this.sheet_test.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // UserControl1
            // 
            this.Controls.Add(this.fpSpread2);
            this.Controls.Add(this.fpSpread1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1007, 589);
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fpSpread2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sheet_test)).EndInit();
            this.ResumeLayout(false);

        }
    }
}
