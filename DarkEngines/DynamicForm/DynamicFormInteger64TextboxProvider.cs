using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DarkEngines.DynamicForm {
	public class DynamicFormInteger64TextboxProvider: IDynamicFormEditorProvider {
		public DynamicFormEditor GetNewEditor() {
			return new DynamicFormTextBox<Int64?>(x => {
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
