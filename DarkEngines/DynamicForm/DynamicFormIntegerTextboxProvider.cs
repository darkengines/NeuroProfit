using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DarkEngines.DynamicForm {
	public class DynamicFormIntegerTextboxProvider: IDynamicFormEditorProvider {
		public DynamicFormEditor GetNewEditor() {
			return new DynamicFormTextBox<int?>(x => {
				int t;
				if (int.TryParse(x, out t)) {
					return t;
				} else {
					return null;
				}
			});
		}
	}
}
