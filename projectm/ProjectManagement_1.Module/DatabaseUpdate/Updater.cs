using System;

using DevExpress.ExpressApp;
using DevExpress.ExpressApp.Updating;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.BaseImpl;
using DevExpress.ExpressApp.Security;

using DevExpress.ExpressApp.Security.Strategy;
using ProjectManagement_1.Module.BusinessObjects;

namespace ProjectManagement_1.Module.DatabaseUpdate {
	public class Updater : ModuleUpdater {
		public Updater(IObjectSpace objectSpace, Version currentDBVersion) : base(objectSpace, currentDBVersion) { }
		public override void UpdateDatabaseAfterUpdateSchema() {
			base.UpdateDatabaseAfterUpdateSchema();

			// ... 
			//SecurityRole
			SecuritySystemRole adminRole = ObjectSpace.FindObject<SecuritySystemRole>(new BinaryOperator("Name", SecurityStrategy.AdministratorRoleName));
			if(adminRole == null) {
				adminRole = ObjectSpace.CreateObject<SecuritySystemRole>();
				adminRole.Name = SecurityStrategy.AdministratorRoleName;
				adminRole.IsAdministrative = true;
				adminRole.Save();
			}
			// ... 

			//Role myAddressPermissions = ObjectSpace.FindObject<Role>(new BinaryOperator("Name", "AggregatedObjectPermissionsOnly"));
			//if(myAddressPermissions == null) {
			//  myAddressPermissions = ObjectSpace.CreateObject<Role>();
			//  myAddressPermissions.Name = "AggregatedObjectPermissionsOnly";
			//  myAddressPermissions.AddPermission(new ObjectAccessPermission(typeof(KnowledgeBase),
			//     ObjectAccess.AllAccess, ObjectAccessModifier.Deny));
			//  //myAddressPermissions.AddPermission(new ObjectAccessPermission(typeof(MyAddress),
			//  //   ObjectAccess.AllAccess, ObjectAccessModifier.Allow));
			//  myAddressPermissions.Save();
			//}

			//User userSam = ObjectSpace.FindObject<User>(new BinaryOperator("UserName", "Sam"));
			//if(userSam == null) {
			//  userSam = ObjectSpace.CreateObject<User>();
			//  userSam.UserName = "Sam";
			//  userSam.FirstName = "Sam";
			//  userSam.Roles.Add(myAddressPermissions);
			//  userSam.Save();
			//}

			//// ... 
			//SecuritySystemRole userRole = ObjectSpace.FindObject<SecuritySystemRole>(new BinaryOperator("Name", "User"));
			//if(userRole == null) {
			//  userRole = ObjectSpace.CreateObject<SecuritySystemRole>();
			//  userRole.Name = "User";
			//  SecuritySystemTypePermissionObject userTypePermission =
			//      ObjectSpace.CreateObject<SecuritySystemTypePermissionObject>();
			//  userTypePermission.TargetType = typeof(SecuritySystemUser);
			//  SecuritySystemObjectPermissionsObject currentUserObjectPermission =
			//      ObjectSpace.CreateObject<SecuritySystemObjectPermissionsObject>();
			//  currentUserObjectPermission.Criteria = "[Oid] = CurrentUserId()";
			//  currentUserObjectPermission.AllowNavigate = true;
			//  currentUserObjectPermission.AllowRead = true;
			//  userTypePermission.ObjectPermissions.Add(currentUserObjectPermission);
			//  userRole.TypePermissions.Add(userTypePermission);
			//}
			//// ... 

			// ... 
			// If a user named 'Sam' doesn't exist in the database, create this user 
			//SecuritySystemUser user1 = ObjectSpace.FindObject<SecuritySystemUser>(
			//  new BinaryOperator("UserName", "Sam"));
			//if(user1 == null) {
			//  user1 = ObjectSpace.CreateObject<SecuritySystemUser>();
			//  user1.UserName = "Sam";
			//  // Set a password if the standard authentication type is used 
			//  user1.SetPassword("");
			//}
			//// If a user named 'John' doesn't exist in the database, create this user 
			//SecuritySystemUser user2 = ObjectSpace.FindObject<SecuritySystemUser>(
			//     new BinaryOperator("UserName", "John"));
			//if(user2 == null) {
			//  user2 = ObjectSpace.CreateObject<SecuritySystemUser>();
			//  user2.UserName = "John";
			//  // Set a password if the standard authentication type is used 
			//  user2.SetPassword("");
			//}

			// ... 

			ProjectManagement_1.Module.BusinessObjects.UserEx user3 =
				ObjectSpace.FindObject<ProjectManagement_1.Module.BusinessObjects.UserEx>(new BinaryOperator("UserName", "Admin"));
			if(user3 == null) {
				user3 = ObjectSpace.CreateObject<ProjectManagement_1.Module.BusinessObjects.UserEx>();
				user3.UserName = "Admin";
				// Set a password if the standard authentication type is used 
				user3.SetPassword("");
			}

			// Add the "Administrators" Role to the user1 
			//user1.Roles.Add(adminRole);
			// Add the "Users" Role to the user2 
			//user2.Roles.Add(userRole);

			user3.Roles.Add(adminRole);
			// ...  

		}
	}
}
