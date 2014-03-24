using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHelpers;

namespace NeuroProfit {
	public class Datum {
		public DateTime Time { get; set; }
		public double Open { get; set; }
		public double High { get; set; }
		public double Low { get; set; }
		public double Close { get; set; }
		public int TickVolume { get; set; }
	}
	public static class DatumHelper {
		public static double? Select(Datum datum, PriceType type) {
			switch (type) {
				case (PriceType.Open): { return datum.Open; }
				case (PriceType.Close): { return datum.Close; }
				case (PriceType.High): { return datum.High; }
				case (PriceType.Low): { return datum.Low; }
				case (PriceType.TickVolume): { return datum.TickVolume; }
				default: { return null; }
			}
		}
		public static Func<Datum, double?> SelectFunc(PriceType type) {
			switch (type) {
				case (PriceType.Open): { return (d) => d.Open; }
				case (PriceType.Close): { return (d) => d.Close; }
				case (PriceType.High): { return (d) => d.High; }
				case (PriceType.Low): { return (d) => d.Low; }
				case (PriceType.TickVolume): { return (d) => d.TickVolume; }
				default: { return null; }
			}
		}
	}
}
