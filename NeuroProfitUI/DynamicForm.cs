using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NeuroProfitUI {
	public partial class DynamicForm : UserControl {
		public ClassInfo classInfo;
		public object instance;
		public ClassInfo ClassInfo {
			get { return classInfo; }
			set {
				classInfo = value;
			}
		}
		public DynamicForm() {
			InitializeComponent();
		}
		protected void Build() {
			var members = classInfo.Members.OrderByDescending(m => m.Position);
			foreach (var member in members) {
				var label = new Label();
				label.Text = member.Label;
				var editor = (Control)member.Editor;
				DynamicLayout.SetRow(label, 1);
				DynamicLayout.SetColumn(label, 1);
				DynamicLayout.SetRow(editor, 0);
				DynamicLayout.SetColumn(editor, 1);
			}
		}
	}
}
