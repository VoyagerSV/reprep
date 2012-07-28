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
	public class Person : BaseObject {
		public Person(Session session) : base(session) { }

		public string Name { get; set; }
		public string Surname { get; set; }
		public string Position { get; set; }
		public string email { get; set; }
		public string Phone { get; set; }
		[Size(2500)]
		public string Description { get; set; }

		[Association("Customer_Person")]
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
