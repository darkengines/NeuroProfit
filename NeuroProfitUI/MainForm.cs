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
		}
	}
}
