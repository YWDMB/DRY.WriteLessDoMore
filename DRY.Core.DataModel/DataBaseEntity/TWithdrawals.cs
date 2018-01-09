namespace DRY.Core.DataModel.DataBaseEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class TWithdrawals
    {
        public int Id { get; set; }

        public int UserMainId { get; set; }

        public decimal Money { get; set; }

        public decimal RealMoney { get; set; }

        [Required]
        [StringLength(50)]
        public string PayeeRealName { get; set; }

        [Required]
        [StringLength(50)]
        public string PayeeAccount { get; set; }

        public int PayeeAccountType { get; set; }

        [Required]
        [StringLength(50)]
        public string HandleMan { get; set; }

        public int HandleResult { get; set; }

        [Required]
        [StringLength(1000)]
        public string Description { get; set; }

        public DateTime? CreateTime { get; set; }
    }
}
