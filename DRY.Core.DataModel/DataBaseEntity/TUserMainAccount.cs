namespace DRY.Core.DataModel.DataBaseEntity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TUserMainAccount")]
    public partial class TUserMainAccount
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TUserMainAccount()
        {
            TUserRelationAccount = new HashSet<TUserRelationAccount>();
        }

        public int Id { get; set; }

        public int UpperId { get; set; }

        public decimal PrizeDynamic { get; set; }

        public decimal PrizeChuCai { get; set; }

        [Required]
        [StringLength(50)]
        public string Mobile { get; set; }

        [Required]
        [StringLength(50)]
        public string UserPwd { get; set; }

        [StringLength(50)]
        public string NickName { get; set; }

        [StringLength(50)]
        public string RealName { get; set; }

        [StringLength(50)]
        public string BankAccount { get; set; }

        [StringLength(500)]
        public string BankOpening { get; set; }

        [StringLength(500)]
        public string AlipayNumber { get; set; }

        [StringLength(500)]
        public string WechatNumber { get; set; }

        public DateTime? CreateTime { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TUserRelationAccount> TUserRelationAccount { get; set; }
    }
}
