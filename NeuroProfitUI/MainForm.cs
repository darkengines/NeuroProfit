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
using System.Windows.Forms.DataVisualization.Charting;

namespace NeuroProfitUI {
	public partial class MainForm : Form {

		public DataRegister dataRegister;

		public MainForm() {
			InitializeComponent();
			dataRegister = new DataRegister();
			dataRegister.DataHandlerRegistered += dataRegister_DataHandlerRegistered;
		}

		void dataRegister_DataHandlerRegistered(object sender, DataHandlerRegisteredEventArgs e) {
			var name = e.DataHandler.Name;
			var chart = new PriceChart();
			chart.DataHandler = e.DataHandler;

			chart.Dock = DockStyle.Fill;

			ChartTab.TabPages.Add(name, name);
			ChartTab.TabPages[name].Controls.Add(chart);
		}

		private void loadToolStripMenuItem_Click(object sender, EventArgs e) {
			var fileDialog = new OpenFileDialog();
			fileDialog.FileOk += fileDialog_FileOk;
			fileDialog.ShowDialog(this);
		}

		void fileDialog_FileOk(object sender, CancelEventArgs e) {
			dataRegister.Register(((OpenFileDialog)sender).FileName);
		}
	}
}
