using NeuroProfit.DataLoader;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeuroProfit {
	public class DataRegister {
		public event EventHandler<DataHandlerRegisteredEventArgs> DataHandlerRegistered;
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
			var dataHandler = new DataHandler(Path.GetFileNameWithoutExtension(source), dataLoader.Load(source));
			dataHandlers.Add(dataHandler);
			if (DataHandlerRegistered != null) {
				DataHandlerRegistered(this, new DataHandlerRegisteredEventArgs(dataHandler));
			}
		}
	}
}
