using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroProfit {
	public class DataHandler {

		public DataHandler(string name, Datum[] data, int count) {
			Name = name;
			Data = data;
			Count = count;
		}

		public string Name { get; protected set; }
		public int Count { get; protected set; }
		public Datum[] Data { get; protected set; }
		public IEnumerable<Datum> GetRange(DateRange range) {
			return Data.SkipWhile(datum => datum.Time <= range.Start).TakeWhile(datum => datum.Time <= range.End);
		}
		public TimeSpan Unit {
			get {
				return Data.ElementAt(1).Time - Data.First().Time;
			}
		}
	}
}
