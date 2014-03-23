using NeuroProfit.DataLoader;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroProfit {
	public class DataRegister {
		protected Loader dataLoader;
		protected List<DataHandler> dataHandlers;
		public DataRegister() {
			dataLoader = new Loader();
			dataHandlers = new List<DataHandler>();
		}
		public IEnumerable<DataHandler> DataHandlers {
			get {
				return dataHandlers;
			}
		}
		public void Register(string source) {
			dataHandlers.Add(new DataHandler(Path.GetFileNameWithoutExtension(source), dataLoader.Load(source)));
		}
	}
}
