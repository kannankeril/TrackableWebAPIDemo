namespace TrackableWebApi.Entities.Shared.Net45
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using TrackableEntities.Client;

    public partial class Order : EntityBase
    {
        public Order()
        {
            OrderDetails = new ChangeTrackingCollection<OrderDetail>();
        }

		public int OrderID
		{ 
			get { return _OrderID; }
			set
			{
				if (Equals(value, _OrderID)) return;
				_OrderID = value;
				NotifyPropertyChanged();
			}
		}
		private int _OrderID;

        [StringLength(5)]
		public string CustomerID
		{ 
			get { return _CustomerID; }
			set
			{
				if (Equals(value, _CustomerID)) return;
				_CustomerID = value;
				NotifyPropertyChanged();
			}
		}
		private string _CustomerID;

		public int? EmployeeID
		{ 
			get { return _EmployeeID; }
			set
			{
				if (Equals(value, _EmployeeID)) return;
				_EmployeeID = value;
				NotifyPropertyChanged();
			}
		}
		private int? _EmployeeID;

		public DateTime? OrderDate
		{ 
			get { return _OrderDate; }
			set
			{
				if (Equals(value, _OrderDate)) return;
				_OrderDate = value;
				NotifyPropertyChanged();
			}
		}
		private DateTime? _OrderDate;

		public DateTime? RequiredDate
		{ 
			get { return _RequiredDate; }
			set
			{
				if (Equals(value, _RequiredDate)) return;
				_RequiredDate = value;
				NotifyPropertyChanged();
			}
		}
		private DateTime? _RequiredDate;

		public DateTime? ShippedDate
		{ 
			get { return _ShippedDate; }
			set
			{
				if (Equals(value, _ShippedDate)) return;
				_ShippedDate = value;
				NotifyPropertyChanged();
			}
		}
		private DateTime? _ShippedDate;

		public int? ShipVia
		{ 
			get { return _ShipVia; }
			set
			{
				if (Equals(value, _ShipVia)) return;
				_ShipVia = value;
				NotifyPropertyChanged();
			}
		}
		private int? _ShipVia;

        [Column(TypeName = "money")]
		public decimal? Freight
		{ 
			get { return _Freight; }
			set
			{
				if (Equals(value, _Freight)) return;
				_Freight = value;
				NotifyPropertyChanged();
			}
		}
		private decimal? _Freight;

        [StringLength(40)]
		public string ShipName
		{ 
			get { return _ShipName; }
			set
			{
				if (Equals(value, _ShipName)) return;
				_ShipName = value;
				NotifyPropertyChanged();
			}
		}
		private string _ShipName;

        [StringLength(60)]
		public string ShipAddress
		{ 
			get { return _ShipAddress; }
			set
			{
				if (Equals(value, _ShipAddress)) return;
				_ShipAddress = value;
				NotifyPropertyChanged();
			}
		}
		private string _ShipAddress;

        [StringLength(15)]
		public string ShipCity
		{ 
			get { return _ShipCity; }
			set
			{
				if (Equals(value, _ShipCity)) return;
				_ShipCity = value;
				NotifyPropertyChanged();
			}
		}
		private string _ShipCity;

        [StringLength(15)]
		public string ShipRegion
		{ 
			get { return _ShipRegion; }
			set
			{
				if (Equals(value, _ShipRegion)) return;
				_ShipRegion = value;
				NotifyPropertyChanged();
			}
		}
		private string _ShipRegion;

        [StringLength(10)]
		public string ShipPostalCode
		{ 
			get { return _ShipPostalCode; }
			set
			{
				if (Equals(value, _ShipPostalCode)) return;
				_ShipPostalCode = value;
				NotifyPropertyChanged();
			}
		}
		private string _ShipPostalCode;

        [StringLength(15)]
		public string ShipCountry
		{ 
			get { return _ShipCountry; }
			set
			{
				if (Equals(value, _ShipCountry)) return;
				_ShipCountry = value;
				NotifyPropertyChanged();
			}
		}
		private string _ShipCountry;


		public Customer Customer
		{
			get { return _Customer; }
			set
			{
				if (Equals(value, _Customer)) return;
				_Customer = value;
				CustomerChangeTracker = _Customer == null ? null
					: new ChangeTrackingCollection<Customer> { _Customer };
				NotifyPropertyChanged();
			}
		}
		private Customer _Customer;
		private ChangeTrackingCollection<Customer> CustomerChangeTracker { get; set; }


		public Employee Employee
		{
			get { return _Employee; }
			set
			{
				if (Equals(value, _Employee)) return;
				_Employee = value;
				EmployeeChangeTracker = _Employee == null ? null
					: new ChangeTrackingCollection<Employee> { _Employee };
				NotifyPropertyChanged();
			}
		}
		private Employee _Employee;
		private ChangeTrackingCollection<Employee> EmployeeChangeTracker { get; set; }

		public ChangeTrackingCollection<OrderDetail> OrderDetails
		{
			get { return _OrderDetails; }
			set
			{
				if (Equals(value, _OrderDetails)) return;
				_OrderDetails = value;
				NotifyPropertyChanged();
			}
		}
		private ChangeTrackingCollection<OrderDetail> _OrderDetails;


		public Shipper Shipper
		{
			get { return _Shipper; }
			set
			{
				if (Equals(value, _Shipper)) return;
				_Shipper = value;
				ShipperChangeTracker = _Shipper == null ? null
					: new ChangeTrackingCollection<Shipper> { _Shipper };
				NotifyPropertyChanged();
			}
		}
		private Shipper _Shipper;
		private ChangeTrackingCollection<Shipper> ShipperChangeTracker { get; set; }
    }
}
