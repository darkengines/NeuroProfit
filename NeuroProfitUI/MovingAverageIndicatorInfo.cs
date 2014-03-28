using NeuroProfit;
using NeuroProfit.Indicators;
using NeuroProfitUI.DynamicForm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroProfitUI {
	public class MovingAverageIndicatorClassInfo : ClassInfo<MovingAverageIndicator> {
		public MovingAverageIndicatorClassInfo() {
			Member(x => x.Period, new DynamicFormIntegerTextboxProvider(), "Period", 0);
			Member(x => x.PriceType, new DynamicFormEnumComboBoxProvider(typeof(PriceType)), "On", 1);
		}
	}
}
