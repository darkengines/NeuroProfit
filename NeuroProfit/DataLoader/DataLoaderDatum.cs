using FileHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroProfit.DataLoader {
	[DelimitedRecord(",")]
	public class DataLoaderDatum {
		[FieldConverter(typeof(CustomDateTimeConverter), "yyyy.MM.dd HH:mm", "yyyy.MM.dd")]
		public DateTime Time;
		public double Open;
		public double High;
		public double Low;
		public double Close;
		public int TickVolume;
		public int Volume;
	}
}
