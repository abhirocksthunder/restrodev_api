using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace RestroDevAPI.Models;

public partial class RestroDevContext : DbContext
{
    public RestroDevContext()
    {
    }

    public RestroDevContext(DbContextOptions<RestroDevContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BranchesInfo> BranchesInfos { get; set; }

    public virtual DbSet<CabinInfo> CabinInfos { get; set; }

    public virtual DbSet<CabinType> CabinTypes { get; set; }

    public virtual DbSet<City> Cities { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<CusineTypeInfo> CusineTypeInfos { get; set; }

    public virtual DbSet<District> Districts { get; set; }

    public virtual DbSet<FloorsInfo> FloorsInfos { get; set; }

    public virtual DbSet<HotelRegistration> HotelRegistrations { get; set; }

    public virtual DbSet<MainMenu> MainMenus { get; set; }

    public virtual DbSet<MenuCategory> MenuCategories { get; set; }

    public virtual DbSet<OrderInfo> OrderInfos { get; set; }

    public virtual DbSet<OrderItem> OrderItems { get; set; }

    public virtual DbSet<StaffInfo> StaffInfos { get; set; }

    public virtual DbSet<StaffType> StaffTypes { get; set; }

    public virtual DbSet<State> States { get; set; }

    public virtual DbSet<SubMenu> SubMenus { get; set; }

    public virtual DbSet<TableInfo> TableInfos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BranchesInfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Branches__3214EC07FD54D2FB");

            entity.ToTable("BranchesInfo");

            entity.Property(e => e.BranchAddress)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.BranchName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.BranchNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.HotelCode)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.HasOne(d => d.Hotel).WithMany(p => p.BranchesInfos)
                .HasForeignKey(d => d.HotelId)
                .HasConstraintName("FK_BranchesInfo_HotelRegistration");
        });

        modelBuilder.Entity<CabinInfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CabinInf__3214EC07A9EFC659");

            entity.ToTable("CabinInfo");

            entity.Property(e => e.CabinName)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.HasOne(d => d.Branch).WithMany(p => p.CabinInfos)
                .HasForeignKey(d => d.BranchId)
                .HasConstraintName("FK_CabinInfo_BranchesInfo");

            entity.HasOne(d => d.CabinTypeNavigation).WithMany(p => p.CabinInfos)
                .HasForeignKey(d => d.CabinType)
                .HasConstraintName("FK_CabinInfo_CabinType");

            entity.HasOne(d => d.Floor).WithMany(p => p.CabinInfos)
                .HasForeignKey(d => d.FloorId)
                .HasConstraintName("FK_CabinInfo_FloorsInfo");
        });

        modelBuilder.Entity<CabinType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CabinTyp__3214EC07E611D442");

            entity.ToTable("CabinType");

            entity.Property(e => e.CabinDescription)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<City>(entity =>
        {
            entity.HasKey(e => e.CityId).HasName("PK__City__F2D21B76EE9CA4AF");

            entity.ToTable("City");

            entity.Property(e => e.City1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("City");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasKey(e => e.CountryId).HasName("PK__Country__10D1609F3E073FFE");

            entity.ToTable("Country");

            entity.Property(e => e.CountryName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<CusineTypeInfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__CusineTy__3214EC076E985E08");

            entity.ToTable("CusineTypeInfo");

            entity.Property(e => e.CusineType)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<District>(entity =>
        {
            entity.HasKey(e => e.DistrictId).HasName("PK__District__85FDA4C6DCECF451");

            entity.ToTable("District");

            entity.Property(e => e.District1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("District");
        });

        modelBuilder.Entity<FloorsInfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__FloorsIn__3214EC0773CFAF76");

            entity.ToTable("FloorsInfo");

            entity.Property(e => e.FloorName)
                .HasMaxLength(30)
                .IsUnicode(false);

            entity.HasOne(d => d.Branch).WithMany(p => p.FloorsInfos)
                .HasForeignKey(d => d.BranchId)
                .HasConstraintName("FK_FloorsInfo_BranchesInfo");
        });

        modelBuilder.Entity<HotelRegistration>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__HotelReg__3214EC070EA330E9");

            entity.ToTable("HotelRegistration");

            entity.Property(e => e.Address)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Gstin)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("GSTIN");
            entity.Property(e => e.HotelCode)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.HotelName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Panno)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("PANNo");
            entity.Property(e => e.Pincode)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.PrimaryContactName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PrimaryContactNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SecondaryContactName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.SecondaryContactNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.SuperAdminPassword)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SuperAdminUserName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Timestamp).HasColumnType("datetime");

            entity.HasOne(d => d.CityNavigation).WithMany(p => p.HotelRegistrations)
                .HasForeignKey(d => d.City)
                .HasConstraintName("FK_HotelRegistration_City");

            entity.HasOne(d => d.CountryNavigation).WithMany(p => p.HotelRegistrations)
                .HasForeignKey(d => d.Country)
                .HasConstraintName("FK_HotelRegistration_Country");

            entity.HasOne(d => d.CusineTypeNavigation).WithMany(p => p.HotelRegistrations)
                .HasForeignKey(d => d.CusineType)
                .HasConstraintName("FK_HotelRegistration_CusineTypeInfo");

            entity.HasOne(d => d.DistrictNavigation).WithMany(p => p.HotelRegistrations)
                .HasForeignKey(d => d.District)
                .HasConstraintName("FK_HotelRegistration_District");

            entity.HasOne(d => d.StateNavigation).WithMany(p => p.HotelRegistrations)
                .HasForeignKey(d => d.State)
                .HasConstraintName("FK_HotelRegistration_State");
        });

        modelBuilder.Entity<MainMenu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MainMenu__3214EC07826B5D96");

            entity.ToTable("MainMenu");

            entity.Property(e => e.MenuName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.MenuCategory).WithMany(p => p.MainMenus)
                .HasForeignKey(d => d.MenuCategoryId)
                .HasConstraintName("FK_MainMenu_MenuCategory");
        });

        modelBuilder.Entity<MenuCategory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__MenuCate__3214EC07D8AD38DA");

            entity.ToTable("MenuCategory");

            entity.Property(e => e.CategoryName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Branch).WithMany(p => p.MenuCategories)
                .HasForeignKey(d => d.BranchId)
                .HasConstraintName("FK_MenuCategory_BranchesInfo");

            entity.HasOne(d => d.Hotel).WithMany(p => p.MenuCategories)
                .HasForeignKey(d => d.HotelId)
                .HasConstraintName("FK_MenuCategory_HotelRegistration");
        });

        modelBuilder.Entity<OrderInfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OrderInf__3214EC07E7FD924F");

            entity.ToTable("OrderInfo");

            entity.Property(e => e.OrderNo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TotalPrice)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Branch).WithMany(p => p.OrderInfos)
                .HasForeignKey(d => d.BranchId)
                .HasConstraintName("FK_OrderInfo_BranchesInfo");

            entity.HasOne(d => d.Hotel).WithMany(p => p.OrderInfos)
                .HasForeignKey(d => d.HotelId)
                .HasConstraintName("FK_OrderInfo_HotelRegistration");

            entity.HasOne(d => d.Table).WithMany(p => p.OrderInfos)
                .HasForeignKey(d => d.TableId)
                .HasConstraintName("FK_OrderInfo_TableInfo");
        });

        modelBuilder.Entity<OrderItem>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OrderIte__3214EC078EA6F922");

            entity.Property(e => e.Item)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.Order).WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.OrderId)
                .HasConstraintName("FK_OrderItems_OrderInfo");
        });

        modelBuilder.Entity<StaffInfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__StaffInf__3214EC07AC3ED542");

            entity.ToTable("StaffInfo");

            entity.Property(e => e.ContactName)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ContactNo)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Timestamp).HasColumnType("datetime");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);

            entity.HasOne(d => d.StaffTypeNavigation).WithMany(p => p.StaffInfos)
                .HasForeignKey(d => d.StaffType)
                .HasConstraintName("FK_StaffInfo_StaffType");
        });

        modelBuilder.Entity<StaffType>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__StaffTyp__3214EC07EB736611");

            entity.ToTable("StaffType");

            entity.Property(e => e.StaffType1)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("StaffType");
        });

        modelBuilder.Entity<State>(entity =>
        {
            entity.HasKey(e => e.StateId).HasName("PK__State__C3BA3B3A74D5B5A9");

            entity.ToTable("State");

            entity.Property(e => e.State1)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("State");
        });

        modelBuilder.Entity<SubMenu>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__SubMenu__3214EC07C189B2FC");

            entity.ToTable("SubMenu");

            entity.Property(e => e.Description)
                .HasMaxLength(200)
                .IsUnicode(false);
            entity.Property(e => e.MenuName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Price)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.MainMenu).WithMany(p => p.SubMenus)
                .HasForeignKey(d => d.MainMenuId)
                .HasConstraintName("FK_SubMenu_MainMenu");
        });

        modelBuilder.Entity<TableInfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__TableInf__3214EC07DEA63C0B");

            entity.ToTable("TableInfo");

            entity.HasOne(d => d.Branch).WithMany(p => p.TableInfos)
                .HasForeignKey(d => d.BranchId)
                .HasConstraintName("FK_TableInfo_BranchesInfo");

            entity.HasOne(d => d.Cabin).WithMany(p => p.TableInfos)
                .HasForeignKey(d => d.CabinId)
                .HasConstraintName("FK_TableInfo_CabinInfo");

            entity.HasOne(d => d.Floor).WithMany(p => p.TableInfos)
                .HasForeignKey(d => d.FloorId)
                .HasConstraintName("FK_TableInfo_FloorsInfo");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
