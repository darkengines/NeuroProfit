using NeuroProfit;
using NeuroProfit.DataLoader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuroProfitUI {
    public partial class MainForm : Form {
        protected DataHandler dataHandler;
        protected DataHandler DataHandler {
            set {
                dataHandler = value;
                ConfigureDatePickers();
            }
        }
        public MainForm() {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) {
            var indicatorForm = new IndicatorForm();
            indicatorForm.IndicatorSelected += indicatorForm_IndicatorSelected;
            indicatorForm.Show();
        }

        void indicatorForm_IndicatorSelected(object sender, IndicatorSelectedEventArgs e) {
            cblInput.Items.Add(e.Indicator);
            cblOutput.Items.Add(e.Indicator);
        }

        private void btnBrowse_Click(object sender, EventArgs e) {
            var fileDialog = new OpenFileDialog();
            fileDialog.FileOk += fileDialog_FileOk;
            fileDialog.ShowDialog();
        }

        void fileDialog_FileOk(object sender, CancelEventArgs e) {
            var fileDialog = (OpenFileDialog)sender;
            var loader = new Loader();
            DataHandler = new DataHandler(Path.GetFileName(fileDialog.FileName), loader.Load(fileDialog.FileName));
        }
        void ConfigureDatePickers() {
            var dates = dataHandler.Date;
            var lastIndex = dataHandler.Date.Count() - 1;
            var trainFromIndex = 0;
            var trainToIndex = (int)Math.Round(lastIndex * 0.75);
            var testFromIndex = trainToIndex + 1;
            var testToIndex = lastIndex;
            dateTrainFrom.Value = dates[trainFromIndex];
            dateTrainTo.Value = dates[trainToIndex];
            dateTestFrom.Value = dates[testFromIndex];
            dateTestTo.Value = dates[testToIndex];
        }
    }
}
