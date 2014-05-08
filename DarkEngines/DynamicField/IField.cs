using DarkEngines.DynamicField.Editors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkEngines.DynamicField {
	public interface IField {
		string Label { get; set; }
		object Value { get; set; }
		object Editor { get; set; }
		PropertyInfo FieldInfo { get; set; }
		void Fill(object instance);
	}
	public abstract class AField<T> : IField {
		public abstract IEditor<T> Editor { get; set; }
		object IField.Editor {
			get {
				return this.Editor;
			}
			set {
				this.Editor = (IEditor<T>)value;
			}
		}
		public abstract string Label { get; set; }
		public abstract object Value { get; set; }
		public abstract void Fill(object instance);
		public abstract PropertyInfo FieldInfo { get; set; }
	}
}
