using System;
using System.ComponentModel;

using DevExpress.Xpo;
using DevExpress.Data.Filtering;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.XtraScheduler;
using DevExpress.XtraEditors.Controls;
using DevExpress.ExpressApp.Model;

namespace ProjectManagement_1.Module.BusinessObjects {
	[DefaultClassOptions]
	public class WorkLoad : BaseObject {
		public WorkLoad(Session session) : base(session) { }

		public UserEx User { get; set; }

		[Aggregated, Association("WorkLoad_WTime", typeof(WTime))]
		public XPCollection<WTime> WTimes {
			get { return GetCollection<WTime>("WTimes"); }
		}

		[Association("WorkLoad_Releases")]
		[ModelDefault("AllowEdit", "False")]
		public Releases Releases {
			get { return releases; }
			set { SetPropertyValue("Releases", ref releases, value); }
		}private Releases releases;

	}

	public class WTime : BaseObject {
		public WTime(Session session) : base(session) { }

		public Days Day { get; set; }
		public string StartTime { get; set; }
		public string EndTime { get; set; }

		[Association("WorkLoad_WTime", typeof(WTime))]
		[ModelDefault("AllowEdit", "False")]
		public WorkLoad WorkLoad {
			get { return workLoad; }
			set { SetPropertyValue("WorkLoad", ref workLoad, value); }
		}private WorkLoad workLoad;

	}

	public enum Days {
		Monday,
		Tuesday,
		Wednesday,
		Thursday,
		Friday,
		Saturday,
		Sunday
	}

}
