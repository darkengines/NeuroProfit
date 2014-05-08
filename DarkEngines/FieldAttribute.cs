using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DarkEngines {
	public class FieldAttribute: Attribute {
		public Type DataSourceProviderType { get; protected set; }
		public FieldAttribute() {
			DataSourceProviderType = null;
		}
		public string Label { get; set; }
		public FieldAttribute(Type dataSourceProviderType) {
			DataSourceProviderType = dataSourceProviderType;
		}
	}
}