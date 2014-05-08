using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkEngines.DynamicForm {
	public class DynamicFormUserControl : UserControl {
		public object Instance {
			get;
			set;
		}
		protected void BuildForm() {
			var properties = Instance.GetType().GetProperties().Where(p => Attribute.IsDefined(p, typeof(FieldAttribute)));
			foreach (var property in properties) {
				var dataSourceType = property.GetCustomAttributes(typeof(FieldAttribute), false)
					.Cast<FieldAttribute>()
					.First()
					.DataSourceProviderType;
				if (dataSourceType != null) {
					var dataSource = Activator.CreateInstance(dataSourceType);
				} else {

				}
			}
		}
	}
}
