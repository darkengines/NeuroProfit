using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeuroProfitUI.DynamicForm {
	public class DynamicFormStringTextboxProvider: IDynamicFormEditorProvider {
		public DynamicFormEditor GetNewEditor() {
			return new DynamicFormTextBox<string>(x => x);
		}
	}
}
