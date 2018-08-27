namespace Master
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label2 = new System.Windows.Forms.Label();
            this.adjustmentDurationOfImpulseNUD = new System.Windows.Forms.NumericUpDown();
            this.adjustmentDurationOfPauseNUD = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.stationaryRB = new System.Windows.Forms.RadioButton();
            this.singleImpulseRB = new System.Windows.Forms.RadioButton();
            this.seriesOfImpulsesRB = new System.Windows.Forms.RadioButton();
            this.stopButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartValve = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.clearLists = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.kNUD = new System.Windows.Forms.NumericUpDown();
            this.qualityControlButton = new System.Windows.Forms.Button();
            this.faultNUD = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataToFileButton = new System.Windows.Forms.Button();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            ((System.ComponentModel.ISupportInitialize)(this.adjustmentDurationOfImpulseNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adjustmentDurationOfPauseNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartValve)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.faultNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(24, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(337, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "Регулювання тривалістю";
            // 
            // adjustmentDurationOfImpulseNUD
            // 
            this.adjustmentDurationOfImpulseNUD.BackColor = System.Drawing.Color.White;
            this.adjustmentDurationOfImpulseNUD.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adjustmentDurationOfImpulseNUD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.adjustmentDurationOfImpulseNUD.Location = new System.Drawing.Point(134, 245);
            this.adjustmentDurationOfImpulseNUD.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.adjustmentDurationOfImpulseNUD.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.adjustmentDurationOfImpulseNUD.Name = "adjustmentDurationOfImpulseNUD";
            this.adjustmentDurationOfImpulseNUD.Size = new System.Drawing.Size(183, 34);
            this.adjustmentDurationOfImpulseNUD.TabIndex = 6;
            this.adjustmentDurationOfImpulseNUD.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // adjustmentDurationOfPauseNUD
            // 
            this.adjustmentDurationOfPauseNUD.BackColor = System.Drawing.Color.White;
            this.adjustmentDurationOfPauseNUD.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.adjustmentDurationOfPauseNUD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.adjustmentDurationOfPauseNUD.Location = new System.Drawing.Point(134, 295);
            this.adjustmentDurationOfPauseNUD.Maximum = new decimal(new int[] {
            20000,
            0,
            0,
            0});
            this.adjustmentDurationOfPauseNUD.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.adjustmentDurationOfPauseNUD.Name = "adjustmentDurationOfPauseNUD";
            this.adjustmentDurationOfPauseNUD.Size = new System.Drawing.Size(183, 34);
            this.adjustmentDurationOfPauseNUD.TabIndex = 7;
            this.adjustmentDurationOfPauseNUD.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(25, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 27);
            this.label3.TabIndex = 8;
            this.label3.Text = "Імпульса";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(25, 297);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 27);
            this.label4.TabIndex = 9;
            this.label4.Text = "Паузи";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.startButton.FlatAppearance.BorderSize = 0;
            this.startButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.Location = new System.Drawing.Point(23, 757);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(168, 61);
            this.startButton.TabIndex = 27;
            this.startButton.Text = "ПУСК";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // stationaryRB
            // 
            this.stationaryRB.AutoSize = true;
            this.stationaryRB.BackColor = System.Drawing.Color.White;
            this.stationaryRB.Checked = true;
            this.stationaryRB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stationaryRB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.stationaryRB.Location = new System.Drawing.Point(29, 72);
            this.stationaryRB.Name = "stationaryRB";
            this.stationaryRB.Size = new System.Drawing.Size(176, 31);
            this.stationaryRB.TabIndex = 28;
            this.stationaryRB.TabStop = true;
            this.stationaryRB.Tag = "stationary";
            this.stationaryRB.Text = "Стаціонарний";
            this.stationaryRB.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.stationaryRB.UseVisualStyleBackColor = false;
            this.stationaryRB.CheckedChanged += new System.EventHandler(this.stationaryRB_CheckedChanged);
            // 
            // singleImpulseRB
            // 
            this.singleImpulseRB.AutoSize = true;
            this.singleImpulseRB.BackColor = System.Drawing.Color.White;
            this.singleImpulseRB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.singleImpulseRB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.singleImpulseRB.Location = new System.Drawing.Point(29, 109);
            this.singleImpulseRB.Name = "singleImpulseRB";
            this.singleImpulseRB.Size = new System.Drawing.Size(235, 31);
            this.singleImpulseRB.TabIndex = 29;
            this.singleImpulseRB.Tag = "impulse";
            this.singleImpulseRB.Text = "Одиночний імпульс";
            this.singleImpulseRB.UseVisualStyleBackColor = false;
            this.singleImpulseRB.CheckedChanged += new System.EventHandler(this.singleImpulseRB_CheckedChanged);
            // 
            // seriesOfImpulsesRB
            // 
            this.seriesOfImpulsesRB.AutoSize = true;
            this.seriesOfImpulsesRB.BackColor = System.Drawing.Color.White;
            this.seriesOfImpulsesRB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.seriesOfImpulsesRB.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.seriesOfImpulsesRB.Location = new System.Drawing.Point(27, 146);
            this.seriesOfImpulsesRB.Name = "seriesOfImpulsesRB";
            this.seriesOfImpulsesRB.Size = new System.Drawing.Size(191, 31);
            this.seriesOfImpulsesRB.TabIndex = 30;
            this.seriesOfImpulsesRB.Tag = "serie";
            this.seriesOfImpulsesRB.Text = "Серія імпульсів";
            this.seriesOfImpulsesRB.UseVisualStyleBackColor = false;
            this.seriesOfImpulsesRB.CheckedChanged += new System.EventHandler(this.seriesOfImpulsesRB_CheckedChanged);
            // 
            // stopButton
            // 
            this.stopButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.stopButton.FlatAppearance.BorderColor = System.Drawing.Color.SeaShell;
            this.stopButton.FlatAppearance.BorderSize = 5;
            this.stopButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.stopButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.stopButton.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stopButton.ForeColor = System.Drawing.Color.White;
            this.stopButton.Location = new System.Drawing.Point(205, 757);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(156, 61);
            this.stopButton.TabIndex = 32;
            this.stopButton.Text = "СТОП";
            this.stopButton.UseVisualStyleBackColor = false;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(323, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 27);
            this.label1.TabIndex = 33;
            this.label1.Text = "мс";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(323, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 27);
            this.label5.TabIndex = 34;
            this.label5.Text = "мс";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(23, 20);
            this.label6.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 32);
            this.label6.TabIndex = 35;
            this.label6.Text = "Режим роботи";
            // 
            // chart
            // 
            chartArea7.AxisX.ScrollBar.ButtonStyle = System.Windows.Forms.DataVisualization.Charting.ScrollBarButtonStyles.None;
            chartArea7.AxisX.Title = "t, мс";
            chartArea7.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea7.AxisY.Maximum = 9000000D;
            chartArea7.AxisY.Minimum = 7000000D;
            chartArea7.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea7.AxisY.Title = "U, В";
            chartArea7.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea7.BackColor = System.Drawing.Color.White;
            chartArea7.Name = "ChartArea1";
            chartArea7.Position.Auto = false;
            chartArea7.Position.Height = 94F;
            chartArea7.Position.Width = 94F;
            chartArea7.Position.Y = 3F;
            this.chart.ChartAreas.Add(chartArea7);
            legend4.Enabled = false;
            legend4.Name = "Legend1";
            this.chart.Legends.Add(legend4);
            this.chart.Location = new System.Drawing.Point(358, 20);
            this.chart.Name = "chart";
            series19.BorderWidth = 3;
            series19.ChartArea = "ChartArea1";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series19.Color = System.Drawing.Color.DodgerBlue;
            series19.Legend = "Legend1";
            series19.MarkerSize = 1;
            series19.Name = "Series1";
            series20.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series20.ChartArea = "ChartArea1";
            series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series20.Color = System.Drawing.Color.Red;
            series20.Legend = "Legend1";
            series20.Name = "Series2";
            series21.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series21.ChartArea = "ChartArea1";
            series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series21.Color = System.Drawing.Color.Red;
            series21.Legend = "Legend1";
            series21.Name = "Series3";
            series22.BorderWidth = 5;
            series22.ChartArea = "ChartArea1";
            series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series22.Color = System.Drawing.Color.Red;
            series22.Legend = "Legend1";
            series22.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series22.Name = "Series4";
            series23.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            series23.ChartArea = "ChartArea1";
            series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series23.Color = System.Drawing.Color.Black;
            series23.Legend = "Legend1";
            series23.Name = "Series5";
            this.chart.Series.Add(series19);
            this.chart.Series.Add(series20);
            this.chart.Series.Add(series21);
            this.chart.Series.Add(series22);
            this.chart.Series.Add(series23);
            this.chart.Size = new System.Drawing.Size(1059, 400);
            this.chart.TabIndex = 36;
            this.chart.Text = "chart";
            // 
            // chartValve
            // 
            chartArea8.AxisX.Title = "t, мс";
            chartArea8.AxisX.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea8.AxisX2.Title = "t, мс";
            chartArea8.AxisX2.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea8.AxisY.MajorGrid.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Auto;
            chartArea8.AxisY.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            chartArea8.AxisY.Title = "N";
            chartArea8.AxisY.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea8.BackColor = System.Drawing.Color.White;
            chartArea8.Name = "ChartArea1";
            this.chartValve.ChartAreas.Add(chartArea8);
            this.chartValve.Location = new System.Drawing.Point(451, 426);
            this.chartValve.Name = "chartValve";
            series24.BorderWidth = 3;
            series24.ChartArea = "ChartArea1";
            series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series24.Name = "Series1";
            this.chartValve.Series.Add(series24);
            this.chartValve.Size = new System.Drawing.Size(966, 400);
            this.chartValve.TabIndex = 37;
            this.chartValve.Text = "chartValve";
            // 
            // clearLists
            // 
            this.clearLists.BackColor = System.Drawing.Color.DodgerBlue;
            this.clearLists.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearLists.ForeColor = System.Drawing.Color.White;
            this.clearLists.Location = new System.Drawing.Point(206, 681);
            this.clearLists.Name = "clearLists";
            this.clearLists.Size = new System.Drawing.Size(155, 61);
            this.clearLists.TabIndex = 40;
            this.clearLists.Text = "ОЧИСТИТИ ДАНІ";
            this.clearLists.UseVisualStyleBackColor = false;
            this.clearLists.Click += new System.EventHandler(this.clearLists_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(25, 376);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(201, 25);
            this.label7.TabIndex = 41;
            this.label7.Text = "Kоефіцієнт фільтру:";
            // 
            // kNUD
            // 
            this.kNUD.BackColor = System.Drawing.Color.White;
            this.kNUD.DecimalPlaces = 1;
            this.kNUD.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.kNUD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.kNUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.kNUD.Location = new System.Drawing.Point(29, 405);
            this.kNUD.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.kNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.kNUD.Name = "kNUD";
            this.kNUD.Size = new System.Drawing.Size(288, 33);
            this.kNUD.TabIndex = 42;
            this.kNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.kNUD.ValueChanged += new System.EventHandler(this.kNUD_ValueChanged);
            // 
            // qualityControlButton
            // 
            this.qualityControlButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.qualityControlButton.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.qualityControlButton.ForeColor = System.Drawing.Color.AliceBlue;
            this.qualityControlButton.Location = new System.Drawing.Point(23, 681);
            this.qualityControlButton.Name = "qualityControlButton";
            this.qualityControlButton.Size = new System.Drawing.Size(168, 61);
            this.qualityControlButton.TabIndex = 43;
            this.qualityControlButton.Text = "ОЦІНКА ЯКОСТІ";
            this.qualityControlButton.UseVisualStyleBackColor = false;
            this.qualityControlButton.Click += new System.EventHandler(this.qualityControlButton_Click);
            // 
            // faultNUD
            // 
            this.faultNUD.BackColor = System.Drawing.Color.White;
            this.faultNUD.DecimalPlaces = 2;
            this.faultNUD.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.faultNUD.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.faultNUD.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.faultNUD.Location = new System.Drawing.Point(28, 481);
            this.faultNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.faultNUD.Name = "faultNUD";
            this.faultNUD.Size = new System.Drawing.Size(289, 33);
            this.faultNUD.TabIndex = 48;
            this.faultNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(25, 452);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 25);
            this.label8.TabIndex = 49;
            this.label8.Text = "Похибка:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(323, 483);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(30, 25);
            this.label9.TabIndex = 50;
            this.label9.Text = "%";
            // 
            // dataToFileButton
            // 
            this.dataToFileButton.BackColor = System.Drawing.Color.DodgerBlue;
            this.dataToFileButton.Font = new System.Drawing.Font("Times New Roman", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dataToFileButton.ForeColor = System.Drawing.Color.White;
            this.dataToFileButton.Location = new System.Drawing.Point(23, 604);
            this.dataToFileButton.Name = "dataToFileButton";
            this.dataToFileButton.Size = new System.Drawing.Size(334, 61);
            this.dataToFileButton.TabIndex = 51;
            this.dataToFileButton.Text = "ВИВЕСТИ ДАНІ У ФАЙЛ";
            this.dataToFileButton.UseVisualStyleBackColor = false;
            this.dataToFileButton.Click += new System.EventHandler(this.dataToFileButton_Click);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1440, 851);
            this.Controls.Add(this.dataToFileButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.faultNUD);
            this.Controls.Add(this.qualityControlButton);
            this.Controls.Add(this.kNUD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.clearLists);
            this.Controls.Add(this.chartValve);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.stationaryRB);
            this.Controls.Add(this.seriesOfImpulsesRB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.singleImpulseRB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.adjustmentDurationOfPauseNUD);
            this.Controls.Add(this.adjustmentDurationOfImpulseNUD);
            this.Controls.Add(this.label2);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.ShowIcon = false;
            this.TransparencyKey = System.Drawing.Color.Black;
            ((System.ComponentModel.ISupportInitialize)(this.adjustmentDurationOfImpulseNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adjustmentDurationOfPauseNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartValve)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.faultNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown adjustmentDurationOfImpulseNUD;
        private System.Windows.Forms.NumericUpDown adjustmentDurationOfPauseNUD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.RadioButton stationaryRB;
        private System.Windows.Forms.RadioButton singleImpulseRB;
        private System.Windows.Forms.RadioButton seriesOfImpulsesRB;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartValve;
        private System.Windows.Forms.Button clearLists;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown kNUD;
        private System.Windows.Forms.Button qualityControlButton;
        private System.Windows.Forms.NumericUpDown faultNUD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button dataToFileButton;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
    }
}

