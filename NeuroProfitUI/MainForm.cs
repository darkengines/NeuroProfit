using NeuroProfit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuroProfitUI {
	public partial class MainForm : Form {

		public Data PriceData { get; set; }

		public MainForm() {
			InitializeComponent();
		}

		private void loadToolStripMenuItem_Click(object sender, EventArgs e) {
			var fileDialog = new OpenFileDialog();
			fileDialog.FileOk += fileDialog_FileOk;
			fileDialog.ShowDialog(this);
		}

		void fileDialog_FileOk(object sender, CancelEventArgs e) {
			PriceData = new Data(((OpenFileDialog)sender).FileName);
			PriceChart.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
			var buffer = PriceData.GetRange(new DateTime(2013, 11, 12), new DateTime(2013, 11, 13));
			PriceChart.DataSource = buffer.Data;
			PriceChart.Series[0].XValueMember = "Time";
			PriceChart.Series[0].YValueMembers = "High, Low, Open, Close";
			PriceChart.ChartAreas[0].AxisY.Maximum = buffer.Max;
			PriceChart.ChartAreas[0].AxisY.Minimum = buffer.Min;
			PriceChart.DataBind();
		}
	}
}
