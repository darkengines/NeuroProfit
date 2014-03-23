using FileHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroProfit.DataLoader {
	public class Loader {
		protected FileHelperEngine<DataLoaderDatum> Engine;
		public Loader() {
			Engine = new FileHelperEngine<DataLoaderDatum>();
		}
		public Datum[] Load(string source) {
			return Engine.ReadFile(source).Select(Convert).ToArray();
		}
		protected Datum Convert(DataLoaderDatum datum) {
			return new Datum { 
				Low = datum.Low,
				Close = datum.Close,
				High = datum.High,
				Open = datum.Open,
				TickVolume = datum.TickVolume,
				Time = datum.Time
			};
		}
	}
}
