namespace ProjectManagement_1.Win {
	partial class ProjectManagement_1WindowsFormsApplication {
		/// <summary> 
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if(disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.module1 = new DevExpress.ExpressApp.SystemModule.SystemModule();
			this.module2 = new DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule();
			this.module3 = new ProjectManagement_1.Module.ProjectManagement_1Module();
			this.module4 = new ProjectManagement_1.Module.Win.ProjectManagement_1WindowsFormsModule();
			this.fileAttachmentsWindowsFormsModule1 = new DevExpress.ExpressApp.FileAttachments.Win.FileAttachmentsWindowsFormsModule();
			this.conditionalAppearanceModule1 = new DevExpress.ExpressApp.ConditionalAppearance.ConditionalAppearanceModule();
			this.validationModule1 = new DevExpress.ExpressApp.Validation.ValidationModule();
			this.stateMachineModule1 = new DevExpress.ExpressApp.StateMachine.StateMachineModule();
			this.schedulerModuleBase1 = new DevExpress.ExpressApp.Scheduler.SchedulerModuleBase();
			this.schedulerWindowsFormsModule1 = new DevExpress.ExpressApp.Scheduler.Win.SchedulerWindowsFormsModule();
			this.securityStrategyComplex1 = new DevExpress.ExpressApp.Security.SecurityStrategyComplex();
			this.authenticationStandard1 = new DevExpress.ExpressApp.Security.AuthenticationStandard();
			this.securityModule1 = new DevExpress.ExpressApp.Security.SecurityModule();
			this.viewVariantsModule1 = new DevExpress.ExpressApp.ViewVariantsModule.ViewVariantsModule();
			this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
			((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
			// 
			// validationModule1
			// 
			this.validationModule1.AllowValidationDetailsAccess = true;
			// 
			// stateMachineModule1
			// 
			this.stateMachineModule1.StateMachineStorageType = typeof(DevExpress.ExpressApp.StateMachine.Xpo.XpoStateMachine);
			// 
			// securityStrategyComplex1
			// 
			this.securityStrategyComplex1.Authentication = this.authenticationStandard1;
			this.securityStrategyComplex1.RoleType = typeof(DevExpress.ExpressApp.Security.Strategy.SecuritySystemRole);
			this.securityStrategyComplex1.UserType = typeof(DevExpress.ExpressApp.Security.Strategy.SecuritySystemUser);
			// 
			// authenticationStandard1
			// 
			this.authenticationStandard1.LogonParametersType = typeof(DevExpress.ExpressApp.Security.AuthenticationStandardLogonParameters);
			// 
			// viewVariantsModule1
			// 
			this.viewVariantsModule1.GenerateVariantsNode = true;
			this.viewVariantsModule1.ShowAdditionalNavigation = false;
			// 
			// sqlConnection1
			// 
			this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
			// 
			// ProjectManagement_1WindowsFormsApplication
			// 
			this.ApplicationName = "ProjectManagement_1";
			this.Connection = this.sqlConnection1;
			this.Modules.Add(this.module1);
			this.Modules.Add(this.module2);
			this.Modules.Add(this.fileAttachmentsWindowsFormsModule1);
			this.Modules.Add(this.conditionalAppearanceModule1);
			this.Modules.Add(this.validationModule1);
			this.Modules.Add(this.stateMachineModule1);
			this.Modules.Add(this.schedulerModuleBase1);
			this.Modules.Add(this.schedulerWindowsFormsModule1);
			this.Modules.Add(this.viewVariantsModule1);
			this.Modules.Add(this.module3);
			this.Modules.Add(this.module4);
			this.Modules.Add(this.securityModule1);
			this.Security = this.securityStrategyComplex1;
			this.DatabaseVersionMismatch += new System.EventHandler<DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs>(this.ProjectManagement_1WindowsFormsApplication_DatabaseVersionMismatch);
			this.CustomizeLanguagesList += new System.EventHandler<DevExpress.ExpressApp.CustomizeLanguagesListEventArgs>(this.ProjectManagement_1WindowsFormsApplication_CustomizeLanguagesList);
			((System.ComponentModel.ISupportInitialize)(this)).EndInit();

		}

		#endregion

		private DevExpress.ExpressApp.SystemModule.SystemModule module1;
		private DevExpress.ExpressApp.Win.SystemModule.SystemWindowsFormsModule module2;
		private ProjectManagement_1.Module.ProjectManagement_1Module module3;
		private ProjectManagement_1.Module.Win.ProjectManagement_1WindowsFormsModule module4;
		private DevExpress.ExpressApp.FileAttachments.Win.FileAttachmentsWindowsFormsModule fileAttachmentsWindowsFormsModule1;
		private DevExpress.ExpressApp.ConditionalAppearance.ConditionalAppearanceModule conditionalAppearanceModule1;
		private DevExpress.ExpressApp.Validation.ValidationModule validationModule1;
		private DevExpress.ExpressApp.StateMachine.StateMachineModule stateMachineModule1;
		private DevExpress.ExpressApp.Scheduler.SchedulerModuleBase schedulerModuleBase1;
		private DevExpress.ExpressApp.Scheduler.Win.SchedulerWindowsFormsModule schedulerWindowsFormsModule1;
		private DevExpress.ExpressApp.Security.SecurityStrategyComplex securityStrategyComplex1;
		private DevExpress.ExpressApp.Security.SecurityModule securityModule1;
		private DevExpress.ExpressApp.Security.AuthenticationStandard authenticationStandard1;
		private DevExpress.ExpressApp.ViewVariantsModule.ViewVariantsModule viewVariantsModule1;
		private System.Data.SqlClient.SqlConnection sqlConnection1;
	}
}
