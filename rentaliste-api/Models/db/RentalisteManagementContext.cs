using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace rentaliste_api.Models.db;

public partial class RentalisteManagementContext : DbContext
{
    public RentalisteManagementContext()
    {
    }

    public RentalisteManagementContext(DbContextOptions<RentalisteManagementContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Communication> Communications { get; set; }

    public virtual DbSet<CommunicationType> CommunicationTypes { get; set; }

    public virtual DbSet<Document> Documents { get; set; }

    public virtual DbSet<DocumentType> DocumentTypes { get; set; }

    public virtual DbSet<Lease> Leases { get; set; }

    public virtual DbSet<MaintenanceRequest> MaintenanceRequests { get; set; }

    public virtual DbSet<MaintenanceType> MaintenanceTypes { get; set; }

    public virtual DbSet<Owner> Owners { get; set; }

    public virtual DbSet<Position> Positions { get; set; }

    public virtual DbSet<Privilege> Privileges { get; set; }

    public virtual DbSet<Property> Properties { get; set; }

    public virtual DbSet<PropertyType> PropertyTypes { get; set; }

    public virtual DbSet<Staff> Staff { get; set; }

    public virtual DbSet<Tenant> Tenants { get; set; }

    public virtual DbSet<Transaction> Transactions { get; set; }

    public virtual DbSet<TransactionType> TransactionTypes { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=RENTALISTE_MANAGEMENT;User ID=sa;Password=Tr@ncer271993;Trusted_Connection=False;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Communication>(entity =>
        {
            entity.ToTable("Communication");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.CommunicationTypeId).HasColumnName("communication_type_id");
            entity.Property(e => e.Message)
                .HasColumnType("text")
                .HasColumnName("message");
            entity.Property(e => e.SendDate)
                .HasColumnType("datetime")
                .HasColumnName("send_date");
            entity.Property(e => e.Status)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");

            entity.HasOne(d => d.CommunicationType).WithMany(p => p.Communications)
                .HasForeignKey(d => d.CommunicationTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Communication_Communication_Type");

            entity.HasOne(d => d.Tenant).WithMany(p => p.Communications)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Communication_Tenant");
        });

        modelBuilder.Entity<CommunicationType>(entity =>
        {
            entity.ToTable("CommunicationType");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Label)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("label");
        });

        modelBuilder.Entity<Document>(entity =>
        {
            entity.ToTable("Document");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.DocumentTypeId).HasColumnName("document_type_id");
            entity.Property(e => e.LeaseId).HasColumnName("lease_id");
            entity.Property(e => e.Link)
                .IsUnicode(false)
                .HasColumnName("link");

            entity.HasOne(d => d.DocumentType).WithMany(p => p.Documents)
                .HasForeignKey(d => d.DocumentTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Document_Document_Type");

            entity.HasOne(d => d.Lease).WithMany(p => p.Documents)
                .HasForeignKey(d => d.LeaseId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Document_Lease");
        });

        modelBuilder.Entity<DocumentType>(entity =>
        {
            entity.ToTable("DocumentType");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Label)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("label");
        });

        modelBuilder.Entity<Lease>(entity =>
        {
            entity.ToTable("Lease");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.DepositAmount)
                .HasColumnType("money")
                .HasColumnName("deposit_amount");
            entity.Property(e => e.EndDate)
                .HasColumnType("date")
                .HasColumnName("end_date");
            entity.Property(e => e.IdProperty).HasColumnName("id_property");
            entity.Property(e => e.IdTenant).HasColumnName("id_tenant");
            entity.Property(e => e.LeaseTerms)
                .HasColumnType("text")
                .HasColumnName("lease_terms");
            entity.Property(e => e.MonthlyRent)
                .HasColumnType("money")
                .HasColumnName("monthly_rent");
            entity.Property(e => e.StartDate)
                .HasColumnType("date")
                .HasColumnName("start_date");

            entity.HasOne(d => d.IdPropertyNavigation).WithMany(p => p.Leases)
                .HasForeignKey(d => d.IdProperty)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Lease_Property");

            entity.HasOne(d => d.IdTenantNavigation).WithMany(p => p.Leases)
                .HasForeignKey(d => d.IdTenant)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Lease_Tenant");
        });

        modelBuilder.Entity<MaintenanceRequest>(entity =>
        {
            entity.ToTable("MaintenanceRequest");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.AssigneeId).HasColumnName("assignee_id");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.MaintenanceTypeId).HasColumnName("maintenance_type_id");
            entity.Property(e => e.PropertyId).HasColumnName("property_id");
            entity.Property(e => e.RequestDate)
                .HasColumnType("date")
                .HasColumnName("request_date");
            entity.Property(e => e.Status)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("status");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");

            entity.HasOne(d => d.Assignee).WithMany(p => p.MaintenanceRequests)
                .HasForeignKey(d => d.AssigneeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Maintenance_Request_Staff");

            entity.HasOne(d => d.MaintenanceType).WithMany(p => p.MaintenanceRequests)
                .HasForeignKey(d => d.MaintenanceTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Maintenance_Request_Maintenance_Type");

            entity.HasOne(d => d.Property).WithMany(p => p.MaintenanceRequests)
                .HasForeignKey(d => d.PropertyId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Maintenance_Request_Property");

            entity.HasOne(d => d.Tenant).WithMany(p => p.MaintenanceRequests)
                .HasForeignKey(d => d.TenantId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Maintenance_Request_Tenant");
        });

        modelBuilder.Entity<MaintenanceType>(entity =>
        {
            entity.ToTable("MaintenanceType");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Label)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("label");
        });

        modelBuilder.Entity<Owner>(entity =>
        {
            entity.ToTable("Owner");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email_address");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_name");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("phone");
        });

        modelBuilder.Entity<Position>(entity =>
        {
            entity.ToTable("Position");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Description)
                .IsUnicode(false)
                .HasColumnName("description");
            entity.Property(e => e.Label)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("label");
        });

        modelBuilder.Entity<Privilege>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.ReadLease).HasColumnName("read_lease");
            entity.Property(e => e.ReadMaintenance).HasColumnName("read_maintenance");
            entity.Property(e => e.ReadPropertyDate).HasColumnName("read_property_date");
            entity.Property(e => e.ReadStaff).HasColumnName("read_staff");
            entity.Property(e => e.ReadTransactions).HasColumnName("read_transactions");
            entity.Property(e => e.SendCommunications).HasColumnName("send_communications");
            entity.Property(e => e.UserId).HasColumnName("user_id");
            entity.Property(e => e.WriteLease).HasColumnName("write_lease");
            entity.Property(e => e.WriteMaintenanace).HasColumnName("write_maintenanace");
            entity.Property(e => e.WritePropertyData).HasColumnName("write_property_data");
            entity.Property(e => e.WriteStaff).HasColumnName("write_staff");
            entity.Property(e => e.WriteTransactions).HasColumnName("write_transactions");

            entity.HasOne(d => d.User).WithMany(p => p.Privileges)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Privileges_User");
        });

        modelBuilder.Entity<Property>(entity =>
        {
            entity.ToTable("Property");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.Details)
                .HasColumnType("text")
                .HasColumnName("details");
            entity.Property(e => e.IdType).HasColumnName("id_type");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.OwnerId).HasColumnName("owner_id");
            entity.Property(e => e.Size).HasColumnName("size");

            entity.HasOne(d => d.IdTypeNavigation).WithMany(p => p.Properties)
                .HasForeignKey(d => d.IdType)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Property_Property_Type");

            entity.HasOne(d => d.Owner).WithMany(p => p.Properties)
                .HasForeignKey(d => d.OwnerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Property_Owner");
        });

        modelBuilder.Entity<PropertyType>(entity =>
        {
            entity.ToTable("PropertyType");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Label)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("label");
        });

        modelBuilder.Entity<Staff>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Address)
                .IsUnicode(false)
                .HasColumnName("address");
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email_address");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_name");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.PositionId).HasColumnName("position_id");

            entity.HasOne(d => d.Position).WithMany(p => p.Staff)
                .HasForeignKey(d => d.PositionId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Staff_Position");
        });

        modelBuilder.Entity<Tenant>(entity =>
        {
            entity.ToTable("Tenant");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email_address");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("first_name");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("last_name");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("phone");
        });

        modelBuilder.Entity<Transaction>(entity =>
        {
            entity.ToTable("Transaction");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Amount)
                .HasColumnType("money")
                .HasColumnName("amount");
            entity.Property(e => e.Description)
                .HasColumnType("text")
                .HasColumnName("description");
            entity.Property(e => e.LeaseId).HasColumnName("lease_id");
            entity.Property(e => e.PropertyId).HasColumnName("property_id");
            entity.Property(e => e.TenantId).HasColumnName("tenant_id");
            entity.Property(e => e.TransactionDate)
                .HasColumnType("datetime")
                .HasColumnName("transaction_date");
            entity.Property(e => e.TransactionTypeId).HasColumnName("transaction_type_id");

            entity.HasOne(d => d.Lease).WithMany(p => p.Transactions)
                .HasForeignKey(d => d.LeaseId)
                .HasConstraintName("FK_Transaction_Lease");

            entity.HasOne(d => d.Property).WithMany(p => p.Transactions)
                .HasForeignKey(d => d.PropertyId)
                .HasConstraintName("FK_Transaction_Property");

            entity.HasOne(d => d.Tenant).WithMany(p => p.Transactions)
                .HasForeignKey(d => d.TenantId)
                .HasConstraintName("FK_Transaction_Tenant");

            entity.HasOne(d => d.TransactionType).WithMany(p => p.Transactions)
                .HasForeignKey(d => d.TransactionTypeId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Transaction_Transaction_Type");
        });

        modelBuilder.Entity<TransactionType>(entity =>
        {
            entity.ToTable("TransactionType");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Label)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("label");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.ToTable("User");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.CreationDate)
                .HasColumnType("datetime")
                .HasColumnName("creation_date");
            entity.Property(e => e.Enabled)
                .IsRequired()
                .HasDefaultValueSql("((1))")
                .HasColumnName("enabled");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.Password)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.StaffId).HasColumnName("staff_id");
            entity.Property(e => e.UpdatedDate)
                .HasColumnType("datetime")
                .HasColumnName("updated_date");
            entity.Property(e => e.Username)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("username");

            entity.HasOne(d => d.Staff).WithMany(p => p.Users)
                .HasForeignKey(d => d.StaffId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_User_Staff");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
