using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Collections.ObjectModel;

namespace NeuroProfitUI.DynamicForm {
	public abstract class MemberInfo {
		public string Name {
			get;
			set;
		}
		public string Label = null;
		public int Position = 0;
		public Type Type = null;
		protected IDynamicFormEditorProvider EditorProvider;
		public DynamicFormEditor Editor {
			get {
				return EditorProvider.GetNewEditor();
			}
		}
	}
	public class MemberInfo<T>: MemberInfo {
		public Expression<Func<T, object>> Member;

		public MemberInfo(Expression<Func<T, object>> member, IDynamicFormEditorProvider editor, string label, int position) {
			Name = ExpressionHelper.MemberToString<T>(member);
			EditorProvider = editor;
			Type = member.GetType().GetGenericArguments()[0].GetGenericArguments()[1];
			Member = member;
			Position = position;
			Label = label ?? Name;
			if (Position == null) Position = 0;
		}
	}
}
