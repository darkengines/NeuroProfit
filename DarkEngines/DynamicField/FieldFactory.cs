using DarkEngines.DynamicField.Editors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkEngines.DynamicField {
	public class FieldFactory {
		private static FieldFactory _instance;
		public static FieldFactory Instance {
			get {
				if (_instance == null) {
					_instance = new FieldFactory();
				}
				return _instance;
			}
		}
		public IEnumerable<IField> GetFields(object instance) {
			var type = instance.GetType();
			var fieldInfos = ReflectionHelper.Instance.GetFieldInfosByAttributeType(type, typeof(FieldAttribute));
			return fieldInfos.Select(f => GetField(f, instance)).ToArray();
		}
		public IField GetField(PropertyInfo fieldInfo, object instance) {
			var field = (IField)Activator.CreateInstance(typeof(Field<>).MakeGenericType(fieldInfo.PropertyType), new object[] {fieldInfo, instance});
			var attribute = ReflectionHelper.Instance.GetAttribute<FieldAttribute>(fieldInfo);
			field.Label = attribute.Label;
			field.Editor = (IEditor<object>)Activator.CreateInstance(ReflectionHelper.Instance.Types.FirstOrDefault(
				t => t.IsAssignableFrom(typeof(IEditor<>))
				&& !t.IsAbstract
				&& t.GenericTypeArguments[0].IsAssignableFrom(t)
			));
			field.Value = fieldInfo.GetValue(instance);
			field.FieldInfo = fieldInfo;
			return field;
		}
	}
}
