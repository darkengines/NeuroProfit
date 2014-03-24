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
			Data = data;
			Indicators = new List<Indicator>();
		}

		public string Name { get; protected set; }
		public Datum[] Data { get; protected set; }
		protected List<Indicator> Indicators { get; set; }
		public IEnumerable<Datum> GetRange(DateRange range) {
			return Data.SkipWhile(datum => datum.Time <= range.Start).TakeWhile(datum => datum.Time <= range.End);
		}
		public TimeSpan Unit {
			get {
				return Data.ElementAt(1).Time - Data.First().Time;
			}
		}
		public void AddIndicator(Indicator indicator) {
			indicator.DataSource = Data;
			Indicators.Add(indicator);
			if (IndicatorAdded != null) {
				IndicatorAdded(this, new IndicatorAddedEventArgs(indicator));
			}
		}
		public void RemoveIndicator(Indicator indicator) {
			Indicators.Remove(indicator);
		}
	}
}
