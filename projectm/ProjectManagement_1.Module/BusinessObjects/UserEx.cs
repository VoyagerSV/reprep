using System;
using System.ComponentModel;

using DevExpress.Xpo;
using DevExpress.Data.Filtering;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.ExpressApp.Model;
using DevExpress.ExpressApp.Security;
using DevExpress.ExpressApp.Security.Strategy;

namespace ProjectManagement_1.Module.BusinessObjects {
	[DefaultClassOptions]
	public class UserEx : SecuritySystemUser, IContact {
		public UserEx(Session session) : base(session) { }
		public string Name { get; set; }
		public string Surname { get; set; }

		//..................... ParticipationDays .........................
		//public bool Monday { get; set; }
		//public bool Tuesday { get; set; }
		//public bool Wednesday { get; set; }
		//public bool Thursday { get; set; }
		//public bool Friday { get; set; }
		//public bool Saturday { get; set; }
		//public bool Sunday { get; set; }
		//.................................................................

		//[Association("Releases_UserEx")]
		//[ModelDefault("AllowEdit", "False")]
		//public Releases Releases {
		//  get { return releases; }
		//  set { SetPropertyValue("Releases", ref releases, value); }
		//}private Releases releases;

		public override void AfterConstruction() {
			base.AfterConstruction();
			// Place here your initialization code.
		}

		#region IContact Members

		//public TitleOfCourtesy TitleOfCourtesy {
		//  get { return titleOfCourtesy; }
		//  set { SetPropertyValue("TitleOfCourtesy", ref titleOfCourtesy, value); }
		//}private TitleOfCourtesy titleOfCourtesy;

		public string WebPageAddress {
			get { return webPageAddress; }
			set { SetPropertyValue("WebPageAddress", ref webPageAddress, value); }
		}private string webPageAddress;

		public string Email {
			get { return email; }
			set { SetPropertyValue("Email", ref email, value); }
		}private string email;

		public string Phone {
			get { return phone; }
			set { SetPropertyValue("Phone", ref phone, value); }
		}private string phone;

		[Size(4096)]
		public string Notes {
			get { return notes; }
			set { SetPropertyValue("Notes", ref notes, value); }
		}private string notes;

		#endregion
	

	}

}
