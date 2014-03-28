﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeuroProfitUI.DynamicForm {
	public interface DynamicFormEditor {
		object GetValue();
		void SetValue(object value);
	}
}