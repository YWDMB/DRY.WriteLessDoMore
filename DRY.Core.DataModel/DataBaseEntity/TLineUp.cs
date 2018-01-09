namespace DRY.Core.DataModel.DataBaseEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TLineUp")]
    public partial class TLineUp
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int SerialNum { get; set; }

        public int UserMainId { get; set; }

        public int UserRelationId { get; set; }

        public DateTime? CreateTime { get; set; }
    }
}
