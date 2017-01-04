namespace TrackableWebApi.Entities.Shared.Net45
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using TrackableEntities.Client;

    public partial class Category : EntityBase
    {
        public Category()
        {
            Products = new ChangeTrackingCollection<Product>();
        }

		public int CategoryID
		{ 
			get { return _CategoryID; }
			set
			{
				if (Equals(value, _CategoryID)) return;
				_CategoryID = value;
				NotifyPropertyChanged();
			}
		}
		private int _CategoryID;

        [Required]
        [StringLength(15)]
		public string CategoryName
		{ 
			get { return _CategoryName; }
			set
			{
				if (Equals(value, _CategoryName)) return;
				_CategoryName = value;
				NotifyPropertyChanged();
			}
		}
		private string _CategoryName;

        [Column(TypeName = "ntext")]
		public string Description
		{ 
			get { return _Description; }
			set
			{
				if (Equals(value, _Description)) return;
				_Description = value;
				NotifyPropertyChanged();
			}
		}
		private string _Description;

        [Column(TypeName = "image")]
		public byte[] Picture
		{ 
			get { return _Picture; }
			set
			{
				if (Equals(value, _Picture)) return;
				_Picture = value;
				NotifyPropertyChanged();
			}
		}
		private byte[] _Picture;

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
