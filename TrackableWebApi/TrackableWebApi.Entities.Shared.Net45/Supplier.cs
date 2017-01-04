namespace TrackableWebApi.Entities.Shared.Net45
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using TrackableEntities.Client;

    public partial class Supplier : EntityBase
    {
        public Supplier()
        {
            Products = new ChangeTrackingCollection<Product>();
        }

		public int SupplierID
		{ 
			get { return _SupplierID; }
			set
			{
				if (Equals(value, _SupplierID)) return;
				_SupplierID = value;
				NotifyPropertyChanged();
			}
		}
		private int _SupplierID;

        [Required]
        [StringLength(40)]
		public string CompanyName
		{ 
			get { return _CompanyName; }
			set
			{
				if (Equals(value, _CompanyName)) return;
				_CompanyName = value;
				NotifyPropertyChanged();
			}
		}
		private string _CompanyName;

        [StringLength(30)]
		public string ContactName
		{ 
			get { return _ContactName; }
			set
			{
				if (Equals(value, _ContactName)) return;
				_ContactName = value;
				NotifyPropertyChanged();
			}
		}
		private string _ContactName;

        [StringLength(30)]
		public string ContactTitle
		{ 
			get { return _ContactTitle; }
			set
			{
				if (Equals(value, _ContactTitle)) return;
				_ContactTitle = value;
				NotifyPropertyChanged();
			}
		}
		private string _ContactTitle;

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
		public string Phone
		{ 
			get { return _Phone; }
			set
			{
				if (Equals(value, _Phone)) return;
				_Phone = value;
				NotifyPropertyChanged();
			}
		}
		private string _Phone;

        [StringLength(24)]
		public string Fax
		{ 
			get { return _Fax; }
			set
			{
				if (Equals(value, _Fax)) return;
				_Fax = value;
				NotifyPropertyChanged();
			}
		}
		private string _Fax;

        [Column(TypeName = "ntext")]
		public string HomePage
		{ 
			get { return _HomePage; }
			set
			{
				if (Equals(value, _HomePage)) return;
				_HomePage = value;
				NotifyPropertyChanged();
			}
		}
		private string _HomePage;

		public ChangeTrackingCollection<Product> Products
		{
			get { return _Products; }
			set
			{
				if (Equals(value, _Products)) return;
				_Products = value;
				NotifyPropertyChanged();
			}
		}
		private ChangeTrackingCollection<Product> _Products;
    }
}
