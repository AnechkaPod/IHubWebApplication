using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace IHubWebApplication.Model;

public partial class IhubWebApplicationContextB59ddbde0599485c928aEe460f987da4Context : DbContext
{
    public IhubWebApplicationContextB59ddbde0599485c928aEe460f987da4Context()
    {
    }

    public IhubWebApplicationContextB59ddbde0599485c928aEe460f987da4Context(DbContextOptions<IhubWebApplicationContextB59ddbde0599485c928aEe460f987da4Context> options)
        : base(options)
    {
    }

    public virtual DbSet<HgdrBank> HgdrBanks { get; set; }

    public virtual DbSet<HgdrCheshbon> HgdrCheshbons { get; set; }

    public virtual DbSet<HgdrMachshir> HgdrMachshirs { get; set; }

    public virtual DbSet<HgdrManpik> HgdrManpiks { get; set; }

    public virtual DbSet<HgdrMatbea> HgdrMatbeas { get; set; }

    public virtual DbSet<HgdrMetafel> HgdrMetafels { get; set; }

    public virtual DbSet<HgdrMutzar> HgdrMutzars { get; set; }

    public virtual DbSet<HgdrMutzarCategory> HgdrMutzarCategories { get; set; }

    public virtual DbSet<HgdrNech> HgdrNeches { get; set; }

    public virtual DbSet<HgdrSapak> HgdrSapaks { get; set; }

    public virtual DbSet<HgdrSugCheshbon> HgdrSugCheshbons { get; set; }

    public virtual DbSet<HgdrSugMutzar> HgdrSugMutzars { get; set; }

    public virtual DbSet<HgdrTatAfik> HgdrTatAfiks { get; set; }

    public virtual DbSet<Map> Maps { get; set; }

    public virtual DbSet<Movie> Movies { get; set; }

    public virtual DbSet<Person> People { get; set; }

    public virtual DbSet<Screen> Screens { get; set; }

    public virtual DbSet<Setting> Settings { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-6KCUQP6\\SQLEXPRESS;Database=IHubWebApplicationContext-b59ddbde-0599-485c-928a-ee460f987da4;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<HgdrBank>(entity =>
        {
            entity.HasKey(e => e.KodBank);

            entity.ToTable("Hgdr_Bank");

            entity.Property(e => e.KodBank)
                .ValueGeneratedNever()
                .HasColumnName("Kod_Bank");
            entity.Property(e => e.Bank).HasMaxLength(50);
            entity.Property(e => e.CounterPartyName)
                .HasMaxLength(50)
                .HasColumnName("Counter Party Name");
            entity.Property(e => e.KodBroker).HasColumnName("Kod_Broker");
            entity.Property(e => e.KodChaverBursa).HasColumnName("Kod_Chaver_Bursa");
            entity.Property(e => e.KodManpik).HasColumnName("Kod_Manpik");
            entity.Property(e => e.TeurChaverBursaPoalim)
                .HasMaxLength(50)
                .HasColumnName("Teur_Chaver_Bursa_Poalim");
        });

        modelBuilder.Entity<HgdrCheshbon>(entity =>
        {
            entity.ToTable("Hgdr_Cheshbon");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aba)
                .HasMaxLength(50)
                .HasColumnName("ABA");
            entity.Property(e => e.Address).HasMaxLength(50);
            entity.Property(e => e.Attention).HasMaxLength(50);
            entity.Property(e => e.BeneficiaryBankName)
                .HasMaxLength(50)
                .HasColumnName("Beneficiary_Bank_Name");
            entity.Property(e => e.Bic)
                .HasMaxLength(50)
                .HasColumnName("BIC");
            entity.Property(e => e.Bsb)
                .HasMaxLength(50)
                .HasColumnName("BSB");
            entity.Property(e => e.CleaningCode)
                .HasMaxLength(50)
                .HasColumnName("Cleaning_Code");
            entity.Property(e => e.IbanIls)
                .HasMaxLength(50)
                .HasColumnName("IBAN_ILS");
            entity.Property(e => e.IbanMatach)
                .HasMaxLength(50)
                .HasColumnName("IBAN_Matach");
            entity.Property(e => e.KodBank).HasColumnName("Kod_Bank");
            entity.Property(e => e.KodCheshbon)
                .HasMaxLength(50)
                .HasColumnName("Kod_Cheshbon");
            entity.Property(e => e.KodCheshbonMatach)
                .HasMaxLength(50)
                .HasColumnName("Kod_Cheshbon_Matach");
            entity.Property(e => e.KodCheshbonNiarot)
                .HasMaxLength(50)
                .HasColumnName("Kod_Cheshbon_Niarot");
            entity.Property(e => e.KodCheshbonShekel)
                .HasMaxLength(50)
                .HasColumnName("Kod_Cheshbon_Shekel");
            entity.Property(e => e.SortCode)
                .HasMaxLength(50)
                .HasColumnName("Sort_Code");
            entity.Property(e => e.SugCheshbon).HasColumnName("Sug_Cheshbon");
            entity.Property(e => e.Swift).HasMaxLength(50);
            entity.Property(e => e.TeurCheshbon)
                .HasMaxLength(100)
                .HasColumnName("Teur_Cheshbon");

            entity.HasOne(d => d.KodBankNavigation).WithMany(p => p.HgdrCheshbons)
                .HasForeignKey(d => d.KodBank)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Hgdr_Cheshbon_Hgdr_Sug_Cheshbon");

            entity.HasOne(d => d.SugCheshbonNavigation).WithMany(p => p.HgdrCheshbons)
                .HasForeignKey(d => d.SugCheshbon)
                .HasConstraintName("FK_Hgdr_Cheshbon_Hgdr_Sug_Cheshbon1");
        });

        modelBuilder.Entity<HgdrMachshir>(entity =>
        {
            entity.ToTable("Hgdr_Machshir");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CheshbonDefault).HasColumnName("Cheshbon_Default");
            entity.Property(e => e.KodMachshirSnir).HasColumnName("Kod_Machshir_Snir");
            entity.Property(e => e.Machshir).HasMaxLength(50);

            entity.HasOne(d => d.CheshbonDefaultNavigation).WithMany(p => p.HgdrMachshirs)
                .HasForeignKey(d => d.CheshbonDefault)
                .HasConstraintName("FK_Hgdr_Machshir_Hgdr_Cheshbon");
        });

        modelBuilder.Entity<HgdrManpik>(entity =>
        {
            entity.ToTable("Hgdr_Manpik");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.KodManpikSnir).HasColumnName("Kod_Manpik_Snir");
            entity.Property(e => e.TeurManpik)
                .HasMaxLength(50)
                .HasColumnName("Teur_Manpik");
        });

        modelBuilder.Entity<HgdrMatbea>(entity =>
        {
            entity.ToTable("Hgdr_Matbea");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.KodMatbea)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("Kod_Matbea");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.Matbea).HasMaxLength(50);
            entity.Property(e => e.PriceMultiplier).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Ric)
                .HasMaxLength(50)
                .HasColumnName("RIC");
            entity.Property(e => e.Source)
                .HasMaxLength(50)
                .HasColumnName("source");
            entity.Property(e => e.UnderlyingRic)
                .HasMaxLength(50)
                .HasColumnName("UnderlyingRIC");
        });

        modelBuilder.Entity<HgdrMetafel>(entity =>
        {
            entity.ToTable("Hgdr_Metafel");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Metafel).HasMaxLength(50);
            entity.Property(e => e.Path).HasMaxLength(255);
        });

        modelBuilder.Entity<HgdrMutzar>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Hgdr_Mutzar_1");

            entity.ToTable("Hgdr_Mutzar");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.KodMutzarCategory).HasColumnName("Kod_Mutzar_Category");
            entity.Property(e => e.KodSugMutzar).HasColumnName("Kod_Sug_Mutzar");

            entity.HasOne(d => d.KodMutzarCategoryNavigation).WithMany(p => p.HgdrMutzars)
                .HasForeignKey(d => d.KodMutzarCategory)
                .HasConstraintName("FK_Hgdr_Mutzar_Hgdr_MutzarCategory");

            entity.HasOne(d => d.KodSugMutzarNavigation).WithMany(p => p.HgdrMutzars)
                .HasForeignKey(d => d.KodSugMutzar)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Hgdr_Mutzar_Hgdr_Sug_Mutzar");
        });

        modelBuilder.Entity<HgdrMutzarCategory>(entity =>
        {
            entity.ToTable("Hgdr_MutzarCategory");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.KodSugMutzar).HasColumnName("Kod_Sug_Mutzar");
            entity.Property(e => e.RafTsuaYomit)
                .HasColumnType("decimal(3, 2)")
                .HasColumnName("Raf_Tsua_Yomit");
            entity.Property(e => e.TeurCategory)
                .HasMaxLength(50)
                .HasColumnName("Teur_Category");

            entity.HasOne(d => d.KodSugMutzarNavigation).WithMany(p => p.HgdrMutzarCategories)
                .HasForeignKey(d => d.KodSugMutzar)
                .HasConstraintName("FK_Hgdr_MutzarCategory_Hgdr_Sug_Mutzar");
        });

        modelBuilder.Entity<HgdrNech>(entity =>
        {
            entity.HasKey(e => e.KodNeches);

            entity.ToTable("Hgdr_Neches");

            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.CanelOrder).HasColumnName("Canel_Order");
            entity.Property(e => e.CheshbonYaadDefault).HasColumnName("Cheshbon_Yaad_Default");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.KodMachshir).HasColumnName("Kod_Machshir");
            entity.Property(e => e.KodMatbea).HasColumnName("Kod_Matbea");
            entity.Property(e => e.Neches).HasMaxLength(250);

            entity.HasOne(d => d.CheshbonYaadDefaultNavigation).WithMany(p => p.HgdrNeches)
                .HasForeignKey(d => d.CheshbonYaadDefault)
                .HasConstraintName("FK_Hgdr_Neches_Hgdr_Cheshbon");

            entity.HasOne(d => d.KodMachshirNavigation).WithMany(p => p.HgdrNeches)
                .HasForeignKey(d => d.KodMachshir)
                .HasConstraintName("FK_Hgdr_Neches_Hgdr_Machshir");

            entity.HasOne(d => d.KodMatbeaNavigation).WithMany(p => p.HgdrNeches)
                .HasForeignKey(d => d.KodMatbea)
                .HasConstraintName("FK_Hgdr_Neches_Hgdr_Matbea");
        });

        modelBuilder.Entity<HgdrSapak>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Hgdr_Mutzar");

            entity.ToTable("Hgdr_Sapak");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.SugSherut)
                .HasMaxLength(50)
                .HasColumnName("Sug_Sherut");
            entity.Property(e => e.TeurSapak)
                .HasMaxLength(50)
                .HasColumnName("Teur_Sapak");
        });

        modelBuilder.Entity<HgdrSugCheshbon>(entity =>
        {
            entity.ToTable("Hgdr_Sug_Cheshbon");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.SugCheshbon)
                .HasMaxLength(50)
                .HasColumnName("Sug_Cheshbon");
        });

        modelBuilder.Entity<HgdrSugMutzar>(entity =>
        {
            entity.ToTable("Hgdr_Sug_Mutzar");

            entity.Property(e => e.SugMutzar)
                .HasMaxLength(50)
                .HasColumnName("Sug_Mutzar");
        });

        modelBuilder.Entity<HgdrTatAfik>(entity =>
        {
            entity.ToTable("Hgdr_Tat_Afik");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Afik).HasMaxLength(50);
            entity.Property(e => e.KodAfik).HasColumnName("Kod_Afik");
            entity.Property(e => e.KodHieTatAfik1).HasColumnName("Kod_Hie_TatAfik_1");
            entity.Property(e => e.KodTatAfik).HasColumnName("Kod_Tat_Afik");
            entity.Property(e => e.NetrulMvtk).HasColumnName("Netrul_Mvtk");
            entity.Property(e => e.TeurTatAfik)
                .HasMaxLength(50)
                .HasColumnName("Teur_Tat_Afik");
        });

        modelBuilder.Entity<Map>(entity =>
        {
            entity.HasKey(e => new { e.Field, e.TableName });

            entity.ToTable("Map");

            entity.Property(e => e.Field).HasMaxLength(50);
            entity.Property(e => e.TableName).HasMaxLength(50);
            entity.Property(e => e.FilteringProps).HasMaxLength(50);
            entity.Property(e => e.HeaderName).HasMaxLength(50);
            entity.Property(e => e.IsPrimaryKey).HasColumnName("isPrimaryKey");
            entity.Property(e => e.OptionsPrimaryKey).HasMaxLength(50);
            entity.Property(e => e.OptionsPropertyToDisplay).HasMaxLength(50);
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<Movie>(entity =>
        {
            entity.ToTable("Movie");

            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Person");

            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.Name)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("name");
        });

        modelBuilder.Entity<Screen>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Screen");

            entity.Property(e => e.ColumnsUrl)
                .HasMaxLength(150)
                .HasColumnName("ColumnsURL");
            entity.Property(e => e.ComboDisplayField)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.DefaultScreenId).HasColumnName("DefaultScreenID");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.RowsUrl)
                .HasMaxLength(50)
                .HasColumnName("RowsURL");
            entity.Property(e => e.ScreenName).HasMaxLength(50);
            entity.Property(e => e.ScreenParentId).HasColumnName("ScreenParentID");
        });

        modelBuilder.Entity<Setting>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Url)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("URL");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
