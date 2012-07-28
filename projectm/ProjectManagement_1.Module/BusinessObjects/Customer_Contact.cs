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
	//[DefaultClassOptions]
	[DefaultProperty("Name")]
	public class CustomerContact : BaseObject {
		public CustomerContact(Session session) : base(session) { }

		public string Name {
			get { return name; }
			set { SetPropertyValue("NickName", ref name, value); }
		}private string name;

		public string WebPageAddress {
			get { return webPageAddress; }
			set { SetPropertyValue("WebPageAddress", ref webPageAddress, value); }
		}private string webPageAddress;

		public string Email {
			get { return email; }
			set { SetPropertyValue("WebPageAddress", ref email, value); }
		}private string email;

		public string Phone {
			get { return phone; }
			set { SetPropertyValue("WebPageAddress", ref phone, value); }
		}private string phone;

		[Size(4096)]
		public string Notes {
			get { return notes; }
			set { SetPropertyValue("Notes", ref notes, value); }
		}private string notes;

		[Association("Customer_Contact")]
		[ModelDefault("AllowEdit", "False")]
		public Customer Customer {
			get { return customer; }
			set { SetPropertyValue("Customer", ref customer, value); }
		}private Customer customer;

		public override void AfterConstruction() {
			base.AfterConstruction();
			// Place here your initialization code.
		}
	}

}
