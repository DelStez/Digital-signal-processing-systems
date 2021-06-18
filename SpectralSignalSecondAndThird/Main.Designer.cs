
namespace SpectralSignalSecondAndThird
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.ANumeric = new System.Windows.Forms.NumericUpDown();
            this.TNumeric = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.NNumeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.SignalF = new System.Windows.Forms.NumericUpDown();
            this.SignalFLabel = new System.Windows.Forms.Label();
            this.SamplingF = new System.Windows.Forms.NumericUpDown();
            this.SamplingFLabel = new System.Windows.Forms.Label();
            this.btnDFT = new System.Windows.Forms.Button();
            this.AChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.PChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnDFTR = new System.Windows.Forms.Button();
            this.SignalChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.alphaN = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.apl = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ANumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SignalF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SamplingF)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SignalChart)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alphaN)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "A = ";
            // 
            // ANumeric
            // 
            this.ANumeric.Location = new System.Drawing.Point(39, 19);
            this.ANumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.ANumeric.Name = "ANumeric";
            this.ANumeric.Size = new System.Drawing.Size(83, 20);
            this.ANumeric.TabIndex = 8;
            this.ANumeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.ANumeric.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // TNumeric
            // 
            this.TNumeric.Location = new System.Drawing.Point(39, 45);
            this.TNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.TNumeric.Name = "TNumeric";
            this.TNumeric.Size = new System.Drawing.Size(83, 20);
            this.TNumeric.TabIndex = 10;
            this.TNumeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.TNumeric.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "T = ";
            // 
            // NNumeric
            // 
            this.NNumeric.Location = new System.Drawing.Point(40, 71);
            this.NNumeric.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NNumeric.Name = "NNumeric";
            this.NNumeric.Size = new System.Drawing.Size(83, 20);
            this.NNumeric.TabIndex = 12;
            this.NNumeric.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.NNumeric.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "N = ";
            // 
            // SignalF
            // 
            this.SignalF.Location = new System.Drawing.Point(262, 47);
            this.SignalF.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.SignalF.Name = "SignalF";
            this.SignalF.Size = new System.Drawing.Size(46, 20);
            this.SignalF.TabIndex = 16;
            this.SignalF.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.SignalF.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // SignalFLabel
            // 
            this.SignalFLabel.AutoSize = true;
            this.SignalFLabel.Location = new System.Drawing.Point(158, 49);
            this.SignalFLabel.Name = "SignalFLabel";
            this.SignalFLabel.Size = new System.Drawing.Size(98, 13);
            this.SignalFLabel.TabIndex = 15;
            this.SignalFLabel.Text = "SignalFrequency = ";
            // 
            // SamplingF
            // 
            this.SamplingF.Location = new System.Drawing.Point(262, 21);
            this.SamplingF.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.SamplingF.Name = "SamplingF";
            this.SamplingF.Size = new System.Drawing.Size(46, 20);
            this.SamplingF.TabIndex = 14;
            this.SamplingF.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.SamplingF.ValueChanged += new System.EventHandler(this.numericUpDown_ValueChanged);
            // 
            // SamplingFLabel
            // 
            this.SamplingFLabel.AutoSize = true;
            this.SamplingFLabel.Location = new System.Drawing.Point(144, 21);
            this.SamplingFLabel.Name = "SamplingFLabel";
            this.SamplingFLabel.Size = new System.Drawing.Size(112, 13);
            this.SamplingFLabel.TabIndex = 13;
            this.SamplingFLabel.Text = "SamplingFrequency = ";
            // 
            // btnDFT
            // 
            this.btnDFT.Location = new System.Drawing.Point(152, 71);
            this.btnDFT.Name = "btnDFT";
            this.btnDFT.Size = new System.Drawing.Size(75, 23);
            this.btnDFT.TabIndex = 17;
            this.btnDFT.Text = "DFT";
            this.btnDFT.UseVisualStyleBackColor = true;
            this.btnDFT.Click += new System.EventHandler(this.btnDFT_Click);
            // 
            // AChart
            // 
            chartArea1.Name = "ChartArea1";
            this.AChart.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            this.AChart.Legends.Add(legend1);
            this.AChart.Location = new System.Drawing.Point(12, 291);
            this.AChart.Name = "AChart";
            this.AChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "A";
            this.AChart.Series.Add(series1);
            this.AChart.Size = new System.Drawing.Size(640, 123);
            this.AChart.TabIndex = 18;
            this.AChart.Text = "AChart";
            // 
            // PChart
            // 
            chartArea2.Name = "ChartArea1";
            this.PChart.ChartAreas.Add(chartArea2);
            legend2.Enabled = false;
            legend2.Name = "Legend1";
            this.PChart.Legends.Add(legend2);
            this.PChart.Location = new System.Drawing.Point(12, 443);
            this.PChart.Name = "PChart";
            this.PChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "P";
            this.PChart.Series.Add(series2);
            this.PChart.Size = new System.Drawing.Size(640, 123);
            this.PChart.TabIndex = 19;
            this.PChart.Text = "PChart";
            // 
            // btnDFTR
            // 
            this.btnDFTR.Location = new System.Drawing.Point(233, 71);
            this.btnDFTR.Name = "btnDFTR";
            this.btnDFTR.Size = new System.Drawing.Size(75, 23);
            this.btnDFTR.TabIndex = 20;
            this.btnDFTR.Text = "DFT revers";
            this.btnDFTR.UseVisualStyleBackColor = true;
            this.btnDFTR.Click += new System.EventHandler(this.btnDFTR_Click);
            // 
            // SignalChart
            // 
            chartArea3.Name = "ChartArea1";
            this.SignalChart.ChartAreas.Add(chartArea3);
            legend3.Enabled = false;
            legend3.Name = "Legend1";
            this.SignalChart.Legends.Add(legend3);
            this.SignalChart.Location = new System.Drawing.Point(12, 149);
            this.SignalChart.Name = "SignalChart";
            this.SignalChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Berry;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "S";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series2";
            this.SignalChart.Series.Add(series3);
            this.SignalChart.Series.Add(series4);
            this.SignalChart.Size = new System.Drawing.Size(640, 123);
            this.SignalChart.TabIndex = 21;
            this.SignalChart.Text = "SignalChart";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ANumeric);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.SignalFLabel);
            this.groupBox2.Controls.Add(this.btnDFTR);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.SamplingF);
            this.groupBox2.Controls.Add(this.btnDFT);
            this.groupBox2.Controls.Add(this.TNumeric);
            this.groupBox2.Controls.Add(this.SignalF);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.SamplingFLabel);
            this.groupBox2.Controls.Add(this.NNumeric);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(317, 111);
            this.groupBox2.TabIndex = 23;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DFT - 2 Lab";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.alphaN);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.apl);
            this.groupBox1.Location = new System.Drawing.Point(335, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(317, 111);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Window - 3Lab";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Окно Бартлетта ",
            "Окно Ханна ",
            "Окно Хэмминга ",
            "Окно Блэкмана",
            "Окно Наттолла",
            "Усеченное гауссовское окно",
            "Окно Кайзера–Бесселя"});
            this.comboBox1.Location = new System.Drawing.Point(6, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(224, 21);
            this.comboBox1.TabIndex = 22;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // alphaN
            // 
            this.alphaN.Enabled = false;
            this.alphaN.Location = new System.Drawing.Point(166, 47);
            this.alphaN.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.alphaN.Name = "alphaN";
            this.alphaN.Size = new System.Drawing.Size(64, 20);
            this.alphaN.TabIndex = 21;
            this.alphaN.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "alpha = ";
            // 
            // apl
            // 
            this.apl.Location = new System.Drawing.Point(236, 16);
            this.apl.Name = "apl";
            this.apl.Size = new System.Drawing.Size(75, 23);
            this.apl.TabIndex = 0;
            this.apl.Text = "Apply";
            this.apl.UseVisualStyleBackColor = true;
            this.apl.Click += new System.EventHandler(this.apl_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 427);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "Phase";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 275);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Amplitude";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Signal";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 576);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SignalChart);
            this.Controls.Add(this.PChart);
            this.Controls.Add(this.AChart);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ANumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SignalF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SamplingF)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SignalChart)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.alphaN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown ANumeric;
        private System.Windows.Forms.NumericUpDown TNumeric;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown NNumeric;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown SignalF;
        private System.Windows.Forms.Label SignalFLabel;
        private System.Windows.Forms.NumericUpDown SamplingF;
        private System.Windows.Forms.Label SamplingFLabel;
        private System.Windows.Forms.Button btnDFT;
        private System.Windows.Forms.DataVisualization.Charting.Chart AChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart PChart;
        private System.Windows.Forms.Button btnDFTR;
        private System.Windows.Forms.DataVisualization.Charting.Chart SignalChart;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.NumericUpDown alphaN;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button apl;
    }
}

