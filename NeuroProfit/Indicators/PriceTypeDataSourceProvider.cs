using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroProfit.Indicators {
	public class PriceTypeDataSourceProvider {
		public IEnumerable<PriceType> DataSource {
			get {
				var enumType = typeof(PriceType);
				var priceTypeNames = Enum.GetNames(enumType);
				foreach (var priceTypeName in priceTypeNames) {
					yield return (PriceType)Enum.Parse(enumType, priceTypeName);
				}
			}
		}
	}
}
