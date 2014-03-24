using NeuroProfit.Indicators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeuroProfit {
	public class IndicatorAddedEventArgs : EventArgs {
		public Indicator Indicator { get; protected set; }
		public IndicatorAddedEventArgs(Indicator indicator) {
			Indicator = indicator;
		}
	}
}
