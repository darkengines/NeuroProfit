using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NeuroProfit;
using System.Windows.Forms.DataVisualization.Charting;

namespace NeuroProfitUI {
	public partial class PriceChart : UserControl {
		protected DataHandler dataHandler;
		public DataHandler DataHandler {
			get { return dataHandler; }
			set {
				dataHandler = value;
				dataHandler.IndicatorAdded += dataHandler_IndicatorAdded;
				var name = dataHandler.Name;
				var chartArea = new ChartArea(name);
				var series = new Series(name);

				Chart.ChartAreas.Add(chartArea);
				Chart.Series.Add(series);

				chartArea.AxisY.Maximum = dataHandler.Data.Select(d => d.High).Max();
				chartArea.AxisY.Minimum = dataHandler.Data.Select(d => d.Low).Min();
				chartArea.AxisX.Interval = 7;
				chartArea.AxisX.ScaleView.Zoomable = true;

				series.ChartArea = chartArea.Name;
				series.ChartType = SeriesChartType.Candlestick;
				series.XValueMember = "Time";
				series.YValueMembers = "Hight, Low, Open, Close";
				series.YValuesPerPoint = 4;

				var data = dataHandler.Data;
				int count = data.Count();

				while (count-- != 0) {
					series.Points.AddXY(
						data[count].Time,
						data[count].High,
						data[count].Low,
						data[count].Open,
						data[count].Close
					);
				}
			}
		}

		void dataHandler_IndicatorAdded(object sender, IndicatorAddedEventArgs e) {
			var indicator = e.Indicator;
			var buffers = indicator.Buffers;
			foreach (var bufferName in buffers.Keys) {
				var series = new Series(bufferName);
				series.ChartArea = Chart.ChartAreas[0].Name;
				series.ChartType = SeriesChartType.Line;
				var count = dataHandler.Data.Count();
				while (count-- != 0) {
					var y = buffers[bufferName][count];
					if (y != null) {
						series[count] = (double)y;
					}
				}
			}
		}
		public PriceChart() {
			InitializeComponent();
		}
	}
}
