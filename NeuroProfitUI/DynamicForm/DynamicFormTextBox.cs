using NeuroProfitUI.DynamicForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NeuroProfitUI {
	public class DynamicFormTextBox<T>: UserControl, DynamicFormEditor {
		private TextBox _textbox;
		public DynamicFormTextBox(Func<string, T> converter) {
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
