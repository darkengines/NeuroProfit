using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkEngines.DynamicField {
	public partial class DynamicFormControl : UserControl {
		protected DynamicForm dynamicForm;
		public object DataSource {
			set {
				dynamicForm = new DynamicForm(value);
			}
		}
		public void Fill(object instance) {
			dynamicForm.Fill(instance);
		}
		public DynamicFormControl() {
			InitializeComponent();
		}
	}
}
