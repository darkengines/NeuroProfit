using NeuroProfit.Indicators;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuroProfitUI {
	public partial class IndicatorForm : Form {
		public IndicatorForm() {
			InitializeComponent();
		}

        private void IndicatorForm_Load(object sender, EventArgs e) {
            var indicators = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.IsSubclassOf(typeof(Indicator))).Select(t => Activator.CreateInstance(t)).Cast<Indicator>();
            var classInfos = Assembly.GetExecutingAssembly().GetTypes().Where(t => t.IsSubclassOf(typeof(ClassInfo))).Select(t => Activator.CreateInstance(t)).Cast<ClassInfo>();

            foreach (var indicatorType in indicators) {
                if (classInfos.FirstOrDefault(ci => ci.
            }
        }
	}
}
