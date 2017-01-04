namespace TrackableWebApi.Entities.Shared.Net45
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using TrackableEntities.Client;

    public partial class Product : EntityBase
    {
        public Product()
        {
            OrderDetails = new ChangeTrackingCollection<OrderDetail>();
        }

		public int ProductID
		{ 
			get { return _ProductID; }
			set
			{
				if (Equals(value, _ProductID)) return;
				_ProductID = value;
				NotifyPropertyChanged();
			}
		}
		private int _ProductID;

        [Required]
        [StringLength(40)]
		public string ProductName
		{ 
			get { return _ProductName; }
			set
			{
				if (Equals(value, _ProductName)) return;
				_ProductName = value;
				NotifyPropertyChanged();
			}
		}
		private string _ProductName;

		public int? SupplierID
		{ 
			get { return _SupplierID; }
			set
			{
				if (Equals(value, _SupplierID)) return;
				_SupplierID = value;
				NotifyPropertyChanged();
			}
		}
		private int? _SupplierID;

		public int? CategoryID
		{ 
			get { return _CategoryID; }
			set
			{
				if (Equals(value, _CategoryID)) return;
				_CategoryID = value;
				NotifyPropertyChanged();
			}
		}
		private int? _CategoryID;

        [StringLength(20)]
		public string QuantityPerUnit
		{ 
			get { return _QuantityPerUnit; }
			set
			{
				if (Equals(value, _QuantityPerUnit)) return;
				_QuantityPerUnit = value;
				NotifyPropertyChanged();
			}
		}
		private string _QuantityPerUnit;

        [Column(TypeName = "money")]
		public decimal? UnitPrice
		{ 
			get { return _UnitPrice; }
			set
			{
				if (Equals(value, _UnitPrice)) return;
				_UnitPrice = value;
				NotifyPropertyChanged();
			}
		}
		private decimal? _UnitPrice;

		public short? UnitsInStock
		{ 
			get { return _UnitsInStock; }
			set
			{
				if (Equals(value, _UnitsInStock)) return;
				_UnitsInStock = value;
				NotifyPropertyChanged();
			}
		}
		private short? _UnitsInStock;

		public short? UnitsOnOrder
		{ 
			get { return _UnitsOnOrder; }
			set
			{
				if (Equals(value, _UnitsOnOrder)) return;
				_UnitsOnOrder = value;
				NotifyPropertyChanged();
			}
		}
		private short? _UnitsOnOrder;

		public short? ReorderLevel
		{ 
			get { return _ReorderLevel; }
			set
			{
				if (Equals(value, _ReorderLevel)) return;
				_ReorderLevel = value;
				NotifyPropertyChanged();
			}
		}
		private short? _ReorderLevel;

		public bool Discontinued
		{ 
			get { return _Discontinued; }
			set
			{
				if (Equals(value, _Discontinued)) return;
				_Discontinued = value;
				NotifyPropertyChanged();
			}
		}
		private bool _Discontinued;


		public Category Category
		{
			get { return _Category; }
			set
			{
				if (Equals(value, _Category)) return;
				_Category = value;
				CategoryChangeTracker = _Category == null ? null
					: new ChangeTrackingCollection<Category> { _Category };
				NotifyPropertyChanged();
			}
		}
		private Category _Category;
		private ChangeTrackingCollection<Category> CategoryChangeTracker { get; set; }

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


		public Supplier Supplier
		{
			get { return _Supplier; }
			set
			{
				if (Equals(value, _Supplier)) return;
				_Supplier = value;
				SupplierChangeTracker = _Supplier == null ? null
					: new ChangeTrackingCollection<Supplier> { _Supplier };
				NotifyPropertyChanged();
			}
		}
		private Supplier _Supplier;
		private ChangeTrackingCollection<Supplier> SupplierChangeTracker { get; set; }
    }
}
