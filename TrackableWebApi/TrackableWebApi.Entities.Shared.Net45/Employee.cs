namespace TrackableWebApi.Entities.Shared.Net45
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using TrackableEntities.Client;

    public partial class Employee : EntityBase
    {
        public Employee()
        {
            Employees1 = new ChangeTrackingCollection<Employee>();
            Orders = new ChangeTrackingCollection<Order>();
            Territories = new ChangeTrackingCollection<Territory>();
        }

		public int EmployeeID
		{ 
			get { return _EmployeeID; }
			set
			{
				if (Equals(value, _EmployeeID)) return;
				_EmployeeID = value;
				NotifyPropertyChanged();
			}
		}
		private int _EmployeeID;

        [Required]
        [StringLength(20)]
		public string LastName
		{ 
			get { return _LastName; }
			set
			{
				if (Equals(value, _LastName)) return;
				_LastName = value;
				NotifyPropertyChanged();
			}
		}
		private string _LastName;

        [Required]
        [StringLength(10)]
		public string FirstName
		{ 
			get { return _FirstName; }
			set
			{
				if (Equals(value, _FirstName)) return;
				_FirstName = value;
				NotifyPropertyChanged();
			}
		}
		private string _FirstName;

        [StringLength(30)]
		public string Title
		{ 
			get { return _Title; }
			set
			{
				if (Equals(value, _Title)) return;
				_Title = value;
				NotifyPropertyChanged();
			}
		}
		private string _Title;

        [StringLength(25)]
		public string TitleOfCourtesy
		{ 
			get { return _TitleOfCourtesy; }
			set
			{
				if (Equals(value, _TitleOfCourtesy)) return;
				_TitleOfCourtesy = value;
				NotifyPropertyChanged();
			}
		}
		private string _TitleOfCourtesy;

		public DateTime? BirthDate
		{ 
			get { return _BirthDate; }
			set
			{
				if (Equals(value, _BirthDate)) return;
				_BirthDate = value;
				NotifyPropertyChanged();
			}
		}
		private DateTime? _BirthDate;

		public DateTime? HireDate
		{ 
			get { return _HireDate; }
			set
			{
				if (Equals(value, _HireDate)) return;
				_HireDate = value;
				NotifyPropertyChanged();
			}
		}
		private DateTime? _HireDate;

        [StringLength(60)]
		public string Address
		{ 
			get { return _Address; }
			set
			{
				if (Equals(value, _Address)) return;
				_Address = value;
				NotifyPropertyChanged();
			}
		}
		private string _Address;

        [StringLength(15)]
		public string City
		{ 
			get { return _City; }
			set
			{
				if (Equals(value, _City)) return;
				_City = value;
				NotifyPropertyChanged();
			}
		}
		private string _City;

        [StringLength(15)]
		public string Region
		{ 
			get { return _Region; }
			set
			{
				if (Equals(value, _Region)) return;
				_Region = value;
				NotifyPropertyChanged();
			}
		}
		private string _Region;

        [StringLength(10)]
		public string PostalCode
		{ 
			get { return _PostalCode; }
			set
			{
				if (Equals(value, _PostalCode)) return;
				_PostalCode = value;
				NotifyPropertyChanged();
			}
		}
		private string _PostalCode;

        [StringLength(15)]
		public string Country
		{ 
			get { return _Country; }
			set
			{
				if (Equals(value, _Country)) return;
				_Country = value;
				NotifyPropertyChanged();
			}
		}
		private string _Country;

        [StringLength(24)]
		public string HomePhone
		{ 
			get { return _HomePhone; }
			set
			{
				if (Equals(value, _HomePhone)) return;
				_HomePhone = value;
				NotifyPropertyChanged();
			}
		}
		private string _HomePhone;

        [StringLength(4)]
		public string Extension
		{ 
			get { return _Extension; }
			set
			{
				if (Equals(value, _Extension)) return;
				_Extension = value;
				NotifyPropertyChanged();
			}
		}
		private string _Extension;

        [Column(TypeName = "image")]
		public byte[] Photo
		{ 
			get { return _Photo; }
			set
			{
				if (Equals(value, _Photo)) return;
				_Photo = value;
				NotifyPropertyChanged();
			}
		}
		private byte[] _Photo;

        [Column(TypeName = "ntext")]
		public string Notes
		{ 
			get { return _Notes; }
			set
			{
				if (Equals(value, _Notes)) return;
				_Notes = value;
				NotifyPropertyChanged();
			}
		}
		private string _Notes;

		public int? ReportsTo
		{ 
			get { return _ReportsTo; }
			set
			{
				if (Equals(value, _ReportsTo)) return;
				_ReportsTo = value;
				NotifyPropertyChanged();
			}
		}
		private int? _ReportsTo;

        [StringLength(255)]
		public string PhotoPath
		{ 
			get { return _PhotoPath; }
			set
			{
				if (Equals(value, _PhotoPath)) return;
				_PhotoPath = value;
				NotifyPropertyChanged();
			}
		}
		private string _PhotoPath;

		public ChangeTrackingCollection<Employee> Employees1
		{
			get { return _Employees1; }
			set
			{
				if (Equals(value, _Employees1)) return;
				_Employees1 = value;
				NotifyPropertyChanged();
			}
		}
		private ChangeTrackingCollection<Employee> _Employees1;


		public Employee Employee1
		{
			get { return _Employee1; }
			set
			{
				if (Equals(value, _Employee1)) return;
				_Employee1 = value;
				Employee1ChangeTracker = _Employee1 == null ? null
					: new ChangeTrackingCollection<Employee> { _Employee1 };
				NotifyPropertyChanged();
			}
		}
		private Employee _Employee1;
		private ChangeTrackingCollection<Employee> Employee1ChangeTracker { get; set; }

		public ChangeTrackingCollection<Order> Orders
		{
			get { return _Orders; }
			set
			{
				if (Equals(value, _Orders)) return;
				_Orders = value;
				NotifyPropertyChanged();
			}
		}
		private ChangeTrackingCollection<Order> _Orders;

		public ChangeTrackingCollection<Territory> Territories
		{
			get { return _Territories; }
			set
			{
				if (value != null) value.Parent = this;
				if (Equals(value, _Territories)) return;
				_Territories = value;
				NotifyPropertyChanged();
			}
		}
		private ChangeTrackingCollection<Territory> _Territories;
    }
}
