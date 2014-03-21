using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;

namespace NeuroProfit {
	[DelimitedRecord(",")]
	public class InternalPriceSession {
		[FieldConverter(ConverterKind.Date, "yyyy.MM.dd HH:mm")]
		public DateTime Time;
		public double Open;
		public double High;
		public double Low;
		public double Close;
		public int TickVolume;
		public int Volume;
	}
	public class Datum {
		public DateTime Time { get; set; }
		public double Open { get; set; }
		public double High { get; set; }
		public double Low { get; set; }
		public double Close { get; set; }
		public int TickVolume { get; set; }
	}
}
