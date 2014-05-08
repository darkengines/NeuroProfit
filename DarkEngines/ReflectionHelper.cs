using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DarkEngines {
	public class ReflectionHelper {
		private static ReflectionHelper _instance;
		public static ReflectionHelper Instance {
			get {
				if (_instance == null) {
					_instance = new ReflectionHelper();
				}
				return _instance;
			}
		}
		public IEnumerable<Type> Types { get; protected set; }
		public ReflectionHelper() {
			Types = AppDomain.CurrentDomain.GetAssemblies().SelectMany(a => a.GetTypes());
		}
		public IEnumerable<PropertyInfo> GetFieldInfosByAttributeType(Type type, Type attributeType) {
			return type.GetProperties().Where(f => Attribute.IsDefined(f, attributeType));
		}
		public T GetAttribute<T>(PropertyInfo fieldInfo) where T : Attribute {
			return fieldInfo.GetCustomAttribute<T>();
		}
	}
}
