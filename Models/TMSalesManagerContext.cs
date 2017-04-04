using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Angular2CoreMVC.Models
{
    public partial class TMSalesManagerContext : DbContext
    {
        public TMSalesManagerContext() { }

        public TMSalesManagerContext(DbContextOptions<TMSalesManagerContext> options) : base(options) { }

        public virtual DbSet<Bill> Bill { get; set; }
        public virtual DbSet<Customers> Customers { get; set; }
        public virtual DbSet<Group> Group { get; set; }
        public virtual DbSet<GroupItem> GroupItem { get; set; }
        public virtual DbSet<Item> Item { get; set; }
        public virtual DbSet<Modules> Modules { get; set; }
        public virtual DbSet<Settings> Settings { get; set; }
        public virtual DbSet<SubBill> SubBill { get; set; }
        public virtual DbSet<SubItem> SubItem { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    #warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        //    optionsBuilder.UseSqlServer(@"Server=.;Database=TMSalesManager;user id=sa;password=tmvnpt;MultipleActiveResultSets=True;App=EntityFramework");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bill>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CodeKey)
                    .HasColumnName("codeKey")
                    .HasMaxLength(128);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasMaxLength(128);

                entity.Property(e => e.CustomerId)
                    .HasColumnName("customerId")
                    .HasMaxLength(128);

                entity.Property(e => e.Desc)
                    .HasColumnName("desc")
                    .HasMaxLength(2000);

                entity.Property(e => e.Extras).HasColumnName("extras");

                entity.Property(e => e.Flag).HasColumnName("flag");

                entity.Property(e => e.Orders).HasColumnName("orders");

                entity.Property(e => e.TotalItem).HasColumnName("totalItem");

                entity.Property(e => e.TotalPrice)
                    .HasColumnName("totalPrice")
                    .HasColumnType("decimal");

                entity.Property(e => e.TotalQuantity).HasColumnName("totalQuantity");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updatedBy")
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<Customers>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address).HasColumnName("address");

                entity.Property(e => e.CardId)
                    .HasColumnName("cardId")
                    .HasMaxLength(128);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasMaxLength(128);

                entity.Property(e => e.DateOfBirth)
                    .HasColumnName("dateOfBirth")
                    .HasMaxLength(50);

                entity.Property(e => e.Desc)
                    .HasColumnName("desc")
                    .HasMaxLength(2000);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(255);

                entity.Property(e => e.Extras).HasColumnName("extras");

                entity.Property(e => e.Facebook)
                    .HasColumnName("facebook")
                    .HasMaxLength(255);

                entity.Property(e => e.Flag).HasColumnName("flag");

                entity.Property(e => e.FullName)
                    .HasColumnName("fullName")
                    .HasMaxLength(150);

                entity.Property(e => e.Images).HasColumnName("images");

                entity.Property(e => e.Mobile)
                    .HasColumnName("mobile")
                    .HasMaxLength(150);

                entity.Property(e => e.Orders).HasColumnName("orders");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updatedBy")
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<Group>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppKey)
                    .HasColumnName("appKey")
                    .HasMaxLength(128);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasMaxLength(128);

                entity.Property(e => e.Desc)
                    .HasColumnName("desc")
                    .HasMaxLength(2000);

                entity.Property(e => e.Extras).HasColumnName("extras");

                entity.Property(e => e.Flag).HasColumnName("flag");

                entity.Property(e => e.IdKey)
                    .HasColumnName("idKey")
                    .HasMaxLength(128);

                entity.Property(e => e.Levels).HasColumnName("levels");

                entity.Property(e => e.Orders).HasColumnName("orders");

                entity.Property(e => e.ParentId).HasColumnName("parentId");

                entity.Property(e => e.ParentsId).HasColumnName("parentsId");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updatedBy")
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<GroupItem>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppKey)
                    .HasColumnName("appKey")
                    .HasMaxLength(128);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasMaxLength(128);

                entity.Property(e => e.EndedAt)
                    .HasColumnName("endedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.Extras).HasColumnName("extras");

                entity.Property(e => e.Flag).HasColumnName("flag");

                entity.Property(e => e.GroupId).HasColumnName("groupId");

                entity.Property(e => e.ItemId).HasColumnName("itemId");

                entity.Property(e => e.Orders).HasColumnName("orders");

                entity.Property(e => e.StartedAt)
                    .HasColumnName("startedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updatedBy")
                    .HasMaxLength(128);

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.GroupItem)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_group_item_group");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.GroupItem)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("FK_group_item_item");
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppKey)
                    .HasColumnName("appKey")
                    .HasMaxLength(255);

                entity.Property(e => e.CodeKey)
                    .HasColumnName("codeKey")
                    .HasMaxLength(255);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasMaxLength(128);

                entity.Property(e => e.Desc)
                    .HasColumnName("desc")
                    .HasMaxLength(2000);

                entity.Property(e => e.EndedAt)
                    .HasColumnName("endedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.Extras).HasColumnName("extras");

                entity.Property(e => e.Flag).HasColumnName("flag");

                entity.Property(e => e.IdKey)
                    .HasColumnName("idKey")
                    .HasMaxLength(255);

                entity.Property(e => e.Image)
                    .HasColumnName("image")
                    .HasColumnType("image");

                entity.Property(e => e.Images).HasColumnName("images");

                entity.Property(e => e.Orders).HasColumnName("orders");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal");

                entity.Property(e => e.PriceOld)
                    .HasColumnName("priceOld")
                    .HasColumnType("decimal");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.QuantityTotal).HasColumnName("quantityTotal");

                entity.Property(e => e.StartedAt)
                    .HasColumnName("startedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updatedBy")
                    .HasMaxLength(128);
            });

            modelBuilder.Entity<Modules>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppKey)
                    .IsRequired()
                    .HasColumnName("appKey")
                    .HasMaxLength(128);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .IsRequired()
                    .HasColumnName("createdBy")
                    .HasMaxLength(128);

                entity.Property(e => e.Extras).HasColumnName("extras");

                entity.Property(e => e.Flag).HasColumnName("flag");

                entity.Property(e => e.MenuId)
                    .IsRequired()
                    .HasColumnName("menuId")
                    .HasMaxLength(50);

                entity.Property(e => e.Orders).HasColumnName("orders");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasColumnName("title")
                    .HasMaxLength(128);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .IsRequired()
                    .HasColumnName("updatedBy")
                    .HasMaxLength(128);

                entity.Property(e => e.Url)
                    .IsRequired()
                    .HasColumnName("url")
                    .HasMaxLength(256);
            });

            modelBuilder.Entity<Settings>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Desc)
                    .HasColumnName("desc")
                    .HasMaxLength(2000);

                entity.Property(e => e.Extras).HasColumnName("extras");

                entity.Property(e => e.Flag).HasColumnName("flag");

                entity.Property(e => e.ModuleKey)
                    .IsRequired()
                    .HasColumnName("moduleKey")
                    .HasMaxLength(255);

                entity.Property(e => e.Orders).HasColumnName("orders");

                entity.Property(e => e.SubKey)
                    .IsRequired()
                    .HasColumnName("subKey")
                    .HasMaxLength(255);

                entity.Property(e => e.SubValue).HasColumnName("subValue");

                entity.Property(e => e.Value).HasColumnName("value");
            });

            modelBuilder.Entity<SubBill>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.CodeKey)
                    .HasColumnName("codeKey")
                    .HasMaxLength(128);

                entity.Property(e => e.Extras).HasColumnName("extras");

                entity.Property(e => e.Flag).HasColumnName("flag");

                entity.Property(e => e.IdKey).HasColumnName("idKey");

                entity.Property(e => e.ItemId).HasColumnName("itemId");

                entity.Property(e => e.Orders).HasColumnName("orders");

                entity.Property(e => e.Price)
                    .HasColumnName("price")
                    .HasColumnType("decimal");

                entity.Property(e => e.PriceOld)
                    .HasColumnName("priceOld")
                    .HasColumnType("decimal");

                entity.Property(e => e.Quantity).HasColumnName("quantity");

                entity.Property(e => e.Title)
                    .HasColumnName("title")
                    .HasMaxLength(255);

                entity.Property(e => e.TotalPrice)
                    .HasColumnName("totalPrice")
                    .HasColumnType("decimal");

                entity.HasOne(d => d.IdKeyNavigation)
                    .WithMany(p => p.SubBill)
                    .HasForeignKey(d => d.IdKey)
                    .HasConstraintName("FK_sub_bill_bill");
            });

            modelBuilder.Entity<SubItem>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppKey)
                    .HasColumnName("appKey")
                    .HasMaxLength(128);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasMaxLength(128);

                entity.Property(e => e.Desc)
                    .HasColumnName("desc")
                    .HasMaxLength(2000);

                entity.Property(e => e.Extras).HasColumnName("extras");

                entity.Property(e => e.Flag).HasColumnName("flag");

                entity.Property(e => e.IdKey).HasColumnName("idKey");

                entity.Property(e => e.Images).HasColumnName("images");

                entity.Property(e => e.ItemId).HasColumnName("itemId");

                entity.Property(e => e.MainKey)
                    .HasColumnName("mainKey")
                    .HasMaxLength(255);

                entity.Property(e => e.Orders).HasColumnName("orders");

                entity.Property(e => e.SubValue)
                    .HasColumnName("subValue")
                    .HasMaxLength(255);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updatedBy")
                    .HasMaxLength(128);

                entity.Property(e => e.Value)
                    .HasColumnName("value")
                    .HasMaxLength(255);

                entity.HasOne(d => d.IdKeyNavigation)
                    .WithMany(p => p.SubItem)
                    .HasForeignKey(d => d.IdKey)
                    .HasConstraintName("FK_sub_item_item");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address).HasColumnName("address");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("createdAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("createdBy")
                    .HasMaxLength(128);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(256);

                entity.Property(e => e.Extras).HasColumnName("extras");

                entity.Property(e => e.Flag).HasColumnName("flag");

                entity.Property(e => e.FullName)
                    .HasColumnName("fullName")
                    .HasMaxLength(256);

                entity.Property(e => e.LastLogin)
                    .HasColumnName("lastLogin")
                    .HasColumnType("datetime");

                entity.Property(e => e.Mobile)
                    .HasColumnName("mobile")
                    .HasMaxLength(128);

                entity.Property(e => e.Orders).HasColumnName("orders");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(256);

                entity.Property(e => e.Roles).HasColumnName("roles");

                entity.Property(e => e.Salt)
                    .HasColumnName("salt")
                    .HasMaxLength(128);

                entity.Property(e => e.StaffId).HasColumnName("staffId");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updatedAt")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("updatedBy")
                    .HasMaxLength(128);

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(128);
            });
        }
    }
}