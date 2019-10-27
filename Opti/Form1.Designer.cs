namespace Opti
{
    partial class Form1
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartGolden = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartNewton = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewGolden = new System.Windows.Forms.DataGridView();
            this.dataGridViewNewton = new System.Windows.Forms.DataGridView();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.chartGoal = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridViewHalf = new System.Windows.Forms.DataGridView();
            this.chartHalf = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartGolden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartNewton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGolden)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNewton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGoal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHalf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHalf)).BeginInit();
            this.SuspendLayout();
            // 
            // chartGolden
            // 
            chartArea5.Name = "ChartAreaHalf";
            this.chartGolden.ChartAreas.Add(chartArea5);
            legend4.Name = "Legend1";
            this.chartGolden.Legends.Add(legend4);
            this.chartGolden.Location = new System.Drawing.Point(-61, 473);
            this.chartGolden.Name = "chartGolden";
            series12.ChartArea = "ChartAreaHalf";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series12.Legend = "Legend1";
            series12.Name = "l";
            series13.ChartArea = "ChartAreaHalf";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series13.Legend = "Legend1";
            series13.Name = "r";
            series14.ChartArea = "ChartAreaHalf";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series14.Legend = "Legend1";
            series14.Name = "x1";
            series15.ChartArea = "ChartAreaHalf";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series15.Legend = "Legend1";
            series15.Name = "x2";
            this.chartGolden.Series.Add(series12);
            this.chartGolden.Series.Add(series13);
            this.chartGolden.Series.Add(series14);
            this.chartGolden.Series.Add(series15);
            this.chartGolden.Size = new System.Drawing.Size(869, 585);
            this.chartGolden.TabIndex = 1;
            this.chartGolden.Text = "chart1";
            // 
            // chartNewton
            // 
            chartArea6.Name = "ChartAreaHalf";
            this.chartNewton.ChartAreas.Add(chartArea6);
            legend5.Name = "Legend1";
            this.chartNewton.Legends.Add(legend5);
            this.chartNewton.Location = new System.Drawing.Point(20, 0);
            this.chartNewton.Name = "chartNewton";
            series16.ChartArea = "ChartAreaHalf";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series16.Legend = "Legend1";
            series16.Name = "x0";
            series17.ChartArea = "ChartAreaHalf";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series17.Legend = "Legend1";
            series17.Name = "x1";
            this.chartNewton.Series.Add(series16);
            this.chartNewton.Series.Add(series17);
            this.chartNewton.Size = new System.Drawing.Size(869, 232);
            this.chartNewton.TabIndex = 2;
            this.chartNewton.Text = "chart1";
            // 
            // dataGridViewGolden
            // 
            this.dataGridViewGolden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewGolden.Location = new System.Drawing.Point(922, 591);
            this.dataGridViewGolden.Name = "dataGridViewGolden";
            this.dataGridViewGolden.Size = new System.Drawing.Size(460, 585);
            this.dataGridViewGolden.TabIndex = 4;
            // 
            // dataGridViewNewton
            // 
            this.dataGridViewNewton.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNewton.Location = new System.Drawing.Point(904, 0);
            this.dataGridViewNewton.Name = "dataGridViewNewton";
            this.dataGridViewNewton.Size = new System.Drawing.Size(368, 182);
            this.dataGridViewNewton.TabIndex = 5;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(0, 0);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 80);
            this.vScrollBar1.TabIndex = 6;
            // 
            // chartGoal
            // 
            chartArea7.Name = "ChartAreaGoal";
            this.chartGoal.ChartAreas.Add(chartArea7);
            this.chartGoal.Location = new System.Drawing.Point(12, 714);
            this.chartGoal.Name = "chartGoal";
            series18.ChartArea = "ChartAreaGoal";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series18.Name = "goal";
            this.chartGoal.Series.Add(series18);
            this.chartGoal.Size = new System.Drawing.Size(1335, 698);
            this.chartGoal.TabIndex = 7;
            this.chartGoal.Text = "chart1";
            title2.Name = "Title1";
            title2.Text = "Tikslo Funkcija";
            this.chartGoal.Titles.Add(title2);
            // 
            // dataGridViewHalf
            // 
            this.dataGridViewHalf.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHalf.Location = new System.Drawing.Point(873, 591);
            this.dataGridViewHalf.Name = "dataGridViewHalf";
            this.dataGridViewHalf.Size = new System.Drawing.Size(559, 418);
            this.dataGridViewHalf.TabIndex = 3;
            // 
            // chartHalf
            // 
            chartArea8.Name = "ChartAreaHalf";
            this.chartHalf.ChartAreas.Add(chartArea8);
            legend6.Name = "Legend1";
            this.chartHalf.Legends.Add(legend6);
            this.chartHalf.Location = new System.Drawing.Point(139, 502);
            this.chartHalf.Name = "chartHalf";
            series19.ChartArea = "ChartAreaHalf";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series19.EmptyPointStyle.IsValueShownAsLabel = true;
            series19.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series19.Legend = "Legend1";
            series19.LegendToolTip = "#VALX #VAL";
            series19.Name = "l";
            series20.ChartArea = "ChartAreaHalf";
            series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series20.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series20.Legend = "Legend1";
            series20.Name = "r";
            series21.ChartArea = "ChartAreaHalf";
            series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series21.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series21.Legend = "Legend1";
            series21.Name = "x1";
            series22.ChartArea = "ChartAreaHalf";
            series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series22.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series22.Legend = "Legend1";
            series22.Name = "x2";
            this.chartHalf.Series.Add(series19);
            this.chartHalf.Series.Add(series20);
            this.chartHalf.Series.Add(series21);
            this.chartHalf.Series.Add(series22);
            this.chartHalf.Size = new System.Drawing.Size(869, 418);
            this.chartHalf.TabIndex = 0;
            this.chartHalf.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1475, 719);
            this.Controls.Add(this.chartGoal);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.dataGridViewNewton);
            this.Controls.Add(this.dataGridViewGolden);
            this.Controls.Add(this.dataGridViewHalf);
            this.Controls.Add(this.chartNewton);
            this.Controls.Add(this.chartGolden);
            this.Controls.Add(this.chartHalf);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chartGolden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartNewton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewGolden)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNewton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartGoal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHalf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartHalf)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGolden;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartNewton;
        private System.Windows.Forms.DataGridView dataGridViewGolden;
        private System.Windows.Forms.DataGridView dataGridViewNewton;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartGoal;
        private System.Windows.Forms.DataGridView dataGridViewHalf;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartHalf;
    }
}

