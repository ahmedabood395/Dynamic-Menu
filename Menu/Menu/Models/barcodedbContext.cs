using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Menu.Models
{
    public partial class barcodedbContext : DbContext
    {
        public barcodedbContext()
        {
        }

        public barcodedbContext(DbContextOptions<barcodedbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<LoginUser> LoginUsers { get; set; }
        public virtual DbSet<SysFunction> SysFunctions { get; set; }
        public virtual DbSet<UserFunction> UserFunctions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-4U16PF9\\SQLEXPRESS;Database=barcodedb;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.HasKey(e => e.EmpCode)
                    .HasName("PK_Emp");

                entity.ToTable("Employee");

                entity.Property(e => e.EmpCode)
                    .HasMaxLength(50)
                    .HasColumnName("Emp_code");

                entity.Property(e => e.EmpActive)
                    .HasColumnName("Emp_active")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.EmpBirthDate)
                    .HasColumnType("date")
                    .HasColumnName("Emp_BirthDate");

                entity.Property(e => e.EmpBirthPlaceId)
                    .HasMaxLength(50)
                    .HasColumnName("Emp_BirthPlaceId");

                entity.Property(e => e.EmpBrCode).HasColumnName("Emp_Br_code");

                entity.Property(e => e.EmpCmpCode)
                    .HasMaxLength(50)
                    .HasColumnName("Emp_Cmp_code");

                entity.Property(e => e.EmpCreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Emp_created_at");

                entity.Property(e => e.EmpCreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Emp_created_by");

                entity.Property(e => e.EmpCreatedChanel)
                    .HasMaxLength(50)
                    .HasColumnName("Emp_created_chanel");

                entity.Property(e => e.EmpDptCode).HasColumnName("Emp_Dpt_code");

                entity.Property(e => e.EmpJobCode).HasColumnName("Emp_Job_code");

                entity.Property(e => e.EmpLnuCode)
                    .HasMaxLength(10)
                    .HasColumnName("Emp_Lnu_code")
                    .IsFixedLength(true);

                entity.Property(e => e.EmpManager)
                    .HasMaxLength(50)
                    .HasColumnName("Emp_manager");

                entity.Property(e => e.EmpMary)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Emp_Mary")
                    .IsFixedLength(true);

                entity.Property(e => e.EmpNameAr)
                    .HasMaxLength(150)
                    .HasColumnName("Emp_name_ar");

                entity.Property(e => e.EmpNameEn)
                    .HasMaxLength(150)
                    .HasColumnName("Emp_name_en");

                entity.Property(e => e.EmpNo)
                    .HasMaxLength(50)
                    .HasColumnName("Emp_No");

                entity.Property(e => e.EmpRankCode).HasColumnName("Emp_Rank_code");

                entity.Property(e => e.EmpReligon).HasColumnName("Emp_Religon");

                entity.Property(e => e.EmpSecCode).HasColumnName("Emp_sec_code");

                entity.Property(e => e.EmpSex)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("Emp_Sex")
                    .HasDefaultValueSql("('M')")
                    .IsFixedLength(true);

                entity.Property(e => e.EmpUpdateAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Emp_update_at");

                entity.Property(e => e.EmpUpdateBy)
                    .HasMaxLength(50)
                    .HasColumnName("Emp_update_by");

                entity.Property(e => e.EmpUpdateChanel)
                    .HasMaxLength(50)
                    .HasColumnName("Emp_update_chanel");

                entity.HasOne(d => d.EmpManagerNavigation)
                    .WithMany(p => p.InverseEmpManagerNavigation)
                    .HasForeignKey(d => d.EmpManager)
                    .HasConstraintName("FK_Employee_Employee");
            });

            modelBuilder.Entity<LoginUser>(entity =>
            {
                entity.HasKey(e => e.LnuCode)
                    .HasName("PK_login");

                entity.ToTable("login_user");

                entity.Property(e => e.LnuCode)
                    .HasMaxLength(50)
                    .HasColumnName("Lnu_code");

                entity.Property(e => e.LnuActive).HasColumnName("lnu_active");

                entity.Property(e => e.LnuCreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("lnu_created_at");

                entity.Property(e => e.LnuCreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("lnu_created_by");

                entity.Property(e => e.LnuCreatedChanel)
                    .HasMaxLength(50)
                    .HasColumnName("lnu_created_chanel");

                entity.Property(e => e.LnuEmail)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("Lnu_email");

                entity.Property(e => e.LnuPassExpdt)
                    .HasColumnType("date")
                    .HasColumnName("lnu_pass_expdt");

                entity.Property(e => e.LnuPassStatus)
                    .HasMaxLength(50)
                    .HasColumnName("lnu_pass_status");

                entity.Property(e => e.LnuPassword)
                    .IsRequired()
                    .HasMaxLength(150)
                    .HasColumnName("Lnu_password");

                entity.Property(e => e.LnuRoleCode).HasColumnName("Lnu_role_code");

                entity.Property(e => e.LnuUpdateAt)
                    .HasColumnType("datetime")
                    .HasColumnName("lnu_update_at");

                entity.Property(e => e.LnuUpdateBy)
                    .HasMaxLength(50)
                    .HasColumnName("lnu_update_by");

                entity.Property(e => e.LnuUpdateChanel)
                    .HasMaxLength(50)
                    .HasColumnName("lnu_update_chanel");
            });

            modelBuilder.Entity<SysFunction>(entity =>
            {
                entity.HasKey(e => e.SysFuncCode)
                    .HasName("PK_sys_functions");

                entity.ToTable("Sys_functions");

                entity.Property(e => e.SysFuncCode)
                    .ValueGeneratedNever()
                    .HasColumnName("Sys_Func_code");

                entity.Property(e => e.SysFuncActive)
                    .HasColumnName("Sys_FuncActive")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SysFuncAddB)
                    .HasMaxLength(50)
                    .HasColumnName("Sys_FuncAddB");

                entity.Property(e => e.SysFuncAppear)
                    .HasMaxLength(1)
                    .HasColumnName("Sys_FuncAppear")
                    .IsFixedLength(true);

                entity.Property(e => e.SysFuncDelB)
                    .HasMaxLength(50)
                    .HasColumnName("Sys_FuncDelB");

                entity.Property(e => e.SysFuncDesc)
                    .HasMaxLength(250)
                    .HasColumnName("Sys_FuncDesc");

                entity.Property(e => e.SysFuncModB)
                    .HasMaxLength(50)
                    .HasColumnName("Sys_FuncModB");

                entity.Property(e => e.SysFuncNameAr)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("Sys_FuncName_ar");

                entity.Property(e => e.SysFuncNameEn)
                    .HasMaxLength(250)
                    .HasColumnName("Sys_FuncName_en");

                entity.Property(e => e.SysFuncParentId).HasColumnName("Sys_FuncParent_id");

                entity.Property(e => e.SysFuncTechName)
                    .HasMaxLength(250)
                    .HasColumnName("Sys_FuncTechName");

                entity.Property(e => e.SysFunccreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Sys_Funccreated_at");

                entity.Property(e => e.SysFunccreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("Sys_Funccreated_by");

                entity.Property(e => e.SysFunccreatedChanel)
                    .HasMaxLength(50)
                    .HasColumnName("Sys_Funccreated_chanel");

                entity.Property(e => e.SysFuncfont)
                    .HasMaxLength(250)
                    .HasColumnName("Sys_Funcfont");

                entity.Property(e => e.SysFuncupdateAt)
                    .HasColumnType("datetime")
                    .HasColumnName("Sys_Funcupdate_at");

                entity.Property(e => e.SysFuncupdateBy)
                    .HasMaxLength(50)
                    .HasColumnName("Sys_Funcupdate_by");

                entity.Property(e => e.SysFuncupdateChanel)
                    .HasMaxLength(50)
                    .HasColumnName("Sys_Funcupdate_chanel");

                entity.HasOne(d => d.SysFuncParent)
                    .WithMany(p => p.InverseSysFuncParent)
                    .HasForeignKey(d => d.SysFuncParentId)
                    .HasConstraintName("FK_Sys_functions_Sys_functions1");
            });

            modelBuilder.Entity<UserFunction>(entity =>
            {
                entity.ToTable("User_Functions");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.UfActive).HasColumnName("UF_Active");

                entity.Property(e => e.UfAddB)
                    .HasMaxLength(50)
                    .HasColumnName("UF_AddB");

                entity.Property(e => e.UfAppear)
                    .HasMaxLength(1)
                    .HasColumnName("UF_Appear")
                    .IsFixedLength(true);

                entity.Property(e => e.UfCreatedAt)
                    .HasColumnType("datetime")
                    .HasColumnName("UF_created_at");

                entity.Property(e => e.UfCreatedBy)
                    .HasMaxLength(50)
                    .HasColumnName("UF_created_by");

                entity.Property(e => e.UfCreatedChanel)
                    .HasMaxLength(50)
                    .HasColumnName("UF_created_chanel");

                entity.Property(e => e.UfDelB)
                    .HasMaxLength(50)
                    .HasColumnName("UF_DelB");

                entity.Property(e => e.UfFont)
                    .HasMaxLength(250)
                    .HasColumnName("UF_font");

                entity.Property(e => e.UfFuncCode).HasColumnName("UF_Func_code");

                entity.Property(e => e.UfFuncDesc)
                    .HasMaxLength(250)
                    .HasColumnName("UF_FuncDesc");

                entity.Property(e => e.UfFuncNameAr)
                    .IsRequired()
                    .HasMaxLength(250)
                    .HasColumnName("UF_FuncName_ar");

                entity.Property(e => e.UfFuncNameEn)
                    .HasMaxLength(250)
                    .HasColumnName("UF_FuncName_en");

                entity.Property(e => e.UfLnuCode).HasColumnName("UF_Lnu_code");

                entity.Property(e => e.UfModB)
                    .HasMaxLength(50)
                    .HasColumnName("UF_ModB");

                entity.Property(e => e.UfParentId).HasColumnName("UF_Parent_id");

                entity.Property(e => e.UfUpdateAt)
                    .HasColumnType("datetime")
                    .HasColumnName("UF_update_at");

                entity.Property(e => e.UfUpdateBy)
                    .HasMaxLength(50)
                    .HasColumnName("UF_update_by");

                entity.Property(e => e.UfUpdateChanel)
                    .HasMaxLength(50)
                    .HasColumnName("UF_update_chanel");

                entity.HasOne(d => d.UfFuncCodeNavigation)
                    .WithMany(p => p.UserFunctions)
                    .HasForeignKey(d => d.UfFuncCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_Functions_Sys_functions");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
