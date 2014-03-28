using NeuroProfit.Indicators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace NeuroProfitUI {
	public static class IndicatorClassInfoProvider {
		public static IEnumerable<ClassInfo> ClassInfos {
			get {
				return Assembly.GetExecutingAssembly().GetTypes()
					.Where(t => t.IsSubclassOf(typeof(ClassInfo)) && !t.IsAbstract && t.BaseType.GenericTypeArguments.First().IsSubclassOf(typeof(Indicator)))
					.Select(t => Activator.CreateInstance(t)).Cast<ClassInfo>();
			}
		}
	}
}
