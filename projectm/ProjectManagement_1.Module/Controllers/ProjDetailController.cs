using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Actions;
using DevExpress.Persistent.Base;
using ProjectManagement_1.Module.BusinessObjects;
using DevExpress.Data.Filtering;
using System.Windows.Forms;
using DevExpress.ExpressApp.Editors;

namespace ProjectManagement_1.Module.Controllers {
	public partial class ProjDetailController : ViewController {
		public ProjDetailController() {
			InitializeComponent();
			RegisterActions(components);
		}

		private void ProjDetailController_ViewControlsCreated(object sender, EventArgs e) {

			//MessageBox.Show(((KnowledgeBase)(View).CurrentObject).UserEx.UserName.ToString());
			if(((KnowledgeBase)(View).CurrentObject).UserEx.UserName != ObjectSpace.GetObjectByKey<UserEx>(SecuritySystem.CurrentUserId).UserName) {
				if(!ObjectSpace.IsNewObject(View.CurrentObject)) {
					foreach(PropertyEditor item in ((DetailView)View).GetItems<PropertyEditor>()) {
						if(item.AllowEdit) {
							item.AllowEdit.SetItemValue("ResultValue", false);
						}
					}
				}
			}

		}

		private void ProjDetailController_Activated(object sender, EventArgs e) {

		}
	}
}
