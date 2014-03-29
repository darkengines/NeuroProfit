using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroProfit.Indicators {
	public abstract class Indicator {
		public DataHandler DataHandler { get; set; }
		protected double[] Get(PriceType type) {
			switch (type) {
				case (PriceType.Open): return DataHandler.Open;
				case (PriceType.Close): return DataHandler.Close;
				case (PriceType.Low): return DataHandler.Low;
				case (PriceType.High): return DataHandler.High;
				case (PriceType.TickVolume): return DataHandler.TickVolume.Select(Convert.ToDouble).ToArray();
				default: return null;
			}
		}
		public abstract void DataBind();
		public override string ToString() {
			return "Indicator";
		}
	}
}
