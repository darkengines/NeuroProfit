using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroProfit.Indicators {
	public class ParameterAttribute: Attribute {
		public Type DataSourceProviderType { get; protected set; }
		public ParameterAttribute() {
			DataSourceProviderType = null;
		}
		public ParameterAttribute(Type dataSourceProviderType) {
			DataSourceProviderType = dataSourceProviderType;
		}
	}
}