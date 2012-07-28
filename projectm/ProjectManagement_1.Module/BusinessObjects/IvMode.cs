using System;
using DevExpress.Xpo;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;

namespace ProjectManagement_1.Module.BusinessObjects {
	public interface IvMode {

		UserEx UserEx { get; set; }
		Visibility VisiMode { get; set; }

	}

	public enum Visibility { Private, Public }

}
