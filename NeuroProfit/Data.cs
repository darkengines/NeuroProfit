using FileHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroProfit {
	public class Data {
		public Data(string source) {
			var engine = new DelimitedFileEngine<InternalPriceSession>();
			Prices = engine.ReadFile(source).Select(x=>new Datum{Low=x.Low, Close=x.Close, High = x.High, Open=x.Open, TickVolume = x.TickVolume, Time = x.Time});
		}
		protected IEnumerable<Datum> Prices { get; set; }
		public Buffer GetRange(DateTime start, DateTime end) {
			return new Buffer(Prices.SkipWhile(x => x.Time < start).TakeWhile(x => x.Time <= end));
		}
	}
}
