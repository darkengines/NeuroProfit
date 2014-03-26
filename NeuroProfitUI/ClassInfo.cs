using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;
using System.Collections.ObjectModel;

namespace NeuroProfitUI {
	public abstract class ClassInfo {
		public Collection<MemberInfo> Members = new Collection<MemberInfo>();
	}
	public abstract class ClassInfo<T>: ClassInfo {
		public void Member(MemberInfo<T> memberInfo) {
			Members.Add(memberInfo);
		}
		public void Member(Expression<Func<T, object>> member, IClassTableEditorProvider editor, string label, int position) {
			Members.Add(new MemberInfo<T>(member, editor, label, position));
		}
	}
}