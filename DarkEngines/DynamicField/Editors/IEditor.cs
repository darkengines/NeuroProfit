using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DarkEngines.DynamicField.Editors {
	public interface IEditor<T> {
		T Value { get; set; }
	}
}
