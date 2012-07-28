using System;
using System.ComponentModel;

using DevExpress.Xpo;
using DevExpress.Data.Filtering;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.ExpressApp.Security.Strategy;
using DevExpress.ExpressApp.Model;

namespace ProjectManagement_1.Module.BusinessObjects {
	//[DefaultProperty("Text")]
	public class Comment : BaseObject {
		public Comment(Session session) : base(session) { }

		[Size(2500)]
		public string Text { get; set; }

		[ModelDefault("AllowEdit", "False")]
		public UserEx Autor {
			get { return autor; }
			set { SetPropertyValue("Author", ref autor, value); }
		}private UserEx autor;

		[ModelDefault("AllowEdit", "False")]
		public DateTime Date {
			get { return date; }
			set { SetPropertyValue("Date", ref date, value); }
		}private DateTime date;

		[Association("Releases_Comment")]
		[ModelDefault("AllowEdit", "False")]
		public Releases Releases {
			get { return releases; }
			set { SetPropertyValue("Releases", ref releases, value); }
		}private Releases releases;

		[Association("Project_Comment")]
		public Project Project {
			get { return project; }
			set { SetPropertyValue("Project", ref project, value); }
		}private Project project;

		public override void AfterConstruction() {
			base.AfterConstruction();
			// Place here your initialization code.
			Date = DateTime.Now;
			Autor = Session.GetObjectByKey<UserEx>((Guid)SecuritySystem.CurrentUserId);
		}

	}

}
