namespace Football_TimeTracker
{
    partial class GameForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 0D);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tempoTotalLabel = new System.Windows.Forms.Label();
            this.tempoAdicionalLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.startstopButton = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SegmentActiveButton = new System.Windows.Forms.Button();
            this.SegmentOutofBoundsButton = new System.Windows.Forms.Button();
            this.SegmentRefBlowButton = new System.Windows.Forms.Button();
            this.SegmentGoalButton = new System.Windows.Forms.Button();
            this.KeybindActive = new System.Windows.Forms.Label();
            this.KeybindOutofBounds = new System.Windows.Forms.Label();
            this.KeybindRefBlow = new System.Windows.Forms.Label();
            this.KeybindGoal = new System.Windows.Forms.Label();
            this.KeybindStartStop = new System.Windows.Forms.Label();
            this.placeholder_label = new System.Windows.Forms.Label();
            this.placeholder_label_bottom = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.BarChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.PieChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
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
            this.BlockKeybindingsSwitch = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.currentStatusLabel = new System.Windows.Forms.Label();
            this.segmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.RemoveSegmentButton = new System.Windows.Forms.Button();
            this.KeybindUndo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BarChart)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.segmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Primeira Parte";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(25, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "Segunda Parte";
            // 
            // tempoTotalLabel
            // 
            this.tempoTotalLabel.AutoSize = true;
            this.tempoTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempoTotalLabel.Location = new System.Drawing.Point(429, 18);
            this.tempoTotalLabel.Name = "tempoTotalLabel";
            this.tempoTotalLabel.Size = new System.Drawing.Size(145, 55);
            this.tempoTotalLabel.TabIndex = 4;
            this.tempoTotalLabel.Text = "00:00";
            // 
            // tempoAdicionalLabel
            // 
            this.tempoAdicionalLabel.AutoSize = true;
            this.tempoAdicionalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempoAdicionalLabel.Location = new System.Drawing.Point(560, 18);
            this.tempoAdicionalLabel.Name = "tempoAdicionalLabel";
            this.tempoAdicionalLabel.Size = new System.Drawing.Size(186, 55);
            this.tempoAdicionalLabel.TabIndex = 6;
            this.tempoAdicionalLabel.Text = "+ 00:00";
            this.tempoAdicionalLabel.Visible = false;
            // 
            // resetButton
            // 
            this.resetButton.Enabled = false;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.Location = new System.Drawing.Point(1430, 706);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(112, 56);
            this.resetButton.TabIndex = 7;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.endButton_Click);
            // 
            // startstopButton
            // 
            this.startstopButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startstopButton.Location = new System.Drawing.Point(1164, 542);
            this.startstopButton.Name = "startstopButton";
            this.startstopButton.Size = new System.Drawing.Size(313, 120);
            this.startstopButton.TabIndex = 8;
            this.startstopButton.Text = "Iniciar 1ª parte";
            this.startstopButton.UseVisualStyleBackColor = true;
            this.startstopButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Football_TimeTracker.Properties.Resources.TimeRuler;
            this.pictureBox2.Location = new System.Drawing.Point(12, 220);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1030, 262);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Football_TimeTracker.Properties.Resources.TimeRuler;
            this.pictureBox1.Location = new System.Drawing.Point(12, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1030, 262);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SegmentActiveButton
            // 
            this.SegmentActiveButton.BackColor = System.Drawing.Color.SpringGreen;
            this.SegmentActiveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SegmentActiveButton.Location = new System.Drawing.Point(439, 488);
            this.SegmentActiveButton.Name = "SegmentActiveButton";
            this.SegmentActiveButton.Size = new System.Drawing.Size(187, 111);
            this.SegmentActiveButton.TabIndex = 9;
            this.SegmentActiveButton.Text = "A Seguir";
            this.SegmentActiveButton.UseVisualStyleBackColor = false;
            this.SegmentActiveButton.Click += new System.EventHandler(this.SegmentActiveButton_Click);
            // 
            // SegmentOutofBoundsButton
            // 
            this.SegmentOutofBoundsButton.BackColor = System.Drawing.Color.Yellow;
            this.SegmentOutofBoundsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SegmentOutofBoundsButton.Location = new System.Drawing.Point(254, 551);
            this.SegmentOutofBoundsButton.Name = "SegmentOutofBoundsButton";
            this.SegmentOutofBoundsButton.Size = new System.Drawing.Size(187, 111);
            this.SegmentOutofBoundsButton.TabIndex = 10;
            this.SegmentOutofBoundsButton.Text = "Bola fora do terreno de jogo";
            this.SegmentOutofBoundsButton.UseVisualStyleBackColor = false;
            this.SegmentOutofBoundsButton.Click += new System.EventHandler(this.SegmentOutofBoundsButton_Click);
            // 
            // SegmentRefBlowButton
            // 
            this.SegmentRefBlowButton.BackColor = System.Drawing.Color.Salmon;
            this.SegmentRefBlowButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SegmentRefBlowButton.Location = new System.Drawing.Point(624, 551);
            this.SegmentRefBlowButton.Name = "SegmentRefBlowButton";
            this.SegmentRefBlowButton.Size = new System.Drawing.Size(187, 111);
            this.SegmentRefBlowButton.TabIndex = 11;
            this.SegmentRefBlowButton.Text = "Arbitro interrompeu jogo";
            this.SegmentRefBlowButton.UseVisualStyleBackColor = false;
            this.SegmentRefBlowButton.Click += new System.EventHandler(this.SegmentRefBlowButton_Click);
            // 
            // SegmentGoalButton
            // 
            this.SegmentGoalButton.BackColor = System.Drawing.Color.LightSkyBlue;
            this.SegmentGoalButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SegmentGoalButton.Location = new System.Drawing.Point(439, 605);
            this.SegmentGoalButton.Name = "SegmentGoalButton";
            this.SegmentGoalButton.Size = new System.Drawing.Size(187, 111);
            this.SegmentGoalButton.TabIndex = 12;
            this.SegmentGoalButton.Text = "Golo / celebração / revisão";
            this.SegmentGoalButton.UseVisualStyleBackColor = false;
            this.SegmentGoalButton.Click += new System.EventHandler(this.SegmentGoalButton_Click);
            // 
            // KeybindActive
            // 
            this.KeybindActive.AutoSize = true;
            this.KeybindActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeybindActive.Location = new System.Drawing.Point(512, 454);
            this.KeybindActive.Name = "KeybindActive";
            this.KeybindActive.Size = new System.Drawing.Size(39, 31);
            this.KeybindActive.TabIndex = 21;
            this.KeybindActive.Text = "W";
            // 
            // KeybindOutofBounds
            // 
            this.KeybindOutofBounds.AutoSize = true;
            this.KeybindOutofBounds.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeybindOutofBounds.Location = new System.Drawing.Point(211, 591);
            this.KeybindOutofBounds.Name = "KeybindOutofBounds";
            this.KeybindOutofBounds.Size = new System.Drawing.Size(32, 31);
            this.KeybindOutofBounds.TabIndex = 22;
            this.KeybindOutofBounds.Text = "A";
            // 
            // KeybindRefBlow
            // 
            this.KeybindRefBlow.AutoSize = true;
            this.KeybindRefBlow.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeybindRefBlow.Location = new System.Drawing.Point(817, 591);
            this.KeybindRefBlow.Name = "KeybindRefBlow";
            this.KeybindRefBlow.Size = new System.Drawing.Size(34, 31);
            this.KeybindRefBlow.TabIndex = 23;
            this.KeybindRefBlow.Text = "D";
            // 
            // KeybindGoal
            // 
            this.KeybindGoal.AutoSize = true;
            this.KeybindGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeybindGoal.Location = new System.Drawing.Point(512, 719);
            this.KeybindGoal.Name = "KeybindGoal";
            this.KeybindGoal.Size = new System.Drawing.Size(32, 31);
            this.KeybindGoal.TabIndex = 24;
            this.KeybindGoal.Text = "S";
            // 
            // KeybindStartStop
            // 
            this.KeybindStartStop.AutoSize = true;
            this.KeybindStartStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeybindStartStop.Location = new System.Drawing.Point(1126, 587);
            this.KeybindStartStop.Name = "KeybindStartStop";
            this.KeybindStartStop.Size = new System.Drawing.Size(32, 31);
            this.KeybindStartStop.TabIndex = 26;
            this.KeybindStartStop.Text = "P";
            // 
            // placeholder_label
            // 
            this.placeholder_label.AutoSize = true;
            this.placeholder_label.Location = new System.Drawing.Point(100, 128);
            this.placeholder_label.Name = "placeholder_label";
            this.placeholder_label.Size = new System.Drawing.Size(51, 13);
            this.placeholder_label.TabIndex = 27;
            this.placeholder_label.Text = "NOTEXT";
            this.placeholder_label.Visible = false;
            // 
            // placeholder_label_bottom
            // 
            this.placeholder_label_bottom.AutoSize = true;
            this.placeholder_label_bottom.Location = new System.Drawing.Point(100, 330);
            this.placeholder_label_bottom.Name = "placeholder_label_bottom";
            this.placeholder_label_bottom.Size = new System.Drawing.Size(51, 13);
            this.placeholder_label_bottom.TabIndex = 28;
            this.placeholder_label_bottom.Text = "NOTEXT";
            this.placeholder_label_bottom.Visible = false;
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
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Enabled = false;
            chartArea1.AxisY.Title = "Minutos";
            chartArea1.BackColor = System.Drawing.Color.DimGray;
            chartArea1.Name = "ChartArea1";
            this.BarChart.ChartAreas.Add(chartArea1);
            legend1.BackColor = System.Drawing.Color.DimGray;
            legend1.Name = "Legend1";
            this.BarChart.Legends.Add(legend1);
            this.BarChart.Location = new System.Drawing.Point(-4, 0);
            this.BarChart.Name = "BarChart";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.SpringGreen;
            series1.Legend = "Legend1";
            series1.Name = "A seguir";
            dataPoint1.Color = System.Drawing.Color.SpringGreen;
            dataPoint1.Label = "";
            dataPoint1.LabelFormat = "";
            dataPoint1.LabelToolTip = "";
            dataPoint1.LegendText = "";
            dataPoint1.LegendToolTip = "";
            dataPoint2.Color = System.Drawing.Color.Yellow;
            dataPoint3.Color = System.Drawing.Color.Salmon;
            dataPoint4.Color = System.Drawing.Color.LightSkyBlue;
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.Points.Add(dataPoint3);
            series1.Points.Add(dataPoint4);
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.Yellow;
            series2.Legend = "Legend1";
            series2.Name = "Bola fora";
            series3.ChartArea = "ChartArea1";
            series3.Color = System.Drawing.Color.Salmon;
            series3.Legend = "Legend1";
            series3.Name = "Arbitro apita";
            series4.ChartArea = "ChartArea1";
            series4.Color = System.Drawing.Color.LightSkyBlue;
            series4.Legend = "Legend1";
            series4.Name = "Golo";
            this.BarChart.Series.Add(series1);
            this.BarChart.Series.Add(series2);
            this.BarChart.Series.Add(series3);
            this.BarChart.Series.Add(series4);
            this.BarChart.Size = new System.Drawing.Size(450, 473);
            this.BarChart.TabIndex = 0;
            this.BarChart.Text = "chart1";
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
            chartArea2.BackColor = System.Drawing.Color.DimGray;
            chartArea2.Name = "ChartArea1";
            this.PieChart.ChartAreas.Add(chartArea2);
            legend2.BackColor = System.Drawing.Color.DimGray;
            legend2.Name = "Legend1";
            this.PieChart.Legends.Add(legend2);
            this.PieChart.Location = new System.Drawing.Point(0, 0);
            this.PieChart.Name = "PieChart";
            series5.BackSecondaryColor = System.Drawing.Color.DimGray;
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series5.Color = System.Drawing.Color.DimGray;
            series5.IsValueShownAsLabel = true;
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            dataPoint5.Color = System.Drawing.Color.SpringGreen;
            dataPoint5.IsValueShownAsLabel = false;
            dataPoint5.MarkerColor = System.Drawing.Color.Empty;
            dataPoint6.Color = System.Drawing.Color.Yellow;
            dataPoint6.IsValueShownAsLabel = false;
            dataPoint7.Color = System.Drawing.Color.Salmon;
            dataPoint7.IsValueShownAsLabel = false;
            dataPoint8.Color = System.Drawing.Color.LightSkyBlue;
            dataPoint8.IsValueShownAsLabel = false;
            series5.Points.Add(dataPoint5);
            series5.Points.Add(dataPoint6);
            series5.Points.Add(dataPoint7);
            series5.Points.Add(dataPoint8);
            series5.SmartLabelStyle.Enabled = false;
            this.PieChart.Series.Add(series5);
            this.PieChart.Size = new System.Drawing.Size(446, 473);
            this.PieChart.TabIndex = 0;
            this.PieChart.Text = "Gráfico Circular";
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(1092, 18);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(450, 495);
            this.tabControl1.TabIndex = 29;
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
            this.biggestStoppedSegmentResult.Location = new System.Drawing.Point(-4, 190);
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
            this.biggestActiveSegmentResult.Location = new System.Drawing.Point(3, 114);
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
            this.biggestActiveSegmentLabel.Location = new System.Drawing.Point(3, 76);
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
            // BlockKeybindingsSwitch
            // 
            this.BlockKeybindingsSwitch.AutoSize = true;
            this.BlockKeybindingsSwitch.Location = new System.Drawing.Point(12, 733);
            this.BlockKeybindingsSwitch.Name = "BlockKeybindingsSwitch";
            this.BlockKeybindingsSwitch.Size = new System.Drawing.Size(99, 17);
            this.BlockKeybindingsSwitch.TabIndex = 30;
            this.BlockKeybindingsSwitch.Text = "Bloquear teclas";
            this.BlockKeybindingsSwitch.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 753);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(259, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "(para escrever sem usar o programa involutáriamente)";
            // 
            // currentStatusLabel
            // 
            this.currentStatusLabel.AutoSize = true;
            this.currentStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentStatusLabel.ForeColor = System.Drawing.Color.Khaki;
            this.currentStatusLabel.Location = new System.Drawing.Point(766, 30);
            this.currentStatusLabel.Name = "currentStatusLabel";
            this.currentStatusLabel.Size = new System.Drawing.Size(195, 29);
            this.currentStatusLabel.TabIndex = 32;
            this.currentStatusLabel.Text = "Jogo por iniciar";
            // 
            // segmentBindingSource
            // 
            this.segmentBindingSource.DataSource = typeof(Football_TimeTracker.Segment);
            // 
            // RemoveSegmentButton
            // 
            this.RemoveSegmentButton.Location = new System.Drawing.Point(931, 660);
            this.RemoveSegmentButton.Name = "RemoveSegmentButton";
            this.RemoveSegmentButton.Size = new System.Drawing.Size(111, 56);
            this.RemoveSegmentButton.TabIndex = 33;
            this.RemoveSegmentButton.Text = "desfazer ultimo segmento";
            this.RemoveSegmentButton.UseVisualStyleBackColor = true;
            this.RemoveSegmentButton.Click += new System.EventHandler(this.RemoveSegmentButton_Click);
            // 
            // KeybindUndo
            // 
            this.KeybindUndo.AutoSize = true;
            this.KeybindUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeybindUndo.Location = new System.Drawing.Point(911, 626);
            this.KeybindUndo.Name = "KeybindUndo";
            this.KeybindUndo.Size = new System.Drawing.Size(148, 31);
            this.KeybindUndo.TabIndex = 34;
            this.KeybindUndo.Text = "Backspace";
            // 
            // GameForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1554, 771);
            this.Controls.Add(this.KeybindUndo);
            this.Controls.Add(this.RemoveSegmentButton);
            this.Controls.Add(this.currentStatusLabel);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BlockKeybindingsSwitch);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.placeholder_label_bottom);
            this.Controls.Add(this.placeholder_label);
            this.Controls.Add(this.KeybindStartStop);
            this.Controls.Add(this.startstopButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.KeybindGoal);
            this.Controls.Add(this.KeybindRefBlow);
            this.Controls.Add(this.KeybindOutofBounds);
            this.Controls.Add(this.KeybindActive);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SegmentGoalButton);
            this.Controls.Add(this.tempoAdicionalLabel);
            this.Controls.Add(this.tempoTotalLabel);
            this.Controls.Add(this.SegmentRefBlowButton);
            this.Controls.Add(this.SegmentOutofBoundsButton);
            this.Controls.Add(this.SegmentActiveButton);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BarChart)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PieChart)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.segmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label tempoTotalLabel;
        private System.Windows.Forms.Label tempoAdicionalLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button startstopButton;
        private System.Windows.Forms.Button SegmentActiveButton;
        private System.Windows.Forms.Button SegmentOutofBoundsButton;
        private System.Windows.Forms.Button SegmentRefBlowButton;
        private System.Windows.Forms.Button SegmentGoalButton;
        private System.Windows.Forms.Label KeybindActive;
        private System.Windows.Forms.Label KeybindOutofBounds;
        private System.Windows.Forms.Label KeybindRefBlow;
        private System.Windows.Forms.Label KeybindGoal;
        private System.Windows.Forms.Label KeybindStartStop;
        private System.Windows.Forms.Label placeholder_label;
        private System.Windows.Forms.Label placeholder_label_bottom;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label StateGoalTimer;
        private System.Windows.Forms.Label StateRefBlowTimer;
        private System.Windows.Forms.Label StateOutofBoundsTimer;
        private System.Windows.Forms.Label StateActiveTimer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.DataVisualization.Charting.Chart PieChart;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.BindingSource segmentBindingSource;
        private System.Windows.Forms.DataVisualization.Charting.Chart BarChart;
        private System.Windows.Forms.CheckBox BlockKeybindingsSwitch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label currentStatusLabel;
        private System.Windows.Forms.Label averageStoppedSegmentLabel;
        private System.Windows.Forms.Label biggestStoppedSegmentLabel;
        private System.Windows.Forms.Label averageActiveSegmentLabel;
        private System.Windows.Forms.Label biggestActiveSegmentLabel;
        private System.Windows.Forms.Label totalSegmentsLabel;
        private System.Windows.Forms.Label averageGoalSegmentResult;
        private System.Windows.Forms.Label averageStoppedSegmentResult;
        private System.Windows.Forms.Label averageActiveSegmentResult;
        private System.Windows.Forms.Label biggestStoppedSegmentResult;
        private System.Windows.Forms.Label biggestActiveSegmentResult;
        private System.Windows.Forms.Label totalSegmentsResult;
        private System.Windows.Forms.Label averageGoalSegmentLabel;
        private System.Windows.Forms.Label TotalGameTimeLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button RemoveSegmentButton;
        private System.Windows.Forms.Label KeybindUndo;
    }
}

