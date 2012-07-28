using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;
using System.Windows.Forms;
using DevExpress.Xpo;
using ProjectManagement_1.Module.BusinessObjects;
using DevExpress.Data.Filtering;
using System.Collections;

namespace ProjectManagement_1.Module.Controllers {
	public partial class TestController : ViewController {
		public TestController() {
			InitializeComponent();
			RegisterActions(components);
		}

		private void TestController_Activated(object sender, EventArgs e) {
			
		}

		private void TestController_ViewControlsCreated(object sender, EventArgs e) {
		
			(View as DevExpress.ExpressApp.ListView).CollectionSource.Criteria.Add("key", CriteriaOperator.Parse("UserEx=? Or VisiMode=='Public'", ObjectSpace.GetObjectByKey<UserEx>(SecuritySystem.CurrentUserId)));

		}

	}
}




////if(!(View as DevExpress.ExpressApp.ListView).CollectionSource.Criteria.ContainsKey("key")) {
////  (View as DevExpress.ExpressApp.ListView).CollectionSource.Criteria.Remove("key");
////}