#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by the ClassGenerator.ttinclude code generation file.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;
using System.Collections.Generic;
using Telerik.OpenAccess;
using Telerik.OpenAccess.Metadata;
using Telerik.OpenAccess.Data.Common;
using Telerik.OpenAccess.Metadata.Fluent;
using Telerik.OpenAccess.Metadata.Fluent.Advanced;

namespace YouthConference.Models	
{
	public partial class Registrant
	{
		private int _id;
		public virtual int Id
		{
			get
			{
				return this._id;
			}
			set
			{
				this._id = value;
			}
		}
		
		private string _firstName;
		public virtual string FirstName
		{
			get
			{
				return this._firstName;
			}
			set
			{
				this._firstName = value;
			}
		}
		
		private string _middleName;
		public virtual string MiddleName
		{
			get
			{
				return this._middleName;
			}
			set
			{
				this._middleName = value;
			}
		}
		
		private string _lastName;
		public virtual string LastName
		{
			get
			{
				return this._lastName;
			}
			set
			{
				this._lastName = value;
			}
		}
		
		private string _state;
		public virtual string State
		{
			get
			{
				return this._state;
			}
			set
			{
				this._state = value;
			}
		}
		
		private string _email;
		public virtual string Email
		{
			get
			{
				return this._email;
			}
			set
			{
				this._email = value;
			}
		}
		
		private string _phoneNumber;
		public virtual string PhoneNumber
		{
			get
			{
				return this._phoneNumber;
			}
			set
			{
				this._phoneNumber = value;
			}
		}
		
		private string _gender;
		public virtual string Gender
		{
			get
			{
				return this._gender;
			}
			set
			{
				this._gender = value;
			}
		}
		
		private string _institution;
		public virtual string Institution
		{
			get
			{
				return this._institution;
			}
			set
			{
				this._institution = value;
			}
		}
		
		private string _courseOfStudy;
		public virtual string CourseOfStudy
		{
			get
			{
				return this._courseOfStudy;
			}
			set
			{
				this._courseOfStudy = value;
			}
		}
		
		private string _country;
		public virtual string Country
		{
			get
			{
				return this._country;
			}
			set
			{
				this._country = value;
			}
		}
		
	}
}
#pragma warning restore 1591
