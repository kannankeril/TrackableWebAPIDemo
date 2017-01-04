namespace TrackableWebApi.Entities.Shared.Net45
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using TrackableEntities.Client;

    [Table("Region")]
    public partial class Region : EntityBase
    {
        public Region()
        {
            Territories = new ChangeTrackingCollection<Territory>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
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

        [Required]
        [StringLength(50)]
		public string RegionDescription
		{ 
			get { return _RegionDescription; }
			set
			{
				if (Equals(value, _RegionDescription)) return;
				_RegionDescription = value;
				NotifyPropertyChanged();
			}
		}
		private string _RegionDescription;

		public ChangeTrackingCollection<Territory> Territories
		{
			get { return _Territories; }
			set
			{
				if (Equals(value, _Territories)) return;
				_Territories = value;
				NotifyPropertyChanged();
			}
		}
		private ChangeTrackingCollection<Territory> _Territories;
    }
}
