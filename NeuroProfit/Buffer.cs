using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroProfit {
	public class Buffer {
		public Buffer(IEnumerable<Datum> data) {
			Data = data;
			Max = data.Select(x => x.High).Max();
			Min = data.Select(x => x.Low).Min();
			StartDate = data.First().Time;
			EndDate = data.Last().Time;
		}
		public IEnumerable<Datum> Data { get; protected set; }
		public double Max { get; protected set; }
		public double Min { get; protected set; }
		public DateTime StartDate { get; protected set; }
		public DateTime EndDate { get; protected set; }
	}
}
