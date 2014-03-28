using NeuroProfit.Indicators;
using NeuroProfitUI.DynamicForm;
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
		public event EventHandler<IndicatorSelectedEventArgs> IndicatorSelected;
		public IndicatorForm() {
			InitializeComponent();

		}

        private void IndicatorForm_Load(object sender, EventArgs e) {
			var classInfos = IndicatorClassInfoProvider.ClassInfos;
			foreach (var classInfo in classInfos) {
				listBox1.Items.Add(classInfo);
			}
        }

		protected void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
			var classInfo = (ClassInfo)((ListBox)sender).SelectedItem;
			dynamicForm.ClassInfo = classInfo;
		}

		private void btnOK_Click(object sender, EventArgs e) {
			var instance = (Indicator)dynamicForm.Instance;
			if (instance != null) {
				if (IndicatorSelected != null) {
					IndicatorSelected(this, new IndicatorSelectedEventArgs(instance));
				}
				Close();
			}
		}
	}
}
