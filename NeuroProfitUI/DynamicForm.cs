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
		protected Dictionary<MemberInfo, ClassTableEditor> MembersControlMap { get; set; }
		protected object instance;
		public ClassInfo ClassInfo {
			get { return classInfo; }
			set {
				if (value != null && value != classInfo) {
					classInfo = value;
					instance = Activator.CreateInstance(classInfo.GetType().BaseType.GenericTypeArguments[0]);
					Build();
					FillForm();
				}
			}
		}
		public DynamicForm() {
			MembersControlMap = new Dictionary<MemberInfo, ClassTableEditor>();
			InitializeComponent();
		}
		public object Instance {
			get {
				FillInstance();
				return instance;
			}
		}
		protected void Build() {
			MembersControlMap.Clear();
			DynamicLayout.Controls.Clear();
			var members = classInfo.Members.OrderBy(m => m.Position);
			DynamicLayout.ColumnCount = 2;
			DynamicLayout.ColumnStyles[0].SizeType = SizeType.AutoSize;
			DynamicLayout.ColumnStyles.Add(new ColumnStyle());
			DynamicLayout.ColumnStyles[1].SizeType = SizeType.Percent;
			DynamicLayout.ColumnStyles[1].Width = 100;
			DynamicLayout.RowCount = members.Count();
			var i = 0;
			foreach (var member in members) {
				if (DynamicLayout.RowStyles.Count < i + 1) {
					DynamicLayout.RowStyles.Add(new RowStyle());
				}
				DynamicLayout.RowStyles[i].SizeType = SizeType.Absolute;
				var label = new Label();
				label.Name = string.Format("label_{0}", member.Name);
				label.Text = member.Label;
				label.Anchor = AnchorStyles.Left | AnchorStyles.Right;
				var editor = (Control)member.Editor;
				editor.Anchor = AnchorStyles.Left | AnchorStyles.Right;
				DynamicLayout.RowStyles[i].Height = 20;
				editor.Name = string.Format("editor_{0}", member.Name);
				editor.Dock = DockStyle.Fill;
				DynamicLayout.Controls.Add(label, 0, i);
				DynamicLayout.Controls.Add(editor, 1, i);
				MembersControlMap[member] = (ClassTableEditor)editor;
				i++;
			}
		}
		protected void FillForm() {
			foreach (var member in MembersControlMap.Keys) {
				var editor = MembersControlMap[member];
				editor.SetValue(Instance.GetType().GetProperty(member.Name).GetValue(Instance));
			}
		}
		protected void FillInstance() {
			var members = classInfo.Members.OrderBy(m => m.Position);
			var type = instance.GetType();
			foreach (var member in members) {
				type.GetProperty(member.Name).SetValue(instance, member.Editor.GetValue());
			}
		}
	}
}
