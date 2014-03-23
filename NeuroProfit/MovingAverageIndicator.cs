using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroProfit {
	class MovingAverageIndicator: Indicator {
		public int Period { get; set; }

		public MovingAverageIndicator(DataHandler dataHandler, int period): base(dataHandler) {
			Period = period;
		}

		public override IEnumerable<Dictionary<string, IEnumerable<double>>> Data {
			get { throw new NotImplementedException(); }
		}

		public override IEnumerable<Dictionary<string, IEnumerable<double>>> GetRange(DateRange range) {
			
			

			return dataHandler.GetRange(range);
		}

		protected IEnumerable<double> MovingAverage {
			get {
				var d = 1.0d/Period;
				while (i < Period - 1) {

				}
			}
		}
	}
}
