using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroProfit.Indicators {
	public class MovingAverageIndicator: Indicator {

		public MovingAverageIndicator(): this(10, PriceType.Close) {
		}
		public MovingAverageIndicator(int period, PriceType priceType) {
			Period = period;
			PriceType = priceType;
		}
		public PriceType PriceType { get; set; }
		public int Period { get; set; }

		public override void DataBind(DataHandler dataHandler) {
			var count = dataHandler.Date.Count();
			var ma = new double?[count];
			var data = Get(dataHandler, PriceType);
			var i = 0;
			var sum = 0.0d;
			while (i < Period) {
				ma[i] = null;
				sum += data[i];
				i++;
			}
			ma[i - 1] = sum / Period;
			var factor = 1.0d / Period;
			while (i < count) {
				var d = (data[i] - data[i-Period])*factor;
				ma[i] = ma[i - 1] + d;
				i++;
			}
			Buffers["MA"] = ma;
		}
	}
}
