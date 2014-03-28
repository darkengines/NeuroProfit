using NeuroProfit.Indicators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeuroProfitUI {
	public class IndicatorSelectedEventArgs: EventArgs {
		public Indicator Indicator {get; protected set;}
		public IndicatorSelectedEventArgs(Indicator indicator) {
			Indicator = indicator;
		}
	}
}
