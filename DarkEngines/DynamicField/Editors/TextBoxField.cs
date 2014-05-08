using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DarkEngines.DynamicField.Editors {
	public class TextBoxField<T> : TextBox, FieldEditor<T> {

		public override T Value {
			get {
				throw new NotImplementedException();
			}
			set {
				throw new NotImplementedException();
			}
		}

		public override Control Control {
			get { throw new NotImplementedException(); }
		}
	}
}
