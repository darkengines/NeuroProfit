using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeuroProfit {
	public class DataHandlerRegisteredEventArgs: EventArgs {
		public DataHandler DataHandler { get; protected set; }
		public DataHandlerRegisteredEventArgs(DataHandler dataHandler) {
			DataHandler = dataHandler;
		}
	}
}
