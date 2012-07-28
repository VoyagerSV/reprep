using System;
using System.ComponentModel;

using DevExpress.Xpo;
using DevExpress.Data.Filtering;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using System.Collections.Generic;
using DevExpress.ExpressApp.StateMachine;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.ConditionalAppearance;

namespace ProjectManagement_1.Module.BusinessObjects {

	[DefaultProperty("Title")]
	[RuleCriteria("", DefaultContexts.Save, "EndDate >= StartDate", "End Date must be greater then start Date", SkipNullOrEmptyValues = false)]
	//[Appearance("FontColorRed", AppearanceItemType = "ViewItem", TargetItems = "EndDate,StartDate", Context = "ListView", Criteria = "EndDate < StartDate", FontColor = "Red")]
	public class Releases : BaseObject, IStateMachineProvider {
		public Releases(Session session) : base(session) { }

		public string Title { get; set; }

		//[ModelDefault("AllowEdit", "False")]
		public DateTime StartDate { get; set; }

		public DateTime EndDate { get; set; }

		//[Association("Releases_UserEx")]
		//public XPCollection<UserEx> Participants {
		//  get { return GetCollection<UserEx>("Participants"); }
		//}

		[Association("WorkLoad_Releases")]
		public XPCollection<WorkLoad> Participants {
			get { return GetCollection<WorkLoad>("Participants"); }
		}

		public Status Status {
			get { return status; }
			set {
				SetPropertyValue("Status", ref status, value);
				if(value == Status.Finished) {
					RealDate = DateTime.Now;
				}
			}
		}private Status status;

		//public string Comments { get; set; }

		[Association("Releases_Files", typeof(File))]
		public XPCollection<File> Files {
			get { return GetCollection<File>("Files"); }
		}

		[Aggregated, Association("Releases_Comment", typeof(Comment))]
		public XPCollection<Comment> Comments {
			get { return GetCollection<Comment>("Comments"); }
		}

		[ModelDefault("AllowEdit", "False")]
		public DateTime RealDate {
			get { return realDate; }
			set { SetPropertyValue("RealDate", ref realDate, value); }
		}private DateTime realDate;

		[Size(500)]
		public string Description { get; set; }

		[Persistent, Association("Project_Releases")]
		public Project Project {
			get { return project; }
			set { SetPropertyValue("Project", ref project, value); }
		}private Project project;

		public IList<IStateMachine> GetStateMachines() {
			List<IStateMachine> result = new List<IStateMachine>();
			result.Add(new StatusStateMachine());
			return result;
		}

		public override void AfterConstruction() {
			base.AfterConstruction();
			StartDate = DateTime.Now;
			// Place here your initialization code.
		}

	}

	public class File : FileAttachmentBase {
		public File(Session session) : base(session) { }

		[Persistent, Association("Releases_Files")]
		[ModelDefault("AllowEdit", "False")]
		public Releases Releases {
			get { return releases; }
			set { SetPropertyValue("Releases", ref releases, value); }
		}private Releases releases;

	}

}