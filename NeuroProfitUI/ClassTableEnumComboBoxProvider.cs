using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeuroProfitUI {
	public class ClassTableEnumComboBoxProvider: IClassTableEditorProvider {
		protected Type enumType;
		public ClassTableEnumComboBoxProvider(Type enumType) {
			this.enumType = enumType;
		}
		public ClassTableEditor GetNewEditor() {
			return new ClassTableComboBox(Enum.GetNames(enumType), x => Enum.Parse(enumType, x.ToString(), true));
		}
	}
}
