
namespace WinFormsTest.View
{
    partial class test01
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            HZH_Controls.Controls.RadarLine radarLine1 = new HZH_Controls.Controls.RadarLine();
            HZH_Controls.Controls.RadarLine radarLine2 = new HZH_Controls.Controls.RadarLine();
            HZH_Controls.Controls.RadarPosition radarPosition1 = new HZH_Controls.Controls.RadarPosition();
            HZH_Controls.Controls.RadarPosition radarPosition2 = new HZH_Controls.Controls.RadarPosition();
            HZH_Controls.Controls.RadarPosition radarPosition3 = new HZH_Controls.Controls.RadarPosition();
            HZH_Controls.Controls.RadarPosition radarPosition4 = new HZH_Controls.Controls.RadarPosition();
            HZH_Controls.Controls.RadarPosition radarPosition5 = new HZH_Controls.Controls.RadarPosition();
            HZH_Controls.Controls.RadarPosition radarPosition6 = new HZH_Controls.Controls.RadarPosition();
            this.ucRadarChart1 = new HZH_Controls.Controls.UCRadarChart();
            this.SuspendLayout();
            // 
            // ucRadarChart1
            // 
            this.ucRadarChart1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            radarLine1.FillColor = null;
            radarLine1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            radarLine1.Name = "line0";
            radarLine1.ShowValueText = false;
            radarLine1.Values = new double[] {
        69D,
        94D,
        82D,
        75D,
        78D,
        59D};
            radarLine2.FillColor = null;
            radarLine2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(39)))), ((int)(((byte)(176)))));
            radarLine2.Name = "line1";
            radarLine2.ShowValueText = false;
            radarLine2.Values = new double[] {
        92D,
        99D,
        23D,
        35D,
        79D,
        71D};
            this.ucRadarChart1.Lines = new HZH_Controls.Controls.RadarLine[] {
        radarLine1,
        radarLine2};
            this.ucRadarChart1.Location = new System.Drawing.Point(161, 91);
            this.ucRadarChart1.Name = "ucRadarChart1";
            radarPosition1.MaxValue = 100D;
            radarPosition1.Text = "Item1";
            radarPosition2.MaxValue = 100D;
            radarPosition2.Text = "Item2";
            radarPosition3.MaxValue = 100D;
            radarPosition3.Text = "Item3";
            radarPosition4.MaxValue = 100D;
            radarPosition4.Text = "Item4";
            radarPosition5.MaxValue = 100D;
            radarPosition5.Text = "Item5";
            radarPosition6.MaxValue = 100D;
            radarPosition6.Text = "Item6";
            this.ucRadarChart1.RadarPositions = new HZH_Controls.Controls.RadarPosition[] {
        radarPosition1,
        radarPosition2,
        radarPosition3,
        radarPosition4,
        radarPosition5,
        radarPosition6};
            this.ucRadarChart1.Size = new System.Drawing.Size(625, 415);
            this.ucRadarChart1.SplitCount = 5;
            this.ucRadarChart1.SplitEvenColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(232)))), ((int)(((byte)(232)))));
            this.ucRadarChart1.SplitOddColor = System.Drawing.Color.White;
            this.ucRadarChart1.TabIndex = 0;
            this.ucRadarChart1.Title = null;
            this.ucRadarChart1.TitleColor = System.Drawing.Color.Black;
            this.ucRadarChart1.TitleFont = new System.Drawing.Font("微软雅黑", 12F);
            this.ucRadarChart1.UseRoundSplit = false;
            // 
            // test01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 651);
            this.Controls.Add(this.ucRadarChart1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "test01";
            this.Text = "test01";
            this.Load += new System.EventHandler(this.FormTest01_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private HZH_Controls.Controls.UCRadarChart ucRadarChart1;
    }
}