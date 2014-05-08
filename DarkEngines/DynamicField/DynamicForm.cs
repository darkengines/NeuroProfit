using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkEngines.DynamicField {
	public class DynamicForm {
		public DynamicForm(object instance) {
			DataSource = instance;
		}
		public object DataSource {
			set {
				fields = FieldFactory.Instance.GetFields(value);
			}
		}
		public void Fill(object instance) {
			foreach (var field in fields) {
				field.Fill(instance);
			}
		}
		protected IEnumerable<IField> fields;
	}
}
