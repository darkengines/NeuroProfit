using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeuroProfitUI {
	public interface ClassTableEditor {
		object GetValue();
		void SetValue(object value);
	}
}
