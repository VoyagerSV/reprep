using System;
using System.ComponentModel;

using DevExpress.Xpo;
using DevExpress.Data.Filtering;

using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;

namespace ProjectManagement_1.Module.BusinessObjects {
	[DefaultClassOptions]
	public class Customer : BaseObject {
		public Customer(Session session) : base(session) { }

		public string Name { get; set; }
		public string Address { get; set; }
		public BusinessSector BusinessSector { get; set; }

		[Aggregated, Association("Customer_Contact")]
		public XPCollection<CustomerContact> Contact {
			get { return GetCollection<CustomerContact>("Contact"); }
		}

		[Aggregated, Association("Customer_Person")]
		public XPCollection<Person> Person {
			get { return GetCollection<Person>("Person"); }
		}

		public override void AfterConstruction() {
			base.AfterConstruction();
			// Place here your initialization code.
		}
	}

}
