using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NeuroProfitUI {
	public class ClassTableComboBox: UserControl, ClassTableEditor {
		private ComboBox comboBox;
		protected Func<object, object> Converter { get; set; }
		public IEnumerable<object> DataSource {
			get {
				return (IEnumerable<object>)comboBox.DataSource;
			}
			set {
				comboBox.DataSource = value;
			}
		}
		public ClassTableComboBox(IEnumerable<object> dataSource, Func<object, object> converter) {
			Converter = converter;
			comboBox = new ComboBox();
			Controls.Add(comboBox);
			DataSource = dataSource;
		}
		public object GetValue() {
			return Converter(comboBox.SelectedItem);
		}
		public void SetValue(object value) {
			comboBox.SelectedItem = value;
		}
	}
}
