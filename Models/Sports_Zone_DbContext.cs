using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SportsZone_using_CoreWebAPI.Models
{
    public partial class Sports_Zone_DbContext : DbContext
    {
        public Sports_Zone_DbContext()
        {
        }

        public Sports_Zone_DbContext(DbContextOptions<Sports_Zone_DbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountDetails> AccountDetails { get; set; }
        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<Cart> Cart { get; set; }
        public virtual DbSet<Categories> Categories { get; set; }
        public virtual DbSet<CustomerInfo> CustomerInfo { get; set; }
        public virtual DbSet<Feedback> Feedback { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<InvoiceProduct> InvoiceProduct { get; set; }
        public virtual DbSet<Payment> Payment { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<SportsInfo> SportsInfo { get; set; }
        public virtual DbSet<UserAddresses> UserAddresses { get; set; }
        public virtual DbSet<UserMobileNumbers> UserMobileNumbers { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=LAPTOP-KU5V8L68\\MYFIRSTSTEP;database=Sports_Zone_Db;trusted_connection=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccountDetails>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Account_Details");

                entity.HasIndex(e => e.AccEmail)
                    .HasName("UQ__Account___66CB83AC63E6FC49")
                    .IsUnique();

                entity.Property(e => e.AccAddress)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.AccEmail)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.AccName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.AccPassword)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.AccPhone)
                    .IsRequired()
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<Admin>(entity =>
            {
                entity.HasKey(e => e.AdmId)
                    .HasName("PK__Admin__A13DEAEA8B11D368");

                entity.Property(e => e.AdmId).HasMaxLength(10);

                entity.Property(e => e.AdmEmail)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.AdmName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.AdmPassword)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Cart>(entity =>
            {
                entity.HasKey(e => e.CarId)
                    .HasName("PK__Cart__68A0342E8F57A946");

                entity.Property(e => e.CarId).HasMaxLength(10);

                entity.Property(e => e.CusId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ProId).HasMaxLength(10);

                entity.Property(e => e.Quantity)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.HasOne(d => d.Cus)
                    .WithMany(p => p.Cart)
                    .HasForeignKey(d => d.CusId)
                    .HasConstraintName("FK__Cart__CusId__5629CD9C");

                entity.HasOne(d => d.Pro)
                    .WithMany(p => p.Cart)
                    .HasForeignKey(d => d.ProId)
                    .HasConstraintName("FK__Cart__ProId__571DF1D5");
            });

            modelBuilder.Entity<Categories>(entity =>
            {
                entity.HasKey(e => e.CatId)
                    .HasName("PK__Categori__6A1C8AFA0E2A44C5");

                entity.Property(e => e.CatId).HasMaxLength(10);

                entity.Property(e => e.CatDescription)
                    .IsRequired()
                    .HasColumnName("catDescription")
                    .HasMaxLength(200);

                entity.Property(e => e.CatName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProId).HasMaxLength(10);

                entity.HasOne(d => d.Pro)
                    .WithMany(p => p.Categories)
                    .HasForeignKey(d => d.ProId)
                    .HasConstraintName("FK__Categorie__ProId__286302EC");
            });

            modelBuilder.Entity<CustomerInfo>(entity =>
            {
                entity.HasKey(e => e.CusId)
                    .HasName("PK__Customer__2F187110BA668F2C");

                entity.ToTable("Customer_info");

                entity.Property(e => e.CusId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Address)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasColumnName("First_Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasColumnName("Last_Name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Cus)
                    .WithOne(p => p.CustomerInfo)
                    .HasForeignKey<CustomerInfo>(d => d.CusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Customer___CusId__3F466844");
            });

            modelBuilder.Entity<Feedback>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Comment).HasMaxLength(300);

                entity.Property(e => e.CusId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.ProId).HasMaxLength(10);

                entity.HasOne(d => d.Cus)
                    .WithMany()
                    .HasForeignKey(d => d.CusId)
                    .HasConstraintName("FK__Feedback__CusId__47DBAE45");

                entity.HasOne(d => d.Pro)
                    .WithMany()
                    .HasForeignKey(d => d.ProId)
                    .HasConstraintName("FK__Feedback__ProId__48CFD27E");
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.HasKey(e => e.InvId)
                    .HasName("PK__Invoice__9DC82C6A614A21BE");

                entity.Property(e => e.InvId).HasMaxLength(10);

                entity.Property(e => e.CusId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.HasOne(d => d.Cus)
                    .WithMany(p => p.Invoice)
                    .HasForeignKey(d => d.CusId)
                    .HasConstraintName("FK__Invoice__CusId__4222D4EF");
            });

            modelBuilder.Entity<InvoiceProduct>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Invoice_Product");

                entity.Property(e => e.InvId).HasMaxLength(10);

                entity.Property(e => e.ProId).HasMaxLength(10);

                entity.HasOne(d => d.Inv)
                    .WithMany()
                    .HasForeignKey(d => d.InvId)
                    .HasConstraintName("FK__Invoice_P__Quant__44FF419A");

                entity.HasOne(d => d.Pro)
                    .WithMany()
                    .HasForeignKey(d => d.ProId)
                    .HasConstraintName("FK__Invoice_P__ProId__45F365D3");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.Property(e => e.PaymentId)
                    .HasColumnName("Payment_Id")
                    .HasMaxLength(10);

                entity.Property(e => e.Amount).HasColumnType("money");

                entity.Property(e => e.CusId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentDate)
                    .HasColumnName("Payment_Date")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Cus)
                    .WithMany(p => p.Payment)
                    .HasForeignKey(d => d.CusId)
                    .HasConstraintName("FK__Payment__CusId__4E88ABD4");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.ProId)
                    .HasName("PK__Product__6202959027E53C62");

                entity.Property(e => e.ProId).HasMaxLength(10);

                entity.Property(e => e.ProDescription).HasMaxLength(200);

                entity.Property(e => e.ProName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ProPrice).HasColumnType("money");
            });

            modelBuilder.Entity<SportsInfo>(entity =>
            {
                entity.HasKey(e => e.SpoId)
                    .HasName("PK__Sports_I__D86D969D52B61CB1");

                entity.ToTable("Sports_Info");

                entity.Property(e => e.SpoId).HasMaxLength(10);

                entity.Property(e => e.SpoCategory)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SpoDescription)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.SpoGears)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SpoName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<UserAddresses>(entity =>
            {
                entity.HasKey(e => new { e.Username, e.Address })
                    .HasName("PK__User_Add__B48A0D9642FB0B6F");

                entity.ToTable("User_Addresses");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.UserAddresses)
                    .HasForeignKey(d => d.Username)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__User_Addr__usern__59FA5E80");
            });

            modelBuilder.Entity<UserMobileNumbers>(entity =>
            {
                entity.HasKey(e => new { e.Username, e.MobileNumber })
                    .HasName("PK__User_mob__00DFA7C3EDA42202");

                entity.ToTable("User_mobile_numbers");

                entity.Property(e => e.Username)
                    .HasColumnName("username")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNumber)
                    .HasColumnName("mobile_number")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.UsernameNavigation)
                    .WithMany(p => p.UserMobileNumbers)
                    .HasForeignKey(d => d.Username)
                    .HasConstraintName("FK__User_mobi__usern__5DCAEF64");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__Users__CB9A1CFF32A54F47");

                entity.Property(e => e.UserId)
                    .HasColumnName("userId")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasColumnName("first_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasColumnName("last_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
