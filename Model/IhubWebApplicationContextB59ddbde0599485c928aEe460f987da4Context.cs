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

    public virtual DbSet<BtzTnuot> BtzTnuots { get; set; }

    public virtual DbSet<HgdrAnaf> HgdrAnafs { get; set; }

    public virtual DbSet<HgdrBank> HgdrBanks { get; set; }

    public virtual DbSet<HgdrBankNech> HgdrBankNeches { get; set; }

    public virtual DbSet<HgdrCheshbon> HgdrCheshbons { get; set; }

    public virtual DbSet<HgdrKarteset> HgdrKartesets { get; set; }

    public virtual DbSet<HgdrMachshir> HgdrMachshirs { get; set; }

    public virtual DbSet<HgdrManpik> HgdrManpiks { get; set; }

    public virtual DbSet<HgdrMatbea> HgdrMatbeas { get; set; }

    public virtual DbSet<HgdrMedina> HgdrMedinas { get; set; }

    public virtual DbSet<HgdrMetafel> HgdrMetafels { get; set; }

    public virtual DbSet<HgdrMutzar> HgdrMutzars { get; set; }

    public virtual DbSet<HgdrMutzarCategory> HgdrMutzarCategories { get; set; }

    public virtual DbSet<HgdrNech> HgdrNeches { get; set; }

    public virtual DbSet<HgdrPitzul> HgdrPitzuls { get; set; }

    public virtual DbSet<HgdrSapak> HgdrSapaks { get; set; }

    public virtual DbSet<HgdrSugCheshbon> HgdrSugCheshbons { get; set; }

    public virtual DbSet<HgdrSugKerenMutzar> HgdrSugKerenMutzars { get; set; }

    public virtual DbSet<HgdrSugMutzar> HgdrSugMutzars { get; set; }

    public virtual DbSet<HgdrTatAfik> HgdrTatAfiks { get; set; }

    public virtual DbSet<HgdrTnua> HgdrTnuas { get; set; }

    public virtual DbSet<HgdrTnutStatus> HgdrTnutStatuses { get; set; }

    public virtual DbSet<Map> Maps { get; set; }

    public virtual DbSet<Movie> Movies { get; set; }

    public virtual DbSet<Person> People { get; set; }

    public virtual DbSet<Screen> Screens { get; set; }

    public virtual DbSet<Setting> Settings { get; set; }

    public virtual DbSet<TbzTnuot> TbzTnuots { get; set; }

    public virtual DbSet<TnutTnuot> TnutTnuots { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=DESKTOP-6KCUQP6\\SQLEXPRESS;Database=IHubWebApplicationContext-b59ddbde-0599-485c-928a-ee460f987da4;Trusted_Connection=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BtzTnuot>(entity =>
        {
            entity.ToTable("BTZ_Tnuot");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AcountId).HasColumnName("Acount_ID");
            entity.Property(e => e.BuyCurrency)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("Buy_Currency");
            entity.Property(e => e.Counterparty).HasMaxLength(50);
            entity.Property(e => e.InsUser)
                .HasMaxLength(50)
                .HasColumnName("Ins_User");
            entity.Property(e => e.IsGilgul).HasColumnName("Is_Gilgul");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.Remarks).HasMaxLength(255);
            entity.Property(e => e.SecurityId)
                .HasMaxLength(50)
                .HasColumnName("Security_ID");
            entity.Property(e => e.SellCurrency)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("Sell_Currency");
            entity.Property(e => e.Shaar).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SibatRechisha)
                .HasMaxLength(50)
                .HasColumnName("Sibat_Rechisha");
            entity.Property(e => e.Strike).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TaarichPeula)
                .HasColumnType("date")
                .HasColumnName("Taarich_Peula");
            entity.Property(e => e.TaarichPika)
                .HasColumnType("date")
                .HasColumnName("Taarich_Pika");

            entity.HasOne(d => d.KodNechesNavigation).WithMany(p => p.BtzTnuots)
                .HasForeignKey(d => d.KodNeches)
                .HasConstraintName("FK_BTZ_Tnuot_Hgdr_Neches");
        });

        modelBuilder.Entity<HgdrAnaf>(entity =>
        {
            entity.ToTable("Hgdr_Anaf");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.KodAnafSnir).HasColumnName("Kod_Anaf_Snir");
            entity.Property(e => e.TeurAnaf)
                .HasMaxLength(50)
                .HasColumnName("Teur_Anaf");
        });

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

        modelBuilder.Entity<HgdrBankNech>(entity =>
        {
            entity.HasKey(e => new { e.KodBank, e.KodNeches, e.MachshirId }).HasName("PK_Hgdr_Bank_Nehes");

            entity.ToTable("Hgdr_Bank_Neches");

            entity.Property(e => e.KodBank).HasColumnName("Kod_Bank");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.MachshirId).HasColumnName("Machshir_ID");
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
            entity.Property(e => e.KodMutzar).HasColumnName("Kod_Mutzar");
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

        modelBuilder.Entity<HgdrKarteset>(entity =>
        {
            entity.ToTable("Hgdr_Karteset");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.DanelKodPratim).HasColumnName("Danel_Kod_Pratim");
            entity.Property(e => e.KodKarteset).HasColumnName("Kod_Karteset");
            entity.Property(e => e.TeurKarteset)
                .HasMaxLength(250)
                .HasColumnName("Teur_Karteset");
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
            entity.Property(e => e.UnderlyingRic)
                .HasMaxLength(50)
                .HasColumnName("UnderlyingRIC");
        });

        modelBuilder.Entity<HgdrMedina>(entity =>
        {
            entity.ToTable("Hgdr_Medina");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.KodMedina).HasColumnName("Kod_Medina");
            entity.Property(e => e.TeurMedina)
                .HasMaxLength(50)
                .HasColumnName("Teur_Medina");
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
            entity.Property(e => e.CheshbonMatach).HasColumnName("Cheshbon_Matach");
            entity.Property(e => e.HarigTsuaYomitFlag).HasColumnName("Harig_Tsua_Yomit_flag");
            entity.Property(e => e.IsKerenMechaka).HasColumnName("Is_Keren_Mechaka");
            entity.Property(e => e.KodKvutzatTikim).HasColumnName("Kod_Kvutzat_Tikim");
            entity.Property(e => e.KodMutzarCategory).HasColumnName("Kod_Mutzar_Category");
            entity.Property(e => e.KodOtzar).HasColumnName("Kod_Otzar");
            entity.Property(e => e.KodSugKeren).HasColumnName("Kod_Sug_Keren");
            entity.Property(e => e.KodSugMutzar).HasColumnName("Kod_Sug_Mutzar");
            entity.Property(e => e.Medina).HasMaxLength(50);
            entity.Property(e => e.Menahel)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.NameForTri)
                .HasMaxLength(100)
                .HasColumnName("Name_For_Tri");
            entity.Property(e => e.NotActive).HasColumnName("Not_Active");

            entity.HasOne(d => d.CheshbonMatachNavigation).WithMany(p => p.HgdrMutzars)
                .HasForeignKey(d => d.CheshbonMatach)
                .HasConstraintName("FK_Hgdr_Mutzar_Hgdr_Cheshbon");

            entity.HasOne(d => d.KodMutzarCategoryNavigation).WithMany(p => p.HgdrMutzars)
                .HasForeignKey(d => d.KodMutzarCategory)
                .HasConstraintName("FK_Hgdr_Mutzar_Hgdr_MutzarCategory");

            entity.HasOne(d => d.KodSugKerenNavigation).WithMany(p => p.InverseKodSugKerenNavigation)
                .HasForeignKey(d => d.KodSugKeren)
                .HasConstraintName("FK_Hgdr_Mutzar_Hgdr_Mutzar");

            entity.HasOne(d => d.KodSugMutzarNavigation).WithMany(p => p.HgdrMutzars)
                .HasForeignKey(d => d.KodSugMutzar)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Hgdr_Mutzar_Hgdr_Sug_Mutzar");

            entity.HasOne(d => d.MetafelNavigation).WithMany(p => p.HgdrMutzars)
                .HasForeignKey(d => d.Metafel)
                .HasConstraintName("FK_Hgdr_Mutzar_Hgdr_Metafel");
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
            entity.Property(e => e.KodBasisHatzmada)
                .HasMaxLength(50)
                .HasColumnName("Kod_BasisHatzmada");
            entity.Property(e => e.KodMachshir).HasColumnName("Kod_Machshir");
            entity.Property(e => e.KodMachshirNb).HasColumnName("Kod_Machshir_NB");
            entity.Property(e => e.KodMatbea).HasColumnName("Kod_Matbea");
            entity.Property(e => e.KodMedinaNischeret).HasColumnName("Kod_Medina_Nischeret");
            entity.Property(e => e.KodMedinatChasifa).HasColumnName("Kod_Medinat_Chasifa");
            entity.Property(e => e.KodTatAfIk).HasColumnName("Kod_Tat_AfIK");
            entity.Property(e => e.Neches).HasMaxLength(250);
            entity.Property(e => e.NechesMisgeretKvua)
                .HasMaxLength(50)
                .HasColumnName("Neches_Misgeret_Kvua");
            entity.Property(e => e.NechesMisgeretMishtana)
                .HasMaxLength(50)
                .HasColumnName("Neches_Misgeret_Mishtana");

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

        modelBuilder.Entity<HgdrPitzul>(entity =>
        {
            entity.HasKey(e => new { e.KodNeches, e.KodMutzar });

            entity.ToTable("Hgdr_Pitzul");

            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.KodMutzar).HasColumnName("Kod_Mutzar");
            entity.Property(e => e.Pitzul).HasColumnType("decimal(19, 18)");
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

        modelBuilder.Entity<HgdrSugKerenMutzar>(entity =>
        {
            entity.HasKey(e => e.KodSugKeren);

            entity.ToTable("Hgdr_Sug_Keren_Mutzar");

            entity.Property(e => e.KodSugKeren)
                .ValueGeneratedNever()
                .HasColumnName("Kod_Sug_Keren");
            entity.Property(e => e.SugKeren)
                .HasMaxLength(50)
                .HasColumnName("Sug_Keren");
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

        modelBuilder.Entity<HgdrTnua>(entity =>
        {
            entity.ToTable("Hgdr_Tnua");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MachpilKamut).HasColumnName("Machpil_Kamut");
            entity.Property(e => e.MachpilShovi).HasColumnName("Machpil_Shovi");
            entity.Property(e => e.TeurTnua)
                .HasMaxLength(50)
                .HasColumnName("Teur_Tnua");
        });

        modelBuilder.Entity<HgdrTnutStatus>(entity =>
        {
            entity.ToTable("Hgdr_Tnut_Status");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Status).HasMaxLength(50);
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

        modelBuilder.Entity<TbzTnuot>(entity =>
        {
            entity.ToTable("TBZ_Tnuot");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AccountId).HasColumnName("Account_ID");
            entity.Property(e => e.SecurityId)
                .HasMaxLength(50)
                .HasColumnName("Security_ID");
        });

        modelBuilder.Entity<TnutTnuot>(entity =>
        {
            entity.ToTable("Tnut_Tnuot");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.ErechNakuv)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Erech_Nakuv");
            entity.Property(e => e.KodBasisHatzmada).HasColumnName("Kod_Basis_Hatzmada");
            entity.Property(e => e.KodKarteset).HasColumnName("Kod_Karteset");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.KodSapak).HasColumnName("Kod_Sapak");
            entity.Property(e => e.KodTnuoa).HasColumnName("Kod_Tnuoa");
            entity.Property(e => e.LoadProcessId).HasColumnName("Load_Process_ID");
            entity.Property(e => e.Shaar).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Shovi).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Taarich).HasColumnType("date");

            entity.HasOne(d => d.KodBasisHatzmadaNavigation).WithMany(p => p.TnutTnuots)
                .HasForeignKey(d => d.KodBasisHatzmada)
                .HasConstraintName("FK_Tnut_Tnuot_Hgdr_Matbea");

            entity.HasOne(d => d.KodKartesetNavigation).WithMany(p => p.TnutTnuots)
                .HasForeignKey(d => d.KodKarteset)
                .HasConstraintName("FK_Tnut_Tnuot_Tnut_Tnuot");

            entity.HasOne(d => d.KodNechesNavigation).WithMany(p => p.TnutTnuots)
                .HasForeignKey(d => d.KodNeches)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Tnut_Tnuot_Hgdr_Neches");

            entity.HasOne(d => d.KodSapakNavigation).WithMany(p => p.TnutTnuots)
                .HasForeignKey(d => d.KodSapak)
                .HasConstraintName("FK_Tnut_Tnuot_Hgdr_Sapak");

            entity.HasOne(d => d.KodTnuoaNavigation).WithMany(p => p.TnutTnuots)
                .HasForeignKey(d => d.KodTnuoa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Tnut_Tnuot_Hgdr_Tnua");

            entity.HasOne(d => d.StatusNavigation).WithMany(p => p.TnutTnuots)
                .HasForeignKey(d => d.Status)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Tnut_Tnuot_Hgdr_Tnut_Status");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
