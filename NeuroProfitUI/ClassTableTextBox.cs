using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NeuroProfitUI {
	public class ClassTableTextBox<T>: UserControl, ClassTableEditor {
		private TextBox _textbox;
		public ClassTableTextBox(Func<string, T> converter) {
			Converter = converter;
			_textbox = new TextBox();
			Controls.Add(_textbox);
		}
		public Func<string, T> Converter {
			get;
			set;
		}
		public object GetValue() {
			return Converter(_textbox.Text);
		}
		public void SetValue(object value) {
			_textbox.Text = value == null ? null : value.ToString();
		}
	}
}
