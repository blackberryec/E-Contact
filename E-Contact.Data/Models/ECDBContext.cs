using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Configuration;

namespace E_Contact.Data.Models
{
    public partial class ECDBContext : DbContext
    {
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<CategoryInfo> CategoryInfo { get; set; }
        public virtual DbSet<CategoryOption> CategoryOption { get; set; }
        public virtual DbSet<CategoryOptionDatasource> CategoryOptionDatasource { get; set; }
        public virtual DbSet<CategoryStore> CategoryStore { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Condition> Condition { get; set; }
        public virtual DbSet<District> District { get; set; }
        public virtual DbSet<Family> Family { get; set; }
        public virtual DbSet<FamilyInfo> FamilyInfo { get; set; }
        public virtual DbSet<GroupHelp> GroupHelp { get; set; }
        public virtual DbSet<Helper> Helper { get; set; }
        public virtual DbSet<Language> Language { get; set; }
        public virtual DbSet<PostedOption> PostedOption { get; set; }
        public virtual DbSet<PostedOptionDatasource> PostedOptionDatasource { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        public virtual DbSet<ProductImage> ProductImage { get; set; }
        public virtual DbSet<ProductInfo> ProductInfo { get; set; }
        public virtual DbSet<ProductOption> ProductOption { get; set; }
        public virtual DbSet<Store> Store { get; set; }
        public virtual DbSet<StoreInfo> StoreInfo { get; set; }
        public virtual DbSet<UserCategory> UserCategory { get; set; }
        public virtual DbSet<UserInfo> UserInfo { get; set; }
        public virtual DbSet<UserProfile> UserProfile { get; set; }
        public virtual DbSet<WebDefault> WebDefault { get; set; }
        public virtual DbSet<WebpagesMembership> WebpagesMembership { get; set; }
        public virtual DbSet<WebpagesOauthMembership> WebpagesOauthMembership { get; set; }
        public virtual DbSet<WebpagesRoles> WebpagesRoles { get; set; }
        public virtual DbSet<WebpagesUsersInRoles> WebpagesUsersInRoles { get; set; }

        // Unable to generate entity type for table 'dbo.ConditionOption'. Please see the warning messages.

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["ECDB"].ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.FamilyId).HasColumnName("FamilyID");

                entity.Property(e => e.ImagePath).HasColumnType("varchar(200)");

                entity.Property(e => e.Sequence).HasDefaultValueSql("0");

                entity.Property(e => e.State).HasDefaultValueSql("0");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Family)
                    .WithMany(p => p.Category)
                    .HasForeignKey(d => d.FamilyId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Category_Family");
            });

