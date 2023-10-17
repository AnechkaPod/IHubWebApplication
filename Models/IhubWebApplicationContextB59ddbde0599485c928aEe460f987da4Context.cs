using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace IHubWebApplication.Models;

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

    public virtual DbSet<HgdrMatbea> HgdrMatbeas { get; set; }

    public virtual DbSet<HgdrNech> HgdrNeches { get; set; }

    public virtual DbSet<HgdrTatAfik> HgdrTatAfiks { get; set; }

    public virtual DbSet<Map> Maps { get; set; }

    public virtual DbSet<Movie> Movies { get; set; }

    public virtual DbSet<Person> People { get; set; }

    public virtual DbSet<Screen> Screens { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-6KCUQP6\\SQLEXPRESS;Database=IHubWebApplicationContext-b59ddbde-0599-485c-928a-ee460f987da4;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<HgdrBank>(entity =>
        {
            entity.ToTable("Hgdr_Bank");

            entity.Property(e => e.Id).HasColumnName("ID");
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

        modelBuilder.Entity<HgdrNech>(entity =>
        {
            entity.ToTable("Hgdr_Neches");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.CancelOrderExport).HasColumnName("Cancel_Order_Export");
            entity.Property(e => e.CheshbonYaadDefault).HasColumnName("Cheshbon_Yaad_Default");
            entity.Property(e => e.KodMachsir).HasColumnName("Kod_Machsir");
            entity.Property(e => e.KodMatbea).HasColumnName("Kod_Matbea");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.KodTatAfik).HasColumnName("Kod_TatAfik");
            entity.Property(e => e.Neches).HasMaxLength(250);
            entity.Property(e => e.NechesMisgeretKvua)
                .HasMaxLength(50)
                .HasColumnName("Neches_Misgeret_Kvua");
            entity.Property(e => e.NechesMisgeretMishtana)
                .HasMaxLength(50)
                .HasColumnName("Neches_Misgeret_Mishtana");
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
            entity.Property(e => e.HeaderName).HasMaxLength(50);
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
                .HasMaxLength(50)
                .HasColumnName("ColumnsURL");
            entity.Property(e => e.ComboDisplayField)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.RowsUrl)
                .HasMaxLength(50)
                .HasColumnName("RowsURL");
            entity.Property(e => e.ScreenName).HasMaxLength(50);
            entity.Property(e => e.ScreenParentId).HasColumnName("ScreenParentID");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
