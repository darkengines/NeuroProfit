using NeuroProfit.Indicators;
using NeuroProfitUI.DynamicForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroProfitUI {
	public static class IndicatorClassInfoFactory {
		public ClassInfo Build(Type T) {
			var classInfo = new ClassInfo<Indicator>();
			var parametersProperties = T.GetProperties().Where(p => Attribute.IsDefined(p, typeof(ParameterAttribute)));
			foreach (var parameterProperty in parametersProperties) {
				classInfo.Member(new MemberInfo<Indicator>(parameterProperty, null, null, 0));
			}
		}
	}
}
