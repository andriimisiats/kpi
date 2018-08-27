using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;

namespace Master
{
    public partial class MainForm : Form
    {
        public SerialPort port;

        List<int> kgs = new List<int>();
        List<int> times = new List<int>();
        List<int> state = new List<int>();
        List<double> filterKgs = new List<double>();

        double startKG = 0;
        int startTime = 0;
        double koeff = 0.1;

        public MainForm()
        {
            InitializeComponent();
            CheckRadioButtons();
            СonnectToPort();
        }

        public void СonnectToPort()
        {
            port = new SerialPort
            {
                PortName = "COM4",
                Parity = Parity.None,
                StopBits = StopBits.One,
                DataBits = 8,
                BaudRate = 38400
            };

            port.DataReceived += new SerialDataReceivedEventHandler(serialDataReceivedEventHandler);

            try
            {
                port.Open();
            }
            catch (System.IO.IOException e)
            {
                MessageBox.Show(e.Message.ToString());
                this.Close();
            }
        }

        private void serialDataReceivedEventHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sData = sender as SerialPort;
            string recData = sData.ReadLine();

            int dataKG;
            int dataTIME;
            int dataOPEN;
        
            string[] subStrings = recData.Split(';');

            if (Int32.TryParse(subStrings[0], out dataKG))
            {
                kgs.Add(dataKG);
            }

            if (Int32.TryParse(subStrings[1], out dataTIME))
            {
                times.Add(dataTIME);
            }

            if (Int32.TryParse(subStrings[2], out dataOPEN))
            {
                state.Add(dataOPEN);
            }

            if (startTime == 0)
                startTime = dataTIME;

            if (startKG == 0)
                startKG = dataKG;

            startKG = startKG * (1 - koeff) + dataKG * koeff;

            filterKgs.Add(startKG);

            chart.Invoke((MethodInvoker)delegate { chart.Series[0].Points.AddXY(dataTIME - startTime, startKG); });

            if (dataOPEN == 1)
                chartValve.Invoke((MethodInvoker)delegate { chartValve.Series[0].Points.AddXY(dataTIME - startTime, 0); });
            else
                chartValve.Invoke((MethodInvoker)delegate { chartValve.Series[0].Points.AddXY(dataTIME - startTime, 1); });

            chart.Invoke((MethodInvoker)delegate
            {
                chart.ChartAreas[0].AxisY.Maximum = filterKgs.Max() + 2000;
                chart.ChartAreas[0].AxisY.Minimum = filterKgs.Min() - 2000;
            });
        }

