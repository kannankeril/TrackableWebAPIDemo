namespace TrackableWebApi.Entities.Shared.Net45
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using TrackableEntities.Client;

    [Table("Order Details")]
    public partial class OrderDetail : EntityBase
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
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

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
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

        [Column(TypeName = "money")]
		public decimal UnitPrice
		{ 
			get { return _UnitPrice; }
			set
			{
				if (Equals(value, _UnitPrice)) return;
				_UnitPrice = value;
				NotifyPropertyChanged();
			}
		}
		private decimal _UnitPrice;

		public short Quantity
		{ 
			get { return _Quantity; }
			set
			{
				if (Equals(value, _Quantity)) return;
				_Quantity = value;
				NotifyPropertyChanged();
			}
		}
		private short _Quantity;

		public float Discount
		{ 
			get { return _Discount; }
			set
			{
				if (Equals(value, _Discount)) return;
				_Discount = value;
				NotifyPropertyChanged();
			}
		}
		private float _Discount;


		public Order Order
		{
			get { return _Order; }
			set
			{
				if (Equals(value, _Order)) return;
				_Order = value;
				OrderChangeTracker = _Order == null ? null
					: new ChangeTrackingCollection<Order> { _Order };
				NotifyPropertyChanged();
			}
		}
		private Order _Order;
		private ChangeTrackingCollection<Order> OrderChangeTracker { get; set; }


		public Product Product
		{
			get { return _Product; }
			set
			{
				if (Equals(value, _Product)) return;
				_Product = value;
				ProductChangeTracker = _Product == null ? null
					: new ChangeTrackingCollection<Product> { _Product };
				NotifyPropertyChanged();
			}
		}
		private Product _Product;
		private ChangeTrackingCollection<Product> ProductChangeTracker { get; set; }
    }
}
