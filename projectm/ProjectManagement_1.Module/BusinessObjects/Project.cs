using System;
using System.ComponentModel;

using DevExpress.Xpo;
using DevExpress.Data.Filtering;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.ConditionalAppearance;

namespace ProjectManagement_1.Module.BusinessObjects {
	[DefaultClassOptions]
	[DefaultProperty("Title")]
	[RuleCriteria("", DefaultContexts.Save, "EndDate >= StartDate", "End Date must be greater then start Date", SkipNullOrEmptyValues = false)]
	//[Appearance("FontColorRed", AppearanceItemType = "ViewItem", TargetItems = "EndDate,StartDate", Context = "ListView", Criteria = "EndDate < StartDate", FontColor = "Red")]
	public class Project : BaseObject, IvMode {
		public Project(Session session) : base(session) { }

		public string Title { get; set; }
		public Customer Custumer { get; set; }//------------------------------------------1
		public string Contract { get; set; }

		[Size(2200)]
		public string TaskDescription { get; set; }

		//[ModelDefault("AllowEdit", "False")]
		public DateTime StartDate { get; set; }

		public DateTime EndDate { get; set; }

		[Aggregated, Association("Project_Releases", typeof(Releases))]
		public XPCollection<Releases> Releases {
			get { return GetCollection<Releases>("Releases"); }
		}

		//.......................Files.........................
		//-public FileData File {
		//-  get { return file; }
		//-  set { SetPropertyValue("File", ref file, value); }
		//-}private FileData file;

		//[Aggregated, Association("Project_Files", typeof(File))]
		//.....................................................

		//public string Comments { get; set; }
		[Aggregated, Association("Project_Comment", typeof(Comment))]
		public XPCollection<Comment> Comments {
			get { return GetCollection<Comment>("Comments"); }
		}

		[Association("Project_KnowledgeBase", typeof(KnowledgeBase))]
		public XPCollection<KnowledgeBase> KnowledgeBase {
			get { return GetCollection<KnowledgeBase>("KnowledgeBase"); }
		}

		#region IvMode Members

		[ModelDefault("AllowEdit", "False")]
		public UserEx UserEx { get; set; }

		public Visibility VisiMode { get; set; }

		#endregion
		

		public override void AfterConstruction() {
			base.AfterConstruction();
			StartDate = DateTime.Now;
			// Place here your initialization code.
			this.UserEx = Session.GetObjectByKey<UserEx>((Guid)SecuritySystem.CurrentUserId);
		}

	}

}
