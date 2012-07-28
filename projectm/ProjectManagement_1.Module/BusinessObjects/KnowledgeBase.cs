using System;
using System.ComponentModel;

using DevExpress.Xpo;
using DevExpress.Data.Filtering;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.ExpressApp.Model;

namespace ProjectManagement_1.Module.BusinessObjects {
	[DefaultClassOptions]
	public class KnowledgeBase : BaseObject, IvMode {
		public KnowledgeBase(Session session) : base(session) { }

		public string Name { get; set; }
		public FileData File { get; set; }
		public Category Category { get; set; }
		[Size(1000)]
		public string Description { get; set; }

		[Association("Project_KnowledgeBase", typeof(Project))]
		[ModelDefault("AllowEdit", "False")]
		public Project Project {
			get { return project; }
			set { SetPropertyValue("Project", ref project, value); }
		}private Project project;

		#region IvMode Members

		[ModelDefault("AllowEdit", "False")]
		public UserEx UserEx { get; set; }

		public Visibility VisiMode { get; set; }

		#endregion

		public override void AfterConstruction() {
			base.AfterConstruction();
			// Place here your initialization code.
			this.UserEx = Session.GetObjectByKey<UserEx>((Guid)SecuritySystem.CurrentUserId);
		}

	}

	public enum Category { Z, X, V, W }

}
