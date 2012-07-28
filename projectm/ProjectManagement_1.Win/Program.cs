using System;
using System.Configuration;
using System.Windows.Forms;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Security;
using DevExpress.ExpressApp.Win;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;

namespace ProjectManagement_1.Win {
	static class Program {
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() {
#if EASYTEST
			DevExpress.ExpressApp.Win.EasyTest.EasyTestRemotingRegistration.Register();
#endif

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			EditModelPermission.AlwaysGranted = System.Diagnostics.Debugger.IsAttached;
			ProjectManagement_1WindowsFormsApplication winApplication = new ProjectManagement_1WindowsFormsApplication();
			//winApplication.ConnectionString = DevExpress.Xpo.DB.MSSqlConnectionProvider.GetConnectionString(Environment.MachineName,"test");
			//winApplication.DatabaseUpdateMode = DatabaseUpdateMode.UpdateDatabaseAlways;
#if EASYTEST
			if(ConfigurationManager.ConnectionStrings["EasyTestConnectionString"] != null) {
				winApplication.ConnectionString = ConfigurationManager.ConnectionStrings["EasyTestConnectionString"].ConnectionString;
			}
#endif
			if(ConfigurationManager.ConnectionStrings["ConnectionString"] != null) {
				winApplication.ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
			}
			try {
				winApplication.Setup();
				winApplication.Start();
			} catch(Exception e) {
				winApplication.HandleException(e);
			}
		}
	}
}
