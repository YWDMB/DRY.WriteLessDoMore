namespace DRY.Core.DataModel.DataBaseEntity
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class YYCFDataModel : DbContext
    {
        public YYCFDataModel()
            : base("name=YYCFDataModel")
        {
        }

        public virtual DbSet<TAdmin> TAdmin { get; set; }
        public virtual DbSet<TCunLiangHis> TCunLiangHis { get; set; }
        public virtual DbSet<TJinLiangHis> TJinLiangHis { get; set; }
        public virtual DbSet<TLineUp> TLineUp { get; set; }
        public virtual DbSet<TOrder> TOrder { get; set; }
        public virtual DbSet<TPrizeChuCaiHis> TPrizeChuCaiHis { get; set; }
        public virtual DbSet<TPrizeDynamicHis> TPrizeDynamicHis { get; set; }
        public virtual DbSet<TRechargeHis> TRechargeHis { get; set; }
        public virtual DbSet<TUserMainAccount> TUserMainAccount { get; set; }
        public virtual DbSet<TUserRelationAccount> TUserRelationAccount { get; set; }
        public virtual DbSet<TWithdrawals> TWithdrawals { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TAdmin>()
                .Property(e => e.Account)
                .IsUnicode(false);

            modelBuilder.Entity<TAdmin>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<TUserMainAccount>()
                .HasMany(e => e.TUserRelationAccount)
                .WithRequired(e => e.TUserMainAccount)
                .HasForeignKey(e => e.UserMainId);

            modelBuilder.Entity<TWithdrawals>()
                .Property(e => e.PayeeRealName)
                .IsUnicode(false);

            modelBuilder.Entity<TWithdrawals>()
                .Property(e => e.PayeeAccount)
                .IsUnicode(false);

            modelBuilder.Entity<TWithdrawals>()
                .Property(e => e.HandleMan)
                .IsUnicode(false);

            modelBuilder.Entity<TWithdrawals>()
                .Property(e => e.Description)
                .IsUnicode(false);
        }
    }
}
