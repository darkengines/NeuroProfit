using DarkEngines;
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
		public event EventHandler<IndicatorSelectedEventArgs> IndicatorSelected;
		protected Indicator instance;
		public IndicatorForm() {
			InitializeComponent();

		}

        private void IndicatorForm_Load(object sender, EventArgs e) {
			var indicatorTypes = Assembly.GetAssembly(typeof(Indicator)).GetTypes().Where(t => typeof(Indicator).IsAssignableFrom(t) && !t.IsAbstract);
			foreach (var indicatorType in indicatorTypes) {
				listBox1.Items.Add(indicatorType);
			}
        }

		protected void listBox1_SelectedIndexChanged(object sender, EventArgs e) {
			var type = (Type)((ListBox)sender).SelectedItem;
			instance = (Indicator)Activator.CreateInstance(type);
			dynamicForm.DataSource = instance;
		}

		private void btnOK_Click(object sender, EventArgs e) {
			dynamicForm.Fill(instance);
			if (instance != null) {
				if (IndicatorSelected != null) {
					IndicatorSelected(this, new IndicatorSelectedEventArgs(instance));
				}
				Close();
			}
		}

		private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e) {

		}

		private void btnOk_Click_1(object sender, EventArgs e) {

		}
	}
}
