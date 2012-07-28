using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;

namespace ProjectManagement_1.Module.Controllers {
	public partial class ProjectController : ViewController {
		public ProjectController() {
			InitializeComponent();
			RegisterActions(components);
		}

		private void ProjectController_ViewControlsCreated(object sender, EventArgs e) {
			//(View as DevExpress.ExpressApp.ListView).CollectionSource.Criteria.Add("key", CriteriaOperator.Parse("UserEx=? Or VisiMode=='Public'", ObjectSpace.GetObjectByKey<UserEx>(SecuritySystem.CurrentUserId)));

		}
	}
}
