namespace DRY.Core.DataModel.DataBaseEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TRechargeHis
    {
        public int Id { get; set; }

        public decimal UserMainId { get; set; }

        public int RechargeType { get; set; }

        public decimal Money { get; set; }

        public decimal RealMoney { get; set; }

        public DateTime? CreateTime { get; set; }
    }
}
