namespace DRY.Core.DataModel.DataBaseEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TOrder")]
    public partial class TOrder
    {
        public int Id { get; set; }

        public int OrderNum { get; set; }

        public decimal RealMoney { get; set; }

        public decimal Money { get; set; }

        public int UserMainId { get; set; }

        public DateTime? CreateTime { get; set; }
    }
}
