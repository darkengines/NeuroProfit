using NeuroProfit.Indicators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroProfit {
	public class IndicatorConfiguration {
		public IndicatorConfiguration(Indicator indicator): this(indicator, 4, false) {
			
		}
		public IndicatorConfiguration(Indicator indicator, int count, bool used) {
			Used = used;
			Count = count;
			Indicator = indicator;
		}
		public bool Used { get; set; }
		public int Count { get; set; }
		public Indicator Indicator { get; set; }
	}
}