            modelBuilder.Entity<CategoryInfo>(entity =>
            {
                entity.HasKey(e => new { e.CategoryInfoId, e.CategoryId, e.Uiculture })
                    .HasName("PK_CategoryInfo");

                entity.Property(e => e.CategoryInfoId)
                    .HasColumnName("CategoryInfoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Uiculture)
                    .HasColumnName("UICulture")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.CategoryName).HasMaxLength(100);

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Keyword).HasMaxLength(150);

                entity.Property(e => e.Summary).HasMaxLength(200);

                entity.Property(e => e.Url).HasColumnType("varchar(100)");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.CategoryInfo)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_CategoryInfo_Category");
            });

            modelBuilder.Entity<CategoryOption>(entity =>
            {
                entity.HasKey(e => new { e.CategoryOptionId, e.CategoryInfoId, e.CategoryId, e.Uiculture })
                    .HasName("PK_CategoryOption");

                entity.Property(e => e.CategoryOptionId)
                    .HasColumnName("CategoryOptionID")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.CategoryInfoId).HasColumnName("CategoryInfoID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Uiculture)
                    .HasColumnName("UICulture")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.ParameterGroup).HasMaxLength(100);

                entity.Property(e => e.ParameterKeyFrom).HasMaxLength(100);

                entity.Property(e => e.ParameterKeyTo).HasMaxLength(100);

                entity.Property(e => e.ParameterType).HasMaxLength(100);

                entity.Property(e => e.ParameterValueDefault).HasMaxLength(100);

                entity.Property(e => e.ParameterValueFrom).HasMaxLength(50);

                entity.Property(e => e.ParameterValueTo).HasMaxLength(50);
            });

            modelBuilder.Entity<CategoryOptionDatasource>(entity =>
            {
                entity.HasKey(e => e.CategoryDatasourceId)
                    .HasName("PK__Category__14E2B3247460F491");

                entity.Property(e => e.CategoryDatasourceId).HasColumnName("CategoryDatasourceID");

                entity.Property(e => e.CategoryOptionId)
                    .HasColumnName("CategoryOptionID")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.Parameter).HasMaxLength(100);
            });

            modelBuilder.Entity<CategoryStore>(entity =>
            {
                entity.HasKey(e => new { e.CategoryId, e.StoreId, e.UserId })
                    .HasName("PK_CategoryStore");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.JoinedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Condition>(entity =>
            {
                entity.Property(e => e.ConditionId).HasColumnName("ConditionID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.DistrictId).HasColumnName("DistrictID");

                entity.Property(e => e.SearchText).HasMaxLength(300);

                entity.Property(e => e.Tooken).HasColumnType("varchar(50)");
            });

            modelBuilder.Entity<District>(entity =>
            {
                entity.Property(e => e.DistrictId).HasColumnName("DistrictID");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.City)
                    .WithMany(p => p.District)
                    .HasForeignKey(d => d.CityId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_District_City");
            });

            modelBuilder.Entity<Family>(entity =>
            {
                entity.Property(e => e.FamilyId).HasColumnName("FamilyID");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.ImageHoverPath).HasColumnType("varchar(200)");

                entity.Property(e => e.ImagePath).HasColumnType("varchar(200)");

                entity.Property(e => e.Sequence).HasDefaultValueSql("0");

                entity.Property(e => e.State).HasDefaultValueSql("0");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<FamilyInfo>(entity =>
            {
                entity.HasKey(e => new { e.FamilyId, e.Uiculture })
                    .HasName("PK_FamilyInfo");

                entity.Property(e => e.FamilyId).HasColumnName("FamilyID");

                entity.Property(e => e.Uiculture)
                    .HasColumnName("UICulture")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.FamilyName).HasMaxLength(100);

                entity.Property(e => e.Keyword).HasMaxLength(150);

                entity.Property(e => e.Summary).HasMaxLength(200);

                entity.Property(e => e.Url).HasColumnType("varchar(100)");

                entity.HasOne(d => d.Family)
                    .WithMany(p => p.FamilyInfo)
                    .HasForeignKey(d => d.FamilyId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_FamilyInfo_Family");
            });

            modelBuilder.Entity<GroupHelp>(entity =>
            {
                entity.HasKey(e => e.GroupId)
                    .HasName("PK__GroupHel__149AF30ACA4B0D9C");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.GroupName).HasMaxLength(200);

                entity.Property(e => e.GroupSummary).HasMaxLength(500);

                entity.Property(e => e.GroupUrl).HasColumnType("varchar(200)");

                entity.Property(e => e.UiCulture)
                    .IsRequired()
                    .HasColumnType("varchar(5)");
            });

            modelBuilder.Entity<Helper>(entity =>
            {
                entity.HasKey(e => e.HelpId)
                    .HasName("PK__Helper__90E3232EBA5BEB64");

                entity.Property(e => e.HelpId).HasColumnName("HelpID");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.Summary).HasMaxLength(300);

                entity.Property(e => e.Title).HasMaxLength(200);

                entity.Property(e => e.Uiculture)
                    .HasColumnName("UICulture")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.Url).HasColumnType("varchar(200)");
            });

            modelBuilder.Entity<Language>(entity =>
            {
                entity.HasKey(e => e.LangugeId)
                    .HasName("PK_Languge");

                entity.Property(e => e.LangugeId).HasColumnName("LangugeID");

                entity.Property(e => e.LangugeName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.Uiculture)
                    .IsRequired()
                    .HasColumnName("UICulture")
                    .HasColumnType("varchar(5)");
            });

            modelBuilder.Entity<PostedOption>(entity =>
            {
                entity.HasKey(e => new { e.CategoryOptionId, e.CategoryInfoId, e.CategoryId, e.Uiculture })
                    .HasName("PK_PostedOption");

                entity.Property(e => e.CategoryOptionId)
                    .HasColumnName("CategoryOptionID")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.CategoryInfoId).HasColumnName("CategoryInfoID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Uiculture)
                    .HasColumnName("UICulture")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.ParameterGroup).HasMaxLength(100);

                entity.Property(e => e.ParameterKeyFrom).HasMaxLength(100);

                entity.Property(e => e.ParameterKeyTo).HasMaxLength(100);

                entity.Property(e => e.ParameterType).HasMaxLength(100);

                entity.Property(e => e.ParameterValueDefault).HasMaxLength(100);

                entity.Property(e => e.ParameterValueFrom).HasMaxLength(50);

                entity.Property(e => e.ParameterValueTo).HasMaxLength(50);
            });

            modelBuilder.Entity<PostedOptionDatasource>(entity =>
            {
                entity.HasKey(e => e.CategoryDatasourceId)
                    .HasName("PK__PostedOp__14E2B324DE6F7ADE");

                entity.Property(e => e.CategoryDatasourceId).HasColumnName("CategoryDatasourceID");

                entity.Property(e => e.CategoryOptionId)
                    .HasColumnName("CategoryOptionID")
                    .HasColumnType("varchar(15)");

                entity.Property(e => e.Parameter).HasMaxLength(100);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DistrictId).HasColumnName("DistrictID");

                entity.Property(e => e.EmailContact).HasColumnType("varchar(150)");

                entity.Property(e => e.FamilyId).HasColumnName("FamilyID");

                entity.Property(e => e.Fobprice)
                    .HasColumnName("FOBPrice")
                    .HasColumnType("decimal");

                entity.Property(e => e.ImagePath).HasColumnType("varchar(200)");

                entity.Property(e => e.IsOffer).HasDefaultValueSql("0");

                entity.Property(e => e.IsPublicPhone).HasDefaultValueSql("1");

                entity.Property(e => e.IsVip).HasDefaultValueSql("0");

                entity.Property(e => e.PhoneContact).HasColumnType("varchar(20)");

                entity.Property(e => e.Price).HasColumnType("decimal");

                entity.Property(e => e.Sequence).HasDefaultValueSql("0");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.TotalView).HasDefaultValueSql("0");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.ViewCount).HasDefaultValueSql("0");

                entity.Property(e => e.Weight).HasColumnType("decimal");
            });

            modelBuilder.Entity<ProductImage>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ImagePath).HasColumnType("varchar(100)");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Summary).HasMaxLength(200);
            });

            modelBuilder.Entity<ProductInfo>(entity =>
            {
                entity.HasKey(e => new { e.ProductInfoId, e.ProductId, e.Uiculture })
                    .HasName("PK_ProductInfo");

                entity.Property(e => e.ProductInfoId)
                    .HasColumnName("ProductInfoID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Uiculture)
                    .HasColumnName("UICulture")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Keyword).HasMaxLength(150);

                entity.Property(e => e.OriginalFeature).HasMaxLength(100);

                entity.Property(e => e.Packaging).HasMaxLength(100);

                entity.Property(e => e.PaymentTerm).HasMaxLength(100);

                entity.Property(e => e.ProductName).HasMaxLength(200);

                entity.Property(e => e.Summary).HasMaxLength(500);

                entity.Property(e => e.Url).HasColumnType("varchar(100)");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductInfo)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_ProductInfo_Product");
            });

            modelBuilder.Entity<ProductOption>(entity =>
            {
                entity.HasKey(e => new { e.ProductOptionId, e.ProductId, e.Uiculture })
                    .HasName("PK_ProductOption");

                entity.Property(e => e.ProductOptionId)
                    .HasColumnName("ProductOptionID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Uiculture)
                    .HasColumnName("UICulture")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.Column1).HasMaxLength(50);

                entity.Property(e => e.Column10).HasMaxLength(50);

                entity.Property(e => e.Column2).HasMaxLength(50);

                entity.Property(e => e.Column3).HasMaxLength(50);

                entity.Property(e => e.Column4).HasMaxLength(50);

                entity.Property(e => e.Column5).HasMaxLength(50);

                entity.Property(e => e.Column6).HasMaxLength(50);

                entity.Property(e => e.Column7).HasMaxLength(50);

                entity.Property(e => e.Column8).HasMaxLength(50);

                entity.Property(e => e.Column9).HasMaxLength(50);
            });

            modelBuilder.Entity<Store>(entity =>
            {
                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.DistrictId).HasColumnName("DistrictID");

                entity.Property(e => e.Email).HasColumnType("varchar(100)");

                entity.Property(e => e.ExpiredDate).HasColumnType("datetime");

                entity.Property(e => e.FaxNumber).HasColumnType("varchar(50)");

                entity.Property(e => e.ImagePath).HasColumnType("varchar(100)");

                entity.Property(e => e.MobileNumber).HasColumnType("varchar(50)");

                entity.Property(e => e.PhoneNumber).HasColumnType("varchar(50)");

                entity.Property(e => e.Sequence).HasDefaultValueSql("0");

                entity.Property(e => e.TaxCode).HasColumnType("varchar(50)");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.Url).HasColumnType("varchar(150)");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Store)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_Store_UserProfile");
            });

            modelBuilder.Entity<StoreInfo>(entity =>
            {
                entity.HasKey(e => new { e.StoreId, e.Uiculture })
                    .HasName("PK_StoreInfo");

                entity.Property(e => e.StoreId).HasColumnName("StoreID");

                entity.Property(e => e.Uiculture)
                    .HasColumnName("UICulture")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Keyword).HasMaxLength(200);

                entity.Property(e => e.OpenningHours).HasMaxLength(100);

                entity.Property(e => e.StoreName).HasMaxLength(200);

                entity.Property(e => e.Summary).HasMaxLength(1000);

                entity.HasOne(d => d.Store)
                    .WithMany(p => p.StoreInfo)
                    .HasForeignKey(d => d.StoreId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_StoreInfo_Store1");
            });

            modelBuilder.Entity<UserCategory>(entity =>
            {
                entity.HasKey(e => new { e.CategoryId, e.UserId })
                    .HasName("PK_UserCategory");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.JoinedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");
            });

            modelBuilder.Entity<UserInfo>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.Uiculture })
                    .HasName("PK_dbo.UserInfo");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.Uiculture)
                    .HasColumnName("UICulture")
                    .HasColumnType("varchar(5)");

                entity.Property(e => e.Address).HasMaxLength(300);

                entity.Property(e => e.CompanyName).HasMaxLength(200);

                entity.Property(e => e.Email).HasMaxLength(150);

                entity.Property(e => e.FaxNumber).HasColumnType("varchar(20)");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.MobileNumber).HasColumnType("varchar(20)");

                entity.Property(e => e.PhoneNumber).HasColumnType("varchar(20)");

                entity.Property(e => e.Summary).HasMaxLength(200);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserInfo)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Restrict)
                    .HasConstraintName("FK_UserInfo_UserProfile");
            });

            modelBuilder.Entity<UserProfile>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK_dbo.UserProfile");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.BlockedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("getdate()");

                entity.Property(e => e.CreditLineValue).HasColumnType("decimal");

                entity.Property(e => e.CreditValue).HasColumnType("decimal");

                entity.Property(e => e.EffectedDate).HasColumnType("datetime");

                entity.Property(e => e.IsEnterprise).HasDefaultValueSql("0");

                entity.Property(e => e.IsPhoneNumberShown).HasDefaultValueSql("1");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Noted).HasMaxLength(100);

                entity.Property(e => e.Status).HasDefaultValueSql("0");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<WebDefault>(entity =>
            {
                entity.HasKey(e => e.UiCulture)
                    .HasName("PK__WebDefau__F342A985EA323BEF");

                entity.Property(e => e.UiCulture).HasColumnType("varchar(5)");

                entity.Property(e => e.Criteria).HasMaxLength(200);

                entity.Property(e => e.Description).HasMaxLength(300);

                entity.Property(e => e.Keyword).HasMaxLength(200);

                entity.Property(e => e.Slogan).HasMaxLength(200);

                entity.Property(e => e.SupportLongText).HasMaxLength(500);

                entity.Property(e => e.Title).HasMaxLength(200);
            });

            modelBuilder.Entity<WebpagesMembership>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK_dbo.webpages_Membership");

                entity.ToTable("webpages_Membership");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.ConfirmationToken).HasMaxLength(128);

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.LastPasswordFailureDate).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PasswordChangedDate).HasColumnType("datetime");

                entity.Property(e => e.PasswordSalt)
                    .IsRequired()
                    .HasMaxLength(128);

                entity.Property(e => e.PasswordVerificationToken).HasMaxLength(128);

                entity.Property(e => e.PasswordVerificationTokenExpirationDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<WebpagesOauthMembership>(entity =>
            {
                entity.HasKey(e => new { e.Provider, e.ProviderUserId })
                    .HasName("PK_dbo.webpages_OAuthMembership");

                entity.ToTable("webpages_OAuthMembership");

                entity.Property(e => e.Provider).HasMaxLength(30);

                entity.Property(e => e.ProviderUserId).HasMaxLength(100);
            });

            modelBuilder.Entity<WebpagesRoles>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK_dbo.webpages_Roles");

                entity.ToTable("webpages_Roles");

                entity.Property(e => e.RoleName).HasMaxLength(256);
            });

            modelBuilder.Entity<WebpagesUsersInRoles>(entity =>
            {
                entity.HasKey(e => new { e.RoleId, e.UserId })
                    .HasName("PK_dbo.webpages_UsersInRoles");

                entity.ToTable("webpages_UsersInRoles");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.WebpagesUsersInRoles)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_dbo.webpages_UsersInRoles_dbo.webpages_Roles_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.WebpagesUsersInRoles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_dbo.webpages_UsersInRoles_dbo.UserProfile_UserId");
            });
        }
    }
}