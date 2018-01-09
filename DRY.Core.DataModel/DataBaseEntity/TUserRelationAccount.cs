namespace DRY.Core.DataModel.DataBaseEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TUserRelationAccount")]
    public partial class TUserRelationAccount
    {
        public int Id { get; set; }

        public int UserMainId { get; set; }

        public int TypeAccount { get; set; }

        public decimal CunLiang { get; set; }

        public decimal JinLiang { get; set; }

        public decimal DongScore { get; set; }

        public decimal HuoScore { get; set; }

        public DateTime? CreateTime { get; set; }

        public virtual TUserMainAccount TUserMainAccount { get; set; }
    }
}
