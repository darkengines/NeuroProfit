﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DarkEngines.DynamicForm {
	public interface IDynamicFormEditorProvider {
		DynamicFormEditor GetNewEditor();
	}
}
