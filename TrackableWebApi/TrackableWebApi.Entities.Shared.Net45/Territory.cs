namespace TrackableWebApi.Entities.Shared.Net45
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using TrackableEntities.Client;

    public partial class Territory : EntityBase
    {
        public Territory()
        {
            Employees = new ChangeTrackingCollection<Employee>();
        }

        [StringLength(20)]
		public string TerritoryID
		{ 
			get { return _TerritoryID; }
			set
			{
				if (Equals(value, _TerritoryID)) return;
				_TerritoryID = value;
				NotifyPropertyChanged();
			}
		}
		private string _TerritoryID;

        [Required]
        [StringLength(50)]
		public string TerritoryDescription
		{ 
			get { return _TerritoryDescription; }
			set
			{
				if (Equals(value, _TerritoryDescription)) return;
				_TerritoryDescription = value;
				NotifyPropertyChanged();
			}
		}
		private string _TerritoryDescription;

		public int RegionID
		{ 
			get { return _RegionID; }
			set
			{
				if (Equals(value, _RegionID)) return;
				_RegionID = value;
				NotifyPropertyChanged();
			}
		}
		private int _RegionID;


		public Region Region
		{
			get { return _Region; }
			set
			{
				if (Equals(value, _Region)) return;
				_Region = value;
				RegionChangeTracker = _Region == null ? null
					: new ChangeTrackingCollection<Region> { _Region };
				NotifyPropertyChanged();
			}
		}
		private Region _Region;
		private ChangeTrackingCollection<Region> RegionChangeTracker { get; set; }

		public ChangeTrackingCollection<Employee> Employees
		{
			get { return _Employees; }
			set
			{
				if (value != null) value.Parent = this;
				if (Equals(value, _Employees)) return;
				_Employees = value;
				NotifyPropertyChanged();
			}
		}
		private ChangeTrackingCollection<Employee> _Employees;
    }
}
