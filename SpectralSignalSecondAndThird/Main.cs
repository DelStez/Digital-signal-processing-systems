using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ZedGraph;

namespace SpectralSignalSecondAndThird
{
    public partial class MainForm : Form
    {
        private readonly FunctionGenerator _functionGenerator;
        private readonly Random _random = new Random();
        private readonly DftProcessor _dftProcessor;
        private readonly Series series1 = new Series();
        private readonly WindowFunctions windowFunctions = new WindowFunctions();
        private Complex[] spectr;
        public MainForm()
        {
            InitializeComponent();
            _functionGenerator = new FunctionGenerator();
            _dftProcessor = new DftProcessor();
            SignalChart.Series[0].ChartType = SeriesChartType.Line;
            SignalChart.Series[1].ChartType = SeriesChartType.Line;
            AChart.Series[0].Color = Color.DarkBlue;
            PChart.Series[0].Color = Color.DarkBlue;
            SignalChart.Series[1].Color = Color.Blue;
            SignalChart.Series[0].Color = Color.Red;
            ANumeric.Value = 100;
            TNumeric.Value = 100;
            NNumeric.Value = 100;
            SignalF.Value = 40;
            SamplingF.Value = 6;
            alphaN.Value = 10;
            comboBox1.SelectedIndex = 1;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            DrawGraph( _functionGenerator.Generate(Convert.ToDouble(NNumeric.Value), Convert.ToDouble(TNumeric.Value),
                40, 6, Convert.ToDouble(ANumeric.Value)));
        }
        private void DrawGraph( double[] values, double[] times = null)
        {
            Clear();
            
            var t = 0.0;
            var dt = Convert.ToDouble(TNumeric.Value) / Convert.ToDouble(NNumeric.Value);
            var data = values.Select((x, i) => new { item = x, index = t += dt})
                .ToList();
            var pointPairList = new PointPairList(times ?? data.Select(x => x.index).ToArray(),
                data.Select(x => x.item).ToArray());
            for (int h = 0; h < data.Count; h++)
            {
                SignalChart.Series[0].Points.AddXY(data[h].index, data[h].item);
            }
        }
        private void DrawGraph(Complex[] values, double[] times = null)
        {
            Clear();

            var t = 0.0;
            var dt = Convert.ToDouble(TNumeric.Value) / Convert.ToDouble(NNumeric.Value);
            var data = values.Select((x, i) => new { item = x, index = t += dt })
                .ToList();
            for (int h = 0; h < data.Count; h++)
            {
                SignalChart.Series[0].Points.AddXY(data[h].index, data[h].item);
            }
        }

        private void numericUpDown_ValueChanged(object sender, EventArgs e)
        {
            DrawGraph(_functionGenerator.Generate(Convert.ToDouble(NNumeric.Value), Convert.ToDouble(TNumeric.Value),
                Convert.ToDouble(SignalF.Value), Convert.ToDouble(SamplingF.Value), Convert.ToDouble(ANumeric.Value)));
        }
        private void btnDFT_Click(object sender, EventArgs e)
        {
            Clear();
            var h = _functionGenerator.Generate(Convert.ToDouble(NNumeric.Value), Convert.ToDouble(TNumeric.Value),
                Convert.ToDouble(SignalF.Value), Convert.ToDouble(SamplingF.Value), Convert.ToDouble(ANumeric.Value));
            DrawGraph(h);
            var result = _dftProcessor.Transform(h, Convert.ToDouble(NNumeric.Value), sender == btnDFTR ? true : false);
            var dt = Convert.ToDouble(TNumeric.Value) / Convert.ToDouble(NNumeric.Value);
            spectr = new Complex[result.Length];
            result.CopyTo(spectr, 0);
            var t = result.Select((_, i) => (double)1 / (i / dt / result.Length)).ToArray();
            for (int j = 0; j < result.Length; j++)
            {
                var temp = Math.Sqrt(Math.Pow(result[j].Real, 2) + Math.Pow(result[j].Imaginary, 2));
                var temp_1 = Math.Atan2(result[j].Imaginary, result[j].Real);
                AChart.Series[0].Points.AddY(temp);
                PChart.Series[0].Points.AddY(temp_1);
            }
        }
        private void DrawGraphS(double[] values, double[] times = null)
        {
            SignalChart.Series[1].Points.Clear();
            var t = 0.0;
            var dt = Convert.ToDouble(TNumeric.Value) / Convert.ToDouble(NNumeric.Value);
            var data = values.Select((x, i) => new { item = x, index = t += dt })
                .ToList();
            for (int h = 0; h < data.Count; h++)
            { 
                SignalChart.Series[1].Points.AddXY(data[h].index, data[h].item);
            }
        }
        private void Clear()
        {
            AChart.Series[0].Points.Clear();
            PChart.Series[0].Points.Clear();
            SignalChart.Series[0].Points.Clear();
            SignalChart.Series[1].Points.Clear();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex >= 5)
            {
                alphaN.Enabled = true;
            }
            else
                alphaN.Enabled = false;
        }

        private void apl_Click(object sender, EventArgs e)
        {
            AChart.Series[0].Points.Clear();
            PChart.Series[0].Points.Clear();
            var window = windowFunctions.SelectTransform(_functionGenerator.Generate(Convert.ToDouble(NNumeric.Value),
                Convert.ToDouble(TNumeric.Value), Convert.ToDouble(SignalF.Value), Convert.ToDouble(SamplingF.Value),
                Convert.ToDouble(ANumeric.Value)), Convert.ToDouble(NNumeric.Value), comboBox1.SelectedIndex +1, (double)alphaN.Value);
            DrawGraphS(window);
            var result =_dftProcessor.Transform(window, Convert.ToDouble(NNumeric.Value), sender == btnDFTR ? true : false);
            var dt = Convert.ToDouble(TNumeric.Value) / Convert.ToDouble(NNumeric.Value);
            var t = result.Select((_, i) => (double)1 / (i / dt / result.Length)).ToArray();
            for (int j = 0; j < result.Length; j++)
            {
                var temp = Math.Sqrt(Math.Pow(result[j].Real, 2) + Math.Pow(result[j].Imaginary, 2));
                var temp_1 = Math.Atan2(result[j].Imaginary, result[j].Real);
                AChart.Series[0].Points.AddY(temp);
                PChart.Series[0].Points.AddY(temp_1);
            }
        }

        private void btnDFTR_Click(object sender, EventArgs e)
        {
            SignalChart.Series[0].Points.Clear();
            var result = _dftProcessor.Transform(spectr, Convert.ToDouble(NNumeric.Value), true);
            var dt = Convert.ToDouble(TNumeric.Value) / Convert.ToDouble(NNumeric.Value);
            var t = result.Select((_, i) => (double)1 / (i / dt / spectr.Length)).ToArray();
            DrawGraph(result);
        }
    }
}
