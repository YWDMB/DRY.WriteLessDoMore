namespace DRY.Core.DataModel.DataBaseEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TPrizeChuCaiHis
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int UserMainId { get; set; }

        public int UserRelationId { get; set; }

        public decimal Deltas { get; set; }

        public int OperateType { get; set; }

        public DateTime? CreateTime { get; set; }
    }
}
