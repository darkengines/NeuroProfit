using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroProfit.Indicators {
	public abstract class Indicator {
		public Indicator() {
			Buffers = new Dictionary<string, double?[]>();
		}
		public Dictionary<string, double?[]> Buffers { get; protected set; }
		public abstract void DataBind(DataHandler dataHandler);
		protected double[] Get(DataHandler dataHandler, PriceType type) {
			switch (type) {
				case (PriceType.Open): return dataHandler.Open;
				case (PriceType.Close): return dataHandler.Close;
				case (PriceType.Low): return dataHandler.Low;
				case (PriceType.High): return dataHandler.High;
				case (PriceType.TickVolume): return dataHandler.TickVolume.Select(Convert.ToDouble).ToArray();
				default: return null;
			}
		}
	}
}
