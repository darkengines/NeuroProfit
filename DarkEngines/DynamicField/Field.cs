using DarkEngines.DynamicField.Editors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkEngines.DynamicField {
	public class Field<T>: AField<T> {
		public Field(PropertyInfo fieldInfo, object instance) {
			var attribute = ReflectionHelper.Instance.GetAttribute<FieldAttribute>(fieldInfo);
			var type = Assembly.GetAssembly(typeof(IEditor<>)).GetTypes().FirstOrDefault(
				t => t.GetInterfaces().Where(it => it.IsGenericType).Select(it => it.GetGenericTypeDefinition()).Contains(typeof(IEditor<>))
			);
			Label = attribute.Label;
			Editor = (IEditor<T>)Activator.CreateInstance(type.MakeGenericType(typeof(T)));
			Value = (T)fieldInfo.GetValue(instance);
			FieldInfo = fieldInfo;
		}
		public string Label { get; set; }
		public T Value { get; set; }
		public IEditor<T> Editor { get; set; }
		object IField.Value {
			get {
				return this.Value;
			}
			set {
				this.Value = (T)value;
			}
		}
		public PropertyInfo FieldInfo { get; set; }
		public void Fill(object instance) {
			FieldInfo.SetValue(Value, instance);
		}
	}
}
