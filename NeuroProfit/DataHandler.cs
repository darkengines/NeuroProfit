using NeuroProfit.Indicators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroProfit {
	public class DataHandler {

		public event EventHandler<IndicatorAddedEventArgs> IndicatorAdded;

		public DataHandler(string name, Datum[] data) {
			Name = name;
			Date = data.Select(d => d.Time).ToArray();
			Open = data.Select(d => d.Open).ToArray();
			High = data.Select(d => d.High).ToArray();
			Low = data.Select(d => d.Low).ToArray();
			Close = data.Select(d => d.Close).ToArray();
			TickVolume = data.Select(d => d.TickVolume).ToArray();

			indicators = new List<Indicator>();
		}

		public string Name { get; protected set; }
		public DateTime[] Date { get; set; }
		public double[] Open { get; set; }
		public double[] High { get; set; }
		public double[] Low { get; set; }
		public double[] Close { get; set; }
		public int[] TickVolume { get; set; }
		protected List<Indicator> indicators;
		public IEnumerable<Indicator> Indicators { get { return indicators; } }

		public void AddIndicator(Indicator indicator) {
			indicator.DataBind();
			indicators.Add(indicator);
			if (IndicatorAdded != null) {
				IndicatorAdded(this, new IndicatorAddedEventArgs(indicator));
			}
		}
		public void RemoveIndicator(Indicator indicator) {
			indicators.Remove(indicator);
		}
	}
}
