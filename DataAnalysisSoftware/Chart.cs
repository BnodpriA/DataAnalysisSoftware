using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Threading;
using System.Text.RegularExpressions;
using System.Timers;
using ZedGraph;

namespace DataAnalysisSoftware
{
    public partial class Chart : Form
    {
        public string fileName;
        delegate void HRDataMethod(string hrData); //This Delegate is a type safe function pointer for HRDataMethod
        delegate void AxisChangeZedGraphCallBack(ZedGraphControl zg);
        public Thread garthererThread;

        LineItem lineOfHeartRate, lineOfSpeed, lineOfCadence, lineOfAltitude, lineOfPower; //Declaring Curve Line Item
        
        PointPairList pointPairListOfHeartRate;
        PointPairList pointPairListOfSpeed;
        PointPairList pointPairListOfCadence;
        PointPairList pointPairListOfAltitude;
        PointPairList pointPairListOfPower;

        string[] heartRates; //Arrary to store Heart Rate
        string[] speeds;
        string[] cadences;
        string[] altitudes;
        string[] powers;

        private void Chart_Load(object sender, EventArgs e)
        {
            GraphPane graphPane = zrcHRMGraph.GraphPane;
            graphPane.Title.Text = "Polar HRM Data Analysis";
            graphPane.XAxis.Title.Text = "X Axis (Values)";
            graphPane.YAxis.Title.Text = "Y Axis " + "\n\n" + "(Heart Rate, Speed, Cadence, Altitude, Power)";

            pointPairListOfHeartRate = new PointPairList();//Declaring PointPairList for Heart Rate
            lineOfHeartRate = graphPane.AddCurve("Heart Rate", pointPairListOfHeartRate, Color.DarkRed, SymbolType.TriangleDown); //Assign lineItem and symbol for PointPairList for Heart Rate

            pointPairListOfSpeed = new PointPairList();//Declaring PointPairList for Speed
            lineOfSpeed = graphPane.AddCurve("Speed", pointPairListOfSpeed, Color.Orange, SymbolType.Plus); //Assign lineItem and symbol for PointPairList for Speed

            pointPairListOfCadence = new PointPairList();//Declaring PointPairList for Cadence
            lineOfCadence = graphPane.AddCurve("Cadence", pointPairListOfCadence, Color.Green, SymbolType.Circle);

            pointPairListOfAltitude = new PointPairList();
            lineOfAltitude = graphPane.AddCurve("Altitude", pointPairListOfAltitude, Color.DarkGray, SymbolType.Triangle);

            pointPairListOfPower = new PointPairList();
            lineOfPower = graphPane.AddCurve("Power", pointPairListOfPower, Color.Maroon, SymbolType.XCross);

            //call HeartRateThread
            Thread heartRateThread = new Thread(new ThreadStart(HeartRateThread));
            heartRateThread.Start();

            //call SpeedThread
            Thread speedThread = new Thread(new ThreadStart(SpeedThread));
            speedThread.Start();

            //call CadenceThread
            Thread cadenceThread = new Thread(new ThreadStart(CadenceThread));
            cadenceThread.Start();

            //call AltitudeThread
            Thread altitudeThread = new Thread(new ThreadStart(AltitudeThread));
            altitudeThread.Start();

            //call PowerThread
            Thread powerThread = new Thread(new ThreadStart(PowerThread));
            powerThread.Start();

            //call CreateGraph Thread
            Thread createGraphThread = new Thread(new ThreadStart(CreateGraph));
            createGraphThread.Start();
        }
        
        public Chart()
        {
            InitializeComponent();
        }
        private void AxisChangeZedGraph(ZedGraphControl zg)
        {
            if (zg.InvokeRequired)
            {
                AxisChangeZedGraphCallBack ad = new AxisChangeZedGraphCallBack(AxisChangeZedGraph);
                zg.Invoke(ad, new object[] { zg });
            }
            else
            {
                zrcHRMGraph.AxisChange();
                zg.Invalidate();
                zg.Refresh();
            }
        }
        private void TimerCallBack(object source, ElapsedEventArgs e)
        {
            garthererThread = new Thread(new ThreadStart(GartherData));
        }
        /// <summary>
        /// Find the work of it
        /// </summary>
        private void GartherData()
        {
            List<float> gadtheredInfo = new List<float>();
            zrcHRMGraph.Invoke(new MethodInvoker(delegate { zrcHRMGraph.Invalidate(); }));
        }
        private void CreateGraph()
        {

            try
            {
                string hrmData = File.ReadAllText(fileName);
                string[] hrmDataArr = hrmData.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                int indexOfHRMDataArr = Array.IndexOf(hrmDataArr, "[HRData]");
                heartRates = new string[hrmDataArr.Length - indexOfHRMDataArr];
                speeds = new string[hrmDataArr.Length - indexOfHRMDataArr];
                cadences = new string[hrmDataArr.Length - indexOfHRMDataArr];
                altitudes = new string[hrmDataArr.Length - indexOfHRMDataArr];
                powers = new string[hrmDataArr.Length - indexOfHRMDataArr];
                int j = 0;



                // Make up some, data arrays based on the Sine function
                double x, y1, y2, y3, y4, y5;
                PointPairList pointPairListOfHeartRate = new PointPairList();
                PointPairList pointPairListOfSpeed = new PointPairList();
                PointPairList pointPairListOfCadence = new PointPairList();
                PointPairList pointPairListOfAltitude = new PointPairList();
                PointPairList pointPairListOfPower = new PointPairList();
                for (int i = indexOfHRMDataArr + 1; i < hrmDataArr.Length - 1; i++)
                {
                    string hrData = hrmDataArr[i];
                    string[] hrDataArr = Regex.Split(hrData, @"\W+");

                    heartRates[j] = hrDataArr[0];
                    speeds[j] = hrDataArr[1];
                    cadences[j] = hrDataArr[2];
                    altitudes[j] = hrDataArr[3];
                    powers[j] = hrDataArr[4];

                    int heartRate = Convert.ToInt32(heartRates[j]);
                    int speed = Convert.ToInt32(speeds[j]);
                    int cadence = Convert.ToInt32(cadences[j]);
                    int altitude = Convert.ToInt32(altitudes[j]);
                    int power = Convert.ToInt32(powers[j]);

                    x = i;
                    y1 = heartRate;
                    y2 = speed;
                    y3 = cadence;
                    y4 = altitude;
                    y5 = power;

                    //Adding lineOfHeartRate in zrcHRMGraph
                    LineItem lineOfHeartRate = zrcHRMGraph.GraphPane.CurveList["Heart Rate"] as LineItem;
                    IPointListEdit heartList = lineOfHeartRate.Points as IPointListEdit;
                    heartList.Add(x, y1);

                    //Adding lineOfSpeed in zrcHRMGraph
                    LineItem lineOfSpeed = zrcHRMGraph.GraphPane.CurveList["Speed"] as LineItem;
                    IPointListEdit speedList = lineOfSpeed.Points as IPointListEdit;
                    speedList.Add(x, y2);

                    //Adding lineOfCadence in zrcHRMGraph
                    LineItem lineOfCadence = zrcHRMGraph.GraphPane.CurveList["Cadence"] as LineItem;
                    IPointListEdit cadenceList = lineOfCadence.Points as IPointListEdit;
                    cadenceList.Add(x, y3);

                    //Adding lineOfAltitude in zrcHRMGraph
                    LineItem lineOfAltitude = zrcHRMGraph.GraphPane.CurveList["Altitude"] as LineItem;
                    IPointListEdit altitudeList = lineOfAltitude.Points as IPointListEdit;
                    altitudeList.Add(x, y4);

                    //Adding lineOfPower in zrcGraph
                    LineItem lineOfPower = zrcHRMGraph.GraphPane.CurveList["Power"] as LineItem;
                    IPointListEdit powerList = lineOfPower.Points as IPointListEdit;
                    powerList.Add(x, y5);

                    AxisChangeZedGraph(zrcHRMGraph);
                    Thread.Sleep(700);
                }
            }
            catch (Exception ex)
            {

               // MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Funtion to display Heart Rate in Summary
        /// 
        /// </summary>
        /// <param name="heartRate"></param>
        private void HRDataHeartRate(string heartRate)
        {
            try
            {
                if (lblHeartRate.InvokeRequired)
                {
                    HRDataMethod hrDataMethod = new HRDataMethod(HRDataHeartRate);
                    this.Invoke(hrDataMethod, new object[] { heartRate });
                }
                else
                {
                    lblHeartRate.Text = heartRate;
                }
            }
            catch (InvalidAsynchronousStateException)
            {
                DataAnalysisSystemPanel asp = new DataAnalysisSystemPanel();
                asp.Close();
                //throw;
            }

        }
        /// <summary>
        /// Thead for fetch Heart Rate
        /// </summary>
        public void HeartRateThread()
        {
            try
            {
                string hrmData = File.ReadAllText(fileName);
                string[] hrmDataArr = hrmData.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                int indexOfHRMDataArr = Array.IndexOf(hrmDataArr, "[HRData]");
                heartRates = new string[hrmDataArr.Length - indexOfHRMDataArr];
                int j = 0;

                for (int i = indexOfHRMDataArr + 1; i < hrmDataArr.Length - 1; i++)
                {
                    string hrData = hrmDataArr[i];
                    string[] hrDataArr = Regex.Split(hrData, @"\W+");
                    heartRates[j] = hrDataArr[0];
                    this.HRDataHeartRate(heartRates[j].ToString());
                    Thread.Sleep(700);
                    j++;
                }
            }
            catch (Exception ex)
            {

               //MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Fucntion to Display Value of Speed in the Summary
        /// </summary>
        /// <param name="speed"></param>
        private void HRDataSpeed(string speed)
        {
            try
            {
                if (lblSpeed.InvokeRequired)
                {
                    HRDataMethod hrDataMethod = new HRDataMethod(HRDataSpeed);
                    this.Invoke(hrDataMethod, new object[] { speed });
                }
                else
                {
                    lblSpeed.Text = speed;
                }
            }
            catch (Exception ex)
            {

                //MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Thread to fetch Speed
        /// </summary>
        private void SpeedThread()
        {
            try
            {
                string hrmData = File.ReadAllText(fileName);
                string[] hrmDataArr = hrmData.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                int indexOfHRMDataArr = Array.IndexOf(hrmDataArr, "[HRData]");
                speeds = new string[hrmDataArr.Length - indexOfHRMDataArr];
                int j = 0;

                for (int i = indexOfHRMDataArr + 1; i < hrmDataArr.Length - 1; i++)
                {
                    string hrData = hrmDataArr[i];
                    string[] hrDataArr = Regex.Split(hrData, @"\W+");
                    speeds[j] = hrDataArr[1];
                    this.HRDataSpeed(speeds[j].ToString());
                    Thread.Sleep(700);
                    j++;
                }
            }
            catch ( Exception ex)
            {

               // MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Function to show values of candence in the summary
        /// </summary>
        /// <param name="cadence"></param>
        private void HRDataCadence(string cadence)
        {
            try
            {
                if (lblCadence.InvokeRequired)
                {
                    HRDataMethod hrDataMethod = new HRDataMethod(HRDataCadence);
                    this.Invoke(hrDataMethod, new object[] { cadence });
                }
                else
                {
                    lblCadence.Text = cadence;
                }
            }
            catch (Exception ex)
            {

               
            }
        }
        /// <summary>
        /// Thread to Fetch the Value of Cadence
        /// </summary>
        private void CadenceThread()
        {
            try
            {
                string hrmData = File.ReadAllText(fileName);
                string[] hrmDataArr = hrmData.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                int indexOfHRMDataArr = Array.IndexOf(hrmDataArr, "[HRData]");
                cadences = new string[hrmDataArr.Length - indexOfHRMDataArr];
                int j = 0;

                for (int i = indexOfHRMDataArr + 1; i < hrmDataArr.Length - 1; i++)
                {
                    string hrData = hrmDataArr[i];
                    string[] hrDataArr = Regex.Split(hrData, @"\W+");
                    cadences[j] = hrDataArr[2];
                    this.HRDataCadence(cadences[j].ToString());
                    Thread.Sleep(700);
                    j++;
                }
            }
            catch (Exception ex)
            {

                //MessageBox.Show(ex.Message);
            }
        }

        private void chkSpeed_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSpeed.Checked == true)
            {
                lineOfSpeed.IsVisible = true;
                chkSpeed.Invalidate();
            }
            else
            {
                lineOfSpeed.IsVisible = false;
                chkSpeed.Invalidate();
            }
        }

        private void chkCadence_CheckedChanged(object sender, EventArgs e)
        {
            if (chkCadence.Checked == true)
            {
                lineOfCadence.IsVisible = true;
                chkCadence.Invalidate();
            }
            else
            {
                lineOfCadence.IsVisible = false;
                chkCadence.Invalidate();
            }
        }

        private void chkAltitude_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAltitude.Checked == true)
            {
                lineOfAltitude.IsVisible = true;
                chkAltitude.Invalidate();
            }
            else
            {
                lineOfAltitude.IsVisible = false;
                chkAltitude.Invalidate();
            }
        }

        private void chkHeartRate_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHeartRate.Checked == true)
            {
                lineOfHeartRate.IsVisible = true;
                chkHeartRate.Invalidate();
            }
            else
            {
                lineOfHeartRate.IsVisible = false;
                chkHeartRate.Invalidate();
            }
        }

        private void chkPower_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPower.Checked == true)
            {
                lineOfPower.IsVisible = true;
                chkPower.Invalidate();
            }
            else
            {
                lineOfPower.IsVisible = false;
                chkPower.Invalidate();
            }
        }

        /// <summary>
        /// Function to show altitude in data summary
        /// </summary>
        /// <param name="altitude"></param>
        private void HRDataAltitude(string altitude)
        {
            try
            {
                if (lblAltitude.InvokeRequired)
                {
                    HRDataMethod hrDataMethod = new HRDataMethod(HRDataAltitude);
                    this.Invoke(hrDataMethod, new object[] { altitude });
                }
                else
                {
                    lblAltitude.Text = altitude;
                }
            }
            catch (Exception ex)
            {

              //  MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Thread to fetch Altitude
        /// </summary>
        private void AltitudeThread()
        {
            try
            {
                string hrmData = File.ReadAllText(fileName);
                string[] hrmDataArr = hrmData.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                int indexOfHRMDataArr = Array.IndexOf(hrmDataArr, "[HRData]");
                altitudes = new string[hrmDataArr.Length - indexOfHRMDataArr];
                int j = 0;

                for (int i = indexOfHRMDataArr + 1; i < hrmDataArr.Length - 1; i++)
                {
                    string hrData = hrmDataArr[i];
                    string[] hrDataArr = Regex.Split(hrData, @"\W+");
                    altitudes[j] = hrDataArr[3];
                    this.HRDataAltitude(altitudes[j].ToString());
                    Thread.Sleep(700);
                    j++;
                }
            }
            catch (Exception ex)
            {

                //MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Function to show power in the summary
        /// </summary>
        /// <param name="power"></param>
        private void HRDataPower(string power)
        {
            try
            {
                if (lblPower.InvokeRequired)
                {
                    HRDataMethod hrDataMethod = new HRDataMethod(HRDataPower);
                    this.Invoke(hrDataMethod, new object[] { power });
                }
                else
                {
                    lblPower.Text = power;
                }
            }
            catch (Exception ex)
            {

                //MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Thread for Power
        /// </summary>
        private void PowerThread()
        {
            try
            {
                string hrmData = File.ReadAllText(fileName);
                string[] hrmDataArr = hrmData.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                int indexOfHRMDataArr = Array.IndexOf(hrmDataArr, "[HRData]");
                powers = new string[hrmDataArr.Length - indexOfHRMDataArr];
                int j = 0;

                for (int i = indexOfHRMDataArr + 1; i < hrmDataArr.Length - 1; i++)
                {
                    string hrData = hrmDataArr[i];
                    string[] hrDataArr = Regex.Split(hrData, @"\W+");
                    powers[j] = hrDataArr[4];
                    this.HRDataPower(powers[j].ToString());
                    Thread.Sleep(700);
                    j++;
                }
            }
            catch (Exception ex)
            {

                //MessageBox.Show(ex.Message);
            }
        }
    }
}
