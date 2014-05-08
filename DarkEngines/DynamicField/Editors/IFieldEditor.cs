using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkEngines.DynamicField.Editors {
	public interface IFieldEditor {
		object Value { get; set; }
		Control Control { get; }
	}
	public abstract class FieldEditor<T>: IFieldEditor {
		public abstract T Value { get; set; }
		public abstract Control Control { get; }
		object IFieldEditor.Value {
			get { return Value; }
			set { Value = (T)value; }
		}
	}
}
