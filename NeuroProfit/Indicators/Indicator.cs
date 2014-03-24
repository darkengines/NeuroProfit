using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroProfit.Indicators {
	public abstract class Indicator {
		public Indicator() {
			Buffers = new Dictionary<string, double?[]>();
		}
		protected Datum[] data;
		public Dictionary<string, double?[]> Buffers { get; protected set; }
		public Datum[] DataSource {
			get {
				return data;
			}
			set {
				data = value;
				Init();
				Compute(data);
			}
		}
		protected abstract void Init();
		protected abstract int ComputeDatum(Datum[] data, int lastComputed, int total);
		protected void Compute(Datum[] data) {
			int count = data.Count();
			int i = 0;
			while (i < count) {
				ComputeDatum(data, i == 0 ? 0 : i - 1, count);
				i++;
			}
		}
	}
}
