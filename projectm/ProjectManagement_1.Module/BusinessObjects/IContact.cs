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

	public interface IContact {

		//TitleOfCourtesy TitleOfCourtesy { get; set; }

		string WebPageAddress { get; set; }

		string Email { get; set; }

		string Phone { get; set; }

		//[Size(4096)]
		string Notes { get; set; }

		//[Association("Releases_HR_Contacts")]
		//[ModelDefault("AllowEdit", "False")]
		//Releases Releases { get; set; }

	}

	public enum TitleOfCourtesy { Dr, Miss, Mr, Mrs, Ms };

}
