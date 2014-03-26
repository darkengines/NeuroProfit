using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeuroProfitUI {
	public class ClassTableStringTextboxProvider: IClassTableEditorProvider {
		public ClassTableEditor GetNewEditor() {
			return new ClassTableTextBox<string>(x => x);
		}
	}
}
