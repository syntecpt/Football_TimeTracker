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
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.averageGoalSegmentResult = new System.Windows.Forms.Label();
            this.averageStoppedSegmentResult = new System.Windows.Forms.Label();
            this.averageActiveSegmentResult = new System.Windows.Forms.Label();
            this.biggestStoppedSegmentResult = new System.Windows.Forms.Label();
            this.biggestActiveSegmentResult = new System.Windows.Forms.Label();
            this.totalGamesResult = new System.Windows.Forms.Label();
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
            this.filterTableButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nameFilter1 = new System.Windows.Forms.TextBox();
            this.addGameFilter2 = new System.Windows.Forms.Label();
            this.addGameFilter3 = new System.Windows.Forms.Label();
            this.nameFilter2 = new System.Windows.Forms.TextBox();
            this.nameFilter3 = new System.Windows.Forms.TextBox();
            this.removeGameFilter2 = new System.Windows.Forms.Label();
            this.removeGameFilter3 = new System.Windows.Forms.Label();
            this.comboBoxNameFilter2 = new System.Windows.Forms.ComboBox();
            this.comboBoxNameFilter3 = new System.Windows.Forms.ComboBox();
            this.removeGameFilter1 = new System.Windows.Forms.Label();
            this.removeCompetitionFilter1 = new System.Windows.Forms.Label();
            this.comboBoxCompetitionFilter3 = new System.Windows.Forms.ComboBox();
            this.comboBoxCompetitionFilter2 = new System.Windows.Forms.ComboBox();
            this.removeCompetitionFilter3 = new System.Windows.Forms.Label();
            this.removeCompetitionFilter2 = new System.Windows.Forms.Label();
            this.competitionFilter3 = new System.Windows.Forms.TextBox();
            this.addCompetitionFilter3 = new System.Windows.Forms.Label();
            this.competitionFilter2 = new System.Windows.Forms.TextBox();
            this.addCompetitionFilter2 = new System.Windows.Forms.Label();
            this.competitionFilter1 = new System.Windows.Forms.TextBox();
            this.removeDateFilter1 = new System.Windows.Forms.Label();
            this.comboBoxDateFilter2 = new System.Windows.Forms.ComboBox();
            this.removeDateFilter2 = new System.Windows.Forms.Label();
            this.dateFilter2 = new System.Windows.Forms.TextBox();
            this.addDateFilter2 = new System.Windows.Forms.Label();
            this.dateFilter1 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(883, 14);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(450, 482);
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
            this.tabPage1.Size = new System.Drawing.Size(442, 456);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Texto";
            // 
            // TotalGameTimeLabel
            // 
            this.TotalGameTimeLabel.BackColor = System.Drawing.Color.DimGray;
            this.TotalGameTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalGameTimeLabel.Location = new System.Drawing.Point(320, 390);
            this.TotalGameTimeLabel.Name = "TotalGameTimeLabel";
            this.TotalGameTimeLabel.Size = new System.Drawing.Size(116, 31);
            this.TotalGameTimeLabel.TabIndex = 30;
            this.TotalGameTimeLabel.Text = "00:00";
            this.TotalGameTimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StateGoalTimer
            // 
            this.StateGoalTimer.BackColor = System.Drawing.Color.LightSkyBlue;
            this.StateGoalTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateGoalTimer.Location = new System.Drawing.Point(320, 300);
            this.StateGoalTimer.Name = "StateGoalTimer";
            this.StateGoalTimer.Size = new System.Drawing.Size(116, 31);
            this.StateGoalTimer.TabIndex = 28;
            this.StateGoalTimer.Text = "00:00";
            this.StateGoalTimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StateRefBlowTimer
            // 
            this.StateRefBlowTimer.BackColor = System.Drawing.Color.Salmon;
            this.StateRefBlowTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateRefBlowTimer.Location = new System.Drawing.Point(320, 210);
            this.StateRefBlowTimer.Name = "StateRefBlowTimer";
            this.StateRefBlowTimer.Size = new System.Drawing.Size(116, 31);
            this.StateRefBlowTimer.TabIndex = 27;
            this.StateRefBlowTimer.Text = "00:00";
            this.StateRefBlowTimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StateOutofBoundsTimer
            // 
            this.StateOutofBoundsTimer.BackColor = System.Drawing.Color.Yellow;
            this.StateOutofBoundsTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateOutofBoundsTimer.Location = new System.Drawing.Point(320, 120);
            this.StateOutofBoundsTimer.Name = "StateOutofBoundsTimer";
            this.StateOutofBoundsTimer.Size = new System.Drawing.Size(116, 31);
            this.StateOutofBoundsTimer.TabIndex = 26;
            this.StateOutofBoundsTimer.Text = "00:00";
            this.StateOutofBoundsTimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StateActiveTimer
            // 
            this.StateActiveTimer.BackColor = System.Drawing.Color.SpringGreen;
            this.StateActiveTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateActiveTimer.Location = new System.Drawing.Point(320, 30);
            this.StateActiveTimer.Name = "StateActiveTimer";
            this.StateActiveTimer.Size = new System.Drawing.Size(116, 31);
            this.StateActiveTimer.TabIndex = 25;
            this.StateActiveTimer.Text = "00:00";
            this.StateActiveTimer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.LightSkyBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(0, 270);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(446, 90);
            this.label6.TabIndex = 24;
            this.label6.Text = "Tempo médio de\r\nGolo / Celebração / Revisão:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Salmon;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(446, 90);
            this.label5.TabIndex = 23;
            this.label5.Text = "Tempo médio de\r\nArbitro interrompeu jogo:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Yellow;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(446, 90);
            this.label4.TabIndex = 22;
            this.label4.Text = "Tempo médio de\r\nBola fora do terreno de jogo:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.SpringGreen;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(446, 90);
            this.label3.TabIndex = 21;
            this.label3.Text = "Tempo médio de\r\nJogo a seguir:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.DimGray;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(0, 360);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(446, 90);
            this.label8.TabIndex = 29;
            this.label8.Text = "Tempo médio de jogo:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DimGray;
            this.tabPage2.Controls.Add(this.PieChart);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(442, 456);
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
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.DimGray;
            this.tabPage4.Controls.Add(this.averageGoalSegmentResult);
            this.tabPage4.Controls.Add(this.averageStoppedSegmentResult);
            this.tabPage4.Controls.Add(this.averageActiveSegmentResult);
            this.tabPage4.Controls.Add(this.biggestStoppedSegmentResult);
            this.tabPage4.Controls.Add(this.biggestActiveSegmentResult);
            this.tabPage4.Controls.Add(this.totalGamesResult);
            this.tabPage4.Controls.Add(this.averageGoalSegmentLabel);
            this.tabPage4.Controls.Add(this.averageStoppedSegmentLabel);
            this.tabPage4.Controls.Add(this.biggestStoppedSegmentLabel);
            this.tabPage4.Controls.Add(this.averageActiveSegmentLabel);
            this.tabPage4.Controls.Add(this.biggestActiveSegmentLabel);
            this.tabPage4.Controls.Add(this.totalSegmentsLabel);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(442, 456);
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
            // totalGamesResult
            // 
            this.totalGamesResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalGamesResult.Location = new System.Drawing.Point(3, 38);
            this.totalGamesResult.Name = "totalGamesResult";
            this.totalGamesResult.Size = new System.Drawing.Size(443, 38);
            this.totalGamesResult.TabIndex = 7;
            this.totalGamesResult.Text = "0";
            this.totalGamesResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // averageGoalSegmentLabel
            // 
            this.averageGoalSegmentLabel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.averageGoalSegmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageGoalSegmentLabel.Location = new System.Drawing.Point(-1, 380);
            this.averageGoalSegmentLabel.Name = "averageGoalSegmentLabel";
            this.averageGoalSegmentLabel.Size = new System.Drawing.Size(443, 38);
            this.averageGoalSegmentLabel.TabIndex = 6;
            this.averageGoalSegmentLabel.Text = "Tempo médio de celebração de golo";
            this.averageGoalSegmentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // averageStoppedSegmentLabel
            // 
            this.averageStoppedSegmentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.averageStoppedSegmentLabel.Location = new System.Drawing.Point(-1, 304);
            this.averageStoppedSegmentLabel.Name = "averageStoppedSegmentLabel";
            this.averageStoppedSegmentLabel.Size = new System.Drawing.Size(443, 38);
            this.averageStoppedSegmentLabel.TabIndex = 5;
            this.averageStoppedSegmentLabel.Text = "Tempo médio de segmento parado";
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
            this.averageActiveSegmentLabel.Text = "Tempo médio de segmento  \"A seguir\"";
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
            this.totalSegmentsLabel.Text = "Nº de jogos";
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
            this.dataGridView1.Location = new System.Drawing.Point(26, 306);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 31;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(819, 293);
            this.dataGridView1.TabIndex = 31;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler( this.dataGridView1_SortCompare );
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
            // filterTableButton
            // 
            this.filterTableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterTableButton.Location = new System.Drawing.Point(702, 220);
            this.filterTableButton.Name = "filterTableButton";
            this.filterTableButton.Size = new System.Drawing.Size(143, 57);
            this.filterTableButton.TabIndex = 33;
            this.filterTableButton.Text = "Filtrar";
            this.filterTableButton.UseVisualStyleBackColor = true;
            this.filterTableButton.Click += new System.EventHandler(this.filterTableButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 33);
            this.label1.TabIndex = 34;
            this.label1.Text = "Jogo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(397, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 33);
            this.label2.TabIndex = 35;
            this.label2.Text = "Competição";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(724, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 33);
            this.label7.TabIndex = 36;
            this.label7.Text = "Data";
            // 
            // nameFilter1
            // 
            this.nameFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameFilter1.Location = new System.Drawing.Point(12, 59);
            this.nameFilter1.MaxLength = 50;
            this.nameFilter1.Name = "nameFilter1";
            this.nameFilter1.Size = new System.Drawing.Size(250, 38);
            this.nameFilter1.TabIndex = 37;
            this.nameFilter1.TextChanged += new System.EventHandler(this.nameFilter1_TextChanged);
            // 
            // addGameFilter2
            // 
            this.addGameFilter2.AutoSize = true;
            this.addGameFilter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGameFilter2.ForeColor = System.Drawing.Color.Chartreuse;
            this.addGameFilter2.Location = new System.Drawing.Point(300, 55);
            this.addGameFilter2.Name = "addGameFilter2";
            this.addGameFilter2.Size = new System.Drawing.Size(41, 42);
            this.addGameFilter2.TabIndex = 38;
            this.addGameFilter2.Text = "+";
            this.addGameFilter2.Click += new System.EventHandler(this.addGameFilter2_Click);
            // 
            // addGameFilter3
            // 
            this.addGameFilter3.AutoSize = true;
            this.addGameFilter3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGameFilter3.ForeColor = System.Drawing.Color.Chartreuse;
            this.addGameFilter3.Location = new System.Drawing.Point(300, 145);
            this.addGameFilter3.Name = "addGameFilter3";
            this.addGameFilter3.Size = new System.Drawing.Size(41, 42);
            this.addGameFilter3.TabIndex = 40;
            this.addGameFilter3.Text = "+";
            this.addGameFilter3.Visible = false;
            this.addGameFilter3.Click += new System.EventHandler(this.addGameFilter3_Click);
            // 
            // nameFilter2
            // 
            this.nameFilter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameFilter2.Location = new System.Drawing.Point(12, 149);
            this.nameFilter2.MaxLength = 50;
            this.nameFilter2.Name = "nameFilter2";
            this.nameFilter2.Size = new System.Drawing.Size(250, 38);
            this.nameFilter2.TabIndex = 39;
            this.nameFilter2.Visible = false;
            this.nameFilter2.TextChanged += new System.EventHandler(this.nameFilter2_TextChanged);
            // 
            // nameFilter3
            // 
            this.nameFilter3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameFilter3.Location = new System.Drawing.Point(12, 239);
            this.nameFilter3.MaxLength = 50;
            this.nameFilter3.Name = "nameFilter3";
            this.nameFilter3.Size = new System.Drawing.Size(250, 38);
            this.nameFilter3.TabIndex = 41;
            this.nameFilter3.Visible = false;
            this.nameFilter3.TextChanged += new System.EventHandler(this.nameFilter3_TextChanged);
            // 
            // removeGameFilter2
            // 
            this.removeGameFilter2.AutoSize = true;
            this.removeGameFilter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeGameFilter2.ForeColor = System.Drawing.Color.IndianRed;
            this.removeGameFilter2.Location = new System.Drawing.Point(268, 138);
            this.removeGameFilter2.Name = "removeGameFilter2";
            this.removeGameFilter2.Size = new System.Drawing.Size(37, 51);
            this.removeGameFilter2.TabIndex = 42;
            this.removeGameFilter2.Text = "-";
            this.removeGameFilter2.Visible = false;
            this.removeGameFilter2.Click += new System.EventHandler(this.removeGameFilter2_Click);
            // 
            // removeGameFilter3
            // 
            this.removeGameFilter3.AutoSize = true;
            this.removeGameFilter3.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeGameFilter3.ForeColor = System.Drawing.Color.IndianRed;
            this.removeGameFilter3.Location = new System.Drawing.Point(268, 233);
            this.removeGameFilter3.Name = "removeGameFilter3";
            this.removeGameFilter3.Size = new System.Drawing.Size(37, 51);
            this.removeGameFilter3.TabIndex = 43;
            this.removeGameFilter3.Text = "-";
            this.removeGameFilter3.Visible = false;
            this.removeGameFilter3.Click += new System.EventHandler(this.removeGameFilter3_Click);
            // 
            // comboBoxNameFilter2
            // 
            this.comboBoxNameFilter2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNameFilter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNameFilter2.FormattingEnabled = true;
            this.comboBoxNameFilter2.Items.AddRange(new object[] {
            "E",
            "Ou"});
            this.comboBoxNameFilter2.Location = new System.Drawing.Point(100, 110);
            this.comboBoxNameFilter2.Name = "comboBoxNameFilter2";
            this.comboBoxNameFilter2.Size = new System.Drawing.Size(56, 33);
            this.comboBoxNameFilter2.TabIndex = 44;
            this.comboBoxNameFilter2.Visible = false;
            // 
            // comboBoxNameFilter3
            // 
            this.comboBoxNameFilter3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxNameFilter3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxNameFilter3.FormattingEnabled = true;
            this.comboBoxNameFilter3.Items.AddRange(new object[] {
            "E",
            "Ou"});
            this.comboBoxNameFilter3.Location = new System.Drawing.Point(100, 200);
            this.comboBoxNameFilter3.Name = "comboBoxNameFilter3";
            this.comboBoxNameFilter3.Size = new System.Drawing.Size(56, 33);
            this.comboBoxNameFilter3.TabIndex = 45;
            this.comboBoxNameFilter3.Visible = false;
            // 
            // removeGameFilter1
            // 
            this.removeGameFilter1.AutoSize = true;
            this.removeGameFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeGameFilter1.ForeColor = System.Drawing.Color.IndianRed;
            this.removeGameFilter1.Location = new System.Drawing.Point(270, 48);
            this.removeGameFilter1.Name = "removeGameFilter1";
            this.removeGameFilter1.Size = new System.Drawing.Size(37, 51);
            this.removeGameFilter1.TabIndex = 46;
            this.removeGameFilter1.Text = "-";
            this.removeGameFilter1.Click += new System.EventHandler(this.removeGameFilter1_Click);
            // 
            // removeCompetitionFilter1
            // 
            this.removeCompetitionFilter1.AutoSize = true;
            this.removeCompetitionFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeCompetitionFilter1.ForeColor = System.Drawing.Color.IndianRed;
            this.removeCompetitionFilter1.Location = new System.Drawing.Point(605, 45);
            this.removeCompetitionFilter1.Name = "removeCompetitionFilter1";
            this.removeCompetitionFilter1.Size = new System.Drawing.Size(37, 51);
            this.removeCompetitionFilter1.TabIndex = 56;
            this.removeCompetitionFilter1.Text = "-";
            this.removeCompetitionFilter1.Click += new System.EventHandler(this.removeCompetitionFilter1_Click);
            // 
            // comboBoxCompetitionFilter3
            // 
            this.comboBoxCompetitionFilter3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCompetitionFilter3.Enabled = false;
            this.comboBoxCompetitionFilter3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCompetitionFilter3.FormattingEnabled = true;
            this.comboBoxCompetitionFilter3.Items.AddRange(new object[] {
            "Ou"});
            this.comboBoxCompetitionFilter3.Location = new System.Drawing.Point(441, 200);
            this.comboBoxCompetitionFilter3.Name = "comboBoxCompetitionFilter3";
            this.comboBoxCompetitionFilter3.Size = new System.Drawing.Size(56, 33);
            this.comboBoxCompetitionFilter3.TabIndex = 55;
            this.comboBoxCompetitionFilter3.Visible = false;
            // 
            // comboBoxCompetitionFilter2
            // 
            this.comboBoxCompetitionFilter2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCompetitionFilter2.Enabled = false;
            this.comboBoxCompetitionFilter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCompetitionFilter2.FormattingEnabled = true;
            this.comboBoxCompetitionFilter2.Items.AddRange(new object[] {
            "Ou"});
            this.comboBoxCompetitionFilter2.Location = new System.Drawing.Point(441, 110);
            this.comboBoxCompetitionFilter2.Name = "comboBoxCompetitionFilter2";
            this.comboBoxCompetitionFilter2.Size = new System.Drawing.Size(56, 33);
            this.comboBoxCompetitionFilter2.TabIndex = 54;
            this.comboBoxCompetitionFilter2.Visible = false;
            // 
            // removeCompetitionFilter3
            // 
            this.removeCompetitionFilter3.AutoSize = true;
            this.removeCompetitionFilter3.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeCompetitionFilter3.ForeColor = System.Drawing.Color.IndianRed;
            this.removeCompetitionFilter3.Location = new System.Drawing.Point(603, 230);
            this.removeCompetitionFilter3.Name = "removeCompetitionFilter3";
            this.removeCompetitionFilter3.Size = new System.Drawing.Size(37, 51);
            this.removeCompetitionFilter3.TabIndex = 53;
            this.removeCompetitionFilter3.Text = "-";
            this.removeCompetitionFilter3.Visible = false;
            this.removeCompetitionFilter3.Click += new System.EventHandler(this.removeCompetitionFilter3_Click);
            // 
            // removeCompetitionFilter2
            // 
            this.removeCompetitionFilter2.AutoSize = true;
            this.removeCompetitionFilter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeCompetitionFilter2.ForeColor = System.Drawing.Color.IndianRed;
            this.removeCompetitionFilter2.Location = new System.Drawing.Point(603, 135);
            this.removeCompetitionFilter2.Name = "removeCompetitionFilter2";
            this.removeCompetitionFilter2.Size = new System.Drawing.Size(37, 51);
            this.removeCompetitionFilter2.TabIndex = 52;
            this.removeCompetitionFilter2.Text = "-";
            this.removeCompetitionFilter2.Visible = false;
            this.removeCompetitionFilter2.Click += new System.EventHandler(this.removeCompetitionFilter2_Click);
            // 
            // competitionFilter3
            // 
            this.competitionFilter3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.competitionFilter3.Location = new System.Drawing.Point(347, 237);
            this.competitionFilter3.MaxLength = 50;
            this.competitionFilter3.Name = "competitionFilter3";
            this.competitionFilter3.Size = new System.Drawing.Size(250, 38);
            this.competitionFilter3.TabIndex = 51;
            this.competitionFilter3.Visible = false;
            this.competitionFilter3.TextChanged += new System.EventHandler(this.competitionFilter3_TextChanged);
            // 
            // addCompetitionFilter3
            // 
            this.addCompetitionFilter3.AutoSize = true;
            this.addCompetitionFilter3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCompetitionFilter3.ForeColor = System.Drawing.Color.Chartreuse;
            this.addCompetitionFilter3.Location = new System.Drawing.Point(635, 142);
            this.addCompetitionFilter3.Name = "addCompetitionFilter3";
            this.addCompetitionFilter3.Size = new System.Drawing.Size(41, 42);
            this.addCompetitionFilter3.TabIndex = 50;
            this.addCompetitionFilter3.Text = "+";
            this.addCompetitionFilter3.Visible = false;
            this.addCompetitionFilter3.Click += new System.EventHandler(this.addCompetitionFilter3_Click);
            // 
            // competitionFilter2
            // 
            this.competitionFilter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.competitionFilter2.Location = new System.Drawing.Point(347, 147);
            this.competitionFilter2.MaxLength = 50;
            this.competitionFilter2.Name = "competitionFilter2";
            this.competitionFilter2.Size = new System.Drawing.Size(250, 38);
            this.competitionFilter2.TabIndex = 49;
            this.competitionFilter2.Visible = false;
            this.competitionFilter2.TextChanged += new System.EventHandler(this.competitionFilter2_TextChanged);
            // 
            // addCompetitionFilter2
            // 
            this.addCompetitionFilter2.AutoSize = true;
            this.addCompetitionFilter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCompetitionFilter2.ForeColor = System.Drawing.Color.Chartreuse;
            this.addCompetitionFilter2.Location = new System.Drawing.Point(635, 52);
            this.addCompetitionFilter2.Name = "addCompetitionFilter2";
            this.addCompetitionFilter2.Size = new System.Drawing.Size(41, 42);
            this.addCompetitionFilter2.TabIndex = 48;
            this.addCompetitionFilter2.Text = "+";
            this.addCompetitionFilter2.Click += new System.EventHandler(this.addCompetitionFilter2_Click);
            // 
            // competitionFilter1
            // 
            this.competitionFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.competitionFilter1.Location = new System.Drawing.Point(347, 57);
            this.competitionFilter1.MaxLength = 50;
            this.competitionFilter1.Name = "competitionFilter1";
            this.competitionFilter1.Size = new System.Drawing.Size(250, 38);
            this.competitionFilter1.TabIndex = 47;
            this.competitionFilter1.TextChanged += new System.EventHandler(this.competitionFilter1_TextChanged);
            // 
            // removeDateFilter1
            // 
            this.removeDateFilter1.AutoSize = true;
            this.removeDateFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeDateFilter1.ForeColor = System.Drawing.Color.IndianRed;
            this.removeDateFilter1.Location = new System.Drawing.Point(806, 48);
            this.removeDateFilter1.Name = "removeDateFilter1";
            this.removeDateFilter1.Size = new System.Drawing.Size(37, 51);
            this.removeDateFilter1.TabIndex = 63;
            this.removeDateFilter1.Text = "-";
            this.removeDateFilter1.Click += new System.EventHandler(this.removeDateFilter1_Click);
            // 
            // comboBoxDateFilter2
            // 
            this.comboBoxDateFilter2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDateFilter2.Enabled = false;
            this.comboBoxDateFilter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxDateFilter2.FormattingEnabled = true;
            this.comboBoxDateFilter2.Items.AddRange(new object[] {
            "Ou"});
            this.comboBoxDateFilter2.Location = new System.Drawing.Point(720, 111);
            this.comboBoxDateFilter2.Name = "comboBoxDateFilter2";
            this.comboBoxDateFilter2.Size = new System.Drawing.Size(56, 33);
            this.comboBoxDateFilter2.TabIndex = 62;
            this.comboBoxDateFilter2.Visible = false;
            // 
            // removeDateFilter2
            // 
            this.removeDateFilter2.AutoSize = true;
            this.removeDateFilter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeDateFilter2.ForeColor = System.Drawing.Color.IndianRed;
            this.removeDateFilter2.Location = new System.Drawing.Point(804, 138);
            this.removeDateFilter2.Name = "removeDateFilter2";
            this.removeDateFilter2.Size = new System.Drawing.Size(37, 51);
            this.removeDateFilter2.TabIndex = 61;
            this.removeDateFilter2.Text = "-";
            this.removeDateFilter2.Visible = false;
            this.removeDateFilter2.Click += new System.EventHandler(this.removeDateFilter2_Click);
            // 
            // dateFilter2
            // 
            this.dateFilter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFilter2.Location = new System.Drawing.Point(693, 148);
            this.dateFilter2.MaxLength = 4;
            this.dateFilter2.Name = "dateFilter2";
            this.dateFilter2.Size = new System.Drawing.Size(110, 38);
            this.dateFilter2.TabIndex = 59;
            this.dateFilter2.Visible = false;
            this.dateFilter2.TextChanged += new System.EventHandler(this.dateFilter2_TextChanged);
            // 
            // addDateFilter2
            // 
            this.addDateFilter2.AutoSize = true;
            this.addDateFilter2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDateFilter2.ForeColor = System.Drawing.Color.Chartreuse;
            this.addDateFilter2.Location = new System.Drawing.Point(836, 55);
            this.addDateFilter2.Name = "addDateFilter2";
            this.addDateFilter2.Size = new System.Drawing.Size(41, 42);
            this.addDateFilter2.TabIndex = 58;
            this.addDateFilter2.Text = "+";
            this.addDateFilter2.Click += new System.EventHandler(this.addDateFilter2_Click);
            // 
            // dateFilter1
            // 
            this.dateFilter1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFilter1.Location = new System.Drawing.Point(693, 58);
            this.dateFilter1.MaxLength = 4;
            this.dateFilter1.Name = "dateFilter1";
            this.dateFilter1.Size = new System.Drawing.Size(110, 38);
            this.dateFilter1.TabIndex = 57;
            this.dateFilter1.TextChanged += new System.EventHandler(this.dateFilter1_TextChanged);
            // 
            // HistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1370, 618);
            this.Controls.Add(this.removeDateFilter1);
            this.Controls.Add(this.comboBoxDateFilter2);
            this.Controls.Add(this.removeDateFilter2);
            this.Controls.Add(this.dateFilter2);
            this.Controls.Add(this.addDateFilter2);
            this.Controls.Add(this.dateFilter1);
            this.Controls.Add(this.removeCompetitionFilter1);
            this.Controls.Add(this.comboBoxCompetitionFilter3);
            this.Controls.Add(this.comboBoxCompetitionFilter2);
            this.Controls.Add(this.removeCompetitionFilter3);
            this.Controls.Add(this.removeCompetitionFilter2);
            this.Controls.Add(this.competitionFilter3);
            this.Controls.Add(this.addCompetitionFilter3);
            this.Controls.Add(this.competitionFilter2);
            this.Controls.Add(this.addCompetitionFilter2);
            this.Controls.Add(this.competitionFilter1);
            this.Controls.Add(this.removeGameFilter1);
            this.Controls.Add(this.comboBoxNameFilter3);
            this.Controls.Add(this.comboBoxNameFilter2);
            this.Controls.Add(this.removeGameFilter3);
            this.Controls.Add(this.removeGameFilter2);
            this.Controls.Add(this.nameFilter3);
            this.Controls.Add(this.addGameFilter3);
            this.Controls.Add(this.nameFilter2);
            this.Controls.Add(this.addGameFilter2);
            this.Controls.Add(this.nameFilter1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.filterTableButton);
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
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label averageGoalSegmentResult;
        private System.Windows.Forms.Label averageStoppedSegmentResult;
        private System.Windows.Forms.Label averageActiveSegmentResult;
        private System.Windows.Forms.Label biggestStoppedSegmentResult;
        private System.Windows.Forms.Label biggestActiveSegmentResult;
        private System.Windows.Forms.Label totalGamesResult;
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
        private System.Windows.Forms.Button filterTableButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nameFilter1;
        private System.Windows.Forms.Label addGameFilter2;
        private System.Windows.Forms.Label addGameFilter3;
        private System.Windows.Forms.TextBox nameFilter2;
        private System.Windows.Forms.TextBox nameFilter3;
        private System.Windows.Forms.Label removeGameFilter2;
        private System.Windows.Forms.Label removeGameFilter3;
        private System.Windows.Forms.ComboBox comboBoxNameFilter2;
        private System.Windows.Forms.ComboBox comboBoxNameFilter3;
        private System.Windows.Forms.Label removeGameFilter1;
        private System.Windows.Forms.Label removeCompetitionFilter1;
        private System.Windows.Forms.ComboBox comboBoxCompetitionFilter3;
        private System.Windows.Forms.ComboBox comboBoxCompetitionFilter2;
        private System.Windows.Forms.Label removeCompetitionFilter3;
        private System.Windows.Forms.Label removeCompetitionFilter2;
        private System.Windows.Forms.TextBox competitionFilter3;
        private System.Windows.Forms.Label addCompetitionFilter3;
        private System.Windows.Forms.TextBox competitionFilter2;
        private System.Windows.Forms.Label addCompetitionFilter2;
        private System.Windows.Forms.TextBox competitionFilter1;
        private System.Windows.Forms.Label removeDateFilter1;
        private System.Windows.Forms.ComboBox comboBoxDateFilter2;
        private System.Windows.Forms.Label removeDateFilter2;
        private System.Windows.Forms.TextBox dateFilter2;
        private System.Windows.Forms.Label addDateFilter2;
        private System.Windows.Forms.TextBox dateFilter1;
    }
}