using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
//using Graph.Model;

namespace heat
{
    public partial class Form2 : Form
    {
        private int Lefttemp;
        private int Righttemp;
        private int Widthlen;
        private int Time;
        private object InsideFunc;
        private int Midtemp;
        private float Coef;
        private double[,] matrix;
        private int min = 0;
        private int max = 0;

        public Form2(int Lefttemp, int Righttemp, int Widthlen, int Time, object InsideFunc,int Midtemp, float Coef)
        {
            InitializeComponent();
            this.Lefttemp = Lefttemp;
            this.Righttemp = Righttemp;
            this.Widthlen = Widthlen;
            this.Time = Time;
            this.InsideFunc = InsideFunc;
            this.Midtemp = Midtemp;
            this.Coef = Coef;
            trackBar1.Maximum = Time;
            trackBar1.Value = 0;
            mytime.Text = trackBar1.Value.ToString();
            endtime.Text = Time.ToString();

            chart1.GetToolTipText += this.chart1_GetToolTipText;
            chart1.ChartAreas[0].AxisX.Minimum = 0;
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisX.Maximum = Widthlen;
            BuildMatrix();
            FindMinMax();
            chart1.ChartAreas[0].AxisY.Minimum = min;
            chart1.ChartAreas[0].AxisY.Maximum = max;
            
            Graph(0);
        }

        private void chart1_GetToolTipText(object sender, ToolTipEventArgs e)
        {
            // Check selected chart element and set tooltip text for it
            switch (e.HitTestResult.ChartElementType)
            {
                case ChartElementType.DataPoint:
                    var dataPoint = e.HitTestResult.Series.Points[e.HitTestResult.PointIndex];
                    e.Text = string.Format("Width:   {0} cm\nTemperature:   {1} celcius\nTime:   {2} sec", dataPoint.XValue, dataPoint.YValues[0], trackBar1.Value.ToString());   
                    break;
            }
        }
        private void FindMinMax() {
            min = int.Parse(matrix[0, 0].ToString()) - 4;
            max = int.Parse(matrix[0, 0].ToString()) + 4;

            for (int i = 0; i <= Time; i++)
            {
                for (int j = 0; j <= Widthlen; j++)
                {
                    if (matrix[i, j] < min)
                        min = (int)matrix[i, j] - 2;
                    if (matrix[i, j] > max)
                        max = (int)matrix[i, j] + 2;
                }
            }
        }

        private void BuildMatrix()
        {
            matrix = new double[Time + 1, Widthlen + 1];

            for (int i = 0; i <= Widthlen; i++) // time =0 
            {
                switch (InsideFunc.ToString())
                {
                    case "cos(x)":
                        matrix[0, i] = Math.Cos(i) + Midtemp;
                        break;
                    case "sin(x)":
                        matrix[0, i] = Math.Sin(i) + Midtemp;
                        break;
                    case "constant":
                        matrix[0, i] = Midtemp;
                        break;
                    default:
                        break;
                }
            }


            for (int j = 1; j <= Time; j++)
            {
                for (int i = 0; i <= Widthlen; i++)
                {
                    if (i == 0) matrix[j, i] = Lefttemp;
                    else if (i == Widthlen) matrix[j, i] = Righttemp;
                    else matrix[j, i] = Calc(j,i);

                }
            }

        }

        private double Calc(int Time, int Widthlen) {

            double x = 0.1;
            double Lambda = (Coef * x) / Math.Pow(0.1, 2);

            while (Lambda > 0.5)
            {
                x = x / 10;
                Lambda = (Coef * x) / Math.Pow(0.1, 2);
            }

            return (1-2*Lambda)*matrix[Time - 1, Widthlen] + Lambda*matrix[Time - 1, Widthlen + 1] + Lambda*matrix[Time - 1, Widthlen - 1];

        }

        private void Graph(int time) {

            for (int i = 0; i <= Widthlen; i++)
            {
                chart1.Series["Series1"].Points.AddXY(i, matrix[time, i]);
                chart1.Series["Series1"].BorderWidth = 5;
                chart1.Series["Series1"].SetCustomProperty("LineTension", "0.1");
            }
            
            chart1.Update();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            mytime.Text = trackBar1.Value.ToString();
            chart1.Series["Series1"].Points.Clear();
            Graph(trackBar1.Value);
        }

        private void Submit_Click(object sender, EventArgs e)
        {

            this.DialogResult = DialogResult.OK;
            this.Close();
        }


    }



}

