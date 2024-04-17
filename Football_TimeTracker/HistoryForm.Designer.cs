namespace Football_TimeTracker
{
    partial class HistoryForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HistoryForm));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TotalGameTimeLabel = new System.Windows.Forms.Label();
            this.StateGoalTimer = new System.Windows.Forms.Label();
            this.StateRefBlowTimer = new System.Windows.Forms.Label();
            this.StateOutofBoundsTimer = new System.Windows.Forms.Label();
            this.StateActiveTimer = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.PieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.BarChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.averageGoalSegmentResult = new System.Windows.Forms.Label();
            this.averageStoppedSegmentResult = new System.Windows.Forms.Label();
            this.averageActiveSegmentResult = new System.Windows.Forms.Label();
            this.biggestStoppedSegmentResult = new System.Windows.Forms.Label();
            this.biggestActiveSegmentResult = new System.Windows.Forms.Label();
            this.totalSegmentsResult = new System.Windows.Forms.Label();
            this.averageGoalSegmentLabel = new System.Windows.Forms.Label();
            this.averageStoppedSegmentLabel = new System.Windows.Forms.Label();
            this.biggestStoppedSegmentLabel = new System.Windows.Forms.Label();
            this.averageActiveSegmentLabel = new System.Windows.Forms.Label();
            this.biggestActiveSegmentLabel = new System.Windows.Forms.Label();
            this.totalSegmentsLabel = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.FullPath = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectedCheckbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.GameName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CompetitionName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GameDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BackButton = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarChart)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(883, 14);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(450, 495);
            this.tabControl1.TabIndex = 30;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DimGray;
            this.tabPage1.Controls.Add(this.TotalGameTimeLabel);
            this.tabPage1.Controls.Add(this.StateGoalTimer);
            this.tabPage1.Controls.Add(this.StateRefBlowTimer);
            this.tabPage1.Controls.Add(this.StateOutofBoundsTimer);
            this.tabPage1.Controls.Add(this.StateActiveTimer);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(442, 469);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Texto";
            // 
            // TotalGameTimeLabel
            // 
            this.TotalGameTimeLabel.AutoSize = true;
            this.TotalGameTimeLabel.BackColor = System.Drawing.Color.DimGray;
            this.TotalGameTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalGameTimeLabel.Location = new System.Drawing.Point(354, 390);
            this.TotalGameTimeLabel.Name = "TotalGameTimeLabel";
            this.TotalGameTimeLabel.Size = new System.Drawing.Size(82, 31);
            this.TotalGameTimeLabel.TabIndex = 30;
            this.TotalGameTimeLabel.Text = "00:00";
            this.TotalGameTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StateGoalTimer
            // 
            this.StateGoalTimer.AutoSize = true;
            this.StateGoalTimer.BackColor = System.Drawing.Color.LightSkyBlue;
            this.StateGoalTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateGoalTimer.Location = new System.Drawing.Point(354, 300);
            this.StateGoalTimer.Name = "StateGoalTimer";
            this.StateGoalTimer.Size = new System.Drawing.Size(82, 31);
            this.StateGoalTimer.TabIndex = 28;
            this.StateGoalTimer.Text = "00:00";
            this.StateGoalTimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StateRefBlowTimer
            // 
            this.StateRefBlowTimer.AutoSize = true;
            this.StateRefBlowTimer.BackColor = System.Drawing.Color.Salmon;
            this.StateRefBlowTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateRefBlowTimer.Location = new System.Drawing.Point(354, 210);
            this.StateRefBlowTimer.Name = "StateRefBlowTimer";
            this.StateRefBlowTimer.Size = new System.Drawing.Size(82, 31);
            this.StateRefBlowTimer.TabIndex = 27;
            this.StateRefBlowTimer.Text = "00:00";
            this.StateRefBlowTimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StateOutofBoundsTimer
            // 
            this.StateOutofBoundsTimer.AutoSize = true;
            this.StateOutofBoundsTimer.BackColor = System.Drawing.Color.Yellow;
            this.StateOutofBoundsTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateOutofBoundsTimer.Location = new System.Drawing.Point(354, 120);
            this.StateOutofBoundsTimer.Name = "StateOutofBoundsTimer";
            this.StateOutofBoundsTimer.Size = new System.Drawing.Size(82, 31);
            this.StateOutofBoundsTimer.TabIndex = 26;
            this.StateOutofBoundsTimer.Text = "00:00";
            this.StateOutofBoundsTimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StateActiveTimer
            // 
            this.StateActiveTimer.AutoSize = true;
            this.StateActiveTimer.BackColor = System.Drawing.Color.SpringGreen;
            this.StateActiveTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateActiveTimer.Location = new System.Drawing.Point(354, 30);
            this.StateActiveTimer.Name = "StateActiveTimer";
            this.StateActiveTimer.Size = new System.Drawing.Size(82, 31);
            this.StateActiveTimer.TabIndex = 25;
            this.StateActiveTimer.Text = "00:00";
            this.StateActiveTimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(446, 90);
            this.label6.TabIndex = 24;
            this.label6.Text = "Golo / Celebração / Revisão:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Salmon;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(446, 90);
            this.label5.TabIndex = 23;
            this.label5.Text = "Arbitro interrompeu jogo:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(446, 90);
            this.label4.TabIndex = 22;
            this.label4.Text = "Bola fora do terreno de jogo:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.SpringGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(446, 90);
            this.label3.TabIndex = 21;
            this.label3.Text = "Jogo a seguir:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.DimGray;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(446, 90);
            this.label8.TabIndex = 29;
            this.label8.Text = "Tempo Total de jogo:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DimGray;
            this.tabPage2.Controls.Add(this.PieChart);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(442, 469);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Gráfico Circular";
            // 
            // PieChart
            // 
            this.PieChart.BackColor = System.Drawing.Color.DimGray;
            this.PieChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PieChart.BorderlineColor = System.Drawing.SystemColors.Desktop;
            chartArea1.BackColor = System.Drawing.Color.DimGray;
            chartArea1.Name = "ChartArea1";
            this.PieChart.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.DimGray;
            legend1.Name = "Legend1";
            this.PieChart.Legends.Add(legend1);
            this.PieChart.Location = new System.Drawing.Point(0, 0);
            this.PieChart.Name = "PieChart";
            series1.BackSecondaryColor = System.Drawing.Color.DimGray;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Color = System.Drawing.Color.DimGray;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            dataPoint1.Color = System.Drawing.Color.SpringGreen;
            dataPoint1.IsValueShownAsLabel = false;
            dataPoint1.MarkerColor = System.Drawing.Color.Empty;
            dataPoint2.Color = System.Drawing.Color.Yellow;
            dataPoint2.IsValueShownAsLabel = false;
            dataPoint3.Color = System.Drawing.Color.Salmon;
            dataPoint3.IsValueShownAsLabel = false;
            dataPoint4.Color = System.Drawing.Color.LightSkyBlue;
            dataPoint4.IsValueShownAsLabel = false;
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series1.SmartLabelStyle.Enabled = false;
            this.PieChart.Series.Add(series1);
            this.PieChart.Size = new System.Drawing.Size(446, 473);
            this.PieChart.TabIndex = 0;
            this.PieChart.Text = "Gráfico Circular";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DimGray;
            this.tabPage3.Controls.Add(this.BarChart);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(442, 469);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "Gráfico de Barras";
            // 
            // BarChart
            // 
            this.BarChart.BackColor = System.Drawing.Color.DimGray;
            chartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Enabled = false;
            chartArea2.AxisY.Title = "Minutos";
            chartArea2.BackColor = System.Drawing.Color.DimGray;
            chartArea2.Name = "ChartArea1";
            this.BarChart.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.DimGray;
            legend2.Name = "Legend1";
            this.BarChart.Legends.Add(legend2);
            this.BarChart.Location = new System.Drawing.Point(-4, 0);
            this.BarChart.Name = "BarChart";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.SpringGreen;
            series2.Legend = "Legend1";
            series2.Name = "A seguir";
            dataPoint5.Color = System.Drawing.Color.SpringGreen;
            dataPoint5.Label = "";
            dataPoint5.LabelFormat = "";
            dataPoint5.LabelToolTip = "";
            dataPoint5.LegendText = "";
            dataPoint5.LegendToolTip = "";
            dataPoint6.Color = System.Drawing.Color.Yellow;
            dataPoint7.Color = System.Drawing.Color.Salmon;
            dataPoint8.Color = System.Drawing.Color.LightSkyBlue;
            series2.Points.Add(dataPoint5);
            series2.Points.Add(dataPoint6);
            series2.Points.Add(dataPoint7);
            series2.Points.Add(dataPoint8);
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.Yellow;
            series3.Legend = "Legend1";
            series3.Name = "Bola fora";
            series4.ChartArea = "ChartArea1";
            series4.Color = System.Drawing.Color.Salmon;
            series4.Legend = "Legend1";
            series4.Name = "Arbitro apita";
            series5.ChartArea = "ChartArea1";
            series5.Color = System.Drawing.Color.LightSkyBlue;
            series5.Legend = "Legend1";
            series5.Name = "Golo";
            this.BarChart.Series.Add(series2);
            this.BarChart.Series.Add(series3);
            this.BarChart.Series.Add(series4);
            this.BarChart.Series.Add(series5);
            this.BarChart.Size = new System.Drawing.Size(450, 473);
            this.BarChart.TabIndex = 0;
            this.BarChart.Text = "chart1";
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.DimGray;
            this.tabPage4.Controls.Add(this.averageGoalSegmentResult);
            this.tabPage4.Controls.Add(this.averageStoppedSegmentResult);
            this.tabPage4.Controls.Add(this.averageActiveSegmentResult);
            this.tabPage4.Controls.Add(this.biggestStoppedSegmentResult);
            this.tabPage4.Controls.Add(this.biggestActiveSegmentResult);
            this.tabPage4.Controls.Add(this.totalSegmentsResult);
            this.tabPage4.Controls.Add(this.averageGoalSegmentLabel);
            this.tabPage4.Controls.Add(this.averageStoppedSegmentLabel);
            this.tabPage4.Controls.Add(this.biggestStoppedSegmentLabel);
            this.tabPage4.Controls.Add(this.averageActiveSegmentLabel);
            this.tabPage4.Controls.Add(this.biggestActiveSegmentLabel);
            this.tabPage4.Controls.Add(this.totalSegmentsLabel);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(442, 469);
            this.tabPage4.TabIndex = 2;
            this.tabPage4.Text = "Outras Estatísticas";
            // 
            // averageGoalSegmentResult
            // 
            this.averageGoalSegmentResult.BackColor = System.Drawing.Color.LightSkyBlue;
            this.averageGoalSegmentResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageGoalSegmentResult.Location = new System.Drawing.Point(-1, 418);
            this.averageGoalSegmentResult.Name = "averageGoalSegmentResult";
            this.averageGoalSegmentResult.Size = new System.Drawing.Size(443, 38);
            this.averageGoalSegmentResult.TabIndex = 12;
            this.averageGoalSegmentResult.Text = "00:00";
            this.averageGoalSegmentResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // averageStoppedSegmentResult
            // 
            this.averageStoppedSegmentResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageStoppedSegmentResult.Location = new System.Drawing.Point(-1, 342);
            this.averageStoppedSegmentResult.Name = "averageStoppedSegmentResult";
            this.averageStoppedSegmentResult.Size = new System.Drawing.Size(443, 38);
            this.averageStoppedSegmentResult.TabIndex = 11;
            this.averageStoppedSegmentResult.Text = "00:00";
            this.averageStoppedSegmentResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // averageActiveSegmentResult
            // 
            this.averageActiveSegmentResult.BackColor = System.Drawing.Color.SpringGreen;
            this.averageActiveSegmentResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageActiveSegmentResult.Location = new System.Drawing.Point(-1, 266);
            this.averageActiveSegmentResult.Name = "averageActiveSegmentResult";
            this.averageActiveSegmentResult.Size = new System.Drawing.Size(443, 38);
            this.averageActiveSegmentResult.TabIndex = 10;
            this.averageActiveSegmentResult.Text = "00:00";
            this.averageActiveSegmentResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // biggestStoppedSegmentResult
            // 
            this.biggestStoppedSegmentResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biggestStoppedSegmentResult.Location = new System.Drawing.Point(-1, 190);
            this.biggestStoppedSegmentResult.Name = "biggestStoppedSegmentResult";
            this.biggestStoppedSegmentResult.Size = new System.Drawing.Size(443, 38);
            this.biggestStoppedSegmentResult.TabIndex = 9;
            this.biggestStoppedSegmentResult.Text = "00:00";
            this.biggestStoppedSegmentResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // biggestActiveSegmentResult
            // 
            this.biggestActiveSegmentResult.BackColor = System.Drawing.Color.SpringGreen;
            this.biggestActiveSegmentResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biggestActiveSegmentResult.Location = new System.Drawing.Point(-1, 114);
            this.biggestActiveSegmentResult.Name = "biggestActiveSegmentResult";
            this.biggestActiveSegmentResult.Size = new System.Drawing.Size(443, 38);
            this.biggestActiveSegmentResult.TabIndex = 8;
            this.biggestActiveSegmentResult.Text = "00:00";
            this.biggestActiveSegmentResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalSegmentsResult
            // 
            this.totalSegmentsResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSegmentsResult.Location = new System.Drawing.Point(3, 38);
            this.totalSegmentsResult.Name = "totalSegmentsResult";
            this.totalSegmentsResult.Size = new System.Drawing.Size(443, 38);
            this.totalSegmentsResult.TabIndex = 7;
            this.totalSegmentsResult.Text = "0";
            this.totalSegmentsResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // averageGoalSegmentLabel
            // 
            this.averageGoalSegmentLabel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.averageGoalSegmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageGoalSegmentLabel.Location = new System.Drawing.Point(-1, 380);
            this.averageGoalSegmentLabel.Name = "averageGoalSegmentLabel";
            this.averageGoalSegmentLabel.Size = new System.Drawing.Size(443, 38);
            this.averageGoalSegmentLabel.TabIndex = 6;
            this.averageGoalSegmentLabel.Text = "Tempo medio de celebração de golo";
            this.averageGoalSegmentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // averageStoppedSegmentLabel
            // 
            this.averageStoppedSegmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageStoppedSegmentLabel.Location = new System.Drawing.Point(-1, 304);
            this.averageStoppedSegmentLabel.Name = "averageStoppedSegmentLabel";
            this.averageStoppedSegmentLabel.Size = new System.Drawing.Size(443, 38);
            this.averageStoppedSegmentLabel.TabIndex = 5;
            this.averageStoppedSegmentLabel.Text = "Tempo medio de jogo parado";
            this.averageStoppedSegmentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // biggestStoppedSegmentLabel
            // 
            this.biggestStoppedSegmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biggestStoppedSegmentLabel.Location = new System.Drawing.Point(-1, 152);
            this.biggestStoppedSegmentLabel.Name = "biggestStoppedSegmentLabel";
            this.biggestStoppedSegmentLabel.Size = new System.Drawing.Size(443, 38);
            this.biggestStoppedSegmentLabel.TabIndex = 4;
            this.biggestStoppedSegmentLabel.Text = "Maior segmento de jogo parado";
            this.biggestStoppedSegmentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // averageActiveSegmentLabel
            // 
            this.averageActiveSegmentLabel.BackColor = System.Drawing.Color.SpringGreen;
            this.averageActiveSegmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageActiveSegmentLabel.Location = new System.Drawing.Point(-1, 228);
            this.averageActiveSegmentLabel.Name = "averageActiveSegmentLabel";
            this.averageActiveSegmentLabel.Size = new System.Drawing.Size(443, 38);
            this.averageActiveSegmentLabel.TabIndex = 2;
            this.averageActiveSegmentLabel.Text = "Tempo medio \"A seguir\"";
            this.averageActiveSegmentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // biggestActiveSegmentLabel
            // 
            this.biggestActiveSegmentLabel.BackColor = System.Drawing.Color.SpringGreen;
            this.biggestActiveSegmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.biggestActiveSegmentLabel.Location = new System.Drawing.Point(-1, 76);
            this.biggestActiveSegmentLabel.Name = "biggestActiveSegmentLabel";
            this.biggestActiveSegmentLabel.Size = new System.Drawing.Size(443, 38);
            this.biggestActiveSegmentLabel.TabIndex = 1;
            this.biggestActiveSegmentLabel.Text = "Maior segmento \"A seguir\"";
            this.biggestActiveSegmentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalSegmentsLabel
            // 
            this.totalSegmentsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSegmentsLabel.Location = new System.Drawing.Point(3, 0);
            this.totalSegmentsLabel.Name = "totalSegmentsLabel";
            this.totalSegmentsLabel.Size = new System.Drawing.Size(443, 38);
            this.totalSegmentsLabel.TabIndex = 0;
            this.totalSegmentsLabel.Text = "Nº total de segmentos";
            this.totalSegmentsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeight = 35;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullPath,
            this.SelectedCheckbox,
            this.GameName,
            this.CompetitionName,
            this.GameDate});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(12, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 31;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(804, 383);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // FullPath
            // 
            this.FullPath.HeaderText = "FullPath";
            this.FullPath.Name = "FullPath";
            this.FullPath.ReadOnly = true;
            this.FullPath.Visible = false;
            // 
            // SelectedCheckbox
            // 
            this.SelectedCheckbox.FalseValue = "False";
            this.SelectedCheckbox.HeaderText = "Selecionar";
            this.SelectedCheckbox.Name = "SelectedCheckbox";
            this.SelectedCheckbox.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SelectedCheckbox.TrueValue = "True";
            this.SelectedCheckbox.Width = 70;
            // 
            // GameName
            // 
            this.GameName.HeaderText = "Nome Jogo";
            this.GameName.Name = "GameName";
            this.GameName.ReadOnly = true;
            this.GameName.Width = 300;
            // 
            // CompetitionName
            // 
            this.CompetitionName.HeaderText = "Competição";
            this.CompetitionName.Name = "CompetitionName";
            this.CompetitionName.ReadOnly = true;
            this.CompetitionName.Width = 200;
            // 
            // GameDate
            // 
            this.GameDate.HeaderText = "Data";
            this.GameDate.Name = "GameDate";
            this.GameDate.ReadOnly = true;
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(1157, 550);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(176, 56);
            this.BackButton.TabIndex = 32;
            this.BackButton.Text = "Voltar";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1370, 618);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver Jogos";
            this.Load += new System.EventHandler(this.HistoryForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BarChart)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label TotalGameTimeLabel;
        private System.Windows.Forms.Label StateGoalTimer;
        private System.Windows.Forms.Label StateRefBlowTimer;
        private System.Windows.Forms.Label StateOutofBoundsTimer;
        private System.Windows.Forms.Label StateActiveTimer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataVisualization.Charting.Chart PieChart;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataVisualization.Charting.Chart BarChart;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label averageGoalSegmentResult;
        private System.Windows.Forms.Label averageStoppedSegmentResult;
        private System.Windows.Forms.Label averageActiveSegmentResult;
        private System.Windows.Forms.Label biggestStoppedSegmentResult;
        private System.Windows.Forms.Label biggestActiveSegmentResult;
        private System.Windows.Forms.Label totalSegmentsResult;
        private System.Windows.Forms.Label averageGoalSegmentLabel;
        private System.Windows.Forms.Label averageStoppedSegmentLabel;
        private System.Windows.Forms.Label biggestStoppedSegmentLabel;
        private System.Windows.Forms.Label averageActiveSegmentLabel;
        private System.Windows.Forms.Label biggestActiveSegmentLabel;
        private System.Windows.Forms.Label totalSegmentsLabel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullPath;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SelectedCheckbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn GameName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CompetitionName;
        private System.Windows.Forms.DataGridViewTextBoxColumn GameDate;
    }
}