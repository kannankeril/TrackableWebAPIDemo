namespace TrackableWebApi.Entities.Shared.Net45
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using TrackableEntities.Client;

    public partial class Shipper : EntityBase
    {
        public Shipper()
        {
            Orders = new ChangeTrackingCollection<Order>();
        }

		public int ShipperID
		{ 
			get { return _ShipperID; }
			set
			{
				if (Equals(value, _ShipperID)) return;
				_ShipperID = value;
				NotifyPropertyChanged();
			}
		}
		private int _ShipperID;

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
    }
}
