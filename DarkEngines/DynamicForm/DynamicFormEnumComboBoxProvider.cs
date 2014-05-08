using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DarkEngines.DynamicForm {
	public class DynamicFormEnumComboBoxProvider: IDynamicFormEditorProvider {
		protected Type enumType;
		public DynamicFormEnumComboBoxProvider(Type enumType) {
			this.enumType = enumType;
		}
		public DynamicFormEditor GetNewEditor() {
			return new DynamicFormComboBox(Enum.GetNames(enumType), x => Enum.Parse(enumType, x.ToString(), true));
		}
	}
}
