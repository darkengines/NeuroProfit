using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroProfit {
	public abstract class Indicator : IIndicator {
		protected DataHandler dataHandler;
		public Indicator(DataHandler dataHandler) {
			this.dataHandler = dataHandler;
		}
		public abstract IEnumerable<Dictionary<string, IEnumerable<double>>> Data { get; }
		public abstract IEnumerable<Dictionary<string, IEnumerable<double>>> GetRange(DateRange range);

		IEnumerable<Dictionary<string, IEnumerable<double>>> IIndicator.Data {
			get { return this.Data; }
		}

		IEnumerable<Dictionary<string, IEnumerable<double>>> IIndicator.GetRange(DateRange range) {
			return this.GetRange(range);
		}
	}
}