        private void CheckRadioButtons()
        {
            if (seriesOfImpulsesRB.Checked)
            {
                adjustmentDurationOfImpulseNUD.Enabled = true;
                adjustmentDurationOfPauseNUD.Enabled = true;
            }

            if (singleImpulseRB.Checked)
            {
                adjustmentDurationOfImpulseNUD.Enabled = true;
                adjustmentDurationOfPauseNUD.Enabled = false;
            }

            if (stationaryRB.Checked)
            {
                adjustmentDurationOfImpulseNUD.Enabled = false;
                adjustmentDurationOfPauseNUD.Enabled = false;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            decimal adjustmentDurationOfImpulse = adjustmentDurationOfImpulseNUD.Value;
            decimal adjustentDurationOfPause = adjustmentDurationOfPauseNUD.Value;

            string modeOfOperation = "";

            if (stationaryRB.Checked)
                modeOfOperation = stationaryRB.Tag.ToString();

            if (singleImpulseRB.Checked)
                modeOfOperation = singleImpulseRB.Tag.ToString();

            if (seriesOfImpulsesRB.Checked)
                modeOfOperation = seriesOfImpulsesRB.Tag.ToString();

            port.Write(
                modeOfOperation + ";" +
                adjustmentDurationOfImpulse + ";" +
                adjustentDurationOfPause
            );

        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            port.Write("stop;");
        }

        private void stationaryRB_CheckedChanged(object sender, EventArgs e)
        {
            if (stationaryRB.Checked)
            {
                adjustmentDurationOfImpulseNUD.Enabled = false;
                adjustmentDurationOfPauseNUD.Enabled = false;
            }
        }

        private void singleImpulseRB_CheckedChanged(object sender, EventArgs e)
        {
            if (singleImpulseRB.Checked)
            {
                adjustmentDurationOfImpulseNUD.Enabled = true;
                adjustmentDurationOfPauseNUD.Enabled = false;
            }
        }

        private void seriesOfImpulsesRB_CheckedChanged(object sender, EventArgs e)
        {
            if (seriesOfImpulsesRB.Checked)
            {
                adjustmentDurationOfImpulseNUD.Enabled = true;
                adjustmentDurationOfPauseNUD.Enabled = true;
            }
        }

        private void clearLists_Click(object sender, EventArgs e)
        {
            times.Clear();
            kgs.Clear();
            state.Clear();
            filterKgs.Clear();

            startTime = 0;
            startKG = 0;

            foreach (var series in chart.Series)
            {
                series.Points.Clear();
            }

            foreach (var series in chartValve.Series)
            {
                series.Points.Clear();
            }
        }

        private void kNUD_ValueChanged(object sender, EventArgs e)
        {
            koeff = (double) kNUD.Value;
        }

        private void qualityControlButton_Click(object sender, EventArgs e)
        {
            List<double> verh = new List<double>();

            for (var i = 0; i < times.Count; i++)
            {
                if (state[i] == 0)
                    verh.Add(filterKgs[i]);
            }

            double h_yst = verh[verh.Count - 1];

            double minus_delta = h_yst - ((h_yst * (double)faultNUD.Value) / 100);
            double plus_delta = h_yst + ((h_yst * (double)faultNUD.Value) / 100);
            double x_minus = 0;
            double y_minus = 0;
            double x_plus = 0;
            double y_plus = 0;
            double pp_time = 0;
            double narost_time = 0;

            chart.Series[1].Points.Clear();
            chart.Series[2].Points.Clear();
            chart.Series[3].Points.Clear();
            chart.Series[4].Points.Clear();

            foreach (var time in times)
            {
                chart.Series[1].Points.AddXY(time - startTime, minus_delta);
                chart.Series[2].Points.AddXY(time - startTime, plus_delta);
                chart.Series[4].Points.AddXY(time - startTime, h_yst);
            }

            for (var i = times.Count - 1; i > 0; i--)
            {
                double A1 = filterKgs[i] - filterKgs[i - 1];
                double B1 = (times[i - 1] - startTime) - (times[i] - startTime);

                double A2 = plus_delta - plus_delta;
                double B2 = (times[i - 1] - startTime) - (times[i] - startTime);

                double delta = (A1 * B2) - (A2 * B1);

                if ((state[i] == 0) && delta != 0  && filterKgs[i - 1] > plus_delta && filterKgs[i] < plus_delta)
                {
                    double C1 = (A1 * (times[i - 1] - startTime)) + (B1 * filterKgs[i - 1]);
                    double C2 = (A2 * (times[i - 1] - startTime)) + (B2 * plus_delta);

                    x_plus = (B2 * C1 - B1 * C2) / delta;
                    y_plus = (A1 * C2 - A2 * C1) / delta;
                    
                    break;
                }
            }

            for (var i = times.Count - 1; i > 0; i--)
            {
                double A1 = filterKgs[i] - filterKgs[i - 1];
                double B1 = (times[i - 1] - startTime) - (times[i] - startTime);

                double A2 = minus_delta - minus_delta;
                double B2 = (times[i - 1] - startTime) - (times[i] - startTime);

                double delta = (A1 * B2) - (A2 * B1);

                if (delta != 0 && filterKgs[i - 1] < minus_delta && filterKgs[i] > minus_delta)
                {
                    double C1 = (A1 * (times[i - 1] - startTime)) + (B1 * filterKgs[i - 1]);
                    double C2 = (A2 * (times[i - 1] - startTime)) + (B2 * minus_delta);

                    x_minus = (B2 * C1 - B1 * C2) / delta;
                    y_minus = (A1 * C2 - A2 * C1) / delta;

                    break;
                }
            }

            for (var i = 0; i < times.Count - 1; i++)
            {
                double A1 = filterKgs[i + 1] - filterKgs[i];
                double B1 = (times[i] - startTime) - (times[i + 1] - startTime);

                double A2 = h_yst - h_yst;
                double B2 = (times[i] - startTime) - (times[i + 1] - startTime);

                double delta = (A1 * B2) - (A2 * B1);

                if (delta != 0 && ((filterKgs[i] < h_yst && filterKgs[i + 1] > h_yst) || (filterKgs[i] > h_yst && filterKgs[i + 1] < h_yst)))
                {
                    double C1 = (A1 * (times[i] - startTime)) + (B1 * filterKgs[i]);
                    double C2 = (A2 * (times[i] - startTime)) + (B2 * h_yst);

                    double x_per = (B2 * C1 - B1 * C2) / delta;
                    double y_per = (A1 * C2 - A2 * C1) / delta;

                    narost_time = x_per;

                    break;
                }
            }

            if (x_minus > x_plus)
            {
                chart.Series[3].Points.AddXY(x_minus, y_minus);
                pp_time = x_minus;
            }
            else
            {
                chart.Series[3].Points.AddXY(x_plus, y_plus);
                pp_time = x_plus;
            }

            double perereg = ((filterKgs.Max() - h_yst) / filterKgs.Max()) * 100;

            int maxTimeIndex = filterKgs.IndexOf(filterKgs.Max());

            

            MessageBox.Show(
                "Час перехідного процесу: " + (pp_time).ToString() + " мс." + "\n" +
                "Перерегулювання: " + (perereg).ToString() + " %" +  "\n" +
                "Час досягнення максимуму: " + (times[maxTimeIndex] - startTime).ToString() + " мс." + "\n" +
                "Час наростання ПП: " + (narost_time).ToString() + " мс." + "\n" + 
                "Усталене значення: " + "\n" + 
                "Частота коливань: " + "\n",
                "Оцінка якості перехідного процесу",
                MessageBoxButtons.OK
            );
        }

        private void dataToFileButton_Click(object sender, EventArgs e)
        {
            string n = string.Format("research-{0:yyyy-MM-dd_hh-mm-ss}.txt", DateTime.Now);
            string path = @"e:\research\" + n;

            try
            {
                // Delete the file if it exists.
                if (File.Exists(path))
                {
                    File.Delete(path);
                }

                // Create the file.
                using (StreamWriter file = new StreamWriter(path))
                {
                    for (var i = 0; i < times.Count; i++)
                    {
                        if (state[i] == 0)
                        {
                            file.WriteLine((times[i] - startTime) + ";" + filterKgs[i] + ";" + 1 + ";");
                        }
                        else
                        {
                            file.WriteLine((times[i] - startTime) + ";" + filterKgs[i] + ";" + 0 + ";");
                        }
                    }
                }
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}