using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroProfit.Indicators {
	class MovingAverageIndicator: Indicator {

		public MovingAverageIndicator(int period, PriceType priceType) {
			Period = period;
			PriceType = priceType;
		}
		public PriceType PriceType { get; set; }
		public int Period { get; set; }

		protected override void Init() {
			Buffers["MA"] = new double?[data.Count()];
		}

		protected override int ComputeDatum(Datum[] data, int lastComputed, int total) {
			if (lastComputed < Period - 1) {
				Buffers["MA"][lastComputed] = null;
			} else {
				int index = lastComputed+1;
				if (lastComputed < Period) {
					Buffers["MA"][index] = data.Take(index).Average(DatumHelper.SelectFunc(PriceType));
				} else {
					double factor = 1.0d / Period;
					Buffers["MA"][index] = Buffers["MA"][index - 1] + (DatumHelper.Select(data[index], PriceType) - DatumHelper.Select(data[index - Period], PriceType)) * factor;
				}			
			}
			return lastComputed++;
		}
	}
}
