using System;
using System.Collections.Generic;
using System.ComponentModel;
using DevExpress.ExpressApp.Win;
using DevExpress.ExpressApp.Updating;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Xpo;

namespace ProjectManagement_1.Win {
	public partial class ProjectManagement_1WindowsFormsApplication : WinApplication {
		public ProjectManagement_1WindowsFormsApplication() {
			InitializeComponent();
			DelayedViewItemsInitialization = true;
		}

		protected override void CreateDefaultObjectSpaceProvider(CreateCustomObjectSpaceProviderEventArgs args) {
			args.ObjectSpaceProvider = new XPObjectSpaceProvider(args.ConnectionString, args.Connection);
		}
		private void ProjectManagement_1WindowsFormsApplication_DatabaseVersionMismatch(object sender, DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs e) {
#if EASYTEST
			e.Updater.Update();
			e.Handled = true;
#else
			if(System.Diagnostics.Debugger.IsAttached) {
				e.Updater.Update();
				e.Handled = true;
			} else {
				throw new InvalidOperationException(
					"The application cannot connect to the specified database, because the latter doesn't exist or its version is older than that of the application.\r\n" +
					"This error occurred  because the automatic database update was disabled when the application was started without debugging.\r\n" +
					"To avoid this error, you should either start the application under Visual Studio in debug mode, or modify the " +
					"source code of the 'DatabaseVersionMismatch' event handler to enable automatic database update, " +
					"or manually create a database using the 'DBUpdater' tool.\r\n" +
					"Anyway, refer to the 'Update Application and Database Versions' help topic at http://www.devexpress.com/Help/?document=ExpressApp/CustomDocument2795.htm " +
					"for more detailed information. If this doesn't help, please contact our Support Team at http://www.devexpress.com/Support/Center/");
			}
#endif
		}
		private void ProjectManagement_1WindowsFormsApplication_CustomizeLanguagesList(object sender, CustomizeLanguagesListEventArgs e) {
			string userLanguageName = System.Threading.Thread.CurrentThread.CurrentUICulture.Name;
			if(userLanguageName != "en-US" && e.Languages.IndexOf(userLanguageName) == -1) {
				e.Languages.Add(userLanguageName);
			}
		}
	}
}
