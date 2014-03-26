using NeuroProfit.Indicators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroProfitUI {
	public class MovingAverageIndicatorClassInfo : ClassInfo<MovingAverageIndicator> {
		public MovingAverageIndicatorClassInfo() {
			Member(x => x.Period, new ClassTableIntegerTextboxProvider(), "Period", 0);
		}
	}
}
