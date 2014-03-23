using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroProfit {
	public static class TimeSpanExtension {
		public static TimeSpan Multiply(this TimeSpan unit, int factor) {
			return TimeSpan.FromTicks(unit.Ticks * factor);
		}
	}
}
