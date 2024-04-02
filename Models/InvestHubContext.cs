using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace IHubWebApplication.Models;

public partial class InvestHubContext : DbContext
{
    public InvestHubContext()
    {
    }

    public InvestHubContext(DbContextOptions<InvestHubContext> options)
        : base(options)
    {
    }

    public virtual DbSet<BkpMvTkHolding> BkpMvTkHoldings { get; set; }

    public virtual DbSet<BsAllShearim> BsAllShearims { get; set; }

    public virtual DbSet<BtzTnout> BtzTnouts { get; set; }

    public virtual DbSet<Credential> Credentials { get; set; }

    public virtual DbSet<CrmGemelResearch> CrmGemelResearches { get; set; }

    public virtual DbSet<DhyAmlatBroker> DhyAmlatBrokers { get; set; }

    public virtual DbSet<DimTime> DimTimes { get; set; }

    public virtual DbSet<DvchReshimatNechasimMipuy> DvchReshimatNechasimMipuys { get; set; }

    public virtual DbSet<DvchSetting> DvchSettings { get; set; }

    public virtual DbSet<DvchYitra> DvchYitras { get; set; }

    public virtual DbSet<FoGilgulHozim> FoGilgulHozims { get; set; }

    public virtual DbSet<FoHgdrMadad> FoHgdrMadads { get; set; }

    public virtual DbSet<FoHgdrMutzarMadad> FoHgdrMutzarMadads { get; set; }

    public virtual DbSet<FoMonth> FoMonths { get; set; }

    public virtual DbSet<FoTnutTnuot> FoTnutTnuots { get; set; }

    public virtual DbSet<FoUserSetting> FoUserSettings { get; set; }

    public virtual DbSet<FoYaadMutzar> FoYaadMutzars { get; set; }

    public virtual DbSet<FoYear> FoYears { get; set; }

    public virtual DbSet<FoYitrot> FoYitrots { get; set; }

    public virtual DbSet<FoYitrotSetting> FoYitrotSettings { get; set; }

    public virtual DbSet<HgdrAdditionalColumnName> HgdrAdditionalColumnNames { get; set; }

    public virtual DbSet<HgdrAdditionalColumnValue> HgdrAdditionalColumnValues { get; set; }

    public virtual DbSet<HgdrAdditionalDataSheetsFilter> HgdrAdditionalDataSheetsFilters { get; set; }

    public virtual DbSet<HgdrAdditionalDataSugYeshut> HgdrAdditionalDataSugYeshuts { get; set; }

    public virtual DbSet<HgdrAdditionalDatum> HgdrAdditionalData { get; set; }

    public virtual DbSet<HgdrAnaf> HgdrAnafs { get; set; }

    public virtual DbSet<HgdrBank> HgdrBanks { get; set; }

    public virtual DbSet<HgdrBankNech> HgdrBankNeches { get; set; }

    public virtual DbSet<HgdrCheshbon> HgdrCheshbons { get; set; }

    public virtual DbSet<HgdrDerug> HgdrDerugs { get; set; }

    public virtual DbSet<HgdrHieTatAfik> HgdrHieTatAfiks { get; set; }

    public virtual DbSet<HgdrHoliday> HgdrHolidays { get; set; }

    public virtual DbSet<HgdrKarteset> HgdrKartesets { get; set; }

    public virtual DbSet<HgdrKvutzatTikim> HgdrKvutzatTikims { get; set; }

    public virtual DbSet<HgdrMachshir> HgdrMachshirs { get; set; }

    public virtual DbSet<HgdrManpik> HgdrManpiks { get; set; }

    public virtual DbSet<HgdrMatbea> HgdrMatbeas { get; set; }

    public virtual DbSet<HgdrMedina> HgdrMedinas { get; set; }

    public virtual DbSet<HgdrMediniyut> HgdrMediniyuts { get; set; }

    public virtual DbSet<HgdrMetafel> HgdrMetafels { get; set; }

    public virtual DbSet<HgdrMutzar> HgdrMutzars { get; set; }

    public virtual DbSet<HgdrMutzarCategory> HgdrMutzarCategories { get; set; }

    public virtual DbSet<HgdrNech> HgdrNeches { get; set; }

    public virtual DbSet<HgdrNechesCounterParty> HgdrNechesCounterParties { get; set; }

    public virtual DbSet<HgdrPitzul> HgdrPitzuls { get; set; }

    public virtual DbSet<HgdrProcessLoad> HgdrProcessLoads { get; set; }

    public virtual DbSet<HgdrSapak> HgdrSapaks { get; set; }

    public virtual DbSet<HgdrSourceSystem> HgdrSourceSystems { get; set; }

    public virtual DbSet<HgdrSugCheshbon> HgdrSugCheshbons { get; set; }

    public virtual DbSet<HgdrSugKerenMutzar> HgdrSugKerenMutzars { get; set; }

    public virtual DbSet<HgdrSugMadad> HgdrSugMadads { get; set; }

    public virtual DbSet<HgdrSugMutzar> HgdrSugMutzars { get; set; }

    public virtual DbSet<HgdrTatAfik> HgdrTatAfiks { get; set; }

    public virtual DbSet<HgdrTnuot> HgdrTnuots { get; set; }

    public virtual DbSet<HgdrTnutStatus> HgdrTnutStatuses { get; set; }

    public virtual DbSet<HgdrYoetz> HgdrYoetzs { get; set; }

    public virtual DbSet<HmrtCheshbon> HmrtCheshbons { get; set; }

    public virtual DbSet<HmrtNech> HmrtNeches { get; set; }

    public virtual DbSet<HtmTnuotDanel> HtmTnuotDanels { get; set; }

    public virtual DbSet<HtmTnuotPitzulim> HtmTnuotPitzulims { get; set; }

    public virtual DbSet<IndexedViewTnuotRikuzWithPirut> IndexedViewTnuotRikuzWithPiruts { get; set; }

    public virtual DbSet<IndxResponse> IndxResponses { get; set; }

    public virtual DbSet<LoadLog> LoadLogs { get; set; }

    public virtual DbSet<Map> Maps { get; set; }

    public virtual DbSet<Mapping> Mappings { get; set; }

    public virtual DbSet<MappingProfile> MappingProfiles { get; set; }

    public virtual DbSet<MgblAlternative> MgblAlternatives { get; set; }

    public virtual DbSet<MgblExclude> MgblExcludes { get; set; }

    public virtual DbSet<MgblInclude> MgblIncludes { get; set; }

    public virtual DbSet<MrktDatum> MrktData { get; set; }

    public virtual DbSet<MrktField> MrktFields { get; set; }

    public virtual DbSet<MrktMadadim> MrktMadadims { get; set; }

    public virtual DbSet<MvTkHolding> MvTkHoldings { get; set; }

    public virtual DbSet<MvTkHoldingsTik> MvTkHoldingsTiks { get; set; }

    public virtual DbSet<MvTkKvutzot> MvTkKvutzots { get; set; }

    public virtual DbSet<MvTkMigbalot> MvTkMigbalots { get; set; }

    public virtual DbSet<MvTkSugMishkal> MvTkSugMishkals { get; set; }

    public virtual DbSet<MvTkSugModel> MvTkSugModels { get; set; }

    public virtual DbSet<MvTkTikModel> MvTkTikModels { get; set; }

    public virtual DbSet<Screen> Screens { get; set; }

    public virtual DbSet<Setting> Settings { get; set; }

    public virtual DbSet<TikEvent> TikEvents { get; set; }

    public virtual DbSet<TikTsua> TikTsuas { get; set; }

    public virtual DbSet<TmpBtzTnout> TmpBtzTnouts { get; set; }

    public virtual DbSet<TmpDvchDatum> TmpDvchData { get; set; }

    public virtual DbSet<TmpHgdrManpik> TmpHgdrManpiks { get; set; }

    public virtual DbSet<TmpHgdrNech> TmpHgdrNeches { get; set; }

    public virtual DbSet<TmpHgdrTatAfik> TmpHgdrTatAfiks { get; set; }

    public virtual DbSet<TmpMrktDatum> TmpMrktData { get; set; }

    public virtual DbSet<TmpMvTkMigbalot> TmpMvTkMigbalots { get; set; }

    public virtual DbSet<TmpShearim> TmpShearims { get; set; }

    public virtual DbSet<TmpTazrim> TmpTazrims { get; set; }

    public virtual DbSet<TmpTikTsua> TmpTikTsuas { get; set; }

    public virtual DbSet<TmpTnuot> TmpTnuots { get; set; }

    public virtual DbSet<TmpTnuotGrouped> TmpTnuotGroupeds { get; set; }

    public virtual DbSet<TmpUpdateShaarIska> TmpUpdateShaarIskas { get; set; }

    public virtual DbSet<TmpYpYomi> TmpYpYomis { get; set; }

    public virtual DbSet<TnutPitzulim> TnutPitzulims { get; set; }

    public virtual DbSet<TnutRpaVerification> TnutRpaVerifications { get; set; }

    public virtual DbSet<TnutStatusLog> TnutStatusLogs { get; set; }

    public virtual DbSet<TnutTnuot> TnutTnuots { get; set; }

    public virtual DbSet<UserProfile> UserProfiles { get; set; }

    public virtual DbSet<UserProfilesScreen> UserProfilesScreens { get; set; }

    public virtual DbSet<UserScreen> UserScreens { get; set; }

    public virtual DbSet<UserUser> UserUsers { get; set; }

    public virtual DbSet<VAdditionalDataFinalFlat> VAdditionalDataFinalFlats { get; set; }

    public virtual DbSet<VAdditionalDataFinalYeshut> VAdditionalDataFinalYeshuts { get; set; }

    public virtual DbSet<VAdditionalDataRaw> VAdditionalDataRaws { get; set; }

    public virtual DbSet<VAdditionalDatum> VAdditionalData { get; set; }

    public virtual DbSet<VBkpMvTk> VBkpMvTks { get; set; }

    public virtual DbSet<VBtzTnout> VBtzTnouts { get; set; }

    public virtual DbSet<VCheshbonDetail> VCheshbonDetails { get; set; }

    public virtual DbSet<VDhyAmlotBroker> VDhyAmlotBrokers { get; set; }

    public virtual DbSet<VDimMatbea> VDimMatbeas { get; set; }

    public virtual DbSet<VDimMutzar> VDimMutzars { get; set; }

    public virtual DbSet<VDimNech> VDimNeches { get; set; }

    public virtual DbSet<VDimTime> VDimTimes { get; set; }

    public virtual DbSet<VDimTimeTrade> VDimTimeTrades { get; set; }

    public virtual DbSet<VDvchAfikHashkaaMuvtachTsua> VDvchAfikHashkaaMuvtachTsuas { get; set; }

    public virtual DbSet<VDvchAgach> VDvchAgaches { get; set; }

    public virtual DbSet<VDvchAgachLoSachir> VDvchAgachLoSachirs { get; set; }

    public virtual DbSet<VDvchAgachMemshalti> VDvchAgachMemshaltis { get; set; }

    public virtual DbSet<VDvchAgachMemshaltiLoSachir> VDvchAgachMemshaltiLoSachirs { get; set; }

    public virtual DbSet<VDvchAgachMiuadotLoSachir> VDvchAgachMiuadotLoSachirs { get; set; }

    public virtual DbSet<VDvchAllDatum> VDvchAllData { get; set; }

    public virtual DbSet<VDvchHashkaotBeChavarotMuchzakot> VDvchHashkaotBeChavarotMuchzakots { get; set; }

    public virtual DbSet<VDvchHozim> VDvchHozims { get; set; }

    public virtual DbSet<VDvchKranotNemanut> VDvchKranotNemanuts { get; set; }

    public virtual DbSet<VDvchKranotSal> VDvchKranotSals { get; set; }

    public virtual DbSet<VDvchKtavOpt> VDvchKtavOpts { get; set; }

    public virtual DbSet<VDvchKtavOptLoSachir> VDvchKtavOptLoSachirs { get; set; }

    public virtual DbSet<VDvchLoSachirNigzarimOther> VDvchLoSachirNigzarimOthers { get; set; }

    public virtual DbSet<VDvchLoan> VDvchLoans { get; set; }

    public virtual DbSet<VDvchMezuman> VDvchMezumen { get; set; }

    public virtual DbSet<VDvchMisgeretAshrai> VDvchMisgeretAshrais { get; set; }

    public virtual DbSet<VDvchMutzarMuvne> VDvchMutzarMuvnes { get; set; }

    public virtual DbSet<VDvchMutzarMuvneLoSachir> VDvchMutzarMuvneLoSachirs { get; set; }

    public virtual DbSet<VDvchNaam> VDvchNaams { get; set; }

    public virtual DbSet<VDvchNaamLoSachir> VDvchNaamLoSachirs { get; set; }

    public virtual DbSet<VDvchNadlan> VDvchNadlans { get; set; }

    public virtual DbSet<VDvchNechasimOther> VDvchNechasimOthers { get; set; }

    public virtual DbSet<VDvchNechesProperty> VDvchNechesProperties { get; set; }

    public virtual DbSet<VDvchOption> VDvchOptions { get; set; }

    public virtual DbSet<VDvchOptionsLoSachir> VDvchOptionsLoSachirs { get; set; }

    public virtual DbSet<VDvchPe> VDvchPes { get; set; }

    public virtual DbSet<VDvchPikdonot> VDvchPikdonots { get; set; }

    public virtual DbSet<VDvchStock> VDvchStocks { get; set; }

    public virtual DbSet<VDvchStocksLoSachir> VDvchStocksLoSachirs { get; set; }

    public virtual DbSet<VDvchYitrotHitchayvutLeHashkaa> VDvchYitrotHitchayvutLeHashkaas { get; set; }

    public virtual DbSet<VFctTazrim> VFctTazrims { get; set; }

    public virtual DbSet<VFctYitrot> VFctYitrots { get; set; }

    public virtual DbSet<VFoAchzakotHozim> VFoAchzakotHozims { get; set; }

    public virtual DbSet<VFoBakaratManpik> VFoBakaratManpiks { get; set; }

    public virtual DbSet<VFoExportGilgulLeumi> VFoExportGilgulLeumis { get; set; }

    public virtual DbSet<VFoExportGoldman> VFoExportGoldmen { get; set; }

    public virtual DbSet<VFoExportIshur> VFoExportIshurs { get; set; }

    public virtual DbSet<VFoExportIshurTnuot> VFoExportIshurTnuots { get; set; }

    public virtual DbSet<VFoExportLeumi> VFoExportLeumis { get; set; }

    public virtual DbSet<VFoExportMerakez> VFoExportMerakezs { get; set; }

    public virtual DbSet<VFoHishuvim> VFoHishuvims { get; set; }

    public virtual DbSet<VFoNechasim> VFoNechasims { get; set; }

    public virtual DbSet<VFoSheariMatbea> VFoSheariMatbeas { get; set; }

    public virtual DbSet<VFoShearim> VFoShearims { get; set; }

    public virtual DbSet<VFoTichnunPeilut> VFoTichnunPeiluts { get; set; }

    public virtual DbSet<VFoYaadim> VFoYaadims { get; set; }

    public virtual DbSet<VFoYitrotSnir> VFoYitrotSnirs { get; set; }

    public virtual DbSet<VHgdrManpikFromTmp> VHgdrManpikFromTmps { get; set; }

    public virtual DbSet<VHgdrNechesFromTmp> VHgdrNechesFromTmps { get; set; }

    public virtual DbSet<VHgdrTatAfikFromTmp> VHgdrTatAfikFromTmps { get; set; }

    public virtual DbSet<VHmrtCheshbon> VHmrtCheshbons { get; set; }

    public virtual DbSet<VHmrtNech> VHmrtNeches { get; set; }

    public virtual DbSet<VLoadLog> VLoadLogs { get; set; }

    public virtual DbSet<VMrktDataDanelMadad> VMrktDataDanelMadads { get; set; }

    public virtual DbSet<VMrktDataDanelMatach> VMrktDataDanelMataches { get; set; }

    public virtual DbSet<VMrktDatum> VMrktData { get; set; }

    public virtual DbSet<VMutzarCheshbon> VMutzarCheshbons { get; set; }

    public virtual DbSet<VMvTk> VMvTks { get; set; }

    public virtual DbSet<VMvTkDmeiNihul> VMvTkDmeiNihuls { get; set; }

    public virtual DbSet<VMvTkDwh> VMvTkDwhs { get; set; }

    public virtual DbSet<VMvTkHolding> VMvTkHoldings { get; set; }

    public virtual DbSet<VMvTkHoldingsLvl1> VMvTkHoldingsLvl1s { get; set; }

    public virtual DbSet<VMvTkHoldingsLvl2> VMvTkHoldingsLvl2s { get; set; }

    public virtual DbSet<VMvTkMatach> VMvTkMataches { get; set; }

    public virtual DbSet<VMvTkMigbalot> VMvTkMigbalots { get; set; }

    public virtual DbSet<VMvTkMivne> VMvTkMivnes { get; set; }

    public virtual DbSet<VMvTkNechesProperty> VMvTkNechesProperties { get; set; }

    public virtual DbSet<VMvtkHistoryDiff> VMvtkHistoryDiffs { get; set; }

    public virtual DbSet<VPitzul> VPitzuls { get; set; }

    public virtual DbSet<VRpaMemshakShovi> VRpaMemshakShovis { get; set; }

    public virtual DbSet<VSwapDetail> VSwapDetails { get; set; }

    public virtual DbSet<VTikTsuaHarig> VTikTsuaHarigs { get; set; }

    public virtual DbSet<VTikTsuaHarigMonthly> VTikTsuaHarigMonthlies { get; set; }

    public virtual DbSet<VTnuot> VTnuots { get; set; }

    public virtual DbSet<VTnuotBankLeumiIl> VTnuotBankLeumiIls { get; set; }

    public virtual DbSet<VTnuotBankLeumiMatach> VTnuotBankLeumiMataches { get; set; }

    public virtual DbSet<VTnuotExport> VTnuotExports { get; set; }

    public virtual DbSet<VTnuotIshur> VTnuotIshurs { get; set; }

    public virtual DbSet<VTnuotMetafel> VTnuotMetafels { get; set; }

    public virtual DbSet<VTnuotNoa> VTnuotNoas { get; set; }

    public virtual DbSet<VTnuotOrder> VTnuotOrders { get; set; }

    public virtual DbSet<VTnuotRikuz> VTnuotRikuzs { get; set; }

    public virtual DbSet<VTnuotRikuzWithCheshbonot> VTnuotRikuzWithCheshbonots { get; set; }

    public virtual DbSet<VTnuotRikuzWithPirut> VTnuotRikuzWithPiruts { get; set; }

    public virtual DbSet<VTnuotRpa> VTnuotRpas { get; set; }

    public virtual DbSet<VTnuotStatusLog> VTnuotStatusLogs { get; set; }

    public virtual DbSet<VTradeDate> VTradeDates { get; set; }

    public virtual DbSet<VUsersWithProfile> VUsersWithProfiles { get; set; }

    public virtual DbSet<VYpdoch> VYpdoches { get; set; }

    public virtual DbSet<VYpdochDailyHol> VYpdochDailyHols { get; set; }

    public virtual DbSet<VYtrSnir> VYtrSnirs { get; set; }

    public virtual DbSet<YpDanelPizulim> YpDanelPizulims { get; set; }

    public virtual DbSet<YpDanelTnout> YpDanelTnouts { get; set; }

    public virtual DbSet<YpYomi> YpYomis { get; set; }

    public virtual DbSet<YtrBank> YtrBanks { get; set; }

    public virtual DbSet<YtrSnir> YtrSnirs { get; set; }

    public virtual DbSet<YtrTazrim> YtrTazrims { get; set; }

//    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//        => optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS01;Database=Invest_Hub;Integrated Security=true;TrustServerCertificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BkpMvTkHolding>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Bkp_MvTk_Holdings");

            entity.Property(e => e.DateTime).HasColumnType("datetime");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.KodSugMishkal).HasColumnName("Kod_Sug_Mishkal");
            entity.Property(e => e.KodSugModel).HasColumnName("Kod_Sug_Model");
            entity.Property(e => e.KodTikModel)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Kod_Tik_Model");
            entity.Property(e => e.Mishkal).HasColumnType("decimal(5, 4)");
            entity.Property(e => e.Remark).HasMaxLength(50);
        });

        modelBuilder.Entity<BsAllShearim>(entity =>
        {
            entity.HasKey(e => new { e.Date, e.Source, e.KodNeches });

            entity.ToTable("BS_AllShearim");

            entity.Property(e => e.Date).HasColumnType("date");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.Neches).HasMaxLength(250);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.PriceYadani)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("Price_Yadani");
            entity.Property(e => e.TaarichIdkunYadani)
                .HasColumnType("date")
                .HasColumnName("Taarich_Idkun_Yadani");

            entity.HasOne(d => d.SourceNavigation).WithMany(p => p.BsAllShearims)
                .HasForeignKey(d => d.Source)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_BS_AllShearim_Hgdr_SourceSystem");
        });

        modelBuilder.Entity<BtzTnout>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BTZ_Tnout");

            entity.Property(e => e.AccountId).HasColumnName("Account_ID");
            entity.Property(e => e.BuyCurrency)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("Buy_Currency");
            entity.Property(e => e.Counterparty).HasMaxLength(50);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.InsUser)
                .HasMaxLength(50)
                .HasColumnName("Ins_User");
            entity.Property(e => e.IsGilgul).HasColumnName("Is_Gilgul");
            entity.Property(e => e.KodMutzar)
                .HasMaxLength(50)
                .HasColumnName("Kod_Mutzar");
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
            entity.Property(e => e.SibatRechisha).HasColumnName("Sibat_Rechisha");
            entity.Property(e => e.Strike).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.TaarichPeula)
                .HasColumnType("date")
                .HasColumnName("Taarich_Peula");
            entity.Property(e => e.TaarichPkia)
                .HasColumnType("date")
                .HasColumnName("Taarich_Pkia");
        });

        modelBuilder.Entity<Credential>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Domain).HasMaxLength(50);
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        modelBuilder.Entity<CrmGemelResearch>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CRM_GemelResearch");

            entity.Property(e => e.GenDebtclassificationgemel).HasColumnName("gen_debtclassificationgemel");
            entity.Property(e => e.GenDescription)
                .HasMaxLength(255)
                .IsFixedLength()
                .HasColumnName("gen_description");
            entity.Property(e => e.GenIsin)
                .HasMaxLength(100)
                .HasColumnName("gen_isin");
            entity.Property(e => e.GenNextanalysisdategemel)
                .HasColumnType("datetime")
                .HasColumnName("gen_nextanalysisdategemel");
            entity.Property(e => e.GenNumber)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("gen_number");
            entity.Property(e => e.GenSubject).HasColumnName("gen_subject");
            entity.Property(e => e.GenUpdatedon)
                .HasColumnType("datetime")
                .HasColumnName("gen_updatedon");
        });

        modelBuilder.Entity<DhyAmlatBroker>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DHY_Amlat_Broker");

            entity.Property(e => e.Broker).HasMaxLength(50);
            entity.Property(e => e.Cheshbon).HasMaxLength(50);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.KodCheshbon)
                .HasMaxLength(50)
                .HasColumnName("Kod_Cheshbon");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.Matbea).HasMaxLength(50);
            entity.Property(e => e.Neches).HasMaxLength(50);
            entity.Property(e => e.Shovi).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TaarichErech)
                .HasColumnType("date")
                .HasColumnName("Taarich_Erech");
        });

        modelBuilder.Entity<DimTime>(entity =>
        {
            entity.HasKey(e => e.TaarichId);

            entity.ToTable("DIM_Time");

            entity.Property(e => e.TaarichId)
                .HasColumnType("date")
                .HasColumnName("Taarich_ID");
            entity.Property(e => e.Chodesh)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Rivon)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Shana)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Yom)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<DvchReshimatNechasimMipuy>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Dvch_ReshimatNechasim_Mipuy");

            entity.Property(e => e.IdDvchSheet).HasColumnName("ID_DvchSheet");
            entity.Property(e => e.IdMachshir).HasColumnName("ID_Machshir");
            entity.Property(e => e.IdSchirut).HasColumnName("ID_Schirut");

            entity.HasOne(d => d.IdMachshirNavigation).WithMany()
                .HasForeignKey(d => d.IdMachshir)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Dvch_ReshimatNechasim_Mipuy_Hgdr_Machshir");
        });

        modelBuilder.Entity<DvchSetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Dvch_Settings");

            entity.Property(e => e.DvchId).HasColumnName("DvchID");
            entity.Property(e => e.TaarichHafaka).HasColumnType("date");
        });

        modelBuilder.Entity<DvchYitra>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Dvch_Yitra");

            entity.Property(e => e.AchuzRibitShnatit)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("Achuz_Ribit_Shnatit");
            entity.Property(e => e.Chasifa).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ChasifaMatbea)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Chasifa_Matbea");
            entity.Property(e => e.ChevraMedareget)
                .HasMaxLength(50)
                .HasColumnName("Chevra_Medareget");
            entity.Property(e => e.Derug).HasMaxLength(50);
            entity.Property(e => e.DmeiNihul)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("Dmei_Nihul");
            entity.Property(e => e.GodelKerenPe)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("Godel_Keren_PE");
            entity.Property(e => e.HitchayvutEndDate)
                .HasColumnType("datetime")
                .HasColumnName("Hitchayvut_End_Date");
            entity.Property(e => e.HitchayvutMekorit)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("Hitchayvut_Mekorit");
            entity.Property(e => e.HitchayvutStartDate)
                .HasColumnType("datetime")
                .HasColumnName("Hitchayvut_Start_Date");
            entity.Property(e => e.HonNifra)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("Hon_Nifra");
            entity.Property(e => e.Isin)
                .HasMaxLength(50)
                .HasColumnName("ISIN");
            entity.Property(e => e.Kamut).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.KodAnaf).HasColumnName("Kod_Anaf");
            entity.Property(e => e.KodBank).HasColumnName("Kod_Bank");
            entity.Property(e => e.KodBasisHatzmada)
                .HasMaxLength(50)
                .HasColumnName("Kod_BasisHatzmada");
            entity.Property(e => e.KodBasisHatzmadaNegative)
                .HasMaxLength(100)
                .HasColumnName("Kod_BasisHatzmada_Negative");
            entity.Property(e => e.KodCheshbon)
                .HasMaxLength(50)
                .HasColumnName("Kod_Cheshbon");
            entity.Property(e => e.KodHieTatAfik1).HasColumnName("Kod_Hie_TatAfik1");
            entity.Property(e => e.KodMachshir).HasColumnName("Kod_Machshir");
            entity.Property(e => e.KodManpik).HasColumnName("Kod_Manpik");
            entity.Property(e => e.KodMatbea)
                .HasMaxLength(50)
                .HasColumnName("Kod_Matbea");
            entity.Property(e => e.KodMutzar).HasColumnName("Kod_Mutzar");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.KodRibitOgen)
                .HasMaxLength(50)
                .HasColumnName("Kod_Ribit_Ogen");
            entity.Property(e => e.KodSugYitra).HasColumnName("Kod_Sug_Yitra");
            entity.Property(e => e.KodTatAfik).HasColumnName("Kod_TatAfik");
            entity.Property(e => e.Macham).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Mutzar).HasMaxLength(50);
            entity.Property(e => e.Nav)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("NAV");
            entity.Property(e => e.Shaar).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.ShaarIska).HasColumnName("Shaar_Iska");
            entity.Property(e => e.ShaarMatbeaHatzmada)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("Shaar_Matbea_Hatzmada");
            entity.Property(e => e.ShaarMatbeaMakor)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("Shaar_Matbea_Makor");
            entity.Property(e => e.ShaarNbIska).HasColumnName("ShaarNB_Iska");
            entity.Property(e => e.ShaarRibitOgen)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("Shaar_Ribit_Ogen");
            entity.Property(e => e.Shovi).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ShoviMatbeaMakor)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Shovi_Matbea_Makor");
            entity.Property(e => e.SnirNechesId).HasColumnName("Snir_Neches_ID");
            entity.Property(e => e.Taarich).HasColumnType("date");
            entity.Property(e => e.TaarichHanpaka)
                .HasColumnType("date")
                .HasColumnName("Taarich_Hanpaka");
            entity.Property(e => e.TaarichPidyonAcharon)
                .HasColumnType("date")
                .HasColumnName("Taarich_Pidyon_Acharon");
            entity.Property(e => e.TaarichPkia)
                .HasColumnType("date")
                .HasColumnName("Taarich_Pkia");
            entity.Property(e => e.TaarichRechisha)
                .HasColumnType("date")
                .HasColumnName("Taarich_Rechisha");
            entity.Property(e => e.TaarichShiaruchAcharon)
                .HasColumnType("date")
                .HasColumnName("Taarich_Shiaruch_Acharon");
            entity.Property(e => e.TatAnaf)
                .HasMaxLength(250)
                .HasColumnName("Tat_Anaf");
            entity.Property(e => e.Ticker).HasMaxLength(50);
            entity.Property(e => e.Tik).HasMaxLength(50);
            entity.Property(e => e.TnayPiraon).HasColumnName("Tnay_Piraon");
            entity.Property(e => e.TsuaLePidyon)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("Tsua_LePidyon");
            entity.Property(e => e.YitratHitchayvut)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("Yitrat_Hitchayvut");
            entity.Property(e => e.ZadKashur).HasColumnName("Zad_Kashur");
            entity.Property(e => e.ZiratMishar)
                .HasMaxLength(250)
                .HasColumnName("Zirat_Mishar");
        });

        modelBuilder.Entity<FoGilgulHozim>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FO_Gilgul_Hozim");

            entity.Property(e => e.TickerAfter)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Ticker_After");
            entity.Property(e => e.TickerBefore)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Ticker_Before");
        });

        modelBuilder.Entity<FoHgdrMadad>(entity =>
        {
            entity.HasKey(e => e.IdMadad).HasName("PK_Hgdr_Madad");

            entity.ToTable("FO_Hgdr_Madad");

            entity.Property(e => e.IdMadad).HasColumnName("ID_Madad");
            entity.Property(e => e.IdSugMadad).HasColumnName("ID_Sug_Madad");
            entity.Property(e => e.MachshirNb).HasColumnName("Machshir_NB");
            entity.Property(e => e.SwapNb)
                .HasMaxLength(50)
                .HasColumnName("Swap_NB");
            entity.Property(e => e.TeurMadad)
                .HasMaxLength(50)
                .HasColumnName("Teur_Madad");

            entity.HasOne(d => d.IdSugMadadNavigation).WithMany(p => p.FoHgdrMadads)
                .HasForeignKey(d => d.IdSugMadad)
                .HasConstraintName("FK_Hgdr_Madad_Hgdr_Sug_Madad");

            entity.HasOne(d => d.MachshirNbNavigation).WithMany(p => p.FoHgdrMadads)
                .HasForeignKey(d => d.MachshirNb)
                .HasConstraintName("FK_Hgdr_Madad_Hgdr_Machshir");

            entity.HasOne(d => d.MatbeaNavigation).WithMany(p => p.FoHgdrMadads)
                .HasForeignKey(d => d.Matbea)
                .HasConstraintName("FK_Hgdr_Madad_Hgdr_Matbea");

            entity.HasOne(d => d.SwapNbNavigation).WithMany(p => p.FoHgdrMadads)
                .HasForeignKey(d => d.SwapNb)
                .HasConstraintName("FK_FO_Hgdr_Madad_Hgdr_Neches");
        });

        modelBuilder.Entity<FoHgdrMutzarMadad>(entity =>
        {
            entity.HasKey(e => new { e.IdMadad, e.KodMutzarCategory }).HasName("PK_Hgdr_Mutzar_Madad");

            entity.ToTable("FO_Hgdr_Mutzar_Madad");

            entity.Property(e => e.IdMadad).HasColumnName("ID_Madad");
            entity.Property(e => e.KodMutzarCategory).HasColumnName("Kod_Mutzar_Category");
            entity.Property(e => e.YaadChasifa)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("Yaad_Chasifa");

            entity.HasOne(d => d.IdMadadNavigation).WithMany(p => p.FoHgdrMutzarMadads)
                .HasForeignKey(d => d.IdMadad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Hgdr_Mutzar_Madad_Hgdr_Madad");

            entity.HasOne(d => d.KodMutzarCategoryNavigation).WithMany(p => p.FoHgdrMutzarMadads)
                .HasForeignKey(d => d.KodMutzarCategory)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Hgdr_Mutzar_Madad_Hgdr_MutzarCategory");
        });

        modelBuilder.Entity<FoMonth>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FO_Months");

            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<FoTnutTnuot>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Hgdr_Tnuot_Derivatives");

            entity.ToTable("FO_Tnut_Tnuot");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.AchuzHasifaRazoi)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Achuz_Hasifa_Razoi");
            entity.Property(e => e.AchuzHasifaRazoiEtf)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Achuz_Hasifa_Razoi_Etf");
            entity.Property(e => e.AchuzHasifaRazoiFutures)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Achuz_Hasifa_Razoi_Futures");
            entity.Property(e => e.CounterParty).HasColumnName("Counter Party");
            entity.Property(e => e.ErechNakuv)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Erech_Nakuv");
            entity.Property(e => e.KodCheshbon).HasColumnName("Kod_Cheshbon");
            entity.Property(e => e.MadadId).HasColumnName("Madad_ID");
            entity.Property(e => e.Taarich).HasColumnType("date");
            entity.Property(e => e.TaarichYitrot)
                .HasColumnType("date")
                .HasColumnName("Taarich_Yitrot");
            entity.Property(e => e.Ticker).HasMaxLength(50);
            entity.Property(e => e.User)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<FoUserSetting>(entity =>
        {
            entity.ToTable("FO_User_Settings");

            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<FoYaadMutzar>(entity =>
        {
            entity.HasKey(e => new { e.KodMutzar, e.IdMadad });

            entity.ToTable("FO_Yaad_Mutzar");

            entity.Property(e => e.KodMutzar).HasColumnName("Kod_Mutzar");
            entity.Property(e => e.IdMadad).HasColumnName("ID_Madad");
            entity.Property(e => e.YaadChasifa)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("Yaad_Chasifa");

            entity.HasOne(d => d.IdMadadNavigation).WithMany(p => p.FoYaadMutzars)
                .HasForeignKey(d => d.IdMadad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FO_Yaad_Mutzar_FO_Hgdr_Madad");

            entity.HasOne(d => d.KodMutzarNavigation).WithMany(p => p.FoYaadMutzars)
                .HasForeignKey(d => d.KodMutzar)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_FO_Yaad_Mutzar_Hgdr_Mutzar");

            entity.HasOne(d => d.MutzarCategoryNavigation).WithMany(p => p.FoYaadMutzars)
                .HasForeignKey(d => d.MutzarCategory)
                .HasConstraintName("FK_FO_Yaad_Mutzar_Hgdr_MutzarCategory");
        });

        modelBuilder.Entity<FoYear>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FO_Year");

            entity.Property(e => e.Code)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Year)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<FoYitrot>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FO_Yitrot");

            entity.Property(e => e.Chasifa).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ChasifaMatbea)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Chasifa_Matbea");
            entity.Property(e => e.DmeiNihul)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("Dmei_Nihul");
            entity.Property(e => e.Kamut).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.KodBank)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Kod_Bank");
            entity.Property(e => e.KodBasisHatzmada)
                .HasMaxLength(50)
                .HasColumnName("Kod_BasisHatzmada");
            entity.Property(e => e.KodBasisHatzmadaNegative)
                .HasMaxLength(100)
                .HasColumnName("Kod_BasisHatzmada_Negative");
            entity.Property(e => e.KodCheshbon)
                .HasMaxLength(50)
                .HasColumnName("Kod_Cheshbon");
            entity.Property(e => e.KodHieTatAfik1).HasColumnName("Kod_Hie_TatAfik1");
            entity.Property(e => e.KodMachshir).HasColumnName("Kod_Machshir");
            entity.Property(e => e.KodManpik).HasColumnName("Kod_Manpik");
            entity.Property(e => e.KodMutzar).HasColumnName("Kod_Mutzar");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.KodSugYitra).HasColumnName("Kod_Sug_Yitra");
            entity.Property(e => e.KodTatAfik).HasColumnName("Kod_TatAfik");
            entity.Property(e => e.LoadProcessId).HasColumnName("LoadProcessID");
            entity.Property(e => e.Macham).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Mutzar).HasMaxLength(50);
            entity.Property(e => e.Neches).HasMaxLength(1000);
            entity.Property(e => e.Shaar).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.ShaarMatbeaMakor)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("Shaar_Matbea_Makor");
            entity.Property(e => e.Shovi).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Snif)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.SnirNechesId).HasColumnName("Snir_Neches_ID");
            entity.Property(e => e.SugYitraSal).HasColumnName("Sug_Yitra_Sal");
            entity.Property(e => e.Taarich).HasColumnType("date");
            entity.Property(e => e.TaarichPkia)
                .HasColumnType("date")
                .HasColumnName("Taarich_Pkia");
            entity.Property(e => e.Tik).HasMaxLength(50);
        });

        modelBuilder.Entity<FoYitrotSetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FO_Yitrot_Settings");

            entity.Property(e => e.QueryDescription).HasMaxLength(50);
            entity.Property(e => e.SourceDb)
                .HasMaxLength(50)
                .HasColumnName("SourceDB");
            entity.Property(e => e.SourceServer).HasMaxLength(50);
        });

        modelBuilder.Entity<HgdrAdditionalColumnName>(entity =>
        {
            entity.HasKey(e => e.ColumnId).HasName("PK_Hgdr_AdditionalColumnName_1");

            entity.ToTable("Hgdr_AdditionalColumnName");

            entity.Property(e => e.ColumnId).HasColumnName("ColumnID");
            entity.Property(e => e.ColumnName).HasMaxLength(50);
        });

        modelBuilder.Entity<HgdrAdditionalColumnValue>(entity =>
        {
            entity.HasKey(e => e.ValueId).HasName("PK_Hgdr_AdditionalColumnValue_1");

            entity.ToTable("Hgdr_AdditionalColumnValue");

            entity.Property(e => e.ValueId).HasColumnName("ValueID");
            entity.Property(e => e.ColumnId).HasColumnName("ColumnID");
            entity.Property(e => e.Value).HasMaxLength(100);

            entity.HasOne(d => d.Column).WithMany(p => p.HgdrAdditionalColumnValues)
                .HasForeignKey(d => d.ColumnId)
                .HasConstraintName("FK_Hgdr_AdditionalColumnValue_Hgdr_AdditionalColumnName1");
        });

        modelBuilder.Entity<HgdrAdditionalDataSheetsFilter>(entity =>
        {
            entity.HasKey(e => e.SheetId);

            entity.ToTable("Hgdr_AdditionalData_SheetsFilter");

            entity.Property(e => e.SheetId)
                .ValueGeneratedNever()
                .HasColumnName("SheetID");
            entity.Property(e => e.KodMachshir).HasColumnName("Kod_Machshir");
            entity.Property(e => e.SheetName)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<HgdrAdditionalDataSugYeshut>(entity =>
        {
            entity.HasKey(e => e.KodSugYeshut);

            entity.ToTable("Hgdr_AdditionalData_SugYeshut");

            entity.Property(e => e.KodSugYeshut).ValueGeneratedNever();
            entity.Property(e => e.SugYeshut).HasMaxLength(50);
        });

        modelBuilder.Entity<HgdrAdditionalDatum>(entity =>
        {
            entity.HasKey(e => new { e.KodSugYeshut, e.KodYeshut, e.ColumnId });

            entity.ToTable("Hgdr_AdditionalData");

            entity.Property(e => e.KodYeshut).HasMaxLength(50);
            entity.Property(e => e.ColumnId).HasColumnName("ColumnID");
            entity.Property(e => e.ValueDate).HasColumnType("date");
            entity.Property(e => e.ValueId).HasColumnName("ValueID");
            entity.Property(e => e.ValueInt).HasColumnType("decimal(28, 4)");
            entity.Property(e => e.ValueString).HasMaxLength(250);

            entity.HasOne(d => d.Column).WithMany(p => p.HgdrAdditionalData)
                .HasForeignKey(d => d.ColumnId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Hgdr_AdditionalData_Hgdr_AdditionalColumnName");

            entity.HasOne(d => d.KodSugYeshutNavigation).WithMany(p => p.HgdrAdditionalData)
                .HasForeignKey(d => d.KodSugYeshut)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Hgdr_AdditionalData_Hgdr_AdditionalData_SugYeshut");
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
            entity.Property(e => e.Bank).HasMaxLength(100);
            entity.Property(e => e.CounterPartyName)
                .HasMaxLength(50)
                .HasColumnName("Counter Party Name");
            entity.Property(e => e.DivuachIdentifier).HasMaxLength(50);
            entity.Property(e => e.KodBroker).HasColumnName("Kod_Broker");
            entity.Property(e => e.KodChaverBursa).HasColumnName("Kod_Chaver_Bursa");
            entity.Property(e => e.KodManpik).HasColumnName("Kod_Manpik");
            entity.Property(e => e.TeurChaverBursaPoalim)
                .HasMaxLength(50)
                .HasColumnName("Teur_Chaver_Bursa_Poalim");
        });

        modelBuilder.Entity<HgdrBankNech>(entity =>
        {
            entity.HasKey(e => new { e.KodBank, e.KodNeches, e.MachshirId });

            entity.ToTable("Hgdr_Bank_Neches");

            entity.Property(e => e.KodBank).HasColumnName("Kod_Bank");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.MachshirId).HasColumnName("Machshir_ID");

            entity.HasOne(d => d.KodBankNavigation).WithMany(p => p.HgdrBankNeches)
                .HasForeignKey(d => d.KodBank)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Hgdr_Bank_Neches_Hgdr_Bank");

            entity.HasOne(d => d.KodNechesNavigation).WithMany(p => p.HgdrBankNeches)
                .HasForeignKey(d => d.KodNeches)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Hgdr_Bank_Neches_Hgdr_Neches");

            entity.HasOne(d => d.Machshir).WithMany(p => p.HgdrBankNeches)
                .HasForeignKey(d => d.MachshirId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Hgdr_Bank_Neches_Hgdr_Machshir");
        });

        modelBuilder.Entity<HgdrCheshbon>(entity =>
        {
            entity.ToTable("Hgdr_Cheshbon");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Aba)
                .HasMaxLength(50)
                .HasColumnName("ABA");
            entity.Property(e => e.Address).HasMaxLength(100);
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
            entity.Property(e => e.ClearingCode)
                .HasMaxLength(50)
                .HasColumnName("Clearing_Code");
            entity.Property(e => e.Correspondent).HasMaxLength(50);
            entity.Property(e => e.CorrespondentAba)
                .HasMaxLength(50)
                .HasColumnName("Correspondent_ABA");
            entity.Property(e => e.CorrespondentBankName)
                .HasMaxLength(50)
                .HasColumnName("Correspondent_Bank_Name");
            entity.Property(e => e.CorrespondentChips)
                .HasMaxLength(50)
                .HasColumnName("Correspondent_Chips");
            entity.Property(e => e.CorrespondentChipsUid)
                .HasMaxLength(50)
                .HasColumnName("Correspondent_Chips_UID");
            entity.Property(e => e.CorrespondentSwift)
                .HasMaxLength(50)
                .HasColumnName("Correspondent_Swift");
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
            entity.Property(e => e.MisparTik)
                .HasMaxLength(50)
                .HasColumnName("Mispar_Tik");
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
                .HasConstraintName("FK_Hgdr_Cheshbon_Hgdr_Bank");

            entity.HasOne(d => d.SugCheshbonNavigation).WithMany(p => p.HgdrCheshbons)
                .HasForeignKey(d => d.SugCheshbon)
                .HasConstraintName("FK_Hgdr_Cheshbon_Hgdr_Sug_Cheshbon");
        });

        modelBuilder.Entity<HgdrDerug>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Hgdr_Derug");

            entity.Property(e => e.Derug).HasMaxLength(10);
            entity.Property(e => e.DerugNamuchInt).HasColumnName("Derug_Namuch_Int");
            entity.Property(e => e.DerugNamuchLocal).HasColumnName("Derug_Namuch_Local");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.NoDerug).HasColumnName("No_Derug");
        });

        modelBuilder.Entity<HgdrHieTatAfik>(entity =>
        {
            entity.HasKey(e => e.HieTatAfikId);

            entity.ToTable("Hgdr_Hie_TatAfik");

            entity.Property(e => e.HieTatAfikId).HasColumnName("Hie_TatAfik_ID");
            entity.Property(e => e.HieTatAfikSnirId).HasColumnName("Hie_TatAfik_Snir_ID");
            entity.Property(e => e.HieTatAfikTeur1)
                .HasMaxLength(50)
                .HasColumnName("Hie_TatAfik_Teur_1");
            entity.Property(e => e.HieTatAfikTeur2)
                .HasMaxLength(50)
                .HasColumnName("Hie_TatAfik_Teur_2");
            entity.Property(e => e.HieTatAfikTeur3)
                .HasMaxLength(50)
                .HasColumnName("Hie_TatAfik_Teur_3");
            entity.Property(e => e.HieTatAfikTeur4)
                .HasMaxLength(50)
                .HasColumnName("Hie_TatAfik_Teur_4");
            entity.Property(e => e.HieTatAfikTeur5)
                .HasMaxLength(50)
                .HasColumnName("Hie_TatAfik_Teur_5");
        });

        modelBuilder.Entity<HgdrHoliday>(entity =>
        {
            entity.HasKey(e => new { e.Date, e.HolidayName, e.Country });

            entity.ToTable("Hgdr_Holiday");

            entity.Property(e => e.Date).HasColumnType("date");
            entity.Property(e => e.HolidayName)
                .HasMaxLength(50)
                .HasColumnName("Holiday_Name");

            entity.HasOne(d => d.CountryNavigation).WithMany(p => p.HgdrHolidays)
                .HasForeignKey(d => d.Country)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Hgdr_Holiday_Hgdr_Medina");
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

        modelBuilder.Entity<HgdrKvutzatTikim>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Hgdr_Kvutzat_Tikim");

            entity.Property(e => e.KodKvutzatTikim).HasColumnName("Kod_Kvutzat_Tikim");
            entity.Property(e => e.TeurKvutzatTikim)
                .HasMaxLength(50)
                .HasColumnName("Teur_kvutzat_Tikim");
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
            entity.Property(e => e.Hp)
                .HasMaxLength(50)
                .HasColumnName("HP");
            entity.Property(e => e.KodManpikSnir).HasColumnName("Kod_Manpik_Snir");
            entity.Property(e => e.TeurManpik)
                .HasMaxLength(50)
                .HasColumnName("Teur_Manpik");
        });

        modelBuilder.Entity<HgdrMatbea>(entity =>
        {
            entity.ToTable("Hgdr_Matbea");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.KodMatbea)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("Kod_Matbea");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.Matbea).HasMaxLength(50);
            entity.Property(e => e.PriceMultiplier).HasColumnType("decimal(18, 6)");
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
            entity.Property(e => e.KodMedinaSnir).HasColumnName("Kod_Medina_Snir");
            entity.Property(e => e.TeurMedina)
                .HasMaxLength(50)
                .HasColumnName("Teur_Medina");
        });

        modelBuilder.Entity<HgdrMediniyut>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Hgdr_Mediniyut");

            entity.Property(e => e.DmeyNihul)
                .HasColumnType("decimal(6, 5)")
                .HasColumnName("Dmey_Nihul");
            entity.Property(e => e.KodKniya)
                .HasMaxLength(50)
                .HasColumnName("Kod_Kniya");
            entity.Property(e => e.KodMechira)
                .HasMaxLength(50)
                .HasColumnName("Kod_Mechira");
            entity.Property(e => e.KodMediniyut).HasColumnName("Kod_Mediniyut");
            entity.Property(e => e.PaymentMethod)
                .HasMaxLength(50)
                .HasColumnName("Payment_Method");
            entity.Property(e => e.TeurMediniyut)
                .HasMaxLength(50)
                .HasColumnName("Teur_Mediniyut");
        });

        modelBuilder.Entity<HgdrMetafel>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Hgdr_Met__3214EC272CFA5EB7");

            entity.ToTable("Hgdr_Metafel");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Metafel).HasMaxLength(50);
            entity.Property(e => e.Path).HasMaxLength(255);
        });

        modelBuilder.Entity<HgdrMutzar>(entity =>
        {
            entity.HasKey(e => e.KodMutzar).HasName("PK_Mutzar");

            entity.ToTable("Hgdr_Mutzar");

            entity.Property(e => e.KodMutzar)
                .ValueGeneratedNever()
                .HasColumnName("Kod_Mutzar");
            entity.Property(e => e.CheshbonMatach).HasColumnName("Cheshbon_Matach");
            entity.Property(e => e.FoKodMutzarCategory).HasColumnName("FO_Kod_Mutzar_Category");
            entity.Property(e => e.HarigTsuaYomitFlag).HasColumnName("Harig_Tsua_Yomit_Flag");
            entity.Property(e => e.IsKerenMechaka).HasColumnName("Is_Keren_Mechaka");
            entity.Property(e => e.KodKvutzatTikim).HasColumnName("Kod_Kvutzat_Tikim");
            entity.Property(e => e.KodMutzarCategory).HasColumnName("Kod_Mutzar_Category");
            entity.Property(e => e.KodOtzar).HasColumnName("Kod_Otzar");
            entity.Property(e => e.KodSugKeren).HasColumnName("Kod_Sug_Keren");
            entity.Property(e => e.KodSugMutzar).HasColumnName("Kod_Sug_Mutzar");
            entity.Property(e => e.KranotAmlatHafatza)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("Kranot_AmlatHafatza");
            entity.Property(e => e.KranotBank)
                .HasMaxLength(50)
                .HasColumnName("Kranot_Bank");
            entity.Property(e => e.KranotChesbonBrokerageDiscount)
                .HasMaxLength(50)
                .HasColumnName("Kranot_ChesbonBrokerageDiscount");
            entity.Property(e => e.KranotChesbonBrokerageLeumi)
                .HasMaxLength(50)
                .HasColumnName("Kranot_ChesbonBrokerageLeumi");
            entity.Property(e => e.KranotDmeyNeeman)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("Kranot_DmeyNeeman");
            entity.Property(e => e.KranotDmeyNihul)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("Kranot_DmeyNIhul");
            entity.Property(e => e.KranotEnglishName)
                .HasMaxLength(250)
                .HasColumnName("Kranot_EnglishName");
            entity.Property(e => e.KranotEnglishNameShort)
                .HasMaxLength(250)
                .HasColumnName("Kranot_EnglishNameShort");
            entity.Property(e => e.KranotFirstHeader)
                .HasMaxLength(250)
                .HasColumnName("Kranot_FirstHeader");
            entity.Property(e => e.KranotHeaderAl)
                .HasMaxLength(250)
                .HasColumnName("Kranot_HeaderAl");
            entity.Property(e => e.KranotHebrewNameShort)
                .HasMaxLength(250)
                .HasColumnName("Kranot_HebrewNameShort");
            entity.Property(e => e.KranotMaslulMas)
                .HasMaxLength(50)
                .HasColumnName("Kranot_MaslulMas");
            entity.Property(e => e.KranotMatbeaPidiyonVeErechNakuv)
                .HasMaxLength(50)
                .HasColumnName("Kranot_MatbeaPidiyonVeErechNakuv");
            entity.Property(e => e.KranotMisparCheshbon)
                .HasMaxLength(250)
                .HasColumnName("Kranot_MisparCheshbon");
            entity.Property(e => e.KranotMisparTik).HasColumnName("Kranot_MisparTik");
            entity.Property(e => e.KranotNeeman)
                .HasMaxLength(50)
                .HasColumnName("Kranot_Neeman");
            entity.Property(e => e.KranotNihulStartDate)
                .HasColumnType("date")
                .HasColumnName("Kranot_NihulStartDate");
            entity.Property(e => e.KranotProfilChasifa)
                .HasMaxLength(50)
                .HasColumnName("Kranot_ProfilChasifa");
            entity.Property(e => e.KranotSecondHeader)
                .HasMaxLength(250)
                .HasColumnName("Kranot_SecondHeader");
            entity.Property(e => e.KranotShaaYeudaMonThu).HasColumnName("Kranot_ShaaYeudaMonThu");
            entity.Property(e => e.KranotShaaYeudaSunday).HasColumnName("Kranot_ShaaYeudaSunday");
            entity.Property(e => e.KranotShiurHosafa)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("Kranot_ShiurHosafa");
            entity.Property(e => e.KranotShnatKesafim)
                .HasMaxLength(50)
                .HasColumnName("Kranot_ShnatKesafim");
            entity.Property(e => e.KranotSugAmlatHafatza).HasColumnName("Kranot_SugAmlatHafatza");
            entity.Property(e => e.Medina).HasMaxLength(50);
            entity.Property(e => e.Menahel).HasMaxLength(50);
            entity.Property(e => e.Mutzar).HasMaxLength(50);
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

            entity.HasOne(d => d.KodSugKerenNavigation).WithMany(p => p.HgdrMutzars)
                .HasForeignKey(d => d.KodSugKeren)
                .HasConstraintName("FK_Hgdr_Mutzar_Hgdr_Mutzar");

            entity.HasOne(d => d.KodSugMutzarNavigation).WithMany(p => p.HgdrMutzars)
                .HasForeignKey(d => d.KodSugMutzar)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Hgdr_Sug_Mutzar_Hgdr_Mutzar");

            entity.HasOne(d => d.MetafelNavigation).WithMany(p => p.HgdrMutzars)
                .HasForeignKey(d => d.Metafel)
                .HasConstraintName("FK_Hgdr_Mutzar_Hgdr_Metafelim");
        });

        modelBuilder.Entity<HgdrMutzarCategory>(entity =>
        {
            entity.ToTable("Hgdr_MutzarCategory");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Foflg).HasColumnName("FOFlg");
            entity.Property(e => e.KodSugMutzar).HasColumnName("Kod_Sug_Mutzar");
            entity.Property(e => e.RafTsuaChodshit)
                .HasColumnType("decimal(3, 2)")
                .HasColumnName("Raf_Tsua_Chodshit");
            entity.Property(e => e.RafTsuaChodshitHarig)
                .HasColumnType("decimal(3, 2)")
                .HasColumnName("Raf_Tsua_Chodshit_Harig");
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
            entity.HasKey(e => e.KodNeches).HasName("PK_Hgdr_Neches_1");

            entity.ToTable("Hgdr_Neches");

            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.CalcTransFlg).HasColumnName("Calc_Trans_Flg");
            entity.Property(e => e.CancelOrderExport).HasColumnName("Cancel_Order_Export");
            entity.Property(e => e.CheshbonYaadDefault).HasColumnName("Cheshbon_Yaad_Default");
            entity.Property(e => e.Derug).HasMaxLength(50);
            entity.Property(e => e.EffectiveDate)
                .HasColumnType("date")
                .HasColumnName("Effective_Date");
            entity.Property(e => e.FixedRateDirection).HasColumnName("Fixed_Rate_Direction");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.IdMadad).HasColumnName("ID_Madad");
            entity.Property(e => e.Interest).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.InterestDate)
                .HasColumnType("date")
                .HasColumnName("Interest_Date");
            entity.Property(e => e.InterestType).HasColumnName("Interest_Type");
            entity.Property(e => e.IsSikunMvTk).HasColumnName("Is_Sikun_MvTk");
            entity.Property(e => e.Isin)
                .HasMaxLength(50)
                .HasColumnName("ISIN");
            entity.Property(e => e.KodAnaf).HasColumnName("Kod_Anaf");
            entity.Property(e => e.KodBasisHatzmada)
                .HasMaxLength(50)
                .HasColumnName("Kod_BasisHatzmada");
            entity.Property(e => e.KodBasisHatzmadaNegative)
                .HasMaxLength(100)
                .HasColumnName("Kod_BasisHatzmada_Negative");
            entity.Property(e => e.KodCounterParty).HasColumnName("Kod_Counter_Party");
            entity.Property(e => e.KodHieTatAfik1).HasColumnName("Kod_Hie_TatAfik1");
            entity.Property(e => e.KodMachshir).HasColumnName("Kod_Machshir");
            entity.Property(e => e.KodMachshirNb).HasColumnName("Kod_Machshir_NB");
            entity.Property(e => e.KodManpik).HasColumnName("Kod_Manpik");
            entity.Property(e => e.KodMatbea).HasColumnName("Kod_Matbea");
            entity.Property(e => e.KodMedinaManpika).HasColumnName("Kod_Medina_Manpika");
            entity.Property(e => e.KodMedinaNischeret).HasColumnName("Kod_Medina_Nischeret");
            entity.Property(e => e.KodMedinatChasifa).HasColumnName("Kod_Medinat_Chasifa");
            entity.Property(e => e.KodNechesBasis)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches_Basis");
            entity.Property(e => e.KodSchirut).HasColumnName("Kod_Schirut");
            entity.Property(e => e.KodTatAfik).HasColumnName("Kod_TatAfik");
            entity.Property(e => e.KodTimeBasis).HasColumnName("Kod_Time_Basis");
            entity.Property(e => e.Multiplier).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Neches).HasMaxLength(250);
            entity.Property(e => e.NechesIsraeli).HasColumnName("Neches_Israeli");
            entity.Property(e => e.NechesMisgeretKvua)
                .HasMaxLength(50)
                .HasColumnName("Neches_Misgeret_Kvua");
            entity.Property(e => e.NechesMisgeretMishtana)
                .HasMaxLength(50)
                .HasColumnName("Neches_Misgeret_Mishtana");
            entity.Property(e => e.NechesRashi).HasColumnName("Neches_Rashi");
            entity.Property(e => e.OrigUnits).HasColumnName("Orig_Units");
            entity.Property(e => e.Ric)
                .HasMaxLength(50)
                .HasColumnName("RIC");
            entity.Property(e => e.SettlementPeriodMonths).HasColumnName("Settlement_Period_Months");
            entity.Property(e => e.ShaarNbYadani)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("ShaarNB_Yadani");
            entity.Property(e => e.Spread).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Strike).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Sufix).HasMaxLength(50);
            entity.Property(e => e.TaarichHakama).HasColumnType("date");
            entity.Property(e => e.TerminationDate)
                .HasColumnType("date")
                .HasColumnName("Termination_Date");
            entity.Property(e => e.Ticker).HasMaxLength(50);
            entity.Property(e => e.TickerNb)
                .HasMaxLength(50)
                .HasColumnName("Ticker_NB");

            entity.HasOne(d => d.IdMadadNavigation).WithMany(p => p.HgdrNeches)
                .HasForeignKey(d => d.IdMadad)
                .HasConstraintName("FK_Hgdr_Neches_Hgdr_Madad");

            entity.HasOne(d => d.KodMachshirNavigation).WithMany(p => p.HgdrNechKodMachshirNavigations)
                .HasForeignKey(d => d.KodMachshir)
                .HasConstraintName("FK_Hgdr_Neches_Hgdr_Machshir");

            entity.HasOne(d => d.KodMachshirNbNavigation).WithMany(p => p.HgdrNechKodMachshirNbNavigations)
                .HasForeignKey(d => d.KodMachshirNb)
                .HasConstraintName("FK_Hgdr_Neches_Hgdr_Machshir1");

            entity.HasOne(d => d.KodManpikNavigation).WithMany(p => p.HgdrNeches)
                .HasForeignKey(d => d.KodManpik)
                .HasConstraintName("FK_Hgdr_Neches_Hgdr_Manpik");

            entity.HasOne(d => d.KodMedinaManpikaNavigation).WithMany(p => p.HgdrNechKodMedinaManpikaNavigations)
                .HasForeignKey(d => d.KodMedinaManpika)
                .HasConstraintName("FK_Hgdr_Neches_Hgdr_Medina_Manpika");

            entity.HasOne(d => d.KodMedinaNischeretNavigation).WithMany(p => p.HgdrNechKodMedinaNischeretNavigations)
                .HasForeignKey(d => d.KodMedinaNischeret)
                .HasConstraintName("FK_Hgdr_Neches_Hgdr_Medina_Nischeret");

            entity.HasOne(d => d.KodMedinatChasifaNavigation).WithMany(p => p.HgdrNechKodMedinatChasifaNavigations)
                .HasForeignKey(d => d.KodMedinatChasifa)
                .HasConstraintName("FK_Hgdr_Neches_Hgdr_Medina");
        });

        modelBuilder.Entity<HgdrNechesCounterParty>(entity =>
        {
            entity.HasKey(e => new { e.KodSugMutzar, e.CounterPartyName, e.Currency });

            entity.ToTable("Hgdr_Neches_CounterParty");

            entity.Property(e => e.KodSugMutzar).HasColumnName("Kod_Sug_Mutzar");
            entity.Property(e => e.CounterPartyName).HasMaxLength(50);
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .IsFixedLength();
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
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

            entity.HasOne(d => d.KodNechesNavigation).WithMany(p => p.HgdrPitzuls)
                .HasForeignKey(d => d.KodNeches)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Hgdr_Pitzul_Hgdr_Neches");
        });

        modelBuilder.Entity<HgdrProcessLoad>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Hgdr_ProcessLoad");

            entity.Property(e => e.EndDate).HasColumnType("date");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.ProcessDisplayName).HasMaxLength(50);
            entity.Property(e => e.ProcessName).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("date");
        });

        modelBuilder.Entity<HgdrSapak>(entity =>
        {
            entity.ToTable("Hgdr_Sapak");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.SugSherut)
                .HasMaxLength(50)
                .HasColumnName("Sug_Sherut");
            entity.Property(e => e.TeurSapak)
                .HasMaxLength(50)
                .HasColumnName("Teur_Sapak");
        });

        modelBuilder.Entity<HgdrSourceSystem>(entity =>
        {
            entity.ToTable("Hgdr_SourceSystem");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Source).HasMaxLength(50);
            entity.Property(e => e.Type).HasMaxLength(50);
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
            entity.HasKey(e => e.KodSugKeren).HasName("PK_Sug_Keren_Mutzar");

            entity.ToTable("Hgdr_Sug_Keren_Mutzar");

            entity.Property(e => e.KodSugKeren)
                .ValueGeneratedNever()
                .HasColumnName("Kod_Sug_Keren");
            entity.Property(e => e.SugKeren)
                .HasMaxLength(50)
                .HasColumnName("Sug_Keren");
        });

        modelBuilder.Entity<HgdrSugMadad>(entity =>
        {
            entity.HasKey(e => e.IdSugMadad);

            entity.ToTable("Hgdr_Sug_Madad");

            entity.Property(e => e.IdSugMadad).HasColumnName("ID_Sug_Madad");
            entity.Property(e => e.SugMadad)
                .HasMaxLength(50)
                .HasColumnName("Sug_Madad");
        });

        modelBuilder.Entity<HgdrSugMutzar>(entity =>
        {
            entity.HasKey(e => e.KodSugMotzar).HasName("PK_Sug_Mutzar");

            entity.ToTable("Hgdr_Sug_Mutzar");

            entity.Property(e => e.KodSugMotzar).HasColumnName("Kod_Sug_Motzar");
            entity.Property(e => e.SugMutzar)
                .HasMaxLength(50)
                .HasColumnName("Sug_Mutzar");
        });

        modelBuilder.Entity<HgdrTatAfik>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Hgdr_Tat_Afik_1");

            entity.ToTable("Hgdr_Tat_Afik");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Afik).HasMaxLength(50);
            entity.Property(e => e.KodAfik).HasColumnName("Kod_Afik");
            entity.Property(e => e.KodHieTatAfik1).HasColumnName("Kod_Hie_TatAfik_1");
            entity.Property(e => e.KodTatAfik).HasColumnName("Kod_Tat_Afik");
            entity.Property(e => e.NetrulMvtk).HasColumnName("Netrul_Mvtk");
            entity.Property(e => e.TatAfikRama2)
                .HasMaxLength(50)
                .HasColumnName("Tat_Afik_Rama_2");
            entity.Property(e => e.TeurTatAfik)
                .HasMaxLength(50)
                .HasColumnName("Teur_Tat_Afik");

            entity.HasOne(d => d.KodHieTatAfik1Navigation).WithMany(p => p.HgdrTatAfiks)
                .HasForeignKey(d => d.KodHieTatAfik1)
                .HasConstraintName("FK_Hgdr_Tat_Afik_Hgdr_Hie_TatAfik");
        });

        modelBuilder.Entity<HgdrTnuot>(entity =>
        {
            entity.ToTable("Hgdr_Tnuot");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.KodPeulaDanel).HasColumnName("Kod_Peula_Danel");
            entity.Property(e => e.KodPratimDanel).HasColumnName("Kod_Pratim_Danel");
            entity.Property(e => e.KodTnuaSdm).HasColumnName("Kod_Tnua_SDM");
            entity.Property(e => e.KodTnuoaDanel).HasColumnName("Kod_Tnuoa_Danel");
            entity.Property(e => e.MachpilAmlaKniyaMechira).HasColumnName("Machpil_Amla_Kniya_Mechira");
            entity.Property(e => e.MachpilKamut).HasColumnName("Machpil_Kamut");
            entity.Property(e => e.MachpilMas).HasColumnName("Machpil_Mas");
            entity.Property(e => e.MachpilOsh).HasColumnName("Machpil_Osh");
            entity.Property(e => e.MachpilRibit).HasColumnName("Machpil_Ribit");
            entity.Property(e => e.MachpilShovi).HasColumnName("Machpil_Shovi");
            entity.Property(e => e.TeurTnuoa)
                .HasMaxLength(50)
                .HasColumnName("Teur_Tnuoa");
        });

        modelBuilder.Entity<HgdrTnutStatus>(entity =>
        {
            entity.ToTable("Hgdr_Tnut_Status");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("ID");
            entity.Property(e => e.Status).HasMaxLength(50);
        });

        modelBuilder.Entity<HgdrYoetz>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Hgdr_Yoetz");

            entity.Property(e => e.KodSnif).HasColumnName("Kod_Snif");
            entity.Property(e => e.KodYoetz).HasColumnName("Kod_Yoetz");
            entity.Property(e => e.TeurYoetz)
                .HasMaxLength(50)
                .HasColumnName("Teur_Yoetz");
            entity.Property(e => e.TeurYoetzCrm)
                .HasMaxLength(50)
                .HasColumnName("Teur_Yoetz_CRM");
        });

        modelBuilder.Entity<HmrtCheshbon>(entity =>
        {
            entity.HasKey(e => new { e.KodMetafel, e.KodCheshbon });

            entity.ToTable("Hmrt_Cheshbon");

            entity.Property(e => e.KodMetafel).HasColumnName("Kod_Metafel");
            entity.Property(e => e.KodCheshbon).HasColumnName("Kod_Cheshbon");
            entity.Property(e => e.KodCheshbonMetafel)
                .HasMaxLength(50)
                .HasColumnName("Kod_Cheshbon_Metafel");

            entity.HasOne(d => d.KodCheshbonNavigation).WithMany(p => p.HmrtCheshbons)
                .HasForeignKey(d => d.KodCheshbon)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Hmrt_Cheshbon_Hgdr_Cheshbon");

            entity.HasOne(d => d.KodMetafelNavigation).WithMany(p => p.HmrtCheshbons)
                .HasForeignKey(d => d.KodMetafel)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Hmrt_Cheshbon_Hgdr_Metafel");
        });

        modelBuilder.Entity<HmrtNech>(entity =>
        {
            entity.HasKey(e => new { e.KodMetafel, e.KodNeches });

            entity.ToTable("Hmrt_Neches");

            entity.Property(e => e.KodMetafel).HasColumnName("Kod_Metafel");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.KodNechesMetafel)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches_Metafel");

            entity.HasOne(d => d.KodMetafelNavigation).WithMany(p => p.HmrtNeches)
                .HasForeignKey(d => d.KodMetafel)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Hmrt_Neches_Hgdr_Metafel");

            entity.HasOne(d => d.KodNechesNavigation).WithMany(p => p.HmrtNeches)
                .HasForeignKey(d => d.KodNeches)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Hmrt_Neches_Hgdr_Neches");
        });

        modelBuilder.Entity<HtmTnuotDanel>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Htm_Tnuot_Danel");

            entity.Property(e => e.ErechNakuv)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Erech_Nakuv");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.IdTnouaDanel).HasColumnName("ID_Tnoua_Danel");
            entity.Property(e => e.Isin)
                .HasMaxLength(50)
                .HasColumnName("ISIN");
            entity.Property(e => e.KodMedinaNischeret).HasColumnName("Kod_Medina_Nischeret");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.KodPeula).HasColumnName("Kod_Peula");
            entity.Property(e => e.MisparTik).HasColumnName("Mispar_Tik");
            entity.Property(e => e.Neches).HasMaxLength(50);
            entity.Property(e => e.Shaar).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ShemCheshbon)
                .HasMaxLength(50)
                .HasColumnName("Shem_Cheshbon");
            entity.Property(e => e.Shovi).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TarichErech)
                .HasColumnType("date")
                .HasColumnName("Tarich_Erech");
            entity.Property(e => e.Ticker).HasMaxLength(50);
        });

        modelBuilder.Entity<HtmTnuotPitzulim>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Htm_Tnuot_Pitzulim");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.IdPitzulDanel).HasColumnName("ID_Pitzul_Danel");
            entity.Property(e => e.Isin)
                .HasMaxLength(50)
                .HasColumnName("ISIN");
            entity.Property(e => e.KodMedinaNischeret).HasColumnName("Kod_Medina_Nischeret");
            entity.Property(e => e.KodTnua).HasColumnName("Kod_Tnua");
            entity.Property(e => e.MisparNiar).HasColumnName("Mispar_Niar");
            entity.Property(e => e.MisparTik).HasColumnName("Mispar_Tik");
            entity.Property(e => e.Niar).HasMaxLength(50);
            entity.Property(e => e.Shaar).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ShemHeshbon)
                .HasMaxLength(50)
                .HasColumnName("Shem_Heshbon");
            entity.Property(e => e.Shovi).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Taarich).HasColumnType("date");
            entity.Property(e => e.Ticker).HasMaxLength(50);
        });

        modelBuilder.Entity<IndexedViewTnuotRikuzWithPirut>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Indexed_View_Tnuot_Rikuz_With_Pirut");

            entity.Property(e => e.KodBasisHatzmada).HasColumnName("Kod_Basis_Hatzmada");
            entity.Property(e => e.KodMutzar).HasColumnName("Kod_Mutzar");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.Shovi).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.Taarich).HasColumnType("date");
        });

        modelBuilder.Entity<IndxResponse>(entity =>
        {
            entity.ToTable("IndxResponse");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Date).HasColumnType("date");
            entity.Property(e => e.ReportType).HasMaxLength(50);
        });

        modelBuilder.Entity<LoadLog>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK_SSISEnterpriseLog");

            entity.ToTable("Load_Log");

            entity.Property(e => e.LogId).HasColumnName("LogID");
            entity.Property(e => e.AppDescription)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.ErrorCode)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.ErrorDescription)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.EventDateTime).HasColumnType("datetime");
            entity.Property(e => e.EventType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.ExecutionId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("ExecutionID");
            entity.Property(e => e.MachineName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PackageId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("PackageID");
            entity.Property(e => e.PackageName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.SourceId)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("SourceID");
            entity.Property(e => e.SourceName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Map>(entity =>
        {
            entity.ToTable("Map");

            entity.Property(e => e.MapId).HasColumnName("MapID");
            entity.Property(e => e.MappingProfileId).HasColumnName("MappingProfileID");
            entity.Property(e => e.XlsName).HasMaxLength(50);

            entity.HasOne(d => d.MappingProfile).WithMany(p => p.Maps)
                .HasForeignKey(d => d.MappingProfileId)
                .HasConstraintName("FK_Map_MappingProfile");
        });

        modelBuilder.Entity<Mapping>(entity =>
        {
            entity.HasKey(e => new { e.Field, e.TableName });

            entity.ToTable("Mapping");

            entity.Property(e => e.Field).HasMaxLength(50);
            entity.Property(e => e.TableName).HasMaxLength(50);
            entity.Property(e => e.FilteringProps).HasMaxLength(50);
            entity.Property(e => e.HeaderName).HasMaxLength(50);
            entity.Property(e => e.IsPrimaryKey).HasColumnName("isPrimaryKey");
            entity.Property(e => e.OptionsPrimaryKey).HasMaxLength(50);
            entity.Property(e => e.OptionsPropertyToDisplay).HasMaxLength(50);
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<MappingProfile>(entity =>
        {
            entity.ToTable("MappingProfile");

            entity.Property(e => e.MappingProfileId).HasColumnName("MappingProfileID");
            entity.Property(e => e.MappingProfileName).HasMaxLength(50);
            entity.Property(e => e.TableTypeName).HasMaxLength(50);
        });

        modelBuilder.Entity<MgblAlternative>(entity =>
        {
            entity.ToTable("MGBL_Alternative");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.KodMigbala).HasColumnName("Kod_Migbala");
            entity.Property(e => e.Migbala).HasMaxLength(255);
        });

        modelBuilder.Entity<MgblExclude>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Hgdr_Migbalot_Exclude");

            entity.ToTable("MGBL_Exclude");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.CreateDate).HasColumnType("datetime");
            entity.Property(e => e.ExcludeEndDate)
                .HasColumnType("datetime")
                .HasColumnName("Exclude_EndDate");
            entity.Property(e => e.ExcludeStartDate)
                .HasColumnType("datetime")
                .HasColumnName("Exclude_StartDate");
            entity.Property(e => e.ExcludeType)
                .HasMaxLength(50)
                .HasColumnName("Exclude_Type");
            entity.Property(e => e.KodMigbala).HasColumnName("Kod_Migbala");
            entity.Property(e => e.KodYeshutKupotMigbala)
                .HasMaxLength(50)
                .HasColumnName("Kod_Yeshut_Kupot_Migbala");
            entity.Property(e => e.KodYeshutMigbala)
                .HasMaxLength(50)
                .HasColumnName("Kod_Yeshut_Migbala");
            entity.Property(e => e.ManagerStatus)
                .HasMaxLength(50)
                .HasColumnName("Manager_Status");
            entity.Property(e => e.ManagerStatusDate)
                .HasColumnType("datetime")
                .HasColumnName("Manager_Status_Date");
            entity.Property(e => e.ManagerStatusName)
                .HasMaxLength(50)
                .HasColumnName("Manager_Status_Name");
            entity.Property(e => e.Migbala).HasMaxLength(255);
            entity.Property(e => e.YeshutKupotMigbala)
                .HasMaxLength(255)
                .HasColumnName("Yeshut_Kupot_Migbala");
            entity.Property(e => e.YeshutMigbala)
                .HasMaxLength(255)
                .HasColumnName("Yeshut_Migbala");
        });

        modelBuilder.Entity<MgblInclude>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MGBL_Include");

            entity.Property(e => e.KodMigbala).HasColumnName("Kod_Migbala");
            entity.Property(e => e.KodYeshut).HasColumnName("Kod_Yeshut");
        });

        modelBuilder.Entity<MrktDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Mrkt_Data");

            entity.Property(e => e.Ask).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Bid).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Isin)
                .HasMaxLength(50)
                .HasColumnName("ISIN");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.OfficialClosePrice)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("Official_Close_Price");
            entity.Property(e => e.Ric)
                .HasMaxLength(50)
                .HasColumnName("RIC");
            entity.Property(e => e.SecurityId)
                .HasMaxLength(50)
                .HasColumnName("Security_ID");
            entity.Property(e => e.Taarich).HasColumnType("date");
            entity.Property(e => e.Ticker).HasMaxLength(50);
            entity.Property(e => e.TradeDate)
                .HasColumnType("date")
                .HasColumnName("Trade_Date");
            entity.Property(e => e.UrrencyCode)
                .HasMaxLength(50)
                .HasColumnName("urrency_Code");
        });

        modelBuilder.Entity<MrktField>(entity =>
        {
            entity.ToTable("Mrkt_Fields");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.FieldDescription)
                .HasMaxLength(250)
                .HasColumnName("Field_Description");
            entity.Property(e => e.FieldId)
                .HasMaxLength(50)
                .HasColumnName("Field_ID");
        });

        modelBuilder.Entity<MrktMadadim>(entity =>
        {
            entity.ToTable("Mrkt_Madadim");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.SecurityIdentifier)
                .HasMaxLength(50)
                .HasColumnName("Security_Identifier");
        });

        modelBuilder.Entity<MvTkHolding>(entity =>
        {
            entity.HasKey(e => new { e.KodSugModel, e.KodNeches });

            entity.ToTable("MvTk_Holdings");

            entity.Property(e => e.KodSugModel).HasColumnName("Kod_Sug_Model");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.KodSugMishkal).HasColumnName("Kod_Sug_Mishkal");
            entity.Property(e => e.Mishkal).HasColumnType("decimal(5, 4)");
            entity.Property(e => e.Remark).HasMaxLength(50);

            entity.HasOne(d => d.KodNechesNavigation).WithMany(p => p.MvTkHoldings)
                .HasForeignKey(d => d.KodNeches)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MvTk_Holdings_Hgdr_Neches");

            entity.HasOne(d => d.KodSugMishkalNavigation).WithMany(p => p.MvTkHoldings)
                .HasForeignKey(d => d.KodSugMishkal)
                .HasConstraintName("FK_MvTk_Holdings_MvTk_Sug_Mishkal");

            entity.HasOne(d => d.KodSugModelNavigation).WithMany(p => p.MvTkHoldings)
                .HasForeignKey(d => d.KodSugModel)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MvTk_Holdings_MvTk_Sug_Model");
        });

        modelBuilder.Entity<MvTkHoldingsTik>(entity =>
        {
            entity.HasKey(e => new { e.KodTikModel, e.KodNeches });

            entity.ToTable("MvTk_Holdings_Tik");

            entity.Property(e => e.KodTikModel).HasColumnName("Kod_Tik_Model");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.Mishkal).HasColumnType("decimal(5, 4)");

            entity.HasOne(d => d.KodNechesNavigation).WithMany(p => p.MvTkHoldingsTiks)
                .HasForeignKey(d => d.KodNeches)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MvTk_Holdings_Tik_Hgdr_Neches");

            entity.HasOne(d => d.KodTikModelNavigation).WithMany(p => p.MvTkHoldingsTiks)
                .HasForeignKey(d => d.KodTikModel)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MvTk_Holdings_Tik_MvTk_Tik_Model");
        });

        modelBuilder.Entity<MvTkKvutzot>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MvTk_Kvutzot");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.KodKvutza).HasColumnName("Kod_Kvutza");
            entity.Property(e => e.TeurKvutza)
                .HasMaxLength(50)
                .HasColumnName("Teur_Kvutza");
        });

        modelBuilder.Entity<MvTkMigbalot>(entity =>
        {
            entity.ToTable("MvTk_Migbalot");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.KodTikModel).HasColumnName("Kod_Tik_Model");
            entity.Property(e => e.MaxLimit)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("Max_Limit");
            entity.Property(e => e.MinLimit)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("Min_Limit");
            entity.Property(e => e.TeurBasisHatzmada)
                .HasMaxLength(50)
                .HasColumnName("Teur_Basis_Hatzmada");
            entity.Property(e => e.TeurHulChasifa)
                .HasMaxLength(50)
                .HasColumnName("Teur_Hul_Chasifa");
            entity.Property(e => e.TeurIsKeren)
                .HasMaxLength(50)
                .HasColumnName("Teur_Is_Keren");
            entity.Property(e => e.TeurKvutzatDerug)
                .HasMaxLength(50)
                .HasColumnName("Teur_Kvutzat_Derug");
            entity.Property(e => e.TeurLoMedurag)
                .HasMaxLength(50)
                .HasColumnName("Teur_Lo_Medurag");
            entity.Property(e => e.TeurMachshir)
                .HasMaxLength(50)
                .HasColumnName("Teur_Machshir");
            entity.Property(e => e.TeurMakor)
                .HasMaxLength(50)
                .HasColumnName("Teur_Makor");
            entity.Property(e => e.TeurMedinaNischeret)
                .HasMaxLength(50)
                .HasColumnName("Teur_Medina_Nischeret");
            entity.Property(e => e.TeurMedinatChasifa)
                .HasMaxLength(50)
                .HasColumnName("Teur_Medinat_Chasifa");
            entity.Property(e => e.TeurMigbala)
                .HasMaxLength(50)
                .HasColumnName("Teur_Migbala");
            entity.Property(e => e.TeurSikunMenayut)
                .HasMaxLength(50)
                .HasColumnName("Teur_Sikun_Menayut");
            entity.Property(e => e.TeurSugMechane)
                .HasMaxLength(50)
                .HasColumnName("Teur_Sug_Mechane");

            entity.HasOne(d => d.KodTikModelNavigation).WithMany(p => p.MvTkMigbalots)
                .HasForeignKey(d => d.KodTikModel)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MvTk_Migbalot_MvTk_Tik_Model");
        });

        modelBuilder.Entity<MvTkSugMishkal>(entity =>
        {
            entity.HasKey(e => e.KodSugMishkal);

            entity.ToTable("MvTk_Sug_Mishkal");

            entity.Property(e => e.KodSugMishkal).HasColumnName("Kod_Sug_Mishkal");
            entity.Property(e => e.TeurSugMishkal)
                .HasMaxLength(50)
                .HasColumnName("Teur_Sug_Mishkal");
        });

        modelBuilder.Entity<MvTkSugModel>(entity =>
        {
            entity.HasKey(e => e.KodSugModel).HasName("PK_Hgdr_Sug_Model");

            entity.ToTable("MvTk_Sug_Model");

            entity.Property(e => e.KodSugModel).HasColumnName("Kod_Sug_Model");
            entity.Property(e => e.Remark).HasMaxLength(250);
            entity.Property(e => e.TeurSugModel)
                .HasMaxLength(50)
                .HasColumnName("Teur_Sug_Model");
        });

        modelBuilder.Entity<MvTkTikModel>(entity =>
        {
            entity.HasKey(e => e.KodTikModel);

            entity.ToTable("MvTk_Tik_Model");

            entity.Property(e => e.KodTikModel).HasColumnName("Kod_Tik_Model");
            entity.Property(e => e.KodKvutza).HasColumnName("Kod_Kvutza");
            entity.Property(e => e.KodMediniyut).HasColumnName("Kod_Mediniyut");
            entity.Property(e => e.KodSugModel).HasColumnName("Kod_Sug_Model");
            entity.Property(e => e.MishkalEquity)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("Mishkal_Equity");
            entity.Property(e => e.NetrulShirshor).HasColumnName("Netrul_Shirshor");
            entity.Property(e => e.TeurTikModel)
                .HasMaxLength(50)
                .HasColumnName("Teur_Tik_Model");

            entity.HasOne(d => d.KodSugModelNavigation).WithMany(p => p.MvTkTikModels)
                .HasForeignKey(d => d.KodSugModel)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_MvTk_Tik_Model_MvTk_Sug_Model");
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

            entity.Property(e => e.SettingName).HasMaxLength(50);
        });

        modelBuilder.Entity<TikEvent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tik_Events");

            entity.Property(e => e.EventType).HasMaxLength(50);
            entity.Property(e => e.Taarich).HasColumnType("date");
        });

        modelBuilder.Entity<TikTsua>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tik_Tsua");

            entity.Property(e => e.Bsc)
                .HasMaxLength(50)
                .HasColumnName("BSC");
            entity.Property(e => e.KodKvutza).HasColumnName("Kod_Kvutza");
            entity.Property(e => e.KodMediniyot).HasColumnName("Kod_Mediniyot");
            entity.Property(e => e.Period).HasMaxLength(50);
            entity.Property(e => e.Shovi).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Taarich).HasColumnType("date");
            entity.Property(e => e.TeurTik)
                .HasMaxLength(250)
                .HasColumnName("Teur_Tik");
            entity.Property(e => e.Tsua).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Yoez).HasMaxLength(50);
        });

        modelBuilder.Entity<TmpBtzTnout>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tmp_BTZ_Tnout");

            entity.Property(e => e.AccountId).HasColumnName("Account_ID");
            entity.Property(e => e.BuyCurrency)
                .HasMaxLength(50)
                .HasColumnName("Buy_Currency");
            entity.Property(e => e.Counterparty).HasMaxLength(50);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.InsUser)
                .HasMaxLength(50)
                .HasColumnName("Ins_User");
            entity.Property(e => e.IsGilgul).HasColumnName("Is_Gilgul");
            entity.Property(e => e.KodMutzar)
                .HasMaxLength(50)
                .HasColumnName("Kod_Mutzar");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.Remarks).HasMaxLength(255);
            entity.Property(e => e.SecurityId)
                .HasMaxLength(50)
                .HasColumnName("Security_ID");
            entity.Property(e => e.SellCurrency)
                .HasMaxLength(50)
                .HasColumnName("Sell_Currency");
            entity.Property(e => e.Shaar).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SibatRechisha).HasColumnName("Sibat_Rechisha");
            entity.Property(e => e.Strike).HasMaxLength(50);
            entity.Property(e => e.TaarichPeula)
                .HasColumnType("date")
                .HasColumnName("Taarich_Peula");
            entity.Property(e => e.TaarichPkia)
                .HasMaxLength(50)
                .HasColumnName("Taarich_Pkia");
        });

        modelBuilder.Entity<TmpDvchDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tmp_Dvch_Data");

            entity.Property(e => e.Afik).HasMaxLength(50);
            entity.Property(e => e.Chasifa).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Hp)
                .HasMaxLength(50)
                .HasColumnName("HP");
            entity.Property(e => e.IdDvchSheet).HasColumnName("ID_DvchSheet");
            entity.Property(e => e.KodAnaf).HasColumnName("Kod_Anaf");
            entity.Property(e => e.KodMachshir).HasColumnName("Kod_Machshir");
            entity.Property(e => e.KodManpikSnir).HasColumnName("Kod_Manpik_Snir");
            entity.Property(e => e.KodMedinatChasifa).HasColumnName("Kod_Medinat_Chasifa");
            entity.Property(e => e.KodMutzar).HasColumnName("Kod_Mutzar");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.KodNechesAd)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches_AD");
            entity.Property(e => e.KodRibitOgen)
                .HasMaxLength(50)
                .HasColumnName("Kod_Ribit_Ogen");
            entity.Property(e => e.KodSchirut).HasColumnName("Kod_Schirut");
            entity.Property(e => e.KodSugMutzar).HasColumnName("Kod_Sug_Mutzar");
            entity.Property(e => e.KodSugYitra).HasColumnName("Kod_Sug_Yitra");
            entity.Property(e => e.KodTatAfik).HasColumnName("Kod_TatAfik");
            entity.Property(e => e.Machshir).HasMaxLength(50);
            entity.Property(e => e.Mutzar).HasMaxLength(50);
            entity.Property(e => e.Navבמטבעהדיווחשלקרןההשקעה)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("NAV (במטבע הדיווח של קרן ההשקעה)");
            entity.Property(e => e.Pitzul).HasColumnType("decimal(19, 18)");
            entity.Property(e => e.RegilaLekabel).HasColumnName("Regila_Lekabel");
            entity.Property(e => e.ShaarIska).HasColumnName("Shaar_Iska");
            entity.Property(e => e.ShaarMatbea)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("Shaar_Matbea");
            entity.Property(e => e.ShoviKupa).HasColumnType("decimal(38, 6)");
            entity.Property(e => e.Taarich).HasColumnType("date");
            entity.Property(e => e.TaarichRechisha)
                .HasColumnType("date")
                .HasColumnName("Taarich_Rechisha");
            entity.Property(e => e.TaarichShiaruchAcharon)
                .HasColumnType("date")
                .HasColumnName("Taarich_Shiaruch_Acharon");
            entity.Property(e => e.TeurAnaf)
                .HasMaxLength(50)
                .HasColumnName("Teur_Anaf");
            entity.Property(e => e.Ticker).HasMaxLength(50);
            entity.Property(e => e.YitraLekabel)
                .HasColumnType("decimal(38, 7)")
                .HasColumnName("Yitra_Lekabel");
            entity.Property(e => e.אסטרטגייתקרןההשקעה)
                .HasMaxLength(250)
                .HasColumnName("אסטרטגיית קרן ההשקעה");
            entity.Property(e => e.בעלענייןצדקשור)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("בעל עניין/צד קשור");
            entity.Property(e => e.גורםמצטט)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("גורם מצטט");
            entity.Property(e => e.דירוג).HasMaxLength(50);
            entity.Property(e => e.דירוגהבנק)
                .HasMaxLength(50)
                .HasColumnName("דירוג הבנק");
            entity.Property(e => e.דירוגהלוואההמנפיק)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("דירוג הלוואה/המנפיק");
            entity.Property(e => e.דירוגניירהערךהמנפיק)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("דירוג נייר הערך/המנפיק");
            entity.Property(e => e.האםסווגכחובבעייתי)
                .HasMaxLength(250)
                .HasColumnName("האם סווג כחוב בעייתי");
            entity.Property(e => e.האםקייםקנסבגיןיציאהמוקדמת)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("האם קיים קנס בגין יציאה מוקדמת");
            entity.Property(e => e.השיטהשבאמצעותהנקבעשוויהנכס)
                .HasMaxLength(250)
                .HasColumnName("השיטה שבאמצעותה נקבע שווי הנכס ");
            entity.Property(e => e.השיטהשיושמהבדוחהכספי)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("השיטה שיושמה בדוח הכספי");
            entity.Property(e => e.זירתמסחר)
                .HasMaxLength(250)
                .HasColumnName("זירת מסחר");
            entity.Property(e => e.זכותחזרה)
                .HasMaxLength(250)
                .HasColumnName("זכות חזרה");
            entity.Property(e => e.זכותפירעוןמוקדם)
                .HasMaxLength(250)
                .HasColumnName("זכות פירעון מוקדם");
            entity.Property(e => e.חודשהבדיקה)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("חודש הבדיקה");
            entity.Property(e => e.חודשהנפקתשכבה)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("חודש הנפקת שכבה");
            entity.Property(e => e.טיקר).HasMaxLength(50);
            entity.Property(e => e.יחסהמרה)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("יחס המרה");
            entity.Property(e => e.יעודהלוואה)
                .HasMaxLength(250)
                .HasColumnName("יעוד הלוואה");
            entity.Property(e => e.ישראלחול)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ישראל/חו\"ל");
            entity.Property(e => e.יתרתהמחויבותלתקופתהדיווחבמטבעהדיווחשלקרןההשקעה)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("יתרת המחויבות לתקופת הדיווח (במטבע הדיווח של קרן ההשקעה)");
            entity.Property(e => e.יתרתהמחויבותלתקופתהדיווחבשח)
                .HasColumnType("decimal(37, 12)")
                .HasColumnName("יתרת המחויבות לתקופת הדיווח (בש\"ח)");
            entity.Property(e => e.כתובתהנכס)
                .HasMaxLength(250)
                .HasColumnName("כתובת הנכס");
            entity.Property(e => e.מאפייןהלוואותמתואמותעבורזכויותמקרקעין)
                .HasMaxLength(250)
                .HasColumnName("מאפיין הלוואות מתואמות עבור זכויות מקרקעין");
            entity.Property(e => e.מאפייןעיקרי)
                .HasMaxLength(250)
                .HasColumnName("מאפיין עיקרי");
            entity.Property(e => e.מבנהלוחסילוקין).HasColumnName("מבנה לוח סילוקין");
            entity.Property(e => e.מדינהלפיחשיפהכלכלית)
                .HasMaxLength(50)
                .HasColumnName("מדינה לפי חשיפה כלכלית");
            entity.Property(e => e.מדינתהתאגדותקרןהשקעה)
                .HasMaxLength(50)
                .HasColumnName("מדינת התאגדות קרן השקעה");
            entity.Property(e => e.מדינתמיקוםנדלן)
                .HasMaxLength(250)
                .HasColumnName("מדינת מיקום נדל\"ן");
            entity.Property(e => e.מועדההתקשרותבעסקה)
                .HasMaxLength(4000)
                .HasColumnName("מועד ההתקשרות בעסקה");
            entity.Property(e => e.מועדסיוםחוזי)
                .HasMaxLength(4000)
                .HasColumnName("מועד סיום חוזי");
            entity.Property(e => e.מועדעדכוןאחרוןלשוויהבטוחות)
                .HasMaxLength(250)
                .HasColumnName("מועד עדכון אחרון לשווי הבטוחות");
            entity.Property(e => e.מועדפדיון)
                .HasMaxLength(4000)
                .HasColumnName("מועד פדיון");
            entity.Property(e => e.מחזורחייהנכס)
                .HasMaxLength(250)
                .HasColumnName("מחזור חיי הנכס");
            entity.Property(e => e.מחמ)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("מח\"מ");
            entity.Property(e => e.מטבע)
                .HasMaxLength(250)
                .HasColumnName("מטבע ");
            entity.Property(e => e.מטבעפעילות)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("מטבע פעילות");
            entity.Property(e => e.מטבעפעילותרגל1)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("מטבע פעילות (רגל 1)");
            entity.Property(e => e.מטבעפעילותרגל2)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("מטבע פעילות (רגל 2)");
            entity.Property(e => e.מיקוםמשרדהשותףהכללי)
                .HasMaxLength(250)
                .HasColumnName("מיקום משרד השותף הכללי");
            entity.Property(e => e.מסגרתאשראיבמועדהעמדה)
                .HasMaxLength(250)
                .HasColumnName("מסגרת אשראי במועד העמדה");
            entity.Property(e => e.מספרLei)
                .HasMaxLength(250)
                .HasColumnName("מספר LEI");
            entity.Property(e => e.מספרהלוואה)
                .HasMaxLength(50)
                .HasColumnName("מספר הלוואה");
            entity.Property(e => e.מספרהנכסהאחר)
                .HasMaxLength(50)
                .HasColumnName("מספר הנכס האחר");
            entity.Property(e => e.מספרמזההבנק)
                .HasMaxLength(50)
                .HasColumnName("מספר מזהה בנק");
            entity.Property(e => e.מספרמזההלווה).HasColumnName("מספר מזהה לווה");
            entity.Property(e => e.מספרמזההקרןהשקעה)
                .HasMaxLength(50)
                .HasColumnName("מספר מזהה קרן השקעה");
            entity.Property(e => e.מספרמזההשותףכלליקרןהשקעות)
                .HasMaxLength(250)
                .HasColumnName("מספר מזהה שותף כללי קרן השקעות");
            entity.Property(e => e.מספרמנפיק).HasColumnName("מספר מנפיק");
            entity.Property(e => e.מספרמסלול).HasColumnName("מספר מסלול");
            entity.Property(e => e.מספרניירערך)
                .HasMaxLength(50)
                .HasColumnName("מספר נייר ערך");
            entity.Property(e => e.מספרנכסיםבמדדנכסייחוסקרנותנאמנות)
                .HasMaxLength(250)
                .HasColumnName("מספר נכסים במדד נכס ייחוס - קרנות נאמנות");
            entity.Property(e => e.מספרעסקהרגל1)
                .HasMaxLength(50)
                .HasColumnName("מספר עסקה (רגל 1)");
            entity.Property(e => e.מספרעסקהרגל2)
                .HasMaxLength(100)
                .HasColumnName("מספר עסקה (רגל 2)");
            entity.Property(e => e.מספרקונסורציוםסינדיקציה)
                .HasMaxLength(250)
                .HasColumnName("מספר קונסורציום/סינדיקציה");
            entity.Property(e => e.מספרקופהקרןחפעבורחברתביטוח).HasColumnName("מספר קופה/קרן/ח.פ. עבור חברת ביטוח");
            entity.Property(e => e.מספרקרן).HasColumnName("מספר קרן");
            entity.Property(e => e.נחיתותחוזית)
                .HasMaxLength(250)
                .HasColumnName("נחיתות חוזית");
            entity.Property(e => e.נכסבסיס)
                .HasMaxLength(250)
                .HasColumnName("נכס בסיס");
            entity.Property(e => e.נכסבסיסכתבאופציה)
                .HasMaxLength(50)
                .HasColumnName("נכס בסיס (כתב אופציה)");
            entity.Property(e => e.נספחהתחשבנותבטחונותCsa)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("נספח התחשבנות בטחונות - CSA");
            entity.Property(e => e.סוגבטוחה)
                .HasMaxLength(250)
                .HasColumnName("סוג בטוחה");
            entity.Property(e => e.סוגגורםמשערך)
                .HasMaxLength(250)
                .HasColumnName("סוג גורם משערך");
            entity.Property(e => e.סוגהנכס)
                .HasMaxLength(250)
                .HasColumnName("סוג הנכס");
            entity.Property(e => e.סוגהסליקה)
                .HasMaxLength(250)
                .HasColumnName("סוג הסליקה");
            entity.Property(e => e.סוגהצמדה)
                .HasMaxLength(250)
                .HasColumnName("סוג הצמדה");
            entity.Property(e => e.סוגהריבית)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("סוג הריבית");
            entity.Property(e => e.סוגלוס)
                .HasMaxLength(250)
                .HasColumnName("סוג לוס");
            entity.Property(e => e.סוגמספרמזההבנק)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("סוג מספר מזהה בנק");
            entity.Property(e => e.סוגמספרמזההלווה)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("סוג מספר מזהה לווה");
            entity.Property(e => e.סוגמספרמזההמנפיק)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("סוג מספר מזהה מנפיק");
            entity.Property(e => e.סוגמספרמזההקרןהשקעות)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("סוג מספר מזהה קרן השקעות");
            entity.Property(e => e.סוגמספרמזההשותףכלליקרןהשקעות)
                .HasMaxLength(250)
                .HasColumnName("סוג מספר מזהה שותף כללי קרן השקעות");
            entity.Property(e => e.סוגמספרניירערך)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("סוג מספר נייר ערך");
            entity.Property(e => e.סוגקרן)
                .HasMaxLength(50)
                .HasColumnName("סוג קרן");
            entity.Property(e => e.סטאטוססחירות)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("סטאטוס סחירות");
            entity.Property(e => e.סיווגהחובכבעייתי)
                .HasMaxLength(250)
                .HasColumnName("סיווג החוב כבעייתי");
            entity.Property(e => e.סיווגהקרן)
                .HasMaxLength(250)
                .HasColumnName("סיווג הקרן");
            entity.Property(e => e.סכוםהמחויבותהראשוניבמטבעהדיווחשלקרןההשקעה)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("סכום המחויבות הראשוני (במטבע הדיווח של קרן ההשקעה)");
            entity.Property(e => e.סכוםהמחויבותהראשוניבשח)
                .HasColumnType("decimal(37, 12)")
                .HasColumnName("סכום המחויבות הראשוני (בש\"ח)");
            entity.Property(e => e.סכוםלקבלבמטבעהפעילות)
                .HasColumnType("decimal(38, 7)")
                .HasColumnName("סכום לקבל (במטבע הפעילות)");
            entity.Property(e => e.סכוםמסגרתהאשראיהראשוניבמטבעהפעילות).HasColumnName("סכום מסגרת האשראי הראשוני (במטבע הפעילות)");
            entity.Property(e => e.סכוםמסגרתהאשראיהראשוניבמטבעהפעילותIHub)
                .HasMaxLength(250)
                .HasColumnName("סכום מסגרת האשראי הראשוני (במטבע הפעילות) - iHub");
            entity.Property(e => e.סכוםמסגרתהאשראיהראשוניבשח).HasColumnName("סכום מסגרת האשראי הראשוני (בש\"ח)");
            entity.Property(e => e.עלותמופחתתבמטבעהפעילות)
                .HasMaxLength(250)
                .HasColumnName("עלות מופחתת (במטבע הפעילות)");
            entity.Property(e => e.עלותמופחתתבשח)
                .HasMaxLength(250)
                .HasColumnName("עלות מופחתת (בש\"ח)");
            entity.Property(e => e.ענףמסחר)
                .HasMaxLength(250)
                .HasColumnName("ענף מסחר");
            entity.Property(e => e.ערךנקוב)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ערך נקוב");
            entity.Property(e => e.ערךנקוביחידות)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ערך נקוב (יחידות)");
            entity.Property(e => e.ערךנקוברגל1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ערך נקוב (רגל 1)");
            entity.Property(e => e.ערךנקוברגל2)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("ערך נקוב (רגל 2)");
            entity.Property(e => e.פקטורמוביל)
                .HasMaxLength(250)
                .HasColumnName("פקטור מוביל");
            entity.Property(e => e.פקטורנוסף)
                .HasMaxLength(250)
                .HasColumnName("פקטור נוסף");
            entity.Property(e => e.צדנגדיCounterparty)
                .HasMaxLength(50)
                .HasColumnName("צד נגדי - Counterparty");
            entity.Property(e => e.קודנכסהלוואתמקור)
                .HasMaxLength(50)
                .HasColumnName("קוד נכס הלוואת מקור");
            entity.Property(e => e.קונסורציוםסינדיקציה)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("קונסורציום/ סינדיקציה");
            entity.Property(e => e.ריביתעוגן)
                .HasMaxLength(250)
                .HasColumnName("ריבית עוגן");
            entity.Property(e => e.ריביתעוגןלדיווח)
                .HasMaxLength(250)
                .HasColumnName("ריבית עוגן לדיווח");
            entity.Property(e => e.שוויהבטוחותהעומדותכנגדההלוואה)
                .HasMaxLength(250)
                .HasColumnName("שווי הבטוחות העומדות כנגד ההלוואה");
            entity.Property(e => e.שוויהוגןבמטבעהנסחררגל1)
                .HasColumnType("decimal(38, 16)")
                .HasColumnName("שווי הוגן במטבע הנסחר (רגל 1)");
            entity.Property(e => e.שוויהוגןבמטבעהנסחררגל2)
                .HasColumnType("decimal(38, 15)")
                .HasColumnName("שווי הוגן במטבע הנסחר (רגל 2)");
            entity.Property(e => e.שוויהוגןבמטבעהפעילות)
                .HasColumnType("decimal(23, 7)")
                .HasColumnName("שווי הוגן (במטבע הפעילות)");
            entity.Property(e => e.שוויהוגןבשח)
                .HasColumnType("decimal(23, 7)")
                .HasColumnName("שווי הוגן (בש\"ח)");
            entity.Property(e => e.שוויהוגןנטובשח)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("שווי הוגן (נטו  בש\"ח)");
            entity.Property(e => e.שוויהנכסיםבאפיק)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("שווי הנכסים באפיק");
            entity.Property(e => e.שווימאזניבשח)
                .HasMaxLength(250)
                .HasColumnName("שווי מאזני (בש\"ח)");
            entity.Property(e => e.שווימטבעי)
                .HasColumnType("decimal(23, 7)")
                .HasColumnName("שווי מטבעי");
            entity.Property(e => e.שיטהשיושמהבדיווחהכספי)
                .HasMaxLength(250)
                .HasColumnName("שיטה שיושמה בדיווח הכספי");
            entity.Property(e => e.שימושעיקריבנכס)
                .HasMaxLength(250)
                .HasColumnName("שימוש עיקרי בנכס");
            entity.Property(e => e.שיעוראחזקהבאמצעישליטה)
                .HasMaxLength(250)
                .HasColumnName("שיעור אחזקה באמצעי שליטה");
            entity.Property(e => e.שיעורהבטוחותמהחוב)
                .HasColumnType("decimal(38, 15)")
                .HasColumnName("שיעור הבטוחות מהחוב");
            entity.Property(e => e.שיעורהחזקהבקרןהשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור החזקה בקרן השקעה");
            entity.Property(e => e.שיעורהקנסבגיןיציאהמוקדמת)
                .HasMaxLength(4000)
                .HasColumnName("שיעור הקנס בגין יציאה מוקדמת");
            entity.Property(e => e.שיעורהקנסבגיןיציאהמוקדמתIHub)
                .HasMaxLength(250)
                .HasColumnName("שיעור הקנס בגין יציאה מוקדמת - iHub");
            entity.Property(e => e.שיעוריתרתהמחויבות)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("שיעור יתרת המחויבות");
            entity.Property(e => e.שיעוריתרתמסגרתאשראי)
                .HasMaxLength(4000)
                .HasColumnName("שיעור יתרת מסגרת אשראי");
            entity.Property(e => e.שיעורמנכסיאפיקההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מנכסי אפיק ההשקעה");
            entity.Property(e => e.שיעורמנכסיאפיקההשקעהרגל1)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("שיעור מנכסי אפיק ההשקעה (רגל 1)");
            entity.Property(e => e.שיעורמסךאפיקההשקעהרגל2)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מסך אפיק ההשקעה (רגל 2)");
            entity.Property(e => e.שיעורמסךנכסיההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מסך נכסי ההשקעה");
            entity.Property(e => e.שיעורמסךנכסיההשקעהרגל1)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מסך נכסי ההשקעה (רגל 1)");
            entity.Property(e => e.שיעורמסךנכסיההשקעהרגל2)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מסך נכסי ההשקעה (רגל 2)");
            entity.Property(e => e.שיעורמערךנקובמונפק)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מערך נקוב מונפק");
            entity.Property(e => e.שיעורריבית)
                .HasMaxLength(4000)
                .HasColumnName("שיעור ריבית");
            entity.Property(e => e.שיעורריביתבגיןאיניצולמסגרתהאשראי)
                .HasMaxLength(4000)
                .HasColumnName("שיעור ריבית בגין אי-ניצול מסגרת האשראי");
            entity.Property(e => e.שיעורריביתעוגן)
                .HasMaxLength(4000)
                .HasColumnName("שיעור ריבית עוגן");
            entity.Property(e => e.שיעורתוספתהפחתהלריביתהעוגן)
                .HasMaxLength(4000)
                .HasColumnName("שיעור תוספת/הפחתה לריבית העוגן");
            entity.Property(e => e.שיעורתשואהבפועלבמהלךהרבעון)
                .HasMaxLength(250)
                .HasColumnName("שיעור תשואה בפועל במהלך הרבעון");
            entity.Property(e => e.שםגורםמשערך)
                .HasMaxLength(250)
                .HasColumnName("שם גורם משערך");
            entity.Property(e => e.שםהבנק)
                .HasMaxLength(100)
                .HasColumnName("שם הבנק");
            entity.Property(e => e.שםהלוואה).HasColumnName("שם הלוואה");
            entity.Property(e => e.שםהנכס).HasColumnName("שם הנכס");
            entity.Property(e => e.שםהנכסהאחר).HasColumnName("שם הנכס האחר");
            entity.Property(e => e.שםמדרג)
                .HasMaxLength(50)
                .HasColumnName("שם מדרג");
            entity.Property(e => e.שםמוסתר)
                .HasMaxLength(250)
                .HasColumnName("שם מוסתר");
            entity.Property(e => e.שםמנפיק)
                .HasMaxLength(50)
                .HasColumnName("שם מנפיק");
            entity.Property(e => e.שםניירערך).HasColumnName("שם נייר ערך");
            entity.Property(e => e.שםקרןהשקעה).HasColumnName("שם קרן השקעה");
            entity.Property(e => e.שםשותףכלליקרןהשקעות)
                .HasMaxLength(250)
                .HasColumnName("שם שותף כללי קרן השקעות");
            entity.Property(e => e.שערהלוואה)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער הלוואה");
            entity.Property(e => e.שערהנגזרבמועדההתקשרותבעסקה).HasColumnName("שער הנגזר במועד ההתקשרות בעסקה");
            entity.Property(e => e.שערהנגזרבמועדההתקשרותבעסקהIHub)
                .HasMaxLength(250)
                .HasColumnName("שער הנגזר במועד ההתקשרות בעסקה - iHub");
            entity.Property(e => e.שערחליפין)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער חליפין");
            entity.Property(e => e.שערמימוש)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער מימוש");
            entity.Property(e => e.שערניירהערך)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער נייר הערך");
            entity.Property(e => e.שערנכסהבסיסבמועדההתקשרותבעסקה).HasColumnName("שער נכס הבסיס במועד ההתקשרות בעסקה");
            entity.Property(e => e.שערנכסהבסיסבמועדההתקשרותבעסקהIHub)
                .HasMaxLength(250)
                .HasColumnName("שער נכס הבסיס במועד ההתקשרות בעסקה - iHub");
            entity.Property(e => e.שערפיקדון)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער פיקדון");
            entity.Property(e => e.תאורמדדנכסייחוסקרנותנאמנות)
                .HasMaxLength(250)
                .HasColumnName("תאור מדד נכס ייחוס - קרנות נאמנות");
            entity.Property(e => e.תאריךאחרוןבונבחנהבפועלירידתערך)
                .HasMaxLength(250)
                .HasColumnName("תאריך אחרון בו נבחנה בפועל ירידת ערך");
            entity.Property(e => e.תאריךהעמדתהלוואה)
                .HasMaxLength(4000)
                .HasColumnName("תאריך העמדת הלוואה");
            entity.Property(e => e.תאריךהעמדתהתחייבותלקרןהשקעה)
                .HasMaxLength(4000)
                .HasColumnName("תאריך העמדת התחייבות לקרן השקעה");
            entity.Property(e => e.תאריךהעמדתמסגרתאשראי)
                .HasMaxLength(4000)
                .HasColumnName("תאריך העמדת מסגרת אשראי");
            entity.Property(e => e.תאריךעסקה)
                .HasMaxLength(250)
                .HasColumnName("תאריך עסקה");
            entity.Property(e => e.תאריךפקיעה)
                .HasMaxLength(4000)
                .HasColumnName("תאריך פקיעה");
            entity.Property(e => e.תאריךפקיעתמחויבותלהשקעה)
                .HasMaxLength(4000)
                .HasColumnName("תאריך פקיעת מחויבות להשקעה");
            entity.Property(e => e.תאריךפקיעתפיקדון)
                .HasMaxLength(4000)
                .HasColumnName("תאריך פקיעת פיקדון");
            entity.Property(e => e.תאריךרכישה)
                .HasMaxLength(250)
                .HasColumnName("תאריך רכישה");
            entity.Property(e => e.תאריךשערוךאחרון)
                .HasMaxLength(4000)
                .HasColumnName("תאריך שערוך אחרון");
            entity.Property(e => e.תאריךשערוךאחרוןIHub)
                .HasMaxLength(250)
                .HasColumnName("תאריך שערוך אחרון - iHub");
            entity.Property(e => e.תדירותReset)
                .HasMaxLength(250)
                .HasColumnName("תדירות Reset");
            entity.Property(e => e.תלותאיתלותהמשערך)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("תלות/אי-תלות המשערך");
            entity.Property(e => e.תקופתריביתעוגן)
                .HasMaxLength(250)
                .HasColumnName("תקופת ריבית עוגן");
            entity.Property(e => e.תשואהלפדיון)
                .HasMaxLength(4000)
                .HasColumnName("תשואה לפדיון");
        });

        modelBuilder.Entity<TmpHgdrManpik>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tmp_Hgdr_Manpik");

            entity.Property(e => e.Hp)
                .HasMaxLength(50)
                .HasColumnName("HP");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.KodManpikSnir).HasColumnName("Kod_Manpik_Snir");
            entity.Property(e => e.TeurManpik)
                .HasMaxLength(50)
                .HasColumnName("Teur_Manpik");
        });

        modelBuilder.Entity<TmpHgdrNech>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tmp_Hgdr_Neches");

            entity.Property(e => e.CancelOrderExport).HasColumnName("Cancel_Order_Export");
            entity.Property(e => e.CheshbonYaadDefault).HasColumnName("Cheshbon_Yaad_Default");
            entity.Property(e => e.Derug).HasMaxLength(50);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.IsSikunMvTk).HasColumnName("Is_Sikun_MvTk");
            entity.Property(e => e.Isin)
                .HasMaxLength(50)
                .HasColumnName("ISIN");
            entity.Property(e => e.KodAnaf).HasColumnName("Kod_Anaf");
            entity.Property(e => e.KodBasisHatzmada)
                .HasMaxLength(50)
                .HasColumnName("Kod_BasisHatzmada");
            entity.Property(e => e.KodBasisHatzmadaNegative)
                .HasMaxLength(100)
                .HasColumnName("Kod_BasisHatzmada_Negative");
            entity.Property(e => e.KodHieTatAfik1).HasColumnName("Kod_Hie_TatAfik1");
            entity.Property(e => e.KodMachshir).HasColumnName("Kod_Machshir");
            entity.Property(e => e.KodMachshirNb).HasColumnName("Kod_Machshir_NB");
            entity.Property(e => e.KodManpik).HasColumnName("Kod_Manpik");
            entity.Property(e => e.KodMatbea).HasColumnName("Kod_Matbea");
            entity.Property(e => e.KodMedinaManpika).HasColumnName("Kod_Medina_Manpika");
            entity.Property(e => e.KodMedinaNischeret).HasColumnName("Kod_Medina_Nischeret");
            entity.Property(e => e.KodMedinatChasifa).HasColumnName("Kod_Medinat_Chasifa");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.KodNechesBasis)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches_Basis");
            entity.Property(e => e.KodSchirut).HasColumnName("Kod_Schirut");
            entity.Property(e => e.KodTatAfik).HasColumnName("Kod_TatAfik");
            entity.Property(e => e.Multiplier).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Neches).HasMaxLength(250);
            entity.Property(e => e.NechesMisgeretKvua)
                .HasMaxLength(50)
                .HasColumnName("Neches_Misgeret_Kvua");
            entity.Property(e => e.NechesMisgeretMishtana)
                .HasMaxLength(50)
                .HasColumnName("Neches_Misgeret_Mishtana");
            entity.Property(e => e.Strike).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Ticker).HasMaxLength(50);
        });

        modelBuilder.Entity<TmpHgdrTatAfik>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tmp_Hgdr_TatAfik");

            entity.Property(e => e.HieTatAfikId).HasColumnName("Hie_TatAfik_ID");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.KodAfik).HasColumnName("Kod_Afik");
            entity.Property(e => e.KodTatAfik).HasColumnName("Kod_TatAfik");
            entity.Property(e => e.TeurAfik)
                .HasMaxLength(50)
                .HasColumnName("Teur_Afik");
            entity.Property(e => e.TeurTatAfik)
                .HasMaxLength(50)
                .HasColumnName("Teur_TatAfik");
        });

        modelBuilder.Entity<TmpMrktDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tmp_Mrkt_Data");

            entity.Property(e => e.Ask).HasMaxLength(50);
            entity.Property(e => e.Bid).HasMaxLength(50);
            entity.Property(e => e.CurrencyCode)
                .HasMaxLength(50)
                .HasColumnName("Currency_Code");
            entity.Property(e => e.Isin)
                .HasMaxLength(50)
                .HasColumnName("ISIN");
            entity.Property(e => e.OfficialClosePrice)
                .HasMaxLength(50)
                .HasColumnName("Official_Close_Price");
            entity.Property(e => e.Ric)
                .HasMaxLength(50)
                .HasColumnName("RIC");
            entity.Property(e => e.Security).HasMaxLength(50);
            entity.Property(e => e.Taarich).HasMaxLength(50);
            entity.Property(e => e.Ticker).HasMaxLength(50);
            entity.Property(e => e.TradeDate)
                .HasColumnType("date")
                .HasColumnName("Trade_Date");
        });

        modelBuilder.Entity<TmpMvTkMigbalot>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tmp_MvTk_Migbalot");

            entity.Property(e => e.AchuzBafual).HasColumnType("decimal(38, 6)");
            entity.Property(e => e.BasisHatzmadaMigbala)
                .HasMaxLength(55)
                .HasColumnName("Basis_Hatzmada_Migbala");
            entity.Property(e => e.HulChasifaMigbala)
                .HasMaxLength(50)
                .HasColumnName("Hul_Chasifa_Migbala");
            entity.Property(e => e.IsKerenMigbala)
                .HasMaxLength(50)
                .HasColumnName("Is_Keren_Migbala");
            entity.Property(e => e.KodTikModel).HasColumnName("Kod_Tik_Model");
            entity.Property(e => e.KvutzatDerugMigbala)
                .HasMaxLength(55)
                .HasColumnName("Kvutzat_Derug_Migbala");
            entity.Property(e => e.MachshirMigbala)
                .HasMaxLength(55)
                .HasColumnName("Machshir_Migbala");
            entity.Property(e => e.Makor).HasMaxLength(50);
            entity.Property(e => e.MedinaNischeretMigbala)
                .HasMaxLength(50)
                .HasColumnName("Medina_Nischeret_Migbala");
            entity.Property(e => e.MedinatChasifaMigbala)
                .HasMaxLength(55)
                .HasColumnName("Medinat_Chasifa_Migbala");
            entity.Property(e => e.MenyautSikunMigbala)
                .HasMaxLength(55)
                .HasColumnName("Menyaut_Sikun_Migbala");
            entity.Property(e => e.NoDerugMigbala)
                .HasMaxLength(55)
                .HasColumnName("No_Derug_Migbala");
        });

        modelBuilder.Entity<TmpShearim>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tmp_Shearim");

            entity.Property(e => e.Date).HasColumnType("date");
            entity.Property(e => e.Isin)
                .HasMaxLength(50)
                .HasColumnName("ISIN");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.Neches).HasMaxLength(250);
            entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Source).HasMaxLength(50);
            entity.Property(e => e.Ticker).HasMaxLength(50);
        });

        modelBuilder.Entity<TmpTazrim>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tmp_Tazrim");

            entity.Property(e => e.Counterparty).HasMaxLength(50);
            entity.Property(e => e.KodBasisHatzmada)
                .HasMaxLength(50)
                .HasColumnName("Kod_BasisHatzmada");
            entity.Property(e => e.KodMutzar).HasColumnName("Kod_Mutzar");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.Shovi).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Taarich).HasColumnType("date");
        });

        modelBuilder.Entity<TmpTikTsua>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tmp_Tik_Tsua");

            entity.Property(e => e.Bsc)
                .HasMaxLength(50)
                .HasColumnName("BSC");
            entity.Property(e => e.KodMediniyot)
                .HasMaxLength(50)
                .HasColumnName("Kod_Mediniyot");
            entity.Property(e => e.Period).HasMaxLength(50);
            entity.Property(e => e.Shovi).HasMaxLength(50);
            entity.Property(e => e.Taarich).HasMaxLength(50);
            entity.Property(e => e.TeurTik)
                .HasMaxLength(250)
                .HasColumnName("Teur_Tik");
            entity.Property(e => e.Tik).HasMaxLength(50);
            entity.Property(e => e.Tsua).HasMaxLength(50);
            entity.Property(e => e.Yoez).HasMaxLength(50);
        });

        modelBuilder.Entity<TmpTnuot>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tmp_Tnuot");

            entity.Property(e => e.CounterPartyName)
                .HasMaxLength(50)
                .HasColumnName("Counter_Party_Name");
            entity.Property(e => e.ErechNakuv)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Erech_Nakuv");
            entity.Property(e => e.KodBasisHatzmada)
                .HasMaxLength(50)
                .HasColumnName("Kod_Basis_Hatzmada");
            entity.Property(e => e.KodMutzar)
                .HasMaxLength(50)
                .HasColumnName("Kod_Mutzar");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.KodPeula).HasColumnName("Kod_Peula");
            entity.Property(e => e.LoadProcessId).HasColumnName("Load_Process_ID");
            entity.Property(e => e.Shaar).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Shovi).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Taarich).HasColumnType("date");
        });

        modelBuilder.Entity<TmpTnuotGrouped>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tmp_Tnuot_Grouped");

            entity.Property(e => e.CounterPartyName)
                .HasMaxLength(50)
                .HasColumnName("Counter_Party_Name");
            entity.Property(e => e.ErechNakuv)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Erech_Nakuv");
            entity.Property(e => e.KodBasisHatzmada)
                .HasMaxLength(50)
                .HasColumnName("Kod_Basis_Hatzmada");
            entity.Property(e => e.KodMutzar)
                .HasMaxLength(50)
                .HasColumnName("Kod_Mutzar");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.KodPeula).HasColumnName("Kod_Peula");
            entity.Property(e => e.LoadProcessId).HasColumnName("Load_Process_ID");
            entity.Property(e => e.Shaar).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Shovi).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Taarich).HasColumnType("date");
        });

        modelBuilder.Entity<TmpUpdateShaarIska>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tmp_UpdateShaarIska");

            entity.Property(e => e.ConvKodNeches).HasColumnName("Conv_Kod_Neches");
            entity.Property(e => e.ConvKodNechesBasis).HasColumnName("Conv_Kod_Neches_Basis");
            entity.Property(e => e.CopyOfTaarichIska)
                .HasColumnType("datetime")
                .HasColumnName("Copy of TaarichIska");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.KodNechesBasis)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches_Basis");
            entity.Property(e => e.ShaarNb).HasColumnName("ShaarNB");
            entity.Property(e => e.TaarichIska).HasColumnType("date");
        });

        modelBuilder.Entity<TmpYpYomi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tmp_YP_Yomi");

            entity.Property(e => e.ChaverBursa)
                .HasMaxLength(50)
                .HasColumnName("Chaver_Bursa");
            entity.Property(e => e.KodChaverBursa).HasColumnName("Kod_Chaver_Bursa");
            entity.Property(e => e.KodMutzar).HasColumnName("Kod_Mutzar");
            entity.Property(e => e.Mutzar).HasMaxLength(50);
            entity.Property(e => e.PidyonotKamut).HasColumnName("Pidyonot_Kamut");
            entity.Property(e => e.PidyonotShovi)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Pidyonot_Shovi");
            entity.Property(e => e.Taarich).HasColumnType("date");
            entity.Property(e => e.YezirotKamut).HasColumnName("Yezirot_Kamut");
            entity.Property(e => e.YezirotShovi)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Yezirot_Shovi");
        });

        modelBuilder.Entity<TnutPitzulim>(entity =>
        {
            entity.ToTable("Tnut_Pitzulim");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ErechNakuv)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Erech_Nakuv");
            entity.Property(e => e.IdTnuoa).HasColumnName("ID_Tnuoa");
            entity.Property(e => e.KodMutzar).HasColumnName("Kod_Mutzar");
            entity.Property(e => e.Shaar).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Shovi).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.IdTnuoaNavigation).WithMany(p => p.TnutPitzulims)
                .HasForeignKey(d => d.IdTnuoa)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Tnut_Pitzulim_Tnut_Tnuot");
        });

        modelBuilder.Entity<TnutRpaVerification>(entity =>
        {
            entity.HasKey(e => new { e.KodNeches, e.CheshbonMakor, e.CheshbonYaad, e.Taarich });

            entity.ToTable("Tnut_RPA_Verification");

            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.CheshbonMakor)
                .HasMaxLength(50)
                .HasColumnName("Cheshbon_Makor");
            entity.Property(e => e.CheshbonYaad)
                .HasMaxLength(50)
                .HasColumnName("Cheshbon_Yaad");
            entity.Property(e => e.Taarich).HasColumnType("date");
        });

        modelBuilder.Entity<TnutStatusLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Tnut_Status_Log");

            entity.Property(e => e.InsUser)
                .HasMaxLength(50)
                .HasColumnName("Ins_User");
            entity.Property(e => e.TimeStamp).HasColumnType("datetime");
            entity.Property(e => e.TnuotId).HasColumnName("TnuotID");
            entity.Property(e => e.TnuotStatusId).HasColumnName("TnuotStatusID");

            entity.HasOne(d => d.Tnuot).WithMany()
                .HasForeignKey(d => d.TnuotId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Tnut_Status_Log_Tnut_Tnuot");

            entity.HasOne(d => d.TnuotStatus).WithMany()
                .HasForeignKey(d => d.TnuotStatusId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Tnut_Status_Log_Hgdr_Tnut_Status");
        });

        modelBuilder.Entity<TnutTnuot>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Tnut_Tnout");

            entity.ToTable("Tnut_Tnuot");

            entity.Property(e => e.Id).HasColumnName("ID");
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
                .HasConstraintName("FK_Tnut_Tnuot_Hgdr_Karteset");

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
                .HasConstraintName("FK_Tnut_Tnuot_Hgdr_Tnuot");

            entity.HasOne(d => d.StatusNavigation).WithMany(p => p.TnutTnuots)
                .HasForeignKey(d => d.Status)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Tnut_Tnuot_Hgdr_Tnut_Status");
        });

        modelBuilder.Entity<UserProfile>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__User_Pro__3214EC27BE93A33D");

            entity.ToTable("User_Profiles");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ProfileName).HasMaxLength(50);

            entity.HasMany(d => d.UserNames).WithMany(p => p.Profiles)
                .UsingEntity<Dictionary<string, object>>(
                    "UserProfilesUser",
                    r => r.HasOne<UserUser>().WithMany()
                        .HasForeignKey("UserName")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__ProfilesU__UserN__737017C0"),
                    l => l.HasOne<UserProfile>().WithMany()
                        .HasForeignKey("ProfileId")
                        .OnDelete(DeleteBehavior.ClientSetNull)
                        .HasConstraintName("FK__User_Prof__Profi__12B3B8EF"),
                    j =>
                    {
                        j.HasKey("ProfileId", "UserName").HasName("PK__User_Pro__4593A0C1F20575B2");
                        j.ToTable("User_ProfilesUsers");
                        j.IndexerProperty<int>("ProfileId").HasColumnName("ProfileID");
                        j.IndexerProperty<string>("UserName")
                            .HasMaxLength(20)
                            .IsUnicode(false);
                    });
        });

        modelBuilder.Entity<UserProfilesScreen>(entity =>
        {
            entity.HasKey(e => new { e.ProfileId, e.ScreenId }).HasName("PK__Profiles__69A7E87CBF52CF01");

            entity.ToTable("User_ProfilesScreens");

            entity.Property(e => e.ProfileId).HasColumnName("ProfileID");
            entity.Property(e => e.ScreenId).HasColumnName("ScreenID");

            entity.HasOne(d => d.Profile).WithMany(p => p.UserProfilesScreens)
                .HasForeignKey(d => d.ProfileId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ProfilesS__Profi__764C846B");

            entity.HasOne(d => d.Screen).WithMany(p => p.UserProfilesScreens)
                .HasForeignKey(d => d.ScreenId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__ProfilesS__Scree__7740A8A4");
        });

        modelBuilder.Entity<UserScreen>(entity =>
        {
            entity.HasKey(e => e.ScreenId).HasName("PK__Screens__0AB60F8595E0FAA0");

            entity.ToTable("User_Screens");

            entity.Property(e => e.ScreenId)
                .ValueGeneratedNever()
                .HasColumnName("ScreenID");
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.ScreenName)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        modelBuilder.Entity<UserUser>(entity =>
        {
            entity.HasKey(e => e.UserName).HasName("PK__Users__C9F284572CA951E8");

            entity.ToTable("User_Users");

            entity.Property(e => e.UserName)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsFixedLength();
        });

        modelBuilder.Entity<VAdditionalDataFinalFlat>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_AdditionalData_FinalFlat");

            entity.Property(e => e.ColumnId).HasColumnName("ColumnID");
            entity.Property(e => e.ColumnName).HasMaxLength(50);
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.KodYeshut).HasMaxLength(50);
            entity.Property(e => e.Value).HasMaxLength(250);
        });

        modelBuilder.Entity<VAdditionalDataFinalYeshut>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_AdditionalData_FinalYeshut");

            entity.Property(e => e.ColumnId).HasColumnName("ColumnID");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
        });

        modelBuilder.Entity<VAdditionalDataRaw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_AdditionalData_Raw");

            entity.Property(e => e.ColumnId).HasColumnName("ColumnID");
            entity.Property(e => e.ColumnName).HasMaxLength(50);
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.KodYeshut).HasMaxLength(50);
            entity.Property(e => e.Value).HasMaxLength(250);
        });

        modelBuilder.Entity<VAdditionalDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_AdditionalData");

            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.אסטרטגייתקרןההשקעה)
                .HasMaxLength(250)
                .HasColumnName("אסטרטגיית קרן ההשקעה");
            entity.Property(e => e.האםסווגכחובבעייתי)
                .HasMaxLength(250)
                .HasColumnName("האם סווג כחוב בעייתי");
            entity.Property(e => e.השיטהשבאמצעותהנקבעשוויהנכס)
                .HasMaxLength(250)
                .HasColumnName("השיטה שבאמצעותה נקבע שווי הנכס ");
            entity.Property(e => e.זכותחזרה)
                .HasMaxLength(250)
                .HasColumnName("זכות חזרה");
            entity.Property(e => e.זכותפירעוןמוקדם)
                .HasMaxLength(250)
                .HasColumnName("זכות פירעון מוקדם");
            entity.Property(e => e.יעודהלוואה)
                .HasMaxLength(250)
                .HasColumnName("יעוד הלוואה");
            entity.Property(e => e.כתובתהנכס)
                .HasMaxLength(250)
                .HasColumnName("כתובת הנכס");
            entity.Property(e => e.מאפייןהלוואותמתואמותעבורזכויותמקרקעין)
                .HasMaxLength(250)
                .HasColumnName("מאפיין הלוואות מתואמות עבור זכויות מקרקעין");
            entity.Property(e => e.מאפייןעיקרי)
                .HasMaxLength(250)
                .HasColumnName("מאפיין עיקרי");
            entity.Property(e => e.מדינתמיקוםנדלן)
                .HasMaxLength(250)
                .HasColumnName("מדינת מיקום נדל\"ן");
            entity.Property(e => e.מועדעדכוןאחרוןלשוויהבטוחות)
                .HasMaxLength(250)
                .HasColumnName("מועד עדכון אחרון לשווי הבטוחות");
            entity.Property(e => e.מחזורחייהנכס)
                .HasMaxLength(250)
                .HasColumnName("מחזור חיי הנכס");
            entity.Property(e => e.מטבע)
                .HasMaxLength(250)
                .HasColumnName("מטבע ");
            entity.Property(e => e.מיקוםמשרדהשותףהכללי)
                .HasMaxLength(250)
                .HasColumnName("מיקום משרד השותף הכללי");
            entity.Property(e => e.מסגרתאשראיבמועדהעמדה)
                .HasMaxLength(250)
                .HasColumnName("מסגרת אשראי במועד העמדה");
            entity.Property(e => e.מספרLei)
                .HasMaxLength(250)
                .HasColumnName("מספר LEI");
            entity.Property(e => e.מספרמזההשותףכלליקרןהשקעות)
                .HasMaxLength(250)
                .HasColumnName("מספר מזהה שותף כללי קרן השקעות");
            entity.Property(e => e.מספרנכסיםבמדדנכסייחוסקרנותנאמנות)
                .HasMaxLength(250)
                .HasColumnName("מספר נכסים במדד נכס ייחוס - קרנות נאמנות");
            entity.Property(e => e.מספרקונסורציוםסינדיקציה)
                .HasMaxLength(250)
                .HasColumnName("מספר קונסורציום/סינדיקציה");
            entity.Property(e => e.נחיתותחוזית)
                .HasMaxLength(250)
                .HasColumnName("נחיתות חוזית");
            entity.Property(e => e.נכסבסיס)
                .HasMaxLength(250)
                .HasColumnName("נכס בסיס");
            entity.Property(e => e.סוגבטוחה)
                .HasMaxLength(250)
                .HasColumnName("סוג בטוחה");
            entity.Property(e => e.סוגגורםמשערך)
                .HasMaxLength(250)
                .HasColumnName("סוג גורם משערך");
            entity.Property(e => e.סוגהנכס)
                .HasMaxLength(250)
                .HasColumnName("סוג הנכס");
            entity.Property(e => e.סוגהסליקה)
                .HasMaxLength(250)
                .HasColumnName("סוג הסליקה");
            entity.Property(e => e.סוגהצמדה)
                .HasMaxLength(250)
                .HasColumnName("סוג הצמדה");
            entity.Property(e => e.סוגלוס)
                .HasMaxLength(250)
                .HasColumnName("סוג לוס");
            entity.Property(e => e.סוגמספרמזההשותףכלליקרןהשקעות)
                .HasMaxLength(250)
                .HasColumnName("סוג מספר מזהה שותף כללי קרן השקעות");
            entity.Property(e => e.סיווגהחובכבעייתי)
                .HasMaxLength(250)
                .HasColumnName("סיווג החוב כבעייתי");
            entity.Property(e => e.סיווגהקרן)
                .HasMaxLength(250)
                .HasColumnName("סיווג הקרן");
            entity.Property(e => e.סכוםמסגרתהאשראיהראשוניבמטבעהפעילותIHub)
                .HasMaxLength(250)
                .HasColumnName("סכום מסגרת האשראי הראשוני (במטבע הפעילות) - iHub");
            entity.Property(e => e.עלותמופחתתבמטבעהפעילות)
                .HasMaxLength(250)
                .HasColumnName("עלות מופחתת (במטבע הפעילות)");
            entity.Property(e => e.עלותמופחתתבשח)
                .HasMaxLength(250)
                .HasColumnName("עלות מופחתת (בש\"ח)");
            entity.Property(e => e.פקטורמוביל)
                .HasMaxLength(250)
                .HasColumnName("פקטור מוביל");
            entity.Property(e => e.פקטורנוסף)
                .HasMaxLength(250)
                .HasColumnName("פקטור נוסף");
            entity.Property(e => e.ריביתעוגןלדיווח)
                .HasMaxLength(250)
                .HasColumnName("ריבית עוגן לדיווח");
            entity.Property(e => e.שוויהבטוחותהעומדותכנגדההלוואה)
                .HasMaxLength(250)
                .HasColumnName("שווי הבטוחות העומדות כנגד ההלוואה");
            entity.Property(e => e.שווימאזניבשח)
                .HasMaxLength(250)
                .HasColumnName("שווי מאזני (בש\"ח)");
            entity.Property(e => e.שיטהשיושמהבדיווחהכספי)
                .HasMaxLength(250)
                .HasColumnName("שיטה שיושמה בדיווח הכספי");
            entity.Property(e => e.שימושעיקריבנכס)
                .HasMaxLength(250)
                .HasColumnName("שימוש עיקרי בנכס");
            entity.Property(e => e.שיעוראחזקהבאמצעישליטה)
                .HasMaxLength(250)
                .HasColumnName("שיעור אחזקה באמצעי שליטה");
            entity.Property(e => e.שיעורהקנסבגיןיציאהמוקדמתIHub)
                .HasMaxLength(250)
                .HasColumnName("שיעור הקנס בגין יציאה מוקדמת - iHub");
            entity.Property(e => e.שיעורתשואהבפועלבמהלךהרבעון)
                .HasMaxLength(250)
                .HasColumnName("שיעור תשואה בפועל במהלך הרבעון");
            entity.Property(e => e.שםגורםמשערך)
                .HasMaxLength(250)
                .HasColumnName("שם גורם משערך");
            entity.Property(e => e.שםמוסתר)
                .HasMaxLength(250)
                .HasColumnName("שם מוסתר");
            entity.Property(e => e.שםשותףכלליקרןהשקעות)
                .HasMaxLength(250)
                .HasColumnName("שם שותף כללי קרן השקעות");
            entity.Property(e => e.שערהנגזרבמועדההתקשרותבעסקהIHub)
                .HasMaxLength(250)
                .HasColumnName("שער הנגזר במועד ההתקשרות בעסקה - iHub");
            entity.Property(e => e.שערנכסהבסיסבמועדההתקשרותבעסקהIHub)
                .HasMaxLength(250)
                .HasColumnName("שער נכס הבסיס במועד ההתקשרות בעסקה - iHub");
            entity.Property(e => e.תאורמדדנכסייחוסקרנותנאמנות)
                .HasMaxLength(250)
                .HasColumnName("תאור מדד נכס ייחוס - קרנות נאמנות");
            entity.Property(e => e.תאריךאחרוןבונבחנהבפועלירידתערך)
                .HasMaxLength(250)
                .HasColumnName("תאריך אחרון בו נבחנה בפועל ירידת ערך");
            entity.Property(e => e.תאריךעסקה)
                .HasMaxLength(250)
                .HasColumnName("תאריך עסקה");
            entity.Property(e => e.תאריךרכישה)
                .HasMaxLength(250)
                .HasColumnName("תאריך רכישה");
            entity.Property(e => e.תאריךשערוךאחרוןIHub)
                .HasMaxLength(250)
                .HasColumnName("תאריך שערוך אחרון - iHub");
            entity.Property(e => e.תדירותReset)
                .HasMaxLength(250)
                .HasColumnName("תדירות Reset");
            entity.Property(e => e.תקופתריביתעוגן)
                .HasMaxLength(250)
                .HasColumnName("תקופת ריבית עוגן");
        });

        modelBuilder.Entity<VBkpMvTk>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Bkp_MvTk");

            entity.Property(e => e.Afik).HasMaxLength(50);
            entity.Property(e => e.DateTime).HasColumnType("date");
            entity.Property(e => e.KodNeches).HasColumnName("Kod_Neches");
            entity.Property(e => e.KodSugMishkal).HasColumnName("Kod_Sug_Mishkal");
            entity.Property(e => e.KodSugModel).HasColumnName("Kod_Sug_Model");
            entity.Property(e => e.KodTikModel).HasColumnName("Kod_Tik_Model");
            entity.Property(e => e.Mishkal).HasColumnType("decimal(5, 4)");
            entity.Property(e => e.Neches).HasMaxLength(250);
            entity.Property(e => e.Remark).HasMaxLength(50);
            entity.Property(e => e.TeurSugMishkal)
                .HasMaxLength(50)
                .HasColumnName("Teur_Sug_Mishkal");
            entity.Property(e => e.TeurSugModel)
                .HasMaxLength(50)
                .HasColumnName("Teur_Sug_Model");
            entity.Property(e => e.TeurTatAfik)
                .HasMaxLength(50)
                .HasColumnName("Teur_Tat_Afik");
        });

        modelBuilder.Entity<VBtzTnout>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_BTZ_Tnout");

            entity.Property(e => e.AccountId).HasColumnName("Account_ID");
            entity.Property(e => e.InsUser)
                .HasMaxLength(50)
                .HasColumnName("Ins_User");
            entity.Property(e => e.IsGilgul).HasColumnName("Is_Gilgul");
            entity.Property(e => e.KodMutzar).HasColumnName("Kod_Mutzar");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.Mutzar).HasMaxLength(50);
            entity.Property(e => e.Remarks).HasMaxLength(255);
            entity.Property(e => e.SecurityId)
                .HasMaxLength(50)
                .HasColumnName("Security_ID");
            entity.Property(e => e.Shaar).HasColumnType("decimal(18, 4)");
            entity.Property(e => e.SibatRechisha).HasColumnName("Sibat_Rechisha");
            entity.Property(e => e.TaarichPeula)
                .HasColumnType("date")
                .HasColumnName("Taarich_Peula");
        });

        modelBuilder.Entity<VCheshbonDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Cheshbon_Details");

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.Property).HasMaxLength(128);
            entity.Property(e => e.Value).HasMaxLength(100);
        });

        modelBuilder.Entity<VDhyAmlotBroker>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_DHY_Amlot_Broker");

            entity.Property(e => e.Broker).HasMaxLength(50);
            entity.Property(e => e.Cheshbon).HasMaxLength(50);
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.KodCheshbon)
                .HasMaxLength(50)
                .HasColumnName("Kod_Cheshbon");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.Matbea).HasMaxLength(50);
            entity.Property(e => e.Neches).HasMaxLength(50);
            entity.Property(e => e.Shovi).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TaarichErech)
                .HasColumnType("date")
                .HasColumnName("Taarich_Erech");
        });

        modelBuilder.Entity<VDimMatbea>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Dim_Matbea");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.KodMatbea)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("Kod_Matbea");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.Matbea).HasMaxLength(50);
        });

        modelBuilder.Entity<VDimMutzar>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Dim_Mutzar");

            entity.Property(e => e.IsKerenMechaka).HasColumnName("Is_Keren_Mechaka");
            entity.Property(e => e.KodCheshbonMatach)
                .HasMaxLength(50)
                .HasColumnName("Kod_Cheshbon_Matach");
            entity.Property(e => e.KodCheshbonShekel)
                .HasMaxLength(50)
                .HasColumnName("Kod_Cheshbon_Shekel");
            entity.Property(e => e.KodMutzar).HasColumnName("Kod_Mutzar");
            entity.Property(e => e.KodSugMutzar).HasColumnName("Kod_Sug_Mutzar");
            entity.Property(e => e.Medina).HasMaxLength(50);
            entity.Property(e => e.Menahel).HasMaxLength(50);
            entity.Property(e => e.Mutzar).HasMaxLength(50);
            entity.Property(e => e.SugMutzar)
                .HasMaxLength(50)
                .HasColumnName("Sug_Mutzar");
        });

        modelBuilder.Entity<VDimNech>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Dim_Neches");

            entity.Property(e => e.CancelOrderExport).HasColumnName("Cancel_Order_Export");
            entity.Property(e => e.CheshbonYaadDefault).HasColumnName("Cheshbon_Yaad_Default");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.KodMachshir).HasColumnName("Kod_Machshir");
            entity.Property(e => e.KodMatbea).HasColumnName("Kod_Matbea");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.Machshir).HasMaxLength(50);
            entity.Property(e => e.Neches).HasMaxLength(250);
        });

        modelBuilder.Entity<VDimTime>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_DIM_Time");

            entity.Property(e => e.Chodesh)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.KodChodesh).HasColumnName("Kod_Chodesh");
            entity.Property(e => e.KodShana).HasColumnName("Kod_Shana");
            entity.Property(e => e.KodYom).HasColumnName("Kod_Yom");
            entity.Property(e => e.Shana)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SortChodesh).HasColumnName("Sort_Chodesh");
            entity.Property(e => e.SortShana).HasColumnName("Sort_Shana");
            entity.Property(e => e.SortYom).HasColumnName("Sort_Yom");
            entity.Property(e => e.TaarichId)
                .HasColumnType("date")
                .HasColumnName("Taarich_ID");
            entity.Property(e => e.Yom)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VDimTimeTrade>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_DIM_Time_Trade");

            entity.Property(e => e.Chodesh)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.KodChodesh).HasColumnName("Kod_Chodesh");
            entity.Property(e => e.KodShana).HasColumnName("Kod_Shana");
            entity.Property(e => e.KodYom).HasColumnName("Kod_Yom");
            entity.Property(e => e.Shana)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SortChodesh).HasColumnName("Sort_Chodesh");
            entity.Property(e => e.SortShana).HasColumnName("Sort_Shana");
            entity.Property(e => e.SortYom).HasColumnName("Sort_Yom");
            entity.Property(e => e.TaarichId)
                .HasColumnType("date")
                .HasColumnName("Taarich_ID");
            entity.Property(e => e.Yom)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VDvchAfikHashkaaMuvtachTsua>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Dvch_AfikHashkaaMuvtachTsua");

            entity.Property(e => e.חודשהבדיקה)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("חודש הבדיקה");
            entity.Property(e => e.חודשהנפקתשכבה)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("חודש הנפקת שכבה");
            entity.Property(e => e.מאפייןעיקרי)
                .HasMaxLength(250)
                .HasColumnName("מאפיין עיקרי");
            entity.Property(e => e.מספרמסלול).HasColumnName("מספר מסלול");
            entity.Property(e => e.מספרקרן).HasColumnName("מספר קרן");
            entity.Property(e => e.שוויהנכסיםבאפיק)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("שווי הנכסים באפיק");
            entity.Property(e => e.שיעורמסךנכסיההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מסך נכסי ההשקעה");
        });

        modelBuilder.Entity<VDvchAgach>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Dvch_Agach");

            entity.Property(e => e.בעלענייןצדקשור)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("בעל עניין/צד קשור");
            entity.Property(e => e.דירוג).HasMaxLength(50);
            entity.Property(e => e.דירוגניירהערךהמנפיק)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("דירוג נייר הערך/המנפיק");
            entity.Property(e => e.האםסווגכחובבעייתי)
                .HasMaxLength(250)
                .HasColumnName("האם סווג כחוב בעייתי");
            entity.Property(e => e.השיטהשיושמהבדוחהכספי)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("השיטה שיושמה בדוח הכספי");
            entity.Property(e => e.זירתמסחר)
                .HasMaxLength(250)
                .HasColumnName("זירת מסחר");
            entity.Property(e => e.ישראלחול)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ישראל/חו\"ל");
            entity.Property(e => e.מאפייןעיקרי)
                .HasMaxLength(250)
                .HasColumnName("מאפיין עיקרי");
            entity.Property(e => e.מדינהלפיחשיפהכלכלית)
                .HasMaxLength(50)
                .HasColumnName("מדינה לפי חשיפה כלכלית");
            entity.Property(e => e.מועדפדיון)
                .HasMaxLength(4000)
                .HasColumnName("מועד פדיון");
            entity.Property(e => e.מחמ)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("מח\"מ");
            entity.Property(e => e.מטבעפעילות)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("מטבע פעילות");
            entity.Property(e => e.מספרמנפיק).HasColumnName("מספר מנפיק");
            entity.Property(e => e.מספרמסלול).HasColumnName("מספר מסלול");
            entity.Property(e => e.מספרניירערך)
                .HasMaxLength(50)
                .HasColumnName("מספר נייר ערך");
            entity.Property(e => e.מספרקופהקרןחפעבורחברתביטוח).HasColumnName("מספר קופה/קרן/ח.פ. עבור חברת ביטוח");
            entity.Property(e => e.נחיתותחוזית)
                .HasMaxLength(250)
                .HasColumnName("נחיתות חוזית");
            entity.Property(e => e.סוגמספרמזההמנפיק)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("סוג מספר מזהה מנפיק");
            entity.Property(e => e.סוגמספרניירערך)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("סוג מספר נייר ערך");
            entity.Property(e => e.סטאטוססחירות)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("סטאטוס סחירות");
            entity.Property(e => e.סכוםלקבלבמטבעהפעילות)
                .HasColumnType("decimal(38, 7)")
                .HasColumnName("סכום לקבל (במטבע הפעילות)");
            entity.Property(e => e.עלותמופחתתבמטבעהפעילות)
                .HasMaxLength(250)
                .HasColumnName("עלות מופחתת (במטבע הפעילות)");
            entity.Property(e => e.עלותמופחתתבשח)
                .HasMaxLength(250)
                .HasColumnName("עלות מופחתת (בש\"ח)");
            entity.Property(e => e.ענףמסחר)
                .HasMaxLength(250)
                .HasColumnName("ענף מסחר");
            entity.Property(e => e.ערךנקוביחידות)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ערך נקוב (יחידות)");
            entity.Property(e => e.שוויהוגןבשח)
                .HasColumnType("decimal(23, 7)")
                .HasColumnName("שווי הוגן (בש\"ח)");
            entity.Property(e => e.שיעורמנכסיאפיקההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מנכסי אפיק ההשקעה");
            entity.Property(e => e.שיעורמסךנכסיההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מסך נכסי ההשקעה");
            entity.Property(e => e.שיעורמערךנקובמונפק)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מערך נקוב מונפק");
            entity.Property(e => e.שיעורריבית)
                .HasMaxLength(4000)
                .HasColumnName("שיעור ריבית");
            entity.Property(e => e.שםמדרג)
                .HasMaxLength(50)
                .HasColumnName("שם מדרג");
            entity.Property(e => e.שםמנפיק)
                .HasMaxLength(50)
                .HasColumnName("שם מנפיק");
            entity.Property(e => e.שםניירערך).HasColumnName("שם נייר ערך");
            entity.Property(e => e.שערחליפין)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער חליפין");
            entity.Property(e => e.שערניירהערך)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער נייר הערך");
            entity.Property(e => e.תשואהלפדיון)
                .HasMaxLength(4000)
                .HasColumnName("תשואה לפדיון");
        });

        modelBuilder.Entity<VDvchAgachLoSachir>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Dvch_Agach_LoSachir");

            entity.Property(e => e.בעלענייןצדקשור)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("בעל עניין/צד קשור");
            entity.Property(e => e.דירוג).HasMaxLength(50);
            entity.Property(e => e.דירוגניירהערךהמנפיק)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("דירוג נייר הערך/המנפיק");
            entity.Property(e => e.האםסווגכחובבעייתי)
                .HasMaxLength(250)
                .HasColumnName("האם סווג כחוב בעייתי");
            entity.Property(e => e.השיטהשיושמהבדוחהכספי)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("השיטה שיושמה בדוח הכספי");
            entity.Property(e => e.ישראלחול)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ישראל/חו\"ל");
            entity.Property(e => e.מאפייןעיקרי)
                .HasMaxLength(250)
                .HasColumnName("מאפיין עיקרי");
            entity.Property(e => e.מדינהלפיחשיפהכלכלית)
                .HasMaxLength(50)
                .HasColumnName("מדינה לפי חשיפה כלכלית");
            entity.Property(e => e.מועדפדיון)
                .HasMaxLength(4000)
                .HasColumnName("מועד פדיון");
            entity.Property(e => e.מחמ)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("מח\"מ");
            entity.Property(e => e.מטבעפעילות)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("מטבע פעילות");
            entity.Property(e => e.מספרמנפיק).HasColumnName("מספר מנפיק");
            entity.Property(e => e.מספרמסלול).HasColumnName("מספר מסלול");
            entity.Property(e => e.מספרניירערך)
                .HasMaxLength(50)
                .HasColumnName("מספר נייר ערך");
            entity.Property(e => e.מספרקופהקרןחפעבורחברתביטוח).HasColumnName("מספר קופה/קרן/ח.פ. עבור חברת ביטוח");
            entity.Property(e => e.נחיתותחוזית)
                .HasMaxLength(250)
                .HasColumnName("נחיתות חוזית");
            entity.Property(e => e.סוגגורםמשערך)
                .HasMaxLength(250)
                .HasColumnName("סוג גורם משערך");
            entity.Property(e => e.סוגמספרמזההמנפיק)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("סוג מספר מזהה מנפיק");
            entity.Property(e => e.סוגמספרניירערך)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("סוג מספר נייר ערך");
            entity.Property(e => e.סטאטוססחירות)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("סטאטוס סחירות");
            entity.Property(e => e.עלותמופחתתבמטבעהפעילות)
                .HasMaxLength(250)
                .HasColumnName("עלות מופחתת (במטבע הפעילות)");
            entity.Property(e => e.עלותמופחתתבשח)
                .HasMaxLength(250)
                .HasColumnName("עלות מופחתת (בש\"ח)");
            entity.Property(e => e.ענףמסחר)
                .HasMaxLength(250)
                .HasColumnName("ענף מסחר");
            entity.Property(e => e.ערךנקוביחידות)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ערך נקוב (יחידות)");
            entity.Property(e => e.שוויהוגןבשח)
                .HasColumnType("decimal(23, 7)")
                .HasColumnName("שווי הוגן (בש\"ח)");
            entity.Property(e => e.שיעורמנכסיאפיקההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מנכסי אפיק ההשקעה");
            entity.Property(e => e.שיעורמסךנכסיההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מסך נכסי ההשקעה");
            entity.Property(e => e.שיעורריבית)
                .HasMaxLength(4000)
                .HasColumnName("שיעור ריבית");
            entity.Property(e => e.שםמדרג)
                .HasMaxLength(50)
                .HasColumnName("שם מדרג");
            entity.Property(e => e.שםמנפיק)
                .HasMaxLength(50)
                .HasColumnName("שם מנפיק");
            entity.Property(e => e.שםניירערך).HasColumnName("שם נייר ערך");
            entity.Property(e => e.שערחליפין)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער חליפין");
            entity.Property(e => e.שערניירהערך)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער נייר הערך");
            entity.Property(e => e.תאריךאחרוןבונבחנהבפועלירידתערך)
                .HasMaxLength(250)
                .HasColumnName("תאריך אחרון בו נבחנה בפועל ירידת ערך");
            entity.Property(e => e.תאריךרכישה)
                .HasMaxLength(250)
                .HasColumnName("תאריך רכישה");
            entity.Property(e => e.תאריךשערוךאחרון)
                .HasMaxLength(4000)
                .HasColumnName("תאריך שערוך אחרון");
            entity.Property(e => e.תלותאיתלותהמשערך)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("תלות/אי-תלות המשערך");
            entity.Property(e => e.תשואהלפדיון)
                .HasMaxLength(4000)
                .HasColumnName("תשואה לפדיון");
        });

        modelBuilder.Entity<VDvchAgachMemshalti>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Dvch_AgachMemshalti");

            entity.Property(e => e.דירוג).HasMaxLength(50);
            entity.Property(e => e.השיטהשיושמהבדוחהכספי)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("השיטה שיושמה בדוח הכספי");
            entity.Property(e => e.זירתמסחר)
                .HasMaxLength(250)
                .HasColumnName("זירת מסחר");
            entity.Property(e => e.ישראלחול)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ישראל/חו\"ל");
            entity.Property(e => e.מאפייןעיקרי)
                .HasMaxLength(250)
                .HasColumnName("מאפיין עיקרי");
            entity.Property(e => e.מדינהלפיחשיפהכלכלית)
                .HasMaxLength(50)
                .HasColumnName("מדינה לפי חשיפה כלכלית");
            entity.Property(e => e.מועדפדיון)
                .HasMaxLength(4000)
                .HasColumnName("מועד פדיון");
            entity.Property(e => e.מחמ)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("מח\"מ");
            entity.Property(e => e.מטבעפעילות)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("מטבע פעילות");
            entity.Property(e => e.מספרמסלול).HasColumnName("מספר מסלול");
            entity.Property(e => e.מספרניירערך)
                .HasMaxLength(50)
                .HasColumnName("מספר נייר ערך");
            entity.Property(e => e.מספרקופהקרןחפעבורחברתביטוח).HasColumnName("מספר קופה/קרן/ח.פ. עבור חברת ביטוח");
            entity.Property(e => e.סכוםלקבלבמטבעהפעילות)
                .HasColumnType("decimal(38, 7)")
                .HasColumnName("סכום לקבל (במטבע הפעילות)");
            entity.Property(e => e.עלותמופחתתבשח)
                .HasMaxLength(250)
                .HasColumnName("עלות מופחתת (בש\"ח)");
            entity.Property(e => e.ערךנקוביחידות)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ערך נקוב (יחידות)");
            entity.Property(e => e.שוויהוגןבשח)
                .HasColumnType("decimal(23, 7)")
                .HasColumnName("שווי הוגן (בש\"ח)");
            entity.Property(e => e.שיעורמנכסיאפיקההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מנכסי אפיק ההשקעה");
            entity.Property(e => e.שיעורמסךנכסיההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מסך נכסי ההשקעה");
            entity.Property(e => e.שיעורמערךנקובמונפק)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מערך נקוב מונפק");
            entity.Property(e => e.שיעורריבית)
                .HasMaxLength(4000)
                .HasColumnName("שיעור ריבית");
            entity.Property(e => e.שםמדרג)
                .HasMaxLength(50)
                .HasColumnName("שם מדרג");
            entity.Property(e => e.שםמנפיק)
                .HasMaxLength(50)
                .HasColumnName("שם מנפיק");
            entity.Property(e => e.שםניירערך).HasColumnName("שם נייר ערך");
            entity.Property(e => e.שערחליפין)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער חליפין");
            entity.Property(e => e.שערניירהערך)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער נייר הערך");
            entity.Property(e => e.תשואהלפדיון)
                .HasMaxLength(4000)
                .HasColumnName("תשואה לפדיון");
        });

        modelBuilder.Entity<VDvchAgachMemshaltiLoSachir>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Dvch_AgachMemshalti_LoSachir");

            entity.Property(e => e.דירוג).HasMaxLength(50);
            entity.Property(e => e.השיטהשיושמהבדוחהכספי)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("השיטה שיושמה בדוח הכספי");
            entity.Property(e => e.ישראלחול)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ישראל/חו\"ל");
            entity.Property(e => e.מאפייןעיקרי)
                .HasMaxLength(250)
                .HasColumnName("מאפיין עיקרי");
            entity.Property(e => e.מדינהלפיחשיפהכלכלית)
                .HasMaxLength(50)
                .HasColumnName("מדינה לפי חשיפה כלכלית");
            entity.Property(e => e.מועדפדיון)
                .HasMaxLength(4000)
                .HasColumnName("מועד פדיון");
            entity.Property(e => e.מחמ)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("מח\"מ");
            entity.Property(e => e.מטבעפעילות)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("מטבע פעילות");
            entity.Property(e => e.מספרמסלול).HasColumnName("מספר מסלול");
            entity.Property(e => e.מספרניירערך)
                .HasMaxLength(50)
                .HasColumnName("מספר נייר ערך");
            entity.Property(e => e.מספרקופהקרןחפעבורחברתביטוח).HasColumnName("מספר קופה/קרן/ח.פ. עבור חברת ביטוח");
            entity.Property(e => e.סוגמספרניירערך)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("סוג מספר נייר ערך");
            entity.Property(e => e.עלותמופחתתבשח)
                .HasMaxLength(250)
                .HasColumnName("עלות מופחתת (בש\"ח)");
            entity.Property(e => e.ערךנקוביחידות)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ערך נקוב (יחידות)");
            entity.Property(e => e.שוויהוגןבשח)
                .HasColumnType("decimal(23, 7)")
                .HasColumnName("שווי הוגן (בש\"ח)");
            entity.Property(e => e.שיעורמנכסיאפיקההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מנכסי אפיק ההשקעה");
            entity.Property(e => e.שיעורמסךנכסיההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מסך נכסי ההשקעה");
            entity.Property(e => e.שיעורריבית)
                .HasMaxLength(4000)
                .HasColumnName("שיעור ריבית");
            entity.Property(e => e.שםמדרג)
                .HasMaxLength(50)
                .HasColumnName("שם מדרג");
            entity.Property(e => e.שםמנפיק)
                .HasMaxLength(50)
                .HasColumnName("שם מנפיק");
            entity.Property(e => e.שםניירערך).HasColumnName("שם נייר ערך");
            entity.Property(e => e.שערחליפין)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער חליפין");
            entity.Property(e => e.שערניירהערך)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער נייר הערך");
            entity.Property(e => e.תאריךרכישה)
                .HasMaxLength(250)
                .HasColumnName("תאריך רכישה");
            entity.Property(e => e.תשואהלפדיון)
                .HasMaxLength(4000)
                .HasColumnName("תשואה לפדיון");
        });

        modelBuilder.Entity<VDvchAgachMiuadotLoSachir>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Dvch_AgachMiuadot_LoSachir");

            entity.Property(e => e.השיטהשיושמהבדוחהכספי)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("השיטה שיושמה בדוח הכספי");
            entity.Property(e => e.מאפייןעיקרי)
                .HasMaxLength(250)
                .HasColumnName("מאפיין עיקרי");
            entity.Property(e => e.מועדפדיון)
                .HasMaxLength(4000)
                .HasColumnName("מועד פדיון");
            entity.Property(e => e.מחמ)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("מח\"מ");
            entity.Property(e => e.מספרמסלול).HasColumnName("מספר מסלול");
            entity.Property(e => e.מספרניירערך)
                .HasMaxLength(50)
                .HasColumnName("מספר נייר ערך");
            entity.Property(e => e.מספרקופהקרןחפעבורחברתביטוח).HasColumnName("מספר קופה/קרן/ח.פ. עבור חברת ביטוח");
            entity.Property(e => e.סוגהצמדה)
                .HasMaxLength(250)
                .HasColumnName("סוג הצמדה");
            entity.Property(e => e.עלותמופחתתבשח)
                .HasMaxLength(250)
                .HasColumnName("עלות מופחתת (בש\"ח)");
            entity.Property(e => e.ערךנקוביחידות)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ערך נקוב (יחידות)");
            entity.Property(e => e.שוויהוגןבשח)
                .HasColumnType("decimal(23, 7)")
                .HasColumnName("שווי הוגן (בש\"ח)");
            entity.Property(e => e.שיעורמנכסיאפיקההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מנכסי אפיק ההשקעה");
            entity.Property(e => e.שיעורמסךנכסיההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מסך נכסי ההשקעה");
            entity.Property(e => e.שיעורריבית)
                .HasMaxLength(4000)
                .HasColumnName("שיעור ריבית");
            entity.Property(e => e.שםניירערך).HasColumnName("שם נייר ערך");
            entity.Property(e => e.שערניירהערך)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער נייר הערך");
            entity.Property(e => e.תאריךרכישה)
                .HasMaxLength(250)
                .HasColumnName("תאריך רכישה");
            entity.Property(e => e.תשואהלפדיון)
                .HasMaxLength(4000)
                .HasColumnName("תשואה לפדיון");
        });

        modelBuilder.Entity<VDvchAllDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Dvch_AllData");

            entity.Property(e => e.Afik).HasMaxLength(50);
            entity.Property(e => e.Chasifa).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Hp)
                .HasMaxLength(50)
                .HasColumnName("HP");
            entity.Property(e => e.IdDvchSheet).HasColumnName("ID_DvchSheet");
            entity.Property(e => e.KodAnaf).HasColumnName("Kod_Anaf");
            entity.Property(e => e.KodMachshir).HasColumnName("Kod_Machshir");
            entity.Property(e => e.KodManpikSnir).HasColumnName("Kod_Manpik_Snir");
            entity.Property(e => e.KodMedinatChasifa).HasColumnName("Kod_Medinat_Chasifa");
            entity.Property(e => e.KodMutzar).HasColumnName("Kod_Mutzar");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.KodNechesAd)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches_AD");
            entity.Property(e => e.KodRibitOgen)
                .HasMaxLength(50)
                .HasColumnName("Kod_Ribit_Ogen");
            entity.Property(e => e.KodSchirut).HasColumnName("Kod_Schirut");
            entity.Property(e => e.KodSugMutzar).HasColumnName("Kod_Sug_Mutzar");
            entity.Property(e => e.KodSugYitra).HasColumnName("Kod_Sug_Yitra");
            entity.Property(e => e.KodTatAfik).HasColumnName("Kod_TatAfik");
            entity.Property(e => e.Machshir).HasMaxLength(50);
            entity.Property(e => e.Mutzar).HasMaxLength(50);
            entity.Property(e => e.Navבמטבעהדיווחשלקרןההשקעה)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("NAV (במטבע הדיווח של קרן ההשקעה)");
            entity.Property(e => e.Pitzul).HasColumnType("decimal(19, 18)");
            entity.Property(e => e.RegilaLekabel).HasColumnName("Regila_Lekabel");
            entity.Property(e => e.ShaarIska).HasColumnName("Shaar_Iska");
            entity.Property(e => e.ShaarMatbea)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("Shaar_Matbea");
            entity.Property(e => e.ShoviKupa).HasColumnType("decimal(38, 6)");
            entity.Property(e => e.Taarich).HasColumnType("date");
            entity.Property(e => e.TaarichRechisha)
                .HasColumnType("date")
                .HasColumnName("Taarich_Rechisha");
            entity.Property(e => e.TaarichShiaruchAcharon)
                .HasColumnType("date")
                .HasColumnName("Taarich_Shiaruch_Acharon");
            entity.Property(e => e.TeurAnaf)
                .HasMaxLength(50)
                .HasColumnName("Teur_Anaf");
            entity.Property(e => e.Ticker).HasMaxLength(50);
            entity.Property(e => e.YitraLekabel)
                .HasColumnType("decimal(38, 7)")
                .HasColumnName("Yitra_Lekabel");
            entity.Property(e => e.אסטרטגייתקרןההשקעה)
                .HasMaxLength(250)
                .HasColumnName("אסטרטגיית קרן ההשקעה");
            entity.Property(e => e.בעלענייןצדקשור)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("בעל עניין/צד קשור");
            entity.Property(e => e.גורםמצטט)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("גורם מצטט");
            entity.Property(e => e.דירוג).HasMaxLength(50);
            entity.Property(e => e.דירוגהבנק)
                .HasMaxLength(50)
                .HasColumnName("דירוג הבנק");
            entity.Property(e => e.דירוגהלוואההמנפיק)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("דירוג הלוואה/המנפיק");
            entity.Property(e => e.דירוגניירהערךהמנפיק)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("דירוג נייר הערך/המנפיק");
            entity.Property(e => e.האםסווגכחובבעייתי)
                .HasMaxLength(250)
                .HasColumnName("האם סווג כחוב בעייתי");
            entity.Property(e => e.האםקייםקנסבגיןיציאהמוקדמת)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("האם קיים קנס בגין יציאה מוקדמת");
            entity.Property(e => e.השיטהשבאמצעותהנקבעשוויהנכס)
                .HasMaxLength(250)
                .HasColumnName("השיטה שבאמצעותה נקבע שווי הנכס ");
            entity.Property(e => e.השיטהשיושמהבדוחהכספי)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("השיטה שיושמה בדוח הכספי");
            entity.Property(e => e.זירתמסחר)
                .HasMaxLength(250)
                .HasColumnName("זירת מסחר");
            entity.Property(e => e.זכותחזרה)
                .HasMaxLength(250)
                .HasColumnName("זכות חזרה");
            entity.Property(e => e.זכותפירעוןמוקדם)
                .HasMaxLength(250)
                .HasColumnName("זכות פירעון מוקדם");
            entity.Property(e => e.חודשהבדיקה)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("חודש הבדיקה");
            entity.Property(e => e.חודשהנפקתשכבה)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("חודש הנפקת שכבה");
            entity.Property(e => e.טיקר).HasMaxLength(50);
            entity.Property(e => e.יחסהמרה)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("יחס המרה");
            entity.Property(e => e.יעודהלוואה)
                .HasMaxLength(250)
                .HasColumnName("יעוד הלוואה");
            entity.Property(e => e.ישראלחול)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ישראל/חו\"ל");
            entity.Property(e => e.יתרתהמחויבותלתקופתהדיווחבמטבעהדיווחשלקרןההשקעה)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("יתרת המחויבות לתקופת הדיווח (במטבע הדיווח של קרן ההשקעה)");
            entity.Property(e => e.יתרתהמחויבותלתקופתהדיווחבשח)
                .HasColumnType("decimal(37, 12)")
                .HasColumnName("יתרת המחויבות לתקופת הדיווח (בש\"ח)");
            entity.Property(e => e.כתובתהנכס)
                .HasMaxLength(250)
                .HasColumnName("כתובת הנכס");
            entity.Property(e => e.מאפייןהלוואותמתואמותעבורזכויותמקרקעין)
                .HasMaxLength(250)
                .HasColumnName("מאפיין הלוואות מתואמות עבור זכויות מקרקעין");
            entity.Property(e => e.מאפייןעיקרי)
                .HasMaxLength(250)
                .HasColumnName("מאפיין עיקרי");
            entity.Property(e => e.מבנהלוחסילוקין).HasColumnName("מבנה לוח סילוקין");
            entity.Property(e => e.מדינהלפיחשיפהכלכלית)
                .HasMaxLength(50)
                .HasColumnName("מדינה לפי חשיפה כלכלית");
            entity.Property(e => e.מדינתהתאגדותקרןהשקעה)
                .HasMaxLength(50)
                .HasColumnName("מדינת התאגדות קרן השקעה");
            entity.Property(e => e.מדינתמיקוםנדלן)
                .HasMaxLength(250)
                .HasColumnName("מדינת מיקום נדל\"ן");
            entity.Property(e => e.מועדההתקשרותבעסקה)
                .HasMaxLength(4000)
                .HasColumnName("מועד ההתקשרות בעסקה");
            entity.Property(e => e.מועדסיוםחוזי)
                .HasMaxLength(4000)
                .HasColumnName("מועד סיום חוזי");
            entity.Property(e => e.מועדעדכוןאחרוןלשוויהבטוחות)
                .HasMaxLength(250)
                .HasColumnName("מועד עדכון אחרון לשווי הבטוחות");
            entity.Property(e => e.מועדפדיון)
                .HasMaxLength(4000)
                .HasColumnName("מועד פדיון");
            entity.Property(e => e.מחזורחייהנכס)
                .HasMaxLength(250)
                .HasColumnName("מחזור חיי הנכס");
            entity.Property(e => e.מחמ)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("מח\"מ");
            entity.Property(e => e.מטבע)
                .HasMaxLength(250)
                .HasColumnName("מטבע ");
            entity.Property(e => e.מטבעפעילות)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("מטבע פעילות");
            entity.Property(e => e.מטבעפעילותרגל1)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("מטבע פעילות (רגל 1)");
            entity.Property(e => e.מטבעפעילותרגל2)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("מטבע פעילות (רגל 2)");
            entity.Property(e => e.מיקוםמשרדהשותףהכללי)
                .HasMaxLength(250)
                .HasColumnName("מיקום משרד השותף הכללי");
            entity.Property(e => e.מסגרתאשראיבמועדהעמדה)
                .HasMaxLength(250)
                .HasColumnName("מסגרת אשראי במועד העמדה");
            entity.Property(e => e.מספרLei)
                .HasMaxLength(250)
                .HasColumnName("מספר LEI");
            entity.Property(e => e.מספרהלוואה)
                .HasMaxLength(50)
                .HasColumnName("מספר הלוואה");
            entity.Property(e => e.מספרהנכסהאחר)
                .HasMaxLength(50)
                .HasColumnName("מספר הנכס האחר");
            entity.Property(e => e.מספרמזההבנק)
                .HasMaxLength(50)
                .HasColumnName("מספר מזהה בנק");
            entity.Property(e => e.מספרמזההלווה).HasColumnName("מספר מזהה לווה");
            entity.Property(e => e.מספרמזההקרןהשקעה)
                .HasMaxLength(50)
                .HasColumnName("מספר מזהה קרן השקעה");
            entity.Property(e => e.מספרמזההשותףכלליקרןהשקעות)
                .HasMaxLength(250)
                .HasColumnName("מספר מזהה שותף כללי קרן השקעות");
            entity.Property(e => e.מספרמנפיק).HasColumnName("מספר מנפיק");
            entity.Property(e => e.מספרמסלול).HasColumnName("מספר מסלול");
            entity.Property(e => e.מספרניירערך)
                .HasMaxLength(50)
                .HasColumnName("מספר נייר ערך");
            entity.Property(e => e.מספרנכסיםבמדדנכסייחוסקרנותנאמנות)
                .HasMaxLength(250)
                .HasColumnName("מספר נכסים במדד נכס ייחוס - קרנות נאמנות");
            entity.Property(e => e.מספרעסקהרגל1)
                .HasMaxLength(50)
                .HasColumnName("מספר עסקה (רגל 1)");
            entity.Property(e => e.מספרעסקהרגל2)
                .HasMaxLength(100)
                .HasColumnName("מספר עסקה (רגל 2)");
            entity.Property(e => e.מספרקונסורציוםסינדיקציה)
                .HasMaxLength(250)
                .HasColumnName("מספר קונסורציום/סינדיקציה");
            entity.Property(e => e.מספרקופהקרןחפעבורחברתביטוח).HasColumnName("מספר קופה/קרן/ח.פ. עבור חברת ביטוח");
            entity.Property(e => e.מספרקרן).HasColumnName("מספר קרן");
            entity.Property(e => e.נחיתותחוזית)
                .HasMaxLength(250)
                .HasColumnName("נחיתות חוזית");
            entity.Property(e => e.נכסבסיס)
                .HasMaxLength(250)
                .HasColumnName("נכס בסיס");
            entity.Property(e => e.נכסבסיסכתבאופציה)
                .HasMaxLength(50)
                .HasColumnName("נכס בסיס (כתב אופציה)");
            entity.Property(e => e.נספחהתחשבנותבטחונותCsa)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("נספח התחשבנות בטחונות - CSA");
            entity.Property(e => e.סוגבטוחה)
                .HasMaxLength(250)
                .HasColumnName("סוג בטוחה");
            entity.Property(e => e.סוגגורםמשערך)
                .HasMaxLength(250)
                .HasColumnName("סוג גורם משערך");
            entity.Property(e => e.סוגהנכס)
                .HasMaxLength(250)
                .HasColumnName("סוג הנכס");
            entity.Property(e => e.סוגהסליקה)
                .HasMaxLength(250)
                .HasColumnName("סוג הסליקה");
            entity.Property(e => e.סוגהצמדה)
                .HasMaxLength(250)
                .HasColumnName("סוג הצמדה");
            entity.Property(e => e.סוגהריבית)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("סוג הריבית");
            entity.Property(e => e.סוגלוס)
                .HasMaxLength(250)
                .HasColumnName("סוג לוס");
            entity.Property(e => e.סוגמספרמזההבנק)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("סוג מספר מזהה בנק");
            entity.Property(e => e.סוגמספרמזההלווה)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("סוג מספר מזהה לווה");
            entity.Property(e => e.סוגמספרמזההמנפיק)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("סוג מספר מזהה מנפיק");
            entity.Property(e => e.סוגמספרמזההקרןהשקעות)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("סוג מספר מזהה קרן השקעות");
            entity.Property(e => e.סוגמספרמזההשותףכלליקרןהשקעות)
                .HasMaxLength(250)
                .HasColumnName("סוג מספר מזהה שותף כללי קרן השקעות");
            entity.Property(e => e.סוגמספרניירערך)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("סוג מספר נייר ערך");
            entity.Property(e => e.סוגקרן)
                .HasMaxLength(50)
                .HasColumnName("סוג קרן");
            entity.Property(e => e.סטאטוססחירות)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("סטאטוס סחירות");
            entity.Property(e => e.סיווגהחובכבעייתי)
                .HasMaxLength(250)
                .HasColumnName("סיווג החוב כבעייתי");
            entity.Property(e => e.סיווגהקרן)
                .HasMaxLength(250)
                .HasColumnName("סיווג הקרן");
            entity.Property(e => e.סכוםהמחויבותהראשוניבמטבעהדיווחשלקרןההשקעה)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("סכום המחויבות הראשוני (במטבע הדיווח של קרן ההשקעה)");
            entity.Property(e => e.סכוםהמחויבותהראשוניבשח)
                .HasColumnType("decimal(37, 12)")
                .HasColumnName("סכום המחויבות הראשוני (בש\"ח)");
            entity.Property(e => e.סכוםלקבלבמטבעהפעילות)
                .HasColumnType("decimal(38, 7)")
                .HasColumnName("סכום לקבל (במטבע הפעילות)");
            entity.Property(e => e.סכוםמסגרתהאשראיהראשוניבמטבעהפעילות).HasColumnName("סכום מסגרת האשראי הראשוני (במטבע הפעילות)");
            entity.Property(e => e.סכוםמסגרתהאשראיהראשוניבמטבעהפעילותIHub)
                .HasMaxLength(250)
                .HasColumnName("סכום מסגרת האשראי הראשוני (במטבע הפעילות) - iHub");
            entity.Property(e => e.סכוםמסגרתהאשראיהראשוניבשח).HasColumnName("סכום מסגרת האשראי הראשוני (בש\"ח)");
            entity.Property(e => e.עלותמופחתתבמטבעהפעילות)
                .HasMaxLength(250)
                .HasColumnName("עלות מופחתת (במטבע הפעילות)");
            entity.Property(e => e.עלותמופחתתבשח)
                .HasMaxLength(250)
                .HasColumnName("עלות מופחתת (בש\"ח)");
            entity.Property(e => e.ענףמסחר)
                .HasMaxLength(250)
                .HasColumnName("ענף מסחר");
            entity.Property(e => e.ערךנקוב)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ערך נקוב");
            entity.Property(e => e.ערךנקוביחידות)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ערך נקוב (יחידות)");
            entity.Property(e => e.ערךנקוברגל1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ערך נקוב (רגל 1)");
            entity.Property(e => e.ערךנקוברגל2)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("ערך נקוב (רגל 2)");
            entity.Property(e => e.פקטורמוביל)
                .HasMaxLength(250)
                .HasColumnName("פקטור מוביל");
            entity.Property(e => e.פקטורנוסף)
                .HasMaxLength(250)
                .HasColumnName("פקטור נוסף");
            entity.Property(e => e.צדנגדיCounterparty)
                .HasMaxLength(50)
                .HasColumnName("צד נגדי - Counterparty");
            entity.Property(e => e.קודנכסהלוואתמקור)
                .HasMaxLength(50)
                .HasColumnName("קוד נכס הלוואת מקור");
            entity.Property(e => e.קונסורציוםסינדיקציה)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("קונסורציום/ סינדיקציה");
            entity.Property(e => e.ריביתעוגן)
                .HasMaxLength(250)
                .HasColumnName("ריבית עוגן");
            entity.Property(e => e.ריביתעוגןלדיווח)
                .HasMaxLength(250)
                .HasColumnName("ריבית עוגן לדיווח");
            entity.Property(e => e.שוויהבטוחותהעומדותכנגדההלוואה)
                .HasMaxLength(250)
                .HasColumnName("שווי הבטוחות העומדות כנגד ההלוואה");
            entity.Property(e => e.שוויהוגןבמטבעהנסחררגל1)
                .HasColumnType("decimal(38, 16)")
                .HasColumnName("שווי הוגן במטבע הנסחר (רגל 1)");
            entity.Property(e => e.שוויהוגןבמטבעהנסחררגל2)
                .HasColumnType("decimal(38, 15)")
                .HasColumnName("שווי הוגן במטבע הנסחר (רגל 2)");
            entity.Property(e => e.שוויהוגןבמטבעהפעילות)
                .HasColumnType("decimal(23, 7)")
                .HasColumnName("שווי הוגן (במטבע הפעילות)");
            entity.Property(e => e.שוויהוגןבשח)
                .HasColumnType("decimal(23, 7)")
                .HasColumnName("שווי הוגן (בש\"ח)");
            entity.Property(e => e.שוויהוגןנטובשח)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("שווי הוגן (נטו  בש\"ח)");
            entity.Property(e => e.שוויהנכסיםבאפיק)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("שווי הנכסים באפיק");
            entity.Property(e => e.שווימאזניבשח)
                .HasMaxLength(250)
                .HasColumnName("שווי מאזני (בש\"ח)");
            entity.Property(e => e.שווימטבעי)
                .HasColumnType("decimal(23, 7)")
                .HasColumnName("שווי מטבעי");
            entity.Property(e => e.שיטהשיושמהבדיווחהכספי)
                .HasMaxLength(250)
                .HasColumnName("שיטה שיושמה בדיווח הכספי");
            entity.Property(e => e.שימושעיקריבנכס)
                .HasMaxLength(250)
                .HasColumnName("שימוש עיקרי בנכס");
            entity.Property(e => e.שיעוראחזקהבאמצעישליטה)
                .HasMaxLength(250)
                .HasColumnName("שיעור אחזקה באמצעי שליטה");
            entity.Property(e => e.שיעורהבטוחותמהחוב)
                .HasColumnType("decimal(38, 15)")
                .HasColumnName("שיעור הבטוחות מהחוב");
            entity.Property(e => e.שיעורהחזקהבקרןהשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור החזקה בקרן השקעה");
            entity.Property(e => e.שיעורהקנסבגיןיציאהמוקדמת)
                .HasMaxLength(4000)
                .HasColumnName("שיעור הקנס בגין יציאה מוקדמת");
            entity.Property(e => e.שיעורהקנסבגיןיציאהמוקדמתIHub)
                .HasMaxLength(250)
                .HasColumnName("שיעור הקנס בגין יציאה מוקדמת - iHub");
            entity.Property(e => e.שיעוריתרתהמחויבות)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("שיעור יתרת המחויבות");
            entity.Property(e => e.שיעוריתרתמסגרתאשראי)
                .HasMaxLength(4000)
                .HasColumnName("שיעור יתרת מסגרת אשראי");
            entity.Property(e => e.שיעורמנכסיאפיקההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מנכסי אפיק ההשקעה");
            entity.Property(e => e.שיעורמנכסיאפיקההשקעהרגל1)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("שיעור מנכסי אפיק ההשקעה (רגל 1)");
            entity.Property(e => e.שיעורמסךאפיקההשקעהרגל2)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מסך אפיק ההשקעה (רגל 2)");
            entity.Property(e => e.שיעורמסךנכסיההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מסך נכסי ההשקעה");
            entity.Property(e => e.שיעורמסךנכסיההשקעהרגל1)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מסך נכסי ההשקעה (רגל 1)");
            entity.Property(e => e.שיעורמסךנכסיההשקעהרגל2)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מסך נכסי ההשקעה (רגל 2)");
            entity.Property(e => e.שיעורמערךנקובמונפק)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מערך נקוב מונפק");
            entity.Property(e => e.שיעורריבית)
                .HasMaxLength(4000)
                .HasColumnName("שיעור ריבית");
            entity.Property(e => e.שיעורריביתבגיןאיניצולמסגרתהאשראי)
                .HasMaxLength(4000)
                .HasColumnName("שיעור ריבית בגין אי-ניצול מסגרת האשראי");
            entity.Property(e => e.שיעורריביתעוגן)
                .HasMaxLength(4000)
                .HasColumnName("שיעור ריבית עוגן");
            entity.Property(e => e.שיעורתוספתהפחתהלריביתהעוגן)
                .HasMaxLength(4000)
                .HasColumnName("שיעור תוספת/הפחתה לריבית העוגן");
            entity.Property(e => e.שיעורתשואהבפועלבמהלךהרבעון)
                .HasMaxLength(250)
                .HasColumnName("שיעור תשואה בפועל במהלך הרבעון");
            entity.Property(e => e.שםגורםמשערך)
                .HasMaxLength(250)
                .HasColumnName("שם גורם משערך");
            entity.Property(e => e.שםהבנק)
                .HasMaxLength(100)
                .HasColumnName("שם הבנק");
            entity.Property(e => e.שםהלוואה).HasColumnName("שם הלוואה");
            entity.Property(e => e.שםהנכס).HasColumnName("שם הנכס");
            entity.Property(e => e.שםהנכסהאחר).HasColumnName("שם הנכס האחר");
            entity.Property(e => e.שםמדרג)
                .HasMaxLength(50)
                .HasColumnName("שם מדרג");
            entity.Property(e => e.שםמוסתר)
                .HasMaxLength(250)
                .HasColumnName("שם מוסתר");
            entity.Property(e => e.שםמנפיק)
                .HasMaxLength(50)
                .HasColumnName("שם מנפיק");
            entity.Property(e => e.שםניירערך).HasColumnName("שם נייר ערך");
            entity.Property(e => e.שםקרןהשקעה).HasColumnName("שם קרן השקעה");
            entity.Property(e => e.שםשותףכלליקרןהשקעות)
                .HasMaxLength(250)
                .HasColumnName("שם שותף כללי קרן השקעות");
            entity.Property(e => e.שערהלוואה)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער הלוואה");
            entity.Property(e => e.שערהנגזרבמועדההתקשרותבעסקה).HasColumnName("שער הנגזר במועד ההתקשרות בעסקה");
            entity.Property(e => e.שערהנגזרבמועדההתקשרותבעסקהIHub)
                .HasMaxLength(250)
                .HasColumnName("שער הנגזר במועד ההתקשרות בעסקה - iHub");
            entity.Property(e => e.שערחליפין)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער חליפין");
            entity.Property(e => e.שערמימוש)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער מימוש");
            entity.Property(e => e.שערניירהערך)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער נייר הערך");
            entity.Property(e => e.שערנכסהבסיסבמועדההתקשרותבעסקה).HasColumnName("שער נכס הבסיס במועד ההתקשרות בעסקה");
            entity.Property(e => e.שערנכסהבסיסבמועדההתקשרותבעסקהIHub)
                .HasMaxLength(250)
                .HasColumnName("שער נכס הבסיס במועד ההתקשרות בעסקה - iHub");
            entity.Property(e => e.שערפיקדון)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער פיקדון");
            entity.Property(e => e.תאורמדדנכסייחוסקרנותנאמנות)
                .HasMaxLength(250)
                .HasColumnName("תאור מדד נכס ייחוס - קרנות נאמנות");
            entity.Property(e => e.תאריךאחרוןבונבחנהבפועלירידתערך)
                .HasMaxLength(250)
                .HasColumnName("תאריך אחרון בו נבחנה בפועל ירידת ערך");
            entity.Property(e => e.תאריךהעמדתהלוואה)
                .HasMaxLength(4000)
                .HasColumnName("תאריך העמדת הלוואה");
            entity.Property(e => e.תאריךהעמדתהתחייבותלקרןהשקעה)
                .HasMaxLength(4000)
                .HasColumnName("תאריך העמדת התחייבות לקרן השקעה");
            entity.Property(e => e.תאריךהעמדתמסגרתאשראי)
                .HasMaxLength(4000)
                .HasColumnName("תאריך העמדת מסגרת אשראי");
            entity.Property(e => e.תאריךעסקה)
                .HasMaxLength(250)
                .HasColumnName("תאריך עסקה");
            entity.Property(e => e.תאריךפקיעה)
                .HasMaxLength(4000)
                .HasColumnName("תאריך פקיעה");
            entity.Property(e => e.תאריךפקיעתמחויבותלהשקעה)
                .HasMaxLength(4000)
                .HasColumnName("תאריך פקיעת מחויבות להשקעה");
            entity.Property(e => e.תאריךפקיעתפיקדון)
                .HasMaxLength(4000)
                .HasColumnName("תאריך פקיעת פיקדון");
            entity.Property(e => e.תאריךרכישה)
                .HasMaxLength(250)
                .HasColumnName("תאריך רכישה");
            entity.Property(e => e.תאריךשערוךאחרון)
                .HasMaxLength(4000)
                .HasColumnName("תאריך שערוך אחרון");
            entity.Property(e => e.תאריךשערוךאחרוןIHub)
                .HasMaxLength(250)
                .HasColumnName("תאריך שערוך אחרון - iHub");
            entity.Property(e => e.תדירותReset)
                .HasMaxLength(250)
                .HasColumnName("תדירות Reset");
            entity.Property(e => e.תלותאיתלותהמשערך)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("תלות/אי-תלות המשערך");
            entity.Property(e => e.תקופתריביתעוגן)
                .HasMaxLength(250)
                .HasColumnName("תקופת ריבית עוגן");
            entity.Property(e => e.תשואהלפדיון)
                .HasMaxLength(4000)
                .HasColumnName("תשואה לפדיון");
        });

        modelBuilder.Entity<VDvchHashkaotBeChavarotMuchzakot>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Dvch_HashkaotBeChavarotMuchzakot");

            entity.Property(e => e.בעלענייןצדקשור)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("בעל עניין/צד קשור");
            entity.Property(e => e.ישראלחול)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ישראל/חו\"ל");
            entity.Property(e => e.מאפייןעיקרי)
                .HasMaxLength(250)
                .HasColumnName("מאפיין עיקרי");
            entity.Property(e => e.מדינהלפיחשיפהכלכלית)
                .HasMaxLength(50)
                .HasColumnName("מדינה לפי חשיפה כלכלית");
            entity.Property(e => e.מטבעפעילות)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("מטבע פעילות");
            entity.Property(e => e.מספרמנפיק).HasColumnName("מספר מנפיק");
            entity.Property(e => e.מספרמסלול).HasColumnName("מספר מסלול");
            entity.Property(e => e.מספרניירערך)
                .HasMaxLength(50)
                .HasColumnName("מספר נייר ערך");
            entity.Property(e => e.מספרקופהקרןחפעבורחברתביטוח).HasColumnName("מספר קופה/קרן/ח.פ. עבור חברת ביטוח");
            entity.Property(e => e.סוגגורםמשערך)
                .HasMaxLength(250)
                .HasColumnName("סוג גורם משערך");
            entity.Property(e => e.סוגמספרמזההמנפיק)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("סוג מספר מזהה מנפיק");
            entity.Property(e => e.סוגמספרניירערך)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("סוג מספר נייר ערך");
            entity.Property(e => e.ענףמסחר)
                .HasMaxLength(250)
                .HasColumnName("ענף מסחר");
            entity.Property(e => e.שוויהוגןבשח)
                .HasColumnType("decimal(23, 7)")
                .HasColumnName("שווי הוגן (בש\"ח)");
            entity.Property(e => e.שווימאזניבשח)
                .HasMaxLength(250)
                .HasColumnName("שווי מאזני (בש\"ח)");
            entity.Property(e => e.שיעוראחזקהבאמצעישליטה)
                .HasMaxLength(250)
                .HasColumnName("שיעור אחזקה באמצעי שליטה");
            entity.Property(e => e.שיעורמנכסיאפיקההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מנכסי אפיק ההשקעה");
            entity.Property(e => e.שיעורמסךנכסיההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מסך נכסי ההשקעה");
            entity.Property(e => e.שםמנפיק)
                .HasMaxLength(50)
                .HasColumnName("שם מנפיק");
            entity.Property(e => e.שםניירערך).HasColumnName("שם נייר ערך");
            entity.Property(e => e.תאריךאחרוןבונבחנהבפועלירידתערך)
                .HasMaxLength(250)
                .HasColumnName("תאריך אחרון בו נבחנה בפועל ירידת ערך");
            entity.Property(e => e.תאריךשערוךאחרון)
                .HasMaxLength(4000)
                .HasColumnName("תאריך שערוך אחרון");
            entity.Property(e => e.תלותאיתלותהמשערך)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("תלות/אי-תלות המשערך");
        });

        modelBuilder.Entity<VDvchHozim>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Dvch_Hozim");

            entity.Property(e => e.בעלענייןצדקשור)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("בעל עניין/צד קשור");
            entity.Property(e => e.זירתמסחר)
                .HasMaxLength(250)
                .HasColumnName("זירת מסחר");
            entity.Property(e => e.ישראלחול)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ישראל/חו\"ל");
            entity.Property(e => e.מדינהלפיחשיפהכלכלית)
                .HasMaxLength(50)
                .HasColumnName("מדינה לפי חשיפה כלכלית");
            entity.Property(e => e.מטבעפעילות)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("מטבע פעילות");
            entity.Property(e => e.מספרמנפיק).HasColumnName("מספר מנפיק");
            entity.Property(e => e.מספרמסלול).HasColumnName("מספר מסלול");
            entity.Property(e => e.מספרניירערך)
                .HasMaxLength(50)
                .HasColumnName("מספר נייר ערך");
            entity.Property(e => e.מספרקופהקרןחפעבורחברתביטוח).HasColumnName("מספר קופה/קרן/ח.פ. עבור חברת ביטוח");
            entity.Property(e => e.נכסבסיס)
                .HasMaxLength(250)
                .HasColumnName("נכס בסיס");
            entity.Property(e => e.סוגמספרמזההמנפיק)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("סוג מספר מזהה מנפיק");
            entity.Property(e => e.סוגמספרניירערך)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("סוג מספר נייר ערך");
            entity.Property(e => e.ערךנקוביחידות)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ערך נקוב (יחידות)");
            entity.Property(e => e.שוויהוגןבשח)
                .HasColumnType("decimal(23, 7)")
                .HasColumnName("שווי הוגן (בש\"ח)");
            entity.Property(e => e.שיעורמנכסיאפיקההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מנכסי אפיק ההשקעה");
            entity.Property(e => e.שיעורמסךנכסיההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מסך נכסי ההשקעה");
            entity.Property(e => e.שםמנפיק)
                .HasMaxLength(50)
                .HasColumnName("שם מנפיק");
            entity.Property(e => e.שםניירערך).HasColumnName("שם נייר ערך");
            entity.Property(e => e.שערחליפין)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער חליפין");
            entity.Property(e => e.שערניירהערך)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער נייר הערך");
        });

        modelBuilder.Entity<VDvchKranotNemanut>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Dvch_KranotNemanut");

            entity.Property(e => e.בעלענייןצדקשור)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("בעל עניין/צד קשור");
            entity.Property(e => e.זירתמסחר)
                .HasMaxLength(250)
                .HasColumnName("זירת מסחר");
            entity.Property(e => e.ישראלחול)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ישראל/חו\"ל");
            entity.Property(e => e.מאפייןעיקרי)
                .HasMaxLength(250)
                .HasColumnName("מאפיין עיקרי");
            entity.Property(e => e.מדינהלפיחשיפהכלכלית)
                .HasMaxLength(50)
                .HasColumnName("מדינה לפי חשיפה כלכלית");
            entity.Property(e => e.מטבעפעילות)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("מטבע פעילות");
            entity.Property(e => e.מספרמנפיק).HasColumnName("מספר מנפיק");
            entity.Property(e => e.מספרמסלול).HasColumnName("מספר מסלול");
            entity.Property(e => e.מספרניירערך)
                .HasMaxLength(50)
                .HasColumnName("מספר נייר ערך");
            entity.Property(e => e.מספרקופהקרןחפעבורחברתביטוח).HasColumnName("מספר קופה/קרן/ח.פ. עבור חברת ביטוח");
            entity.Property(e => e.סוגמספרמזההמנפיק)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("סוג מספר מזהה מנפיק");
            entity.Property(e => e.סוגמספרניירערך)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("סוג מספר נייר ערך");
            entity.Property(e => e.סטאטוססחירות)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("סטאטוס סחירות");
            entity.Property(e => e.סיווגהקרן)
                .HasMaxLength(250)
                .HasColumnName("סיווג הקרן");
            entity.Property(e => e.ערךנקוביחידות)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ערך נקוב (יחידות)");
            entity.Property(e => e.שוויהוגןבשח)
                .HasColumnType("decimal(23, 7)")
                .HasColumnName("שווי הוגן (בש\"ח)");
            entity.Property(e => e.שיעורמנכסיאפיקההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מנכסי אפיק ההשקעה");
            entity.Property(e => e.שיעורמסךנכסיההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מסך נכסי ההשקעה");
            entity.Property(e => e.שיעורמערךנקובמונפק)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מערך נקוב מונפק");
            entity.Property(e => e.שםמנפיק)
                .HasMaxLength(50)
                .HasColumnName("שם מנפיק");
            entity.Property(e => e.שםניירערך).HasColumnName("שם נייר ערך");
            entity.Property(e => e.שערחליפין)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער חליפין");
            entity.Property(e => e.שערניירהערך)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער נייר הערך");
        });

        modelBuilder.Entity<VDvchKranotSal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Dvch_KranotSal");

            entity.Property(e => e.בעלענייןצדקשור)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("בעל עניין/צד קשור");
            entity.Property(e => e.זירתמסחר)
                .HasMaxLength(250)
                .HasColumnName("זירת מסחר");
            entity.Property(e => e.ישראלחול)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ישראל/חו\"ל");
            entity.Property(e => e.מאפייןעיקרי)
                .HasMaxLength(250)
                .HasColumnName("מאפיין עיקרי");
            entity.Property(e => e.מדינהלפיחשיפהכלכלית)
                .HasMaxLength(50)
                .HasColumnName("מדינה לפי חשיפה כלכלית");
            entity.Property(e => e.מטבעפעילות)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("מטבע פעילות");
            entity.Property(e => e.מספרמנפיק).HasColumnName("מספר מנפיק");
            entity.Property(e => e.מספרמסלול).HasColumnName("מספר מסלול");
            entity.Property(e => e.מספרניירערך)
                .HasMaxLength(50)
                .HasColumnName("מספר נייר ערך");
            entity.Property(e => e.מספרקופהקרןחפעבורחברתביטוח).HasColumnName("מספר קופה/קרן/ח.פ. עבור חברת ביטוח");
            entity.Property(e => e.סוגמספרמזההמנפיק)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("סוג מספר מזהה מנפיק");
            entity.Property(e => e.סוגמספרניירערך)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("סוג מספר נייר ערך");
            entity.Property(e => e.סיווגהקרן)
                .HasMaxLength(250)
                .HasColumnName("סיווג הקרן");
            entity.Property(e => e.ערךנקוביחידות)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ערך נקוב (יחידות)");
            entity.Property(e => e.שוויהוגןבשח)
                .HasColumnType("decimal(23, 7)")
                .HasColumnName("שווי הוגן (בש\"ח)");
            entity.Property(e => e.שיעורמנכסיאפיקההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מנכסי אפיק ההשקעה");
            entity.Property(e => e.שיעורמסךנכסיההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מסך נכסי ההשקעה");
            entity.Property(e => e.שיעורמערךנקובמונפק)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מערך נקוב מונפק");
            entity.Property(e => e.שםמנפיק)
                .HasMaxLength(50)
                .HasColumnName("שם מנפיק");
            entity.Property(e => e.שםניירערך).HasColumnName("שם נייר ערך");
            entity.Property(e => e.שערחליפין)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער חליפין");
            entity.Property(e => e.שערניירהערך)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער נייר הערך");
        });

        modelBuilder.Entity<VDvchKtavOpt>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Dvch_KtavOpt");

            entity.Property(e => e.בעלענייןצדקשור)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("בעל עניין/צד קשור");
            entity.Property(e => e.זירתמסחר)
                .HasMaxLength(250)
                .HasColumnName("זירת מסחר");
            entity.Property(e => e.יחסהמרה)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("יחס המרה");
            entity.Property(e => e.ישראלחול)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ישראל/חו\"ל");
            entity.Property(e => e.מדינהלפיחשיפהכלכלית)
                .HasMaxLength(50)
                .HasColumnName("מדינה לפי חשיפה כלכלית");
            entity.Property(e => e.מטבעפעילות)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("מטבע פעילות");
            entity.Property(e => e.מספרמנפיק).HasColumnName("מספר מנפיק");
            entity.Property(e => e.מספרמסלול).HasColumnName("מספר מסלול");
            entity.Property(e => e.מספרניירערך)
                .HasMaxLength(50)
                .HasColumnName("מספר נייר ערך");
            entity.Property(e => e.מספרקופהקרןחפעבורחברתביטוח).HasColumnName("מספר קופה/קרן/ח.פ. עבור חברת ביטוח");
            entity.Property(e => e.נכסבסיסכתבאופציה)
                .HasMaxLength(50)
                .HasColumnName("נכס בסיס (כתב אופציה)");
            entity.Property(e => e.סוגמספרמזההמנפיק)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("סוג מספר מזהה מנפיק");
            entity.Property(e => e.סוגמספרניירערך)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("סוג מספר נייר ערך");
            entity.Property(e => e.סטאטוססחירות)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("סטאטוס סחירות");
            entity.Property(e => e.ענףמסחר)
                .HasMaxLength(250)
                .HasColumnName("ענף מסחר");
            entity.Property(e => e.ערךנקוביחידות)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ערך נקוב (יחידות)");
            entity.Property(e => e.שוויהוגןבשח)
                .HasColumnType("decimal(23, 7)")
                .HasColumnName("שווי הוגן (בש\"ח)");
            entity.Property(e => e.שיעורמנכסיאפיקההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מנכסי אפיק ההשקעה");
            entity.Property(e => e.שיעורמסךנכסיההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מסך נכסי ההשקעה");
            entity.Property(e => e.שםמנפיק)
                .HasMaxLength(50)
                .HasColumnName("שם מנפיק");
            entity.Property(e => e.שםניירערך).HasColumnName("שם נייר ערך");
            entity.Property(e => e.שערחליפין)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער חליפין");
            entity.Property(e => e.שערמימוש)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער מימוש");
            entity.Property(e => e.שערניירהערך)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער נייר הערך");
            entity.Property(e => e.תאריךפקיעה)
                .HasMaxLength(4000)
                .HasColumnName("תאריך פקיעה");
        });

        modelBuilder.Entity<VDvchKtavOptLoSachir>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Dvch_KtavOpt_LoSachir");

            entity.Property(e => e.בעלענייןצדקשור)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("בעל עניין/צד קשור");
            entity.Property(e => e.יחסהמרה)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("יחס המרה");
            entity.Property(e => e.ישראלחול)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ישראל/חו\"ל");
            entity.Property(e => e.מדינהלפיחשיפהכלכלית)
                .HasMaxLength(50)
                .HasColumnName("מדינה לפי חשיפה כלכלית");
            entity.Property(e => e.מטבעפעילות)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("מטבע פעילות");
            entity.Property(e => e.מספרמנפיק).HasColumnName("מספר מנפיק");
            entity.Property(e => e.מספרמסלול).HasColumnName("מספר מסלול");
            entity.Property(e => e.מספרניירערך)
                .HasMaxLength(50)
                .HasColumnName("מספר נייר ערך");
            entity.Property(e => e.מספרקופהקרןחפעבורחברתביטוח).HasColumnName("מספר קופה/קרן/ח.פ. עבור חברת ביטוח");
            entity.Property(e => e.נכסבסיסכתבאופציה)
                .HasMaxLength(50)
                .HasColumnName("נכס בסיס (כתב אופציה)");
            entity.Property(e => e.סוגגורםמשערך)
                .HasMaxLength(250)
                .HasColumnName("סוג גורם משערך");
            entity.Property(e => e.סוגמספרמזההמנפיק)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("סוג מספר מזהה מנפיק");
            entity.Property(e => e.סוגמספרניירערך)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("סוג מספר נייר ערך");
            entity.Property(e => e.סטאטוססחירות)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("סטאטוס סחירות");
            entity.Property(e => e.ענףמסחר)
                .HasMaxLength(250)
                .HasColumnName("ענף מסחר");
            entity.Property(e => e.ערךנקוביחידות)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ערך נקוב (יחידות)");
            entity.Property(e => e.שוויהוגןבשח)
                .HasColumnType("decimal(23, 7)")
                .HasColumnName("שווי הוגן (בש\"ח)");
            entity.Property(e => e.שיעורמנכסיאפיקההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מנכסי אפיק ההשקעה");
            entity.Property(e => e.שיעורמסךנכסיההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מסך נכסי ההשקעה");
            entity.Property(e => e.שםמנפיק)
                .HasMaxLength(50)
                .HasColumnName("שם מנפיק");
            entity.Property(e => e.שםניירערך).HasColumnName("שם נייר ערך");
            entity.Property(e => e.שערחליפין)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער חליפין");
            entity.Property(e => e.שערמימוש)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער מימוש");
            entity.Property(e => e.שערניירהערך)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער נייר הערך");
            entity.Property(e => e.תאריךפקיעה)
                .HasMaxLength(4000)
                .HasColumnName("תאריך פקיעה");
            entity.Property(e => e.תאריךרכישה)
                .HasMaxLength(250)
                .HasColumnName("תאריך רכישה");
            entity.Property(e => e.תאריךשערוךאחרון)
                .HasMaxLength(4000)
                .HasColumnName("תאריך שערוך אחרון");
            entity.Property(e => e.תלותאיתלותהמשערך)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("תלות/אי-תלות המשערך");
        });

        modelBuilder.Entity<VDvchLoSachirNigzarimOther>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Dvch_LoSachir_NigzarimOther");

            entity.Property(e => e.בעלענייןצדקשור)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("בעל עניין/צד קשור");
            entity.Property(e => e.גורםמצטט)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("גורם מצטט");
            entity.Property(e => e.האםקייםקנסבגיןיציאהמוקדמת)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("האם קיים קנס בגין יציאה מוקדמת");
            entity.Property(e => e.טיקר).HasMaxLength(50);
            entity.Property(e => e.ישראלחול)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ישראל/חו\"ל");
            entity.Property(e => e.מאפייןעיקרי)
                .HasMaxLength(250)
                .HasColumnName("מאפיין עיקרי");
            entity.Property(e => e.מדינהלפיחשיפהכלכלית)
                .HasMaxLength(50)
                .HasColumnName("מדינה לפי חשיפה כלכלית");
            entity.Property(e => e.מועדההתקשרותבעסקה)
                .HasMaxLength(4000)
                .HasColumnName("מועד ההתקשרות בעסקה");
            entity.Property(e => e.מועדסיוםחוזי)
                .HasMaxLength(4000)
                .HasColumnName("מועד סיום חוזי");
            entity.Property(e => e.מטבעפעילותרגל1)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("מטבע פעילות (רגל 1)");
            entity.Property(e => e.מטבעפעילותרגל2)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("מטבע פעילות (רגל 2)");
            entity.Property(e => e.מספרמסלול).HasColumnName("מספר מסלול");
            entity.Property(e => e.מספרעסקהרגל1)
                .HasMaxLength(50)
                .HasColumnName("מספר עסקה (רגל 1)");
            entity.Property(e => e.מספרעסקהרגל2)
                .HasMaxLength(100)
                .HasColumnName("מספר עסקה (רגל 2)");
            entity.Property(e => e.מספרקופהקרןחפעבורחברתביטוח).HasColumnName("מספר קופה/קרן/ח.פ. עבור חברת ביטוח");
            entity.Property(e => e.נספחהתחשבנותבטחונותCsa)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("נספח התחשבנות בטחונות - CSA");
            entity.Property(e => e.סוגהנכס)
                .HasMaxLength(250)
                .HasColumnName("סוג הנכס");
            entity.Property(e => e.סוגהסליקה)
                .HasMaxLength(250)
                .HasColumnName("סוג הסליקה");
            entity.Property(e => e.ערךנקוברגל1)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ערך נקוב (רגל 1)");
            entity.Property(e => e.ערךנקוברגל2)
                .HasColumnType("decimal(37, 8)")
                .HasColumnName("ערך נקוב (רגל 2)");
            entity.Property(e => e.פקטורמוביל)
                .HasMaxLength(250)
                .HasColumnName("פקטור מוביל");
            entity.Property(e => e.פקטורנוסף)
                .HasMaxLength(250)
                .HasColumnName("פקטור נוסף");
            entity.Property(e => e.צדנגדיCounterparty)
                .HasMaxLength(50)
                .HasColumnName("צד נגדי - Counterparty");
            entity.Property(e => e.ריביתעוגן)
                .HasMaxLength(250)
                .HasColumnName("ריבית עוגן");
            entity.Property(e => e.שוויהוגןבמטבעהנסחררגל1)
                .HasColumnType("decimal(38, 16)")
                .HasColumnName("שווי הוגן במטבע הנסחר (רגל 1)");
            entity.Property(e => e.שוויהוגןבמטבעהנסחררגל2)
                .HasColumnType("decimal(38, 15)")
                .HasColumnName("שווי הוגן במטבע הנסחר (רגל 2)");
            entity.Property(e => e.שוויהוגןנטובשח)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("שווי הוגן (נטו  בש\"ח)");
            entity.Property(e => e.שיעורהקנסבגיןיציאהמוקדמת)
                .HasMaxLength(4000)
                .HasColumnName("שיעור הקנס בגין יציאה מוקדמת");
            entity.Property(e => e.שיעורמנכסיאפיקההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מנכסי אפיק ההשקעה");
            entity.Property(e => e.שיעורמנכסיאפיקההשקעהרגל1)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("שיעור מנכסי אפיק ההשקעה (רגל 1)");
            entity.Property(e => e.שיעורמסךאפיקההשקעהרגל2)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מסך אפיק ההשקעה (רגל 2)");
            entity.Property(e => e.שיעורמסךנכסיההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מסך נכסי ההשקעה");
            entity.Property(e => e.שיעורמסךנכסיההשקעהרגל1)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מסך נכסי ההשקעה (רגל 1)");
            entity.Property(e => e.שיעורמסךנכסיההשקעהרגל2)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מסך נכסי ההשקעה (רגל 2)");
            entity.Property(e => e.שיעורריביתעוגן)
                .HasMaxLength(4000)
                .HasColumnName("שיעור ריבית עוגן");
            entity.Property(e => e.שערהנגזרבמועדההתקשרותבעסקה).HasColumnName("שער הנגזר במועד ההתקשרות בעסקה");
            entity.Property(e => e.שערחליפין)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער חליפין");
            entity.Property(e => e.שערנכסהבסיסבמועדההתקשרותבעסקה).HasColumnName("שער נכס הבסיס במועד ההתקשרות בעסקה");
            entity.Property(e => e.תדירותReset)
                .HasMaxLength(250)
                .HasColumnName("תדירות Reset");
            entity.Property(e => e.תקופתריביתעוגן)
                .HasMaxLength(250)
                .HasColumnName("תקופת ריבית עוגן");
        });

        modelBuilder.Entity<VDvchLoan>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Dvch_Loans");

            entity.Property(e => e.בעלענייןצדקשור)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("בעל עניין/צד קשור");
            entity.Property(e => e.דירוג).HasMaxLength(50);
            entity.Property(e => e.דירוגהלוואההמנפיק)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("דירוג הלוואה/המנפיק");
            entity.Property(e => e.האםסווגכחובבעייתי)
                .HasMaxLength(250)
                .HasColumnName("האם סווג כחוב בעייתי");
            entity.Property(e => e.השיטהשיושמהבדוחהכספי)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("השיטה שיושמה בדוח הכספי");
            entity.Property(e => e.זכותחזרה)
                .HasMaxLength(250)
                .HasColumnName("זכות חזרה");
            entity.Property(e => e.זכותפירעוןמוקדם)
                .HasMaxLength(250)
                .HasColumnName("זכות פירעון מוקדם");
            entity.Property(e => e.יעודהלוואה)
                .HasMaxLength(250)
                .HasColumnName("יעוד הלוואה");
            entity.Property(e => e.ישראלחול)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ישראל/חו\"ל");
            entity.Property(e => e.מאפייןהלוואותמתואמותעבורזכויותמקרקעין)
                .HasMaxLength(250)
                .HasColumnName("מאפיין הלוואות מתואמות עבור זכויות מקרקעין");
            entity.Property(e => e.מאפייןעיקרי)
                .HasMaxLength(250)
                .HasColumnName("מאפיין עיקרי");
            entity.Property(e => e.מבנהלוחסילוקין).HasColumnName("מבנה לוח סילוקין");
            entity.Property(e => e.מדינהלפיחשיפהכלכלית)
                .HasMaxLength(50)
                .HasColumnName("מדינה לפי חשיפה כלכלית");
            entity.Property(e => e.מועדעדכוןאחרוןלשוויהבטוחות)
                .HasMaxLength(250)
                .HasColumnName("מועד עדכון אחרון לשווי הבטוחות");
            entity.Property(e => e.מועדפדיון)
                .HasMaxLength(4000)
                .HasColumnName("מועד פדיון");
            entity.Property(e => e.מחמ)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("מח\"מ");
            entity.Property(e => e.מטבעפעילות)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("מטבע פעילות");
            entity.Property(e => e.מספרהלוואה)
                .HasMaxLength(50)
                .HasColumnName("מספר הלוואה");
            entity.Property(e => e.מספרמזההלווה).HasColumnName("מספר מזהה לווה");
            entity.Property(e => e.מספרמסלול).HasColumnName("מספר מסלול");
            entity.Property(e => e.מספרקונסורציוםסינדיקציה)
                .HasMaxLength(250)
                .HasColumnName("מספר קונסורציום/סינדיקציה");
            entity.Property(e => e.מספרקופהקרןחפעבורחברתביטוח).HasColumnName("מספר קופה/קרן/ח.פ. עבור חברת ביטוח");
            entity.Property(e => e.נחיתותחוזית)
                .HasMaxLength(250)
                .HasColumnName("נחיתות חוזית");
            entity.Property(e => e.סוגבטוחה)
                .HasMaxLength(250)
                .HasColumnName("סוג בטוחה");
            entity.Property(e => e.סוגגורםמשערך)
                .HasMaxLength(250)
                .HasColumnName("סוג גורם משערך");
            entity.Property(e => e.סוגהצמדה)
                .HasMaxLength(250)
                .HasColumnName("סוג הצמדה");
            entity.Property(e => e.סוגהריבית)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("סוג הריבית");
            entity.Property(e => e.סוגמספרמזההלווה)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("סוג מספר מזהה לווה");
            entity.Property(e => e.עלותמופחתתבמטבעהפעילות)
                .HasMaxLength(250)
                .HasColumnName("עלות מופחתת (במטבע הפעילות)");
            entity.Property(e => e.עלותמופחתתבשח)
                .HasMaxLength(250)
                .HasColumnName("עלות מופחתת (בש\"ח)");
            entity.Property(e => e.ענףמסחר)
                .HasMaxLength(250)
                .HasColumnName("ענף מסחר");
            entity.Property(e => e.ערךנקוב)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ערך נקוב");
            entity.Property(e => e.קונסורציוםסינדיקציה)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("קונסורציום/ סינדיקציה");
            entity.Property(e => e.ריביתעוגן)
                .HasMaxLength(250)
                .HasColumnName("ריבית עוגן");
            entity.Property(e => e.שוויהבטוחותהעומדותכנגדההלוואה)
                .HasMaxLength(250)
                .HasColumnName("שווי הבטוחות העומדות כנגד ההלוואה");
            entity.Property(e => e.שוויהוגןבמטבעהפעילות)
                .HasColumnType("decimal(23, 7)")
                .HasColumnName("שווי הוגן (במטבע הפעילות)");
            entity.Property(e => e.שוויהוגןבשח)
                .HasColumnType("decimal(23, 7)")
                .HasColumnName("שווי הוגן (בש\"ח)");
            entity.Property(e => e.שיעורהבטוחותמהחוב)
                .HasColumnType("decimal(38, 15)")
                .HasColumnName("שיעור הבטוחות מהחוב");
            entity.Property(e => e.שיעורמנכסיאפיקההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מנכסי אפיק ההשקעה");
            entity.Property(e => e.שיעורמסךנכסיההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מסך נכסי ההשקעה");
            entity.Property(e => e.שיעורריבית)
                .HasMaxLength(4000)
                .HasColumnName("שיעור ריבית");
            entity.Property(e => e.שיעורריביתבגיןאיניצולמסגרתהאשראי)
                .HasMaxLength(4000)
                .HasColumnName("שיעור ריבית בגין אי-ניצול מסגרת האשראי");
            entity.Property(e => e.שיעורתוספתהפחתהלריביתהעוגן)
                .HasMaxLength(4000)
                .HasColumnName("שיעור תוספת/הפחתה לריבית העוגן");
            entity.Property(e => e.שםגורםמשערך)
                .HasMaxLength(250)
                .HasColumnName("שם גורם משערך");
            entity.Property(e => e.שםהלוואה).HasColumnName("שם הלוואה");
            entity.Property(e => e.שםמדרג)
                .HasMaxLength(50)
                .HasColumnName("שם מדרג");
            entity.Property(e => e.שערהלוואה)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער הלוואה");
            entity.Property(e => e.שערחליפין)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער חליפין");
            entity.Property(e => e.תאריךאחרוןבונבחנהבפועלירידתערך)
                .HasMaxLength(250)
                .HasColumnName("תאריך אחרון בו נבחנה בפועל ירידת ערך");
            entity.Property(e => e.תאריךהעמדתהלוואה)
                .HasMaxLength(4000)
                .HasColumnName("תאריך העמדת הלוואה");
            entity.Property(e => e.תאריךשערוךאחרון)
                .HasMaxLength(4000)
                .HasColumnName("תאריך שערוך אחרון");
            entity.Property(e => e.תלותאיתלותהמשערך)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("תלות/אי-תלות המשערך");
            entity.Property(e => e.תשואהלפדיון)
                .HasMaxLength(4000)
                .HasColumnName("תשואה לפדיון");
        });

        modelBuilder.Entity<VDvchMezuman>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Dvch_Mezuman");

            entity.Property(e => e.בעלענייןצדקשור)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("בעל עניין/צד קשור");
            entity.Property(e => e.דירוגהבנק)
                .HasMaxLength(50)
                .HasColumnName("דירוג הבנק");
            entity.Property(e => e.ישראלחול)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ישראל/חו\"ל");
            entity.Property(e => e.מאפייןעיקרי)
                .HasMaxLength(250)
                .HasColumnName("מאפיין עיקרי");
            entity.Property(e => e.מטבעפעילות)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("מטבע פעילות");
            entity.Property(e => e.מספרמזההבנק)
                .HasMaxLength(50)
                .HasColumnName("מספר מזהה בנק");
            entity.Property(e => e.מספרמסלול).HasColumnName("מספר מסלול");
            entity.Property(e => e.מספרקופהקרןחפעבורחברתביטוח).HasColumnName("מספר קופה/קרן/ח.פ. עבור חברת ביטוח");
            entity.Property(e => e.סוגמספרמזההבנק)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("סוג מספר מזהה בנק");
            entity.Property(e => e.שוויהוגןבשח)
                .HasColumnType("decimal(23, 7)")
                .HasColumnName("שווי הוגן (בש\"ח)");
            entity.Property(e => e.שווימטבעי)
                .HasColumnType("decimal(23, 7)")
                .HasColumnName("שווי מטבעי");
            entity.Property(e => e.שיעורמנכסיאפיקההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מנכסי אפיק ההשקעה");
            entity.Property(e => e.שיעורמסךנכסיההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מסך נכסי ההשקעה");
            entity.Property(e => e.שיעורריבית)
                .HasMaxLength(4000)
                .HasColumnName("שיעור ריבית");
            entity.Property(e => e.שםהבנק)
                .HasMaxLength(100)
                .HasColumnName("שם הבנק");
            entity.Property(e => e.שםמדרג)
                .HasMaxLength(50)
                .HasColumnName("שם מדרג");
            entity.Property(e => e.שערחליפין)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער חליפין");
        });

        modelBuilder.Entity<VDvchMisgeretAshrai>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Dvch_MisgeretAshrai");

            entity.Property(e => e.בעלענייןצדקשור)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("בעל עניין/צד קשור");
            entity.Property(e => e.דירוג).HasMaxLength(50);
            entity.Property(e => e.דירוגהלוואההמנפיק)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("דירוג הלוואה/המנפיק");
            entity.Property(e => e.ישראלחול)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ישראל/חו\"ל");
            entity.Property(e => e.מדינהלפיחשיפהכלכלית)
                .HasMaxLength(50)
                .HasColumnName("מדינה לפי חשיפה כלכלית");
            entity.Property(e => e.מטבעפעילות)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("מטבע פעילות");
            entity.Property(e => e.מספרהלוואה)
                .HasMaxLength(50)
                .HasColumnName("מספר הלוואה");
            entity.Property(e => e.מספרמזההלווה).HasColumnName("מספר מזהה לווה");
            entity.Property(e => e.מספרמסלול).HasColumnName("מספר מסלול");
            entity.Property(e => e.מספרקופהקרןחפעבורחברתביטוח).HasColumnName("מספר קופה/קרן/ח.פ. עבור חברת ביטוח");
            entity.Property(e => e.סוגהריבית)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("סוג הריבית");
            entity.Property(e => e.סוגמספרמזההלווה)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("סוג מספר מזהה לווה");
            entity.Property(e => e.סכוםמסגרתהאשראיהראשוניבמטבעהפעילות).HasColumnName("סכום מסגרת האשראי הראשוני (במטבע הפעילות)");
            entity.Property(e => e.סכוםמסגרתהאשראיהראשוניבשח).HasColumnName("סכום מסגרת האשראי הראשוני (בש\"ח)");
            entity.Property(e => e.שיעוריתרתמסגרתאשראי)
                .HasMaxLength(4000)
                .HasColumnName("שיעור יתרת מסגרת אשראי");
            entity.Property(e => e.שיעורריבית)
                .HasMaxLength(4000)
                .HasColumnName("שיעור ריבית");
            entity.Property(e => e.שםהלוואה).HasColumnName("שם הלוואה");
            entity.Property(e => e.שםמדרג)
                .HasMaxLength(50)
                .HasColumnName("שם מדרג");
            entity.Property(e => e.שערחליפין)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער חליפין");
            entity.Property(e => e.תאריךהעמדתמסגרתאשראי)
                .HasMaxLength(4000)
                .HasColumnName("תאריך העמדת מסגרת אשראי");
        });

        modelBuilder.Entity<VDvchMutzarMuvne>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Dvch_MutzarMuvne");

            entity.Property(e => e.בעלענייןצדקשור)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("בעל עניין/צד קשור");
            entity.Property(e => e.דירוג).HasMaxLength(50);
            entity.Property(e => e.דירוגניירהערךהמנפיק)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("דירוג נייר הערך/המנפיק");
            entity.Property(e => e.זירתמסחר)
                .HasMaxLength(250)
                .HasColumnName("זירת מסחר");
            entity.Property(e => e.ישראלחול)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ישראל/חו\"ל");
            entity.Property(e => e.מאפייןעיקרי)
                .HasMaxLength(250)
                .HasColumnName("מאפיין עיקרי");
            entity.Property(e => e.מדינהלפיחשיפהכלכלית)
                .HasMaxLength(50)
                .HasColumnName("מדינה לפי חשיפה כלכלית");
            entity.Property(e => e.מחמ)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("מח\"מ");
            entity.Property(e => e.מטבעפעילות)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("מטבע פעילות");
            entity.Property(e => e.מספרמנפיק).HasColumnName("מספר מנפיק");
            entity.Property(e => e.מספרמסלול).HasColumnName("מספר מסלול");
            entity.Property(e => e.מספרניירערך)
                .HasMaxLength(50)
                .HasColumnName("מספר נייר ערך");
            entity.Property(e => e.מספרקופהקרןחפעבורחברתביטוח).HasColumnName("מספר קופה/קרן/ח.פ. עבור חברת ביטוח");
            entity.Property(e => e.נכסבסיס)
                .HasMaxLength(250)
                .HasColumnName("נכס בסיס");
            entity.Property(e => e.סוגמספרמזההמנפיק)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("סוג מספר מזהה מנפיק");
            entity.Property(e => e.סוגמספרניירערך)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("סוג מספר נייר ערך");
            entity.Property(e => e.סטאטוססחירות)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("סטאטוס סחירות");
            entity.Property(e => e.ערךנקוביחידות)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ערך נקוב (יחידות)");
            entity.Property(e => e.שוויהוגןבשח)
                .HasColumnType("decimal(23, 7)")
                .HasColumnName("שווי הוגן (בש\"ח)");
            entity.Property(e => e.שיעורמנכסיאפיקההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מנכסי אפיק ההשקעה");
            entity.Property(e => e.שיעורמסךנכסיההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מסך נכסי ההשקעה");
            entity.Property(e => e.שיעורריבית)
                .HasMaxLength(4000)
                .HasColumnName("שיעור ריבית");
            entity.Property(e => e.שםמדרג)
                .HasMaxLength(50)
                .HasColumnName("שם מדרג");
            entity.Property(e => e.שםמנפיק)
                .HasMaxLength(50)
                .HasColumnName("שם מנפיק");
            entity.Property(e => e.שםניירערך).HasColumnName("שם נייר ערך");
            entity.Property(e => e.שערחליפין)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער חליפין");
            entity.Property(e => e.שערניירהערך)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער נייר הערך");
            entity.Property(e => e.תשואהלפדיון)
                .HasMaxLength(4000)
                .HasColumnName("תשואה לפדיון");
        });

        modelBuilder.Entity<VDvchMutzarMuvneLoSachir>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Dvch_MutzarMuvne_LoSachir");

            entity.Property(e => e.בעלענייןצדקשור)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("בעל עניין/צד קשור");
            entity.Property(e => e.דירוג).HasMaxLength(50);
            entity.Property(e => e.דירוגניירהערךהמנפיק)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("דירוג נייר הערך/המנפיק");
            entity.Property(e => e.ישראלחול)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ישראל/חו\"ל");
            entity.Property(e => e.מאפייןעיקרי)
                .HasMaxLength(250)
                .HasColumnName("מאפיין עיקרי");
            entity.Property(e => e.מדינהלפיחשיפהכלכלית)
                .HasMaxLength(50)
                .HasColumnName("מדינה לפי חשיפה כלכלית");
            entity.Property(e => e.מחמ)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("מח\"מ");
            entity.Property(e => e.מטבעפעילות)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("מטבע פעילות");
            entity.Property(e => e.מספרמנפיק).HasColumnName("מספר מנפיק");
            entity.Property(e => e.מספרמסלול).HasColumnName("מספר מסלול");
            entity.Property(e => e.מספרניירערך)
                .HasMaxLength(50)
                .HasColumnName("מספר נייר ערך");
            entity.Property(e => e.מספרקופהקרןחפעבורחברתביטוח).HasColumnName("מספר קופה/קרן/ח.פ. עבור חברת ביטוח");
            entity.Property(e => e.נכסבסיס)
                .HasMaxLength(250)
                .HasColumnName("נכס בסיס");
            entity.Property(e => e.סוגגורםמשערך)
                .HasMaxLength(250)
                .HasColumnName("סוג גורם משערך");
            entity.Property(e => e.סוגמספרמזההמנפיק)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("סוג מספר מזהה מנפיק");
            entity.Property(e => e.סוגמספרניירערך)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("סוג מספר נייר ערך");
            entity.Property(e => e.ערךנקוביחידות)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ערך נקוב (יחידות)");
            entity.Property(e => e.שוויהוגןבשח)
                .HasColumnType("decimal(23, 7)")
                .HasColumnName("שווי הוגן (בש\"ח)");
            entity.Property(e => e.שיעורמנכסיאפיקההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מנכסי אפיק ההשקעה");
            entity.Property(e => e.שיעורמסךנכסיההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מסך נכסי ההשקעה");
            entity.Property(e => e.שיעורריבית)
                .HasMaxLength(4000)
                .HasColumnName("שיעור ריבית");
            entity.Property(e => e.שםמדרג)
                .HasMaxLength(50)
                .HasColumnName("שם מדרג");
            entity.Property(e => e.שםמנפיק)
                .HasMaxLength(50)
                .HasColumnName("שם מנפיק");
            entity.Property(e => e.שםניירערך).HasColumnName("שם נייר ערך");
            entity.Property(e => e.שערחליפין)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער חליפין");
            entity.Property(e => e.שערניירהערך)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער נייר הערך");
            entity.Property(e => e.תאריךרכישה)
                .HasMaxLength(250)
                .HasColumnName("תאריך רכישה");
            entity.Property(e => e.תאריךשערוךאחרון)
                .HasMaxLength(4000)
                .HasColumnName("תאריך שערוך אחרון");
            entity.Property(e => e.תלותאיתלותהמשערך)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("תלות/אי-תלות המשערך");
            entity.Property(e => e.תשואהלפדיון)
                .HasMaxLength(4000)
                .HasColumnName("תשואה לפדיון");
        });

        modelBuilder.Entity<VDvchNaam>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Dvch_Naam");

            entity.Property(e => e.בעלענייןצדקשור)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("בעל עניין/צד קשור");
            entity.Property(e => e.דירוג).HasMaxLength(50);
            entity.Property(e => e.דירוגניירהערךהמנפיק)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("דירוג נייר הערך/המנפיק");
            entity.Property(e => e.האםסווגכחובבעייתי)
                .HasMaxLength(250)
                .HasColumnName("האם סווג כחוב בעייתי");
            entity.Property(e => e.השיטהשיושמהבדוחהכספי)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("השיטה שיושמה בדוח הכספי");
            entity.Property(e => e.זירתמסחר)
                .HasMaxLength(250)
                .HasColumnName("זירת מסחר");
            entity.Property(e => e.ישראלחול)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ישראל/חו\"ל");
            entity.Property(e => e.מאפייןעיקרי)
                .HasMaxLength(250)
                .HasColumnName("מאפיין עיקרי");
            entity.Property(e => e.מדינהלפיחשיפהכלכלית)
                .HasMaxLength(50)
                .HasColumnName("מדינה לפי חשיפה כלכלית");
            entity.Property(e => e.מועדפדיון)
                .HasMaxLength(4000)
                .HasColumnName("מועד פדיון");
            entity.Property(e => e.מחמ)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("מח\"מ");
            entity.Property(e => e.מטבעפעילות)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("מטבע פעילות");
            entity.Property(e => e.מספרמנפיק).HasColumnName("מספר מנפיק");
            entity.Property(e => e.מספרמסלול).HasColumnName("מספר מסלול");
            entity.Property(e => e.מספרניירערך)
                .HasMaxLength(50)
                .HasColumnName("מספר נייר ערך");
            entity.Property(e => e.מספרקופהקרןחפעבורחברתביטוח).HasColumnName("מספר קופה/קרן/ח.פ. עבור חברת ביטוח");
            entity.Property(e => e.נחיתותחוזית)
                .HasMaxLength(250)
                .HasColumnName("נחיתות חוזית");
            entity.Property(e => e.סוגמספרמזההמנפיק)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("סוג מספר מזהה מנפיק");
            entity.Property(e => e.סוגמספרניירערך)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("סוג מספר נייר ערך");
            entity.Property(e => e.סכוםלקבלבמטבעהפעילות)
                .HasColumnType("decimal(38, 7)")
                .HasColumnName("סכום לקבל (במטבע הפעילות)");
            entity.Property(e => e.עלותמופחתתבמטבעהפעילות)
                .HasMaxLength(250)
                .HasColumnName("עלות מופחתת (במטבע הפעילות)");
            entity.Property(e => e.עלותמופחתתבשח)
                .HasMaxLength(250)
                .HasColumnName("עלות מופחתת (בש\"ח)");
            entity.Property(e => e.ענףמסחר)
                .HasMaxLength(250)
                .HasColumnName("ענף מסחר");
            entity.Property(e => e.ערךנקוביחידות)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ערך נקוב (יחידות)");
            entity.Property(e => e.ריביתעוגן)
                .HasMaxLength(250)
                .HasColumnName("ריבית עוגן");
            entity.Property(e => e.שוויהוגןבשח)
                .HasColumnType("decimal(23, 7)")
                .HasColumnName("שווי הוגן (בש\"ח)");
            entity.Property(e => e.שיעורמנכסיאפיקההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מנכסי אפיק ההשקעה");
            entity.Property(e => e.שיעורמסךנכסיההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מסך נכסי ההשקעה");
            entity.Property(e => e.שיעורמערךנקובמונפק)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מערך נקוב מונפק");
            entity.Property(e => e.שיעורריבית)
                .HasMaxLength(4000)
                .HasColumnName("שיעור ריבית");
            entity.Property(e => e.שםמדרג)
                .HasMaxLength(50)
                .HasColumnName("שם מדרג");
            entity.Property(e => e.שםמנפיק)
                .HasMaxLength(50)
                .HasColumnName("שם מנפיק");
            entity.Property(e => e.שםניירערך).HasColumnName("שם נייר ערך");
            entity.Property(e => e.שערחליפין)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער חליפין");
            entity.Property(e => e.שערניירהערך)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער נייר הערך");
            entity.Property(e => e.תשואהלפדיון)
                .HasMaxLength(4000)
                .HasColumnName("תשואה לפדיון");
        });

        modelBuilder.Entity<VDvchNaamLoSachir>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Dvch_Naam_LoSachir");

            entity.Property(e => e.בעלענייןצדקשור)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("בעל עניין/צד קשור");
            entity.Property(e => e.דירוג).HasMaxLength(50);
            entity.Property(e => e.דירוגניירהערךהמנפיק)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("דירוג נייר הערך/המנפיק");
            entity.Property(e => e.האםסווגכחובבעייתי)
                .HasMaxLength(250)
                .HasColumnName("האם סווג כחוב בעייתי");
            entity.Property(e => e.השיטהשיושמהבדוחהכספי)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("השיטה שיושמה בדוח הכספי");
            entity.Property(e => e.ישראלחול)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ישראל/חו\"ל");
            entity.Property(e => e.מאפייןעיקרי)
                .HasMaxLength(250)
                .HasColumnName("מאפיין עיקרי");
            entity.Property(e => e.מדינהלפיחשיפהכלכלית)
                .HasMaxLength(50)
                .HasColumnName("מדינה לפי חשיפה כלכלית");
            entity.Property(e => e.מועדפדיון)
                .HasMaxLength(4000)
                .HasColumnName("מועד פדיון");
            entity.Property(e => e.מחמ)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("מח\"מ");
            entity.Property(e => e.מטבעפעילות)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("מטבע פעילות");
            entity.Property(e => e.מספרמנפיק).HasColumnName("מספר מנפיק");
            entity.Property(e => e.מספרמסלול).HasColumnName("מספר מסלול");
            entity.Property(e => e.מספרניירערך)
                .HasMaxLength(50)
                .HasColumnName("מספר נייר ערך");
            entity.Property(e => e.מספרקופהקרןחפעבורחברתביטוח).HasColumnName("מספר קופה/קרן/ח.פ. עבור חברת ביטוח");
            entity.Property(e => e.נחיתותחוזית)
                .HasMaxLength(250)
                .HasColumnName("נחיתות חוזית");
            entity.Property(e => e.סוגגורםמשערך)
                .HasMaxLength(250)
                .HasColumnName("סוג גורם משערך");
            entity.Property(e => e.סוגהצמדה)
                .HasMaxLength(250)
                .HasColumnName("סוג הצמדה");
            entity.Property(e => e.סוגמספרמזההמנפיק)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("סוג מספר מזהה מנפיק");
            entity.Property(e => e.סוגמספרניירערך)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("סוג מספר נייר ערך");
            entity.Property(e => e.עלותמופחתתבמטבעהפעילות)
                .HasMaxLength(250)
                .HasColumnName("עלות מופחתת (במטבע הפעילות)");
            entity.Property(e => e.עלותמופחתתבשח)
                .HasMaxLength(250)
                .HasColumnName("עלות מופחתת (בש\"ח)");
            entity.Property(e => e.ענףמסחר)
                .HasMaxLength(250)
                .HasColumnName("ענף מסחר");
            entity.Property(e => e.ערךנקוביחידות)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ערך נקוב (יחידות)");
            entity.Property(e => e.ריביתעוגן)
                .HasMaxLength(250)
                .HasColumnName("ריבית עוגן");
            entity.Property(e => e.שוויהוגןבשח)
                .HasColumnType("decimal(23, 7)")
                .HasColumnName("שווי הוגן (בש\"ח)");
            entity.Property(e => e.שיעורמנכסיאפיקההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מנכסי אפיק ההשקעה");
            entity.Property(e => e.שיעורמסךנכסיההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מסך נכסי ההשקעה");
            entity.Property(e => e.שיעורריבית)
                .HasMaxLength(4000)
                .HasColumnName("שיעור ריבית");
            entity.Property(e => e.שםגורםמשערך)
                .HasMaxLength(250)
                .HasColumnName("שם גורם משערך");
            entity.Property(e => e.שםמדרג)
                .HasMaxLength(50)
                .HasColumnName("שם מדרג");
            entity.Property(e => e.שםמנפיק)
                .HasMaxLength(50)
                .HasColumnName("שם מנפיק");
            entity.Property(e => e.שםניירערך).HasColumnName("שם נייר ערך");
            entity.Property(e => e.שערחליפין)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער חליפין");
            entity.Property(e => e.שערניירהערך)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער נייר הערך");
            entity.Property(e => e.תאריךאחרוןבונבחנהבפועלירידתערך)
                .HasMaxLength(250)
                .HasColumnName("תאריך אחרון בו נבחנה בפועל ירידת ערך");
            entity.Property(e => e.תאריךרכישה)
                .HasMaxLength(250)
                .HasColumnName("תאריך רכישה");
            entity.Property(e => e.תאריךשערוךאחרון)
                .HasMaxLength(4000)
                .HasColumnName("תאריך שערוך אחרון");
            entity.Property(e => e.תלותאיתלותהמשערך)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("תלות/אי-תלות המשערך");
            entity.Property(e => e.תשואהלפדיון)
                .HasMaxLength(4000)
                .HasColumnName("תשואה לפדיון");
        });

        modelBuilder.Entity<VDvchNadlan>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Dvch_Nadlan");

            entity.Property(e => e.בעלענייןצדקשור)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("בעל עניין/צד קשור");
            entity.Property(e => e.השיטהשבאמצעותהנקבעשוויהנכס)
                .HasMaxLength(250)
                .HasColumnName("השיטה שבאמצעותה נקבע שווי הנכס ");
            entity.Property(e => e.השיטהשיושמהבדוחהכספי)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("השיטה שיושמה בדוח הכספי");
            entity.Property(e => e.כתובתהנכס)
                .HasMaxLength(250)
                .HasColumnName("כתובת הנכס");
            entity.Property(e => e.מאפייןעיקרי)
                .HasMaxLength(250)
                .HasColumnName("מאפיין עיקרי");
            entity.Property(e => e.מדינתמיקוםנדלן)
                .HasMaxLength(250)
                .HasColumnName("מדינת מיקום נדל\"ן");
            entity.Property(e => e.מחזורחייהנכס)
                .HasMaxLength(250)
                .HasColumnName("מחזור חיי הנכס");
            entity.Property(e => e.מטבעפעילות)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("מטבע פעילות");
            entity.Property(e => e.מספרמסלול).HasColumnName("מספר מסלול");
            entity.Property(e => e.מספרקופהקרןחפעבורחברתביטוח).HasColumnName("מספר קופה/קרן/ח.פ. עבור חברת ביטוח");
            entity.Property(e => e.סוגגורםמשערך)
                .HasMaxLength(250)
                .HasColumnName("סוג גורם משערך");
            entity.Property(e => e.עלותמופחתתבמטבעהפעילות)
                .HasMaxLength(250)
                .HasColumnName("עלות מופחתת (במטבע הפעילות)");
            entity.Property(e => e.עלותמופחתתבשח)
                .HasMaxLength(250)
                .HasColumnName("עלות מופחתת (בש\"ח)");
            entity.Property(e => e.שוויהוגןבמטבעהפעילות)
                .HasColumnType("decimal(23, 7)")
                .HasColumnName("שווי הוגן (במטבע הפעילות)");
            entity.Property(e => e.שוויהוגןבשח)
                .HasColumnType("decimal(23, 7)")
                .HasColumnName("שווי הוגן (בש\"ח)");
            entity.Property(e => e.שימושעיקריבנכס)
                .HasMaxLength(250)
                .HasColumnName("שימוש עיקרי בנכס");
            entity.Property(e => e.שיעורמנכסיאפיקההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מנכסי אפיק ההשקעה");
            entity.Property(e => e.שיעורמסךנכסיההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מסך נכסי ההשקעה");
            entity.Property(e => e.שיעורתשואהבפועלבמהלךהרבעון)
                .HasMaxLength(250)
                .HasColumnName("שיעור תשואה בפועל במהלך הרבעון");
            entity.Property(e => e.שםגורםמשערך)
                .HasMaxLength(250)
                .HasColumnName("שם גורם משערך");
            entity.Property(e => e.שםהנכס).HasColumnName("שם הנכס");
            entity.Property(e => e.תאריךרכישה)
                .HasMaxLength(250)
                .HasColumnName("תאריך רכישה");
            entity.Property(e => e.תאריךשערוךאחרון)
                .HasMaxLength(4000)
                .HasColumnName("תאריך שערוך אחרון");
            entity.Property(e => e.תלותאיתלותהמשערך)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("תלות/אי-תלות המשערך");
        });

        modelBuilder.Entity<VDvchNechasimOther>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Dvch_NechasimOther");

            entity.Property(e => e.בעלענייןצדקשור)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("בעל עניין/צד קשור");
            entity.Property(e => e.השיטהשיושמהבדוחהכספי)
                .HasMaxLength(11)
                .IsUnicode(false)
                .HasColumnName("השיטה שיושמה בדוח הכספי");
            entity.Property(e => e.ישראלחול)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ישראל/חו\"ל");
            entity.Property(e => e.מאפייןעיקרי)
                .HasMaxLength(250)
                .HasColumnName("מאפיין עיקרי");
            entity.Property(e => e.מדינהלפיחשיפהכלכלית)
                .HasMaxLength(50)
                .HasColumnName("מדינה לפי חשיפה כלכלית");
            entity.Property(e => e.מטבעפעילות)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("מטבע פעילות");
            entity.Property(e => e.מספרהנכסהאחר)
                .HasMaxLength(50)
                .HasColumnName("מספר הנכס האחר");
            entity.Property(e => e.מספרמסלול).HasColumnName("מספר מסלול");
            entity.Property(e => e.מספרקופהקרןחפעבורחברתביטוח).HasColumnName("מספר קופה/קרן/ח.פ. עבור חברת ביטוח");
            entity.Property(e => e.עלותמופחתתבשח)
                .HasMaxLength(250)
                .HasColumnName("עלות מופחתת (בש\"ח)");
            entity.Property(e => e.שוויהוגןבשח)
                .HasColumnType("decimal(23, 7)")
                .HasColumnName("שווי הוגן (בש\"ח)");
            entity.Property(e => e.שווימטבעי)
                .HasColumnType("decimal(23, 7)")
                .HasColumnName("שווי מטבעי");
            entity.Property(e => e.שיעורמנכסיאפיקההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מנכסי אפיק ההשקעה");
            entity.Property(e => e.שיעורמסךנכסיההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מסך נכסי ההשקעה");
            entity.Property(e => e.שםהנכסהאחר).HasColumnName("שם הנכס האחר");
            entity.Property(e => e.שערחליפין)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער חליפין");
            entity.Property(e => e.תאריךעסקה)
                .HasMaxLength(250)
                .HasColumnName("תאריך עסקה");
            entity.Property(e => e.תאריךשערוךאחרון)
                .HasMaxLength(4000)
                .HasColumnName("תאריך שערוך אחרון");
        });

        modelBuilder.Entity<VDvchNechesProperty>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Dvch_Neches_Properties");

            entity.Property(e => e.AchuzRibitShnatit).HasColumnName("Achuz_Ribit_Shnatit");
            entity.Property(e => e.KodMatbea)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("Kod_Matbea");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.KodNechesNegdi)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches_Negdi");
        });

        modelBuilder.Entity<VDvchOption>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Dvch_Options");

            entity.Property(e => e.בעלענייןצדקשור)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("בעל עניין/צד קשור");
            entity.Property(e => e.זירתמסחר)
                .HasMaxLength(250)
                .HasColumnName("זירת מסחר");
            entity.Property(e => e.ישראלחול)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ישראל/חו\"ל");
            entity.Property(e => e.מאפייןעיקרי)
                .HasMaxLength(250)
                .HasColumnName("מאפיין עיקרי");
            entity.Property(e => e.מדינהלפיחשיפהכלכלית)
                .HasMaxLength(50)
                .HasColumnName("מדינה לפי חשיפה כלכלית");
            entity.Property(e => e.מטבעפעילות)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("מטבע פעילות");
            entity.Property(e => e.מספרמנפיק).HasColumnName("מספר מנפיק");
            entity.Property(e => e.מספרמסלול).HasColumnName("מספר מסלול");
            entity.Property(e => e.מספרניירערך)
                .HasMaxLength(50)
                .HasColumnName("מספר נייר ערך");
            entity.Property(e => e.מספרקופהקרןחפעבורחברתביטוח).HasColumnName("מספר קופה/קרן/ח.פ. עבור חברת ביטוח");
            entity.Property(e => e.נכסבסיס)
                .HasMaxLength(250)
                .HasColumnName("נכס בסיס");
            entity.Property(e => e.סוגמספרמזההמנפיק)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("סוג מספר מזהה מנפיק");
            entity.Property(e => e.סוגמספרניירערך)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("סוג מספר נייר ערך");
            entity.Property(e => e.ענףמסחר)
                .HasMaxLength(250)
                .HasColumnName("ענף מסחר");
            entity.Property(e => e.ערךנקוביחידות)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ערך נקוב (יחידות)");
            entity.Property(e => e.שוויהוגןבשח)
                .HasColumnType("decimal(23, 7)")
                .HasColumnName("שווי הוגן (בש\"ח)");
            entity.Property(e => e.שיעורמנכסיאפיקההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מנכסי אפיק ההשקעה");
            entity.Property(e => e.שיעורמסךנכסיההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מסך נכסי ההשקעה");
            entity.Property(e => e.שםמנפיק)
                .HasMaxLength(50)
                .HasColumnName("שם מנפיק");
            entity.Property(e => e.שםניירערך).HasColumnName("שם נייר ערך");
            entity.Property(e => e.שערחליפין)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער חליפין");
            entity.Property(e => e.שערמימוש)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער מימוש");
            entity.Property(e => e.שערניירהערך)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער נייר הערך");
            entity.Property(e => e.תאריךפקיעה)
                .HasMaxLength(4000)
                .HasColumnName("תאריך פקיעה");
        });

        modelBuilder.Entity<VDvchOptionsLoSachir>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Dvch_Options_LoSachir");

            entity.Property(e => e.בעלענייןצדקשור)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("בעל עניין/צד קשור");
            entity.Property(e => e.יחסהמרה)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("יחס המרה");
            entity.Property(e => e.ישראלחול)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ישראל/חו\"ל");
            entity.Property(e => e.מאפייןעיקרי)
                .HasMaxLength(250)
                .HasColumnName("מאפיין עיקרי");
            entity.Property(e => e.מדינהלפיחשיפהכלכלית)
                .HasMaxLength(50)
                .HasColumnName("מדינה לפי חשיפה כלכלית");
            entity.Property(e => e.מטבעפעילות)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("מטבע פעילות");
            entity.Property(e => e.מספרמנפיק).HasColumnName("מספר מנפיק");
            entity.Property(e => e.מספרמסלול).HasColumnName("מספר מסלול");
            entity.Property(e => e.מספרניירערך)
                .HasMaxLength(50)
                .HasColumnName("מספר נייר ערך");
            entity.Property(e => e.מספרקופהקרןחפעבורחברתביטוח).HasColumnName("מספר קופה/קרן/ח.פ. עבור חברת ביטוח");
            entity.Property(e => e.נכסבסיס)
                .HasMaxLength(250)
                .HasColumnName("נכס בסיס");
            entity.Property(e => e.סוגגורםמשערך)
                .HasMaxLength(250)
                .HasColumnName("סוג גורם משערך");
            entity.Property(e => e.סוגמספרמזההמנפיק)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("סוג מספר מזהה מנפיק");
            entity.Property(e => e.סוגמספרניירערך)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("סוג מספר נייר ערך");
            entity.Property(e => e.ענףמסחר)
                .HasMaxLength(250)
                .HasColumnName("ענף מסחר");
            entity.Property(e => e.ערךנקוביחידות)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ערך נקוב (יחידות)");
            entity.Property(e => e.שוויהוגןבשח)
                .HasColumnType("decimal(23, 7)")
                .HasColumnName("שווי הוגן (בש\"ח)");
            entity.Property(e => e.שיעורמנכסיאפיקההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מנכסי אפיק ההשקעה");
            entity.Property(e => e.שיעורמסךנכסיההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מסך נכסי ההשקעה");
            entity.Property(e => e.שםמנפיק)
                .HasMaxLength(50)
                .HasColumnName("שם מנפיק");
            entity.Property(e => e.שםניירערך).HasColumnName("שם נייר ערך");
            entity.Property(e => e.שערחליפין)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער חליפין");
            entity.Property(e => e.שערמימוש)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער מימוש");
            entity.Property(e => e.שערניירהערך)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער נייר הערך");
            entity.Property(e => e.תאריךפקיעה)
                .HasMaxLength(4000)
                .HasColumnName("תאריך פקיעה");
            entity.Property(e => e.תאריךרכישה)
                .HasMaxLength(250)
                .HasColumnName("תאריך רכישה");
            entity.Property(e => e.תאריךשערוךאחרון)
                .HasMaxLength(4000)
                .HasColumnName("תאריך שערוך אחרון");
            entity.Property(e => e.תלותאיתלותהמשערך)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("תלות/אי-תלות המשערך");
        });

        modelBuilder.Entity<VDvchPe>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Dvch_PE");

            entity.Property(e => e.Navבמטבעהדיווחשלקרןההשקעה)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("NAV (במטבע הדיווח של קרן ההשקעה)");
            entity.Property(e => e.אסטרטגייתקרןההשקעה)
                .HasMaxLength(250)
                .HasColumnName("אסטרטגיית קרן ההשקעה");
            entity.Property(e => e.בעלענייןצדקשור)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("בעל עניין/צד קשור");
            entity.Property(e => e.ישראלחול)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ישראל/חו\"ל");
            entity.Property(e => e.מאפייןעיקרי)
                .HasMaxLength(250)
                .HasColumnName("מאפיין עיקרי");
            entity.Property(e => e.מדינהלפיחשיפהכלכלית)
                .HasMaxLength(50)
                .HasColumnName("מדינה לפי חשיפה כלכלית");
            entity.Property(e => e.מדינתהתאגדותקרןהשקעה)
                .HasMaxLength(50)
                .HasColumnName("מדינת התאגדות קרן השקעה");
            entity.Property(e => e.מטבעפעילות)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("מטבע פעילות");
            entity.Property(e => e.מיקוםמשרדהשותףהכללי)
                .HasMaxLength(250)
                .HasColumnName("מיקום משרד השותף הכללי");
            entity.Property(e => e.מספרמזההקרןהשקעה)
                .HasMaxLength(50)
                .HasColumnName("מספר מזהה קרן השקעה");
            entity.Property(e => e.מספרמזההשותףכלליקרןהשקעות)
                .HasMaxLength(250)
                .HasColumnName("מספר מזהה שותף כללי קרן השקעות");
            entity.Property(e => e.מספרמסלול).HasColumnName("מספר מסלול");
            entity.Property(e => e.מספרקופהקרןחפעבורחברתביטוח).HasColumnName("מספר קופה/קרן/ח.פ. עבור חברת ביטוח");
            entity.Property(e => e.סוגגורםמשערך)
                .HasMaxLength(250)
                .HasColumnName("סוג גורם משערך");
            entity.Property(e => e.סוגמספרמזההקרןהשקעות)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("סוג מספר מזהה קרן השקעות");
            entity.Property(e => e.סוגמספרמזההשותףכלליקרןהשקעות)
                .HasMaxLength(250)
                .HasColumnName("סוג מספר מזהה שותף כללי קרן השקעות");
            entity.Property(e => e.שוויהוגןבשח)
                .HasColumnType("decimal(23, 7)")
                .HasColumnName("שווי הוגן (בש\"ח)");
            entity.Property(e => e.שיעורהחזקהבקרןהשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור החזקה בקרן השקעה");
            entity.Property(e => e.שיעורמנכסיאפיקההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מנכסי אפיק ההשקעה");
            entity.Property(e => e.שיעורמסךנכסיההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מסך נכסי ההשקעה");
            entity.Property(e => e.שםקרןהשקעה).HasColumnName("שם קרן השקעה");
            entity.Property(e => e.שםשותףכלליקרןהשקעות)
                .HasMaxLength(250)
                .HasColumnName("שם שותף כללי קרן השקעות");
            entity.Property(e => e.שערחליפין)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער חליפין");
            entity.Property(e => e.תאריךרכישה)
                .HasMaxLength(250)
                .HasColumnName("תאריך רכישה");
            entity.Property(e => e.תאריךשערוךאחרון)
                .HasMaxLength(4000)
                .HasColumnName("תאריך שערוך אחרון");
            entity.Property(e => e.תלותאיתלותהמשערך)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("תלות/אי-תלות המשערך");
        });

        modelBuilder.Entity<VDvchPikdonot>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Dvch_Pikdonot");

            entity.Property(e => e.בעלענייןצדקשור)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("בעל עניין/צד קשור");
            entity.Property(e => e.דירוגהבנק)
                .HasMaxLength(50)
                .HasColumnName("דירוג הבנק");
            entity.Property(e => e.ישראלחול)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ישראל/חו\"ל");
            entity.Property(e => e.מאפייןעיקרי)
                .HasMaxLength(250)
                .HasColumnName("מאפיין עיקרי");
            entity.Property(e => e.מדינהלפיחשיפהכלכלית)
                .HasMaxLength(50)
                .HasColumnName("מדינה לפי חשיפה כלכלית");
            entity.Property(e => e.מחמ)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("מח\"מ");
            entity.Property(e => e.מטבעפעילות)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("מטבע פעילות");
            entity.Property(e => e.מספרמזההבנק)
                .HasMaxLength(50)
                .HasColumnName("מספר מזהה בנק");
            entity.Property(e => e.מספרמסלול).HasColumnName("מספר מסלול");
            entity.Property(e => e.מספרקופהקרןחפעבורחברתביטוח).HasColumnName("מספר קופה/קרן/ח.פ. עבור חברת ביטוח");
            entity.Property(e => e.סוגמספרמזההבנק)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("סוג מספר מזהה בנק");
            entity.Property(e => e.שוויהוגןבשח)
                .HasColumnType("decimal(23, 7)")
                .HasColumnName("שווי הוגן (בש\"ח)");
            entity.Property(e => e.שווימטבעי)
                .HasColumnType("decimal(23, 7)")
                .HasColumnName("שווי מטבעי");
            entity.Property(e => e.שיעורמנכסיאפיקההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מנכסי אפיק ההשקעה");
            entity.Property(e => e.שיעורמסךנכסיההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מסך נכסי ההשקעה");
            entity.Property(e => e.שיעורריבית)
                .HasMaxLength(4000)
                .HasColumnName("שיעור ריבית");
            entity.Property(e => e.שםהבנק)
                .HasMaxLength(100)
                .HasColumnName("שם הבנק");
            entity.Property(e => e.שםמדרג)
                .HasMaxLength(50)
                .HasColumnName("שם מדרג");
            entity.Property(e => e.שערחליפין)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער חליפין");
            entity.Property(e => e.שערפיקדון)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער פיקדון");
            entity.Property(e => e.תאריךפקיעתפיקדון)
                .HasMaxLength(4000)
                .HasColumnName("תאריך פקיעת פיקדון");
            entity.Property(e => e.תשואהלפדיון)
                .HasMaxLength(4000)
                .HasColumnName("תשואה לפדיון");
        });

        modelBuilder.Entity<VDvchStock>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Dvch_Stocks");

            entity.Property(e => e.בעלענייןצדקשור)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("בעל עניין/צד קשור");
            entity.Property(e => e.זירתמסחר)
                .HasMaxLength(250)
                .HasColumnName("זירת מסחר");
            entity.Property(e => e.ישראלחול)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ישראל/חו\"ל");
            entity.Property(e => e.מאפייןעיקרי)
                .HasMaxLength(250)
                .HasColumnName("מאפיין עיקרי");
            entity.Property(e => e.מדינהלפיחשיפהכלכלית)
                .HasMaxLength(50)
                .HasColumnName("מדינה לפי חשיפה כלכלית");
            entity.Property(e => e.מטבעפעילות)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("מטבע פעילות");
            entity.Property(e => e.מספרמנפיק).HasColumnName("מספר מנפיק");
            entity.Property(e => e.מספרמסלול).HasColumnName("מספר מסלול");
            entity.Property(e => e.מספרניירערך)
                .HasMaxLength(50)
                .HasColumnName("מספר נייר ערך");
            entity.Property(e => e.מספרקופהקרןחפעבורחברתביטוח).HasColumnName("מספר קופה/קרן/ח.פ. עבור חברת ביטוח");
            entity.Property(e => e.סוגמספרמזההמנפיק)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("סוג מספר מזהה מנפיק");
            entity.Property(e => e.סוגמספרניירערך)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("סוג מספר נייר ערך");
            entity.Property(e => e.סטאטוססחירות)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("סטאטוס סחירות");
            entity.Property(e => e.סכוםלקבלבמטבעהפעילות)
                .HasColumnType("decimal(38, 7)")
                .HasColumnName("סכום לקבל (במטבע הפעילות)");
            entity.Property(e => e.ענףמסחר)
                .HasMaxLength(250)
                .HasColumnName("ענף מסחר");
            entity.Property(e => e.ערךנקוביחידות)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ערך נקוב (יחידות)");
            entity.Property(e => e.שוויהוגןבשח)
                .HasColumnType("decimal(23, 7)")
                .HasColumnName("שווי הוגן (בש\"ח)");
            entity.Property(e => e.שיעורמנכסיאפיקההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מנכסי אפיק ההשקעה");
            entity.Property(e => e.שיעורמסךנכסיההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מסך נכסי ההשקעה");
            entity.Property(e => e.שיעורמערךנקובמונפק)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מערך נקוב מונפק");
            entity.Property(e => e.שםמנפיק)
                .HasMaxLength(50)
                .HasColumnName("שם מנפיק");
            entity.Property(e => e.שםניירערך).HasColumnName("שם נייר ערך");
            entity.Property(e => e.שערחליפין)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער חליפין");
            entity.Property(e => e.שערניירהערך)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער נייר הערך");
        });

        modelBuilder.Entity<VDvchStocksLoSachir>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Dvch_Stocks_LoSachir");

            entity.Property(e => e.בעלענייןצדקשור)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("בעל עניין/צד קשור");
            entity.Property(e => e.ישראלחול)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("ישראל/חו\"ל");
            entity.Property(e => e.מאפייןעיקרי)
                .HasMaxLength(250)
                .HasColumnName("מאפיין עיקרי");
            entity.Property(e => e.מדינהלפיחשיפהכלכלית)
                .HasMaxLength(50)
                .HasColumnName("מדינה לפי חשיפה כלכלית");
            entity.Property(e => e.מטבעפעילות)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("מטבע פעילות");
            entity.Property(e => e.מספרמנפיק).HasColumnName("מספר מנפיק");
            entity.Property(e => e.מספרמסלול).HasColumnName("מספר מסלול");
            entity.Property(e => e.מספרניירערך)
                .HasMaxLength(50)
                .HasColumnName("מספר נייר ערך");
            entity.Property(e => e.מספרקופהקרןחפעבורחברתביטוח).HasColumnName("מספר קופה/קרן/ח.פ. עבור חברת ביטוח");
            entity.Property(e => e.סוגגורםמשערך)
                .HasMaxLength(250)
                .HasColumnName("סוג גורם משערך");
            entity.Property(e => e.סוגמספרמזההמנפיק)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("סוג מספר מזהה מנפיק");
            entity.Property(e => e.סוגמספרניירערך)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("סוג מספר נייר ערך");
            entity.Property(e => e.סטאטוססחירות)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("סטאטוס סחירות");
            entity.Property(e => e.ענףמסחר)
                .HasMaxLength(250)
                .HasColumnName("ענף מסחר");
            entity.Property(e => e.ערךנקוביחידות)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("ערך נקוב (יחידות)");
            entity.Property(e => e.שוויהוגןבשח)
                .HasColumnType("decimal(23, 7)")
                .HasColumnName("שווי הוגן (בש\"ח)");
            entity.Property(e => e.שיעורמנכסיאפיקההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מנכסי אפיק ההשקעה");
            entity.Property(e => e.שיעורמסךנכסיההשקעה)
                .HasMaxLength(4000)
                .HasColumnName("שיעור מסך נכסי ההשקעה");
            entity.Property(e => e.שםמנפיק)
                .HasMaxLength(50)
                .HasColumnName("שם מנפיק");
            entity.Property(e => e.שםניירערך).HasColumnName("שם נייר ערך");
            entity.Property(e => e.שערחליפין)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער חליפין");
            entity.Property(e => e.שערניירהערך)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("שער נייר הערך");
            entity.Property(e => e.תאריךאחרוןבונבחנהבפועלירידתערך)
                .HasMaxLength(250)
                .HasColumnName("תאריך אחרון בו נבחנה בפועל ירידת ערך");
            entity.Property(e => e.תאריךרכישה)
                .HasMaxLength(250)
                .HasColumnName("תאריך רכישה");
            entity.Property(e => e.תאריךשערוךאחרון)
                .HasMaxLength(4000)
                .HasColumnName("תאריך שערוך אחרון");
            entity.Property(e => e.תלותאיתלותהמשערך)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("תלות/אי-תלות המשערך");
        });

        modelBuilder.Entity<VDvchYitrotHitchayvutLeHashkaa>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Dvch_YitrotHitchayvutLeHashkaa");

            entity.Property(e => e.יתרתהמחויבותלתקופתהדיווחבמטבעהדיווחשלקרןההשקעה)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("יתרת המחויבות לתקופת הדיווח (במטבע הדיווח של קרן ההשקעה)");
            entity.Property(e => e.יתרתהמחויבותלתקופתהדיווחבשח)
                .HasColumnType("decimal(37, 12)")
                .HasColumnName("יתרת המחויבות לתקופת הדיווח (בש\"ח)");
            entity.Property(e => e.מאפייןעיקרי)
                .HasMaxLength(250)
                .HasColumnName("מאפיין עיקרי");
            entity.Property(e => e.מטבעפעילות)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("מטבע פעילות");
            entity.Property(e => e.מספרמזההקרןהשקעה)
                .HasMaxLength(50)
                .HasColumnName("מספר מזהה קרן השקעה");
            entity.Property(e => e.מספרמזההשותףכלליקרןהשקעות)
                .HasMaxLength(250)
                .HasColumnName("מספר מזהה שותף כללי קרן השקעות");
            entity.Property(e => e.מספרמסלול).HasColumnName("מספר מסלול");
            entity.Property(e => e.מספרקופהקרןחפעבורחברתביטוח).HasColumnName("מספר קופה/קרן/ח.פ. עבור חברת ביטוח");
            entity.Property(e => e.סוגמספרמזההקרןהשקעות)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("סוג מספר מזהה קרן השקעות");
            entity.Property(e => e.סוגמספרמזההשותףכלליקרןהשקעות)
                .HasMaxLength(250)
                .HasColumnName("סוג מספר מזהה שותף כללי קרן השקעות");
            entity.Property(e => e.סכוםהמחויבותהראשוניבמטבעהדיווחשלקרןההשקעה)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("סכום המחויבות הראשוני (במטבע הדיווח של קרן ההשקעה)");
            entity.Property(e => e.סכוםהמחויבותהראשוניבשח)
                .HasColumnType("decimal(37, 12)")
                .HasColumnName("סכום המחויבות הראשוני (בש\"ח)");
            entity.Property(e => e.שיעוריתרתהמחויבות)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("שיעור יתרת המחויבות");
            entity.Property(e => e.שםקרןהשקעה).HasColumnName("שם קרן השקעה");
            entity.Property(e => e.שםשותףכלליקרןהשקעות)
                .HasMaxLength(250)
                .HasColumnName("שם שותף כללי קרן השקעות");
            entity.Property(e => e.תאריךהעמדתהתחייבותלקרןהשקעה)
                .HasMaxLength(4000)
                .HasColumnName("תאריך העמדת התחייבות לקרן השקעה");
            entity.Property(e => e.תאריךפקיעתמחויבותלהשקעה)
                .HasMaxLength(4000)
                .HasColumnName("תאריך פקיעת מחויבות להשקעה");
        });

        modelBuilder.Entity<VFctTazrim>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_FCT_Tazrim");

            entity.Property(e => e.KodBasisHatzmada)
                .HasMaxLength(50)
                .HasColumnName("Kod_BasisHatzmada");
            entity.Property(e => e.KodMutzar).HasColumnName("Kod_Mutzar");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.KodYom)
                .HasMaxLength(4000)
                .HasColumnName("Kod_Yom");
            entity.Property(e => e.RecType).HasColumnName("Rec_Type");
            entity.Property(e => e.Shovi).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ShoviMutzar)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("Shovi_Mutzar");
        });

        modelBuilder.Entity<VFctYitrot>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_FCT_Yitrot");

            entity.Property(e => e.Kamut).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.KodBasisHatzmada)
                .HasMaxLength(50)
                .HasColumnName("Kod_BasisHatzmada");
            entity.Property(e => e.KodHieTatAfik1).HasColumnName("Kod_Hie_TatAfik1");
            entity.Property(e => e.KodMachshir).HasColumnName("Kod_Machshir");
            entity.Property(e => e.KodMutzar).HasColumnName("Kod_Mutzar");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.KodSugYitra).HasColumnName("Kod_Sug_Yitra");
            entity.Property(e => e.KodTatAfik).HasColumnName("Kod_TatAfik");
            entity.Property(e => e.KodYom)
                .HasMaxLength(4000)
                .HasColumnName("Kod_Yom");
            entity.Property(e => e.Mutzar).HasMaxLength(50);
            entity.Property(e => e.Neches).HasMaxLength(1000);
            entity.Property(e => e.Shovi).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<VFoAchzakotHozim>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_FO_Achzakot_Hozim");

            entity.Property(e => e.Hodesh).HasMaxLength(1);
            entity.Property(e => e.KamutGoldman)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("Kamut_Goldman");
            entity.Property(e => e.KamutLeumi)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("Kamut_Leumi");
            entity.Property(e => e.KamutTotal)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("Kamut_Total");
            entity.Property(e => e.Shana).HasMaxLength(1);
            entity.Property(e => e.TeurMadad)
                .HasMaxLength(50)
                .HasColumnName("Teur_Madad");
            entity.Property(e => e.Ticker)
                .HasMaxLength(50)
                .HasColumnName("ticker");
            entity.Property(e => e.Year)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<VFoBakaratManpik>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_FO_Bakarat_Manpik");

            entity.Property(e => e.ChasifaAfterTnua)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("Chasifa_After_Tnua");
            entity.Property(e => e.KodManpik).HasColumnName("Kod_Manpik");
            entity.Property(e => e.KodMutzarCategory).HasColumnName("Kod_Mutzar_Category");
            entity.Property(e => e.TeurCategory)
                .HasMaxLength(50)
                .HasColumnName("Teur_Category");
            entity.Property(e => e.TeurManpik)
                .HasMaxLength(50)
                .HasColumnName("Teur_Manpik");
            entity.Property(e => e.Ticker).HasMaxLength(50);
        });

        modelBuilder.Entity<VFoExportGilgulLeumi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_FO_Export_Gilgul_Leumi");

            entity.Property(e => e.Acct)
                .HasMaxLength(50)
                .HasColumnName("ACCT");
            entity.Property(e => e.AcctFut)
                .HasMaxLength(50)
                .HasColumnName("ACCT_FUT");
            entity.Property(e => e.Kamut).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.KodMutzar).HasColumnName("Kod_Mutzar");
            entity.Property(e => e.Mutzar).HasMaxLength(50);
            entity.Property(e => e.QttyB)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("QTTY B");
            entity.Property(e => e.QttyS)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("QTTY S");
            entity.Property(e => e.Ticker).HasMaxLength(50);
            entity.Property(e => e.TickerAfter)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Ticker_After");
        });

        modelBuilder.Entity<VFoExportGoldman>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_FO_Export_Goldman");

            entity.Property(e => e.AccountNumber)
                .HasMaxLength(50)
                .HasColumnName("Account Number");
            entity.Property(e => e.BuySell)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Buy/Sell");
            entity.Property(e => e.ClearingBroker)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("Clearing Broker");
            entity.Property(e => e.ClearingDate)
                .HasMaxLength(4000)
                .HasColumnName("Clearing Date");
            entity.Property(e => e.CommissionFlag)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("Commission Flag");
            entity.Property(e => e.ExecutionBroker)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("Execution Broker");
            entity.Property(e => e.GroupId).HasColumnName("Group ID");
            entity.Property(e => e.ProductCode)
                .HasMaxLength(4000)
                .HasColumnName("Product Code");
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SymbologyType)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Symbology Type");
            entity.Property(e => e.Ticker).HasMaxLength(50);
            entity.Property(e => e.TransactionType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Transaction Type");
            entity.Property(e => e.UniqueTradeId)
                .HasMaxLength(4000)
                .HasColumnName("Unique Trade ID");
        });

        modelBuilder.Entity<VFoExportIshur>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_FO_Export_Ishur");

            entity.Property(e => e.ChasifaAfterTnua)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("Chasifa_After_Tnua");
            entity.Property(e => e.KamutAfterTnua)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("Kamut_After_Tnua");
            entity.Property(e => e.KodCheshbon)
                .HasMaxLength(50)
                .HasColumnName("Kod_Cheshbon");
            entity.Property(e => e.KodMachshir).HasColumnName("Kod_Machshir");
            entity.Property(e => e.Machshir).HasMaxLength(50);
            entity.Property(e => e.Mutzar).HasMaxLength(50);
            entity.Property(e => e.NechesRashi).HasColumnName("Neches_Rashi");
            entity.Property(e => e.SortCatagory).HasColumnName("Sort_Catagory");
            entity.Property(e => e.SortMutzar).HasColumnName("Sort_Mutzar");
            entity.Property(e => e.Symbol)
                .HasMaxLength(4000)
                .HasColumnName("SYMBOL");
            entity.Property(e => e.TeurCategory)
                .HasMaxLength(50)
                .HasColumnName("Teur_Category");
            entity.Property(e => e.TeurMadad)
                .HasMaxLength(50)
                .HasColumnName("Teur_Madad");
            entity.Property(e => e.Ticker).HasMaxLength(50);
        });

        modelBuilder.Entity<VFoExportIshurTnuot>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_FO_Export_Ishur_Tnuot");

            entity.Property(e => e.Chasifa).HasColumnType("numeric(38, 6)");
            entity.Property(e => e.Kamut).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.KodCheshbon)
                .HasMaxLength(50)
                .HasColumnName("Kod_Cheshbon");
            entity.Property(e => e.KodMachshir).HasColumnName("Kod_Machshir");
            entity.Property(e => e.Machshir).HasMaxLength(50);
            entity.Property(e => e.Mutzar).HasMaxLength(50);
            entity.Property(e => e.NechesRashi).HasColumnName("Neches_Rashi");
            entity.Property(e => e.SortCatagory).HasColumnName("Sort_Catagory");
            entity.Property(e => e.SortMutzar).HasColumnName("Sort_Mutzar");
            entity.Property(e => e.Symbol)
                .HasMaxLength(4000)
                .HasColumnName("SYMBOL");
            entity.Property(e => e.TeurCategory)
                .HasMaxLength(50)
                .HasColumnName("Teur_Category");
            entity.Property(e => e.TeurMadad)
                .HasMaxLength(50)
                .HasColumnName("Teur_Madad");
            entity.Property(e => e.Ticker).HasMaxLength(50);
        });

        modelBuilder.Entity<VFoExportLeumi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_FO_Export_Leumi");

            entity.Property(e => e.Acct)
                .HasMaxLength(50)
                .HasColumnName("ACCT");
            entity.Property(e => e.AcctFut)
                .HasMaxLength(50)
                .HasColumnName("ACCT_FUT");
            entity.Property(e => e.Branch).HasColumnName("BRANCH");
            entity.Property(e => e.ErechNakuv)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Erech_Nakuv");
            entity.Property(e => e.NechesRashi).HasColumnName("Neches_Rashi");
            entity.Property(e => e.Symbol)
                .HasMaxLength(50)
                .HasColumnName("SYMBOL");
            entity.Property(e => e.Ticker).HasMaxLength(50);
        });

        modelBuilder.Entity<VFoExportMerakez>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_FO_Export_Merakez");

            entity.Property(e => e.ErechNakuv)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Erech_Nakuv");
            entity.Property(e => e.KodMutzar).HasColumnName("Kod_Mutzar");
            entity.Property(e => e.Ticker).HasMaxLength(4000);
        });

        modelBuilder.Entity<VFoHishuvim>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_FO_Hishuvim");

            entity.Property(e => e.Bank).HasMaxLength(100);
            entity.Property(e => e.ChasifaAfterTnuaMumlezet)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("Chasifa_After_Tnua_Mumlezet");
            entity.Property(e => e.ChasifaFromTnuaMumlezetEtf)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("Chasifa_from_Tnua_Mumlezet_ETF");
            entity.Property(e => e.ChasifaFromTnuaMumlezetFutures)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("Chasifa_from_Tnua_Mumlezet_Futures");
            entity.Property(e => e.ChasifaSwap)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Chasifa_Swap");
            entity.Property(e => e.CounterPartyName)
                .HasMaxLength(50)
                .HasColumnName("Counter Party Name");
            entity.Property(e => e.HashlamatKamutEtf)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("Hashlamat_Kamut_Etf");
            entity.Property(e => e.HefreshYaadChasifa)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("Hefresh_Yaad_Chasifa");
            entity.Property(e => e.IdCheshbon).HasColumnName("ID_Cheshbon");
            entity.Property(e => e.IdMadad).HasColumnName("ID_Madad");
            entity.Property(e => e.KamutMumlezetFutures)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Kamut_Mumlezet_Futures");
            entity.Property(e => e.KamutYaad)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("Kamut_Yaad");
            entity.Property(e => e.KodBank).HasColumnName("Kod_Bank");
            entity.Property(e => e.KodCheshbon)
                .HasMaxLength(50)
                .HasColumnName("Kod_Cheshbon");
            entity.Property(e => e.KodMachshir).HasColumnName("Kod_Machshir");
            entity.Property(e => e.KodManpik).HasColumnName("Kod_Manpik");
            entity.Property(e => e.KodMatbea).HasColumnName("Kod_Matbea");
            entity.Property(e => e.KodMutzar).HasColumnName("Kod_Mutzar");
            entity.Property(e => e.KodMutzarCategory).HasColumnName("Kod_Mutzar_Category");
            entity.Property(e => e.Multiplier).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Mutzar).HasMaxLength(50);
            entity.Property(e => e.Neches).HasMaxLength(250);
            entity.Property(e => e.NechesIsraeli).HasColumnName("Neches_Israeli");
            entity.Property(e => e.NechesRashi).HasColumnName("Neches_Rashi");
            entity.Property(e => e.Shaar).HasColumnType("numeric(26, 12)");
            entity.Property(e => e.ShaarMatbea)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("Shaar_Matbea");
            entity.Property(e => e.ShaarNb)
                .HasColumnType("numeric(26, 12)")
                .HasColumnName("ShaarNB");
            entity.Property(e => e.ShaarNbYadani)
                .HasColumnType("numeric(26, 12)")
                .HasColumnName("ShaarNB_Yadani");
            entity.Property(e => e.ShoviKupa).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.SortCatagory).HasColumnName("Sort_Catagory");
            entity.Property(e => e.SortMutzar).HasColumnName("Sort_Mutzar");
            entity.Property(e => e.TeurCategory)
                .HasMaxLength(50)
                .HasColumnName("Teur_Category");
            entity.Property(e => e.TeurMadad)
                .HasMaxLength(50)
                .HasColumnName("Teur_Madad");
            entity.Property(e => e.TeurManpik)
                .HasMaxLength(50)
                .HasColumnName("Teur_Manpik");
            entity.Property(e => e.Ticker).HasMaxLength(50);
            entity.Property(e => e.YaadChasifa)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("Yaad_Chasifa");
            entity.Property(e => e.YitratPaar)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("Yitrat_Paar");
            entity.Property(e => e.YtrAchuzChasifa)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("YTR_Achuz_Chasifa");
            entity.Property(e => e.YtrAchuzChasifaEtf)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("YTR_Achuz_Chasifa_Etf");
            entity.Property(e => e.YtrAchuzChasifaEtfSal)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("YTR_Achuz_Chasifa_Etf_Sal");
            entity.Property(e => e.YtrAchuzChasifaFutures)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("YTR_Achuz_Chasifa_Futures");
            entity.Property(e => e.YtrAchuzChasifaFuturesSal)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("YTR_Achuz_Chasifa_Futures_Sal");
            entity.Property(e => e.YtrKamut)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("YTR_Kamut");
            entity.Property(e => e.YtrKamutEtf)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("YTR_Kamut_Etf");
            entity.Property(e => e.YtrKamutEtfSal)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("YTR_Kamut_Etf_Sal");
            entity.Property(e => e.YtrKamutFutures)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("YTR_Kamut_Futures");
            entity.Property(e => e.YtrKamutFuturesSal)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("YTR_Kamut_Futures_Sal");
        });

        modelBuilder.Entity<VFoNechasim>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_FO_Nechasim");

            entity.Property(e => e.CalcTransFlg).HasColumnName("Calc_Trans_Flg");
            entity.Property(e => e.KodMachshir).HasColumnName("Kod_Machshir");
            entity.Property(e => e.KodMatbea).HasColumnName("Kod_Matbea");
            entity.Property(e => e.KodNechesBasis)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches_Basis");
            entity.Property(e => e.Multiplier).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Neches).HasMaxLength(250);
            entity.Property(e => e.NechesIsraeli).HasColumnName("Neches_Israeli");
            entity.Property(e => e.NechesRashi).HasColumnName("Neches_Rashi");
            entity.Property(e => e.Shaar).HasColumnType("decimal(38, 6)");
            entity.Property(e => e.ShaarNbYadani)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("ShaarNB_Yadani");
            entity.Property(e => e.Sufix).HasMaxLength(50);
            entity.Property(e => e.TeurMadad)
                .HasMaxLength(50)
                .HasColumnName("Teur_Madad");
            entity.Property(e => e.Ticker).HasMaxLength(50);
        });

        modelBuilder.Entity<VFoSheariMatbea>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_FO_Sheari_Matbea");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.KodMatbea)
                .HasMaxLength(3)
                .IsFixedLength()
                .HasColumnName("Kod_Matbea");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.Matbea).HasMaxLength(50);
            entity.Property(e => e.Shaar).HasColumnType("decimal(38, 6)");
            entity.Property(e => e.ShaarKovea)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("Shaar_Kovea");
            entity.Property(e => e.ShaarNbYadani)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("ShaarNB_Yadani");
        });

        modelBuilder.Entity<VFoShearim>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_FO_Shearim");

            entity.Property(e => e.Date).HasColumnType("date");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("kod_neches");
            entity.Property(e => e.Shaar).HasColumnType("decimal(38, 6)");
            entity.Property(e => e.Source).HasMaxLength(50);
            entity.Property(e => e.Ticker).HasMaxLength(50);
        });

        modelBuilder.Entity<VFoTichnunPeilut>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_FO_TichnunPeilut");

            entity.Property(e => e.AchuzHasifaRazoiEtf)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Achuz_Hasifa_Razoi_Etf");
            entity.Property(e => e.AchuzHasifaRazoiFutures)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Achuz_Hasifa_Razoi_Futures");
            entity.Property(e => e.Bank).HasMaxLength(100);
            entity.Property(e => e.ChasifaAfterTnua)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("Chasifa_After_Tnua");
            entity.Property(e => e.ChasifaAfterTnuaMumlezet)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("Chasifa_After_Tnua_Mumlezet");
            entity.Property(e => e.ChasifaFromTnuaMumlezetEtf)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("Chasifa_from_Tnua_Mumlezet_ETF");
            entity.Property(e => e.ChasifaFromTnuaMumlezetFutures)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("Chasifa_from_Tnua_Mumlezet_Futures");
            entity.Property(e => e.ChasifaSwap)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Chasifa_Swap");
            entity.Property(e => e.ChasifaUnitEtf)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("Chasifa_Unit_Etf");
            entity.Property(e => e.ChasifaUnitFutures)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("Chasifa_Unit_Futures");
            entity.Property(e => e.CounterPartyName)
                .HasMaxLength(50)
                .HasColumnName("Counter Party Name");
            entity.Property(e => e.HashlamatKamutEtf)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("Hashlamat_Kamut_Etf");
            entity.Property(e => e.HefreshYaadAfterTnua)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("Hefresh_Yaad_After_Tnua");
            entity.Property(e => e.HefreshYaadChasifa)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("Hefresh_Yaad_Chasifa");
            entity.Property(e => e.IdCheshbon).HasColumnName("ID_Cheshbon");
            entity.Property(e => e.IdMadad).HasColumnName("ID_Madad");
            entity.Property(e => e.Kamut).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.KamutAfterTnua)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("Kamut_After_Tnua");
            entity.Property(e => e.KamutMumlezetFutures)
                .HasColumnType("numeric(38, 2)")
                .HasColumnName("Kamut_Mumlezet_Futures");
            entity.Property(e => e.KamutYaad)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("Kamut_Yaad");
            entity.Property(e => e.KodBank).HasColumnName("Kod_Bank");
            entity.Property(e => e.KodCheshbon)
                .HasMaxLength(50)
                .HasColumnName("Kod_Cheshbon");
            entity.Property(e => e.KodMachshir).HasColumnName("Kod_Machshir");
            entity.Property(e => e.KodManpik).HasColumnName("Kod_Manpik");
            entity.Property(e => e.KodMatbea).HasColumnName("Kod_Matbea");
            entity.Property(e => e.KodMutzar).HasColumnName("Kod_Mutzar");
            entity.Property(e => e.KodMutzarCategory).HasColumnName("Kod_Mutzar_Category");
            entity.Property(e => e.Multiplier).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Mutzar).HasMaxLength(50);
            entity.Property(e => e.Neches).HasMaxLength(250);
            entity.Property(e => e.NechesIsraeli).HasColumnName("Neches_Israeli");
            entity.Property(e => e.NechesRashi).HasColumnName("Neches_Rashi");
            entity.Property(e => e.Shaar).HasColumnType("numeric(26, 12)");
            entity.Property(e => e.ShaarMatbea)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("Shaar_Matbea");
            entity.Property(e => e.ShoviKupa).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.SortCatagory).HasColumnName("Sort_Catagory");
            entity.Property(e => e.SortMutzar).HasColumnName("Sort_Mutzar");
            entity.Property(e => e.Taarich).HasColumnType("date");
            entity.Property(e => e.TeurCategory)
                .HasMaxLength(50)
                .HasColumnName("Teur_Category");
            entity.Property(e => e.TeurMadad)
                .HasMaxLength(50)
                .HasColumnName("Teur_Madad");
            entity.Property(e => e.TeurManpik)
                .HasMaxLength(50)
                .HasColumnName("Teur_Manpik");
            entity.Property(e => e.Ticker).HasMaxLength(50);
            entity.Property(e => e.TnuotChasifaEtf)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("Tnuot_Chasifa_Etf");
            entity.Property(e => e.TnuotChasifaFutures)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("Tnuot_Chasifa_Futures");
            entity.Property(e => e.TnuotKamutEtf)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("Tnuot_Kamut_Etf");
            entity.Property(e => e.TnuotKamutFutures)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("Tnuot_Kamut_Futures");
            entity.Property(e => e.YaadChasifa)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("Yaad_Chasifa");
            entity.Property(e => e.YitratPaar)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("Yitrat_Paar");
            entity.Property(e => e.YtrAchuzChasifa)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("YTR_Achuz_Chasifa");
            entity.Property(e => e.YtrAchuzChasifaEtf)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("YTR_Achuz_Chasifa_Etf");
            entity.Property(e => e.YtrAchuzChasifaEtfSal)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("YTR_Achuz_Chasifa_Etf_Sal");
            entity.Property(e => e.YtrAchuzChasifaFutures)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("YTR_Achuz_Chasifa_Futures");
            entity.Property(e => e.YtrAchuzChasifaFuturesSal)
                .HasColumnType("numeric(38, 6)")
                .HasColumnName("YTR_Achuz_Chasifa_Futures_Sal");
            entity.Property(e => e.YtrKamut)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("YTR_Kamut");
            entity.Property(e => e.YtrKamutEtf)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("YTR_Kamut_Etf");
            entity.Property(e => e.YtrKamutEtfSal)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("YTR_Kamut_Etf_Sal");
            entity.Property(e => e.YtrKamutFutures)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("YTR_Kamut_Futures");
            entity.Property(e => e.YtrKamutFuturesSal)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("YTR_Kamut_Futures_Sal");
        });

        modelBuilder.Entity<VFoYaadim>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_FO_Yaadim");

            entity.Property(e => e.IdMadad).HasColumnName("ID_Madad");
            entity.Property(e => e.KodMutzar).HasColumnName("Kod_Mutzar");
            entity.Property(e => e.KodMutzarCategory).HasColumnName("Kod_Mutzar_Category");
            entity.Property(e => e.TeurCategory)
                .HasMaxLength(50)
                .HasColumnName("Teur_Category");
            entity.Property(e => e.YaadChasifa)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("Yaad_Chasifa");
            entity.Property(e => e.YaadChasifaCatagory)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("Yaad_Chasifa_Catagory");
            entity.Property(e => e.YaadChasifaMutzar)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("Yaad_Chasifa_Mutzar");
        });

        modelBuilder.Entity<VFoYitrotSnir>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_FO_Yitrot_Snir");

            entity.Property(e => e.AchuzChasifa)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Achuz_Chasifa");
            entity.Property(e => e.Afik).HasMaxLength(50);
            entity.Property(e => e.Chasifa).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Kamut).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.KodBank)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("Kod_Bank");
            entity.Property(e => e.KodCheshbon)
                .HasMaxLength(50)
                .HasColumnName("Kod_Cheshbon");
            entity.Property(e => e.KodMachshir).HasColumnName("Kod_Machshir");
            entity.Property(e => e.KodMutzar).HasColumnName("Kod_Mutzar");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.KodNechesBasis)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches_Basis");
            entity.Property(e => e.KodNechesHamara)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches_Hamara");
            entity.Property(e => e.KodSugMutzar).HasColumnName("Kod_Sug_Mutzar");
            entity.Property(e => e.Multiplier).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Mutzar).HasMaxLength(50);
            entity.Property(e => e.Neches).HasMaxLength(1000);
            entity.Property(e => e.Shaar).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Shovi).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ShoviKupa).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.Snif)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.SugYitraSal).HasColumnName("Sug_Yitra_Sal");
            entity.Property(e => e.Taarich).HasColumnType("date");
            entity.Property(e => e.TeurTatAfik)
                .HasMaxLength(50)
                .HasColumnName("Teur_Tat_Afik");
            entity.Property(e => e.Ticker).HasMaxLength(50);
        });

        modelBuilder.Entity<VHgdrManpikFromTmp>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Hgdr_Manpik_From_Tmp");

            entity.Property(e => e.Hp)
                .HasMaxLength(50)
                .HasColumnName("HP");
            entity.Property(e => e.Id).HasColumnName("ID");
        });

        modelBuilder.Entity<VHgdrNechesFromTmp>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Hgdr_Neches_From_Tmp");

            entity.Property(e => e.Derug).HasMaxLength(50);
            entity.Property(e => e.Isin)
                .HasMaxLength(50)
                .HasColumnName("ISIN");
            entity.Property(e => e.KodAnaf).HasColumnName("Kod_Anaf");
            entity.Property(e => e.KodBasisHatzmada)
                .HasMaxLength(50)
                .HasColumnName("Kod_BasisHatzmada");
            entity.Property(e => e.KodBasisHatzmadaNegative)
                .HasMaxLength(100)
                .HasColumnName("Kod_BasisHatzmada_Negative");
            entity.Property(e => e.KodHieTatAfik1).HasColumnName("Kod_Hie_TatAfik1");
            entity.Property(e => e.KodMachshir).HasColumnName("Kod_Machshir");
            entity.Property(e => e.KodMachshirNb).HasColumnName("Kod_Machshir_NB");
            entity.Property(e => e.KodManpik).HasColumnName("Kod_Manpik");
            entity.Property(e => e.KodMatbea).HasColumnName("Kod_Matbea");
            entity.Property(e => e.KodMedinaManpika).HasColumnName("Kod_Medina_Manpika");
            entity.Property(e => e.KodMedinaNischeret).HasColumnName("Kod_Medina_Nischeret");
            entity.Property(e => e.KodMedinatChasifa).HasColumnName("Kod_Medinat_Chasifa");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.KodNechesBasis)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches_Basis");
            entity.Property(e => e.KodSchirut).HasColumnName("Kod_Schirut");
            entity.Property(e => e.KodTatAfik).HasColumnName("Kod_TatAfik");
            entity.Property(e => e.Multiplier).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Strike).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Ticker).HasMaxLength(50);
        });

        modelBuilder.Entity<VHgdrTatAfikFromTmp>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Hgdr_TatAfik_From_Tmp");

            entity.Property(e => e.HieTatAfikId).HasColumnName("Hie_TatAfik_ID");
            entity.Property(e => e.KodAfik).HasColumnName("Kod_Afik");
            entity.Property(e => e.KodTatAfik).HasColumnName("Kod_Tat_Afik");
            entity.Property(e => e.TeurAfik)
                .HasMaxLength(50)
                .HasColumnName("Teur_Afik");
            entity.Property(e => e.TeurTatAfik)
                .HasMaxLength(50)
                .HasColumnName("Teur_TatAfik");
        });

        modelBuilder.Entity<VHmrtCheshbon>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Hmrt_Cheshbon");

            entity.Property(e => e.Id).HasColumnName("ID");
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
            entity.Property(e => e.KodKvutzatTikim).HasColumnName("Kod_Kvutzat_Tikim");
            entity.Property(e => e.KodMetafel).HasColumnName("Kod_Metafel");
            entity.Property(e => e.KodMutzar).HasColumnName("Kod_Mutzar");
            entity.Property(e => e.KodOtzar).HasColumnName("Kod_Otzar");
            entity.Property(e => e.Metafel).HasMaxLength(50);
            entity.Property(e => e.MisparTik)
                .HasMaxLength(50)
                .HasColumnName("Mispar_Tik");
            entity.Property(e => e.TeurCheshbon)
                .HasMaxLength(100)
                .HasColumnName("Teur_Cheshbon");
        });

        modelBuilder.Entity<VHmrtNech>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Hmrt_Neches");

            entity.Property(e => e.KodMetafel).HasColumnName("Kod_Metafel");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.KodNechesMetafel)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches_Metafel");
            entity.Property(e => e.Metafel).HasMaxLength(50);
            entity.Property(e => e.Neches).HasMaxLength(250);
        });

        modelBuilder.Entity<VLoadLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Load_Log");

            entity.Property(e => e.AppDescription)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.ErrorCode)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.ErrorDescription)
                .HasMaxLength(1000)
                .IsUnicode(false);
            entity.Property(e => e.EventDateTime).HasColumnType("datetime");
            entity.Property(e => e.EventType)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LogId)
                .ValueGeneratedOnAdd()
                .HasColumnName("LogID");
            entity.Property(e => e.PackageName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.SourceName)
                .HasMaxLength(150)
                .IsUnicode(false);
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VMrktDataDanelMadad>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Mrkt_Data_Danel_Madad");

            entity.Property(e => e.DanelDate).HasColumnType("date");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.Neches).HasMaxLength(250);
            entity.Property(e => e.OfficialClosePrice)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("Official_Close_Price");
            entity.Property(e => e.Price).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Ric)
                .HasMaxLength(50)
                .HasColumnName("RIC");
            entity.Property(e => e.TradeDate)
                .HasColumnType("date")
                .HasColumnName("Trade_Date");
        });

        modelBuilder.Entity<VMrktDataDanelMatach>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Mrkt_Data_Danel_Matach");

            entity.Property(e => e.DanelDate).HasColumnType("date");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.Matbea).HasMaxLength(50);
            entity.Property(e => e.OfficialClosePrice)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("Official_Close_Price");
            entity.Property(e => e.Price).HasColumnType("decimal(38, 6)");
            entity.Property(e => e.Ric)
                .HasMaxLength(50)
                .HasColumnName("RIC");
            entity.Property(e => e.TradeDate)
                .HasColumnType("date")
                .HasColumnName("Trade_Date");
            entity.Property(e => e.UnderlyingRic)
                .HasMaxLength(50)
                .HasColumnName("UnderlyingRIC");
            entity.Property(e => e.Undl)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("_Undl");
        });

        modelBuilder.Entity<VMrktDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Mrkt_Data");

            entity.Property(e => e.Ask).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Bid).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Isin)
                .HasMaxLength(50)
                .HasColumnName("ISIN");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.OfficialClosePrice)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("Official_Close_Price");
            entity.Property(e => e.Ric)
                .HasMaxLength(50)
                .HasColumnName("RIC");
            entity.Property(e => e.SecurityId)
                .HasMaxLength(50)
                .HasColumnName("Security_ID");
            entity.Property(e => e.Taarich).HasColumnType("date");
            entity.Property(e => e.Ticker).HasMaxLength(50);
            entity.Property(e => e.TradeDate)
                .HasColumnType("date")
                .HasColumnName("Trade_Date");
            entity.Property(e => e.UrrencyCode)
                .HasMaxLength(50)
                .HasColumnName("urrency_Code");
        });

        modelBuilder.Entity<VMutzarCheshbon>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Mutzar_Cheshbon");

            entity.Property(e => e.Id).HasColumnName("ID");
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
            entity.Property(e => e.NameForTri)
                .HasMaxLength(100)
                .HasColumnName("Name_For_Tri");
        });

        modelBuilder.Entity<VMvTk>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_MvTk");

            entity.Property(e => e.AchuzMenayutMediniut)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("Achuz_Menayut_Mediniut");
            entity.Property(e => e.Afik).HasMaxLength(50);
            entity.Property(e => e.BasisHatzmadaMigbala)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("Basis_Hatzmada_Migbala");
            entity.Property(e => e.Chasifa).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.ChasifaHov)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("Chasifa_Hov");
            entity.Property(e => e.ChasifaMatbeaPiruk)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("Chasifa_Matbea_Piruk");
            entity.Property(e => e.ChasifaPiruk)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("Chasifa_Piruk");
            entity.Property(e => e.Derug).HasMaxLength(50);
            entity.Property(e => e.DmeiNihul)
                .HasColumnType("decimal(31, 12)")
                .HasColumnName("Dmei_Nihul");
            entity.Property(e => e.HieTatAfikTeur1)
                .HasMaxLength(50)
                .HasColumnName("Hie_TatAfik_Teur_1");
            entity.Property(e => e.HieTatAfikTeur2)
                .HasMaxLength(50)
                .HasColumnName("Hie_TatAfik_Teur_2");
            entity.Property(e => e.HieTatAfikTeur3)
                .HasMaxLength(50)
                .HasColumnName("Hie_TatAfik_Teur_3");
            entity.Property(e => e.HieTatAfikTeur4)
                .HasMaxLength(50)
                .HasColumnName("Hie_TatAfik_Teur_4");
            entity.Property(e => e.HieTatAfikTeur5)
                .HasMaxLength(50)
                .HasColumnName("Hie_TatAfik_Teur_5");
            entity.Property(e => e.HulChasifaMigbala)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasColumnName("Hul_Chasifa_Migbala");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.IsKerenMigbala)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("Is_Keren_Migbala");
            entity.Property(e => e.KodMachshir).HasColumnName("Kod_Machshir");
            entity.Property(e => e.KodNeches).HasColumnName("Kod_Neches");
            entity.Property(e => e.KodNechesKeren)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches_Keren");
            entity.Property(e => e.KodNechesKuvea)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches_Kuvea");
            entity.Property(e => e.KodTatAfik).HasColumnName("Kod_TatAfik");
            entity.Property(e => e.KodTikModel).HasColumnName("Kod_Tik_Model");
            entity.Property(e => e.KvutzatDerugMigbala)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("Kvutzat_Derug_Migbala");
            entity.Property(e => e.Macham).HasColumnType("decimal(38, 6)");
            entity.Property(e => e.MachshirMigbala)
                .HasMaxLength(55)
                .HasColumnName("Machshir_Migbala");
            entity.Property(e => e.MachshirNb)
                .HasMaxLength(50)
                .HasColumnName("Machshir_NB");
            entity.Property(e => e.Matbea).HasMaxLength(50);
            entity.Property(e => e.MatbeaMakor)
                .HasMaxLength(50)
                .HasColumnName("Matbea_Makor");
            entity.Property(e => e.MedinaNischeret)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Medina_Nischeret");
            entity.Property(e => e.MedinaNischeretMigbala)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Medina_Nischeret_Migbala");
            entity.Property(e => e.MedinatChasifaMigbala)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Medinat_Chasifa_Migbala");
            entity.Property(e => e.MenyautSikunMigbala)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Menyaut_Sikun_Migbala");
            entity.Property(e => e.Mishkal).HasColumnType("decimal(12, 6)");
            entity.Property(e => e.MishkalMakor)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("Mishkal_Makor");
            entity.Property(e => e.Neches).HasMaxLength(250);
            entity.Property(e => e.NechesMakor)
                .HasMaxLength(250)
                .HasColumnName("Neches_Makor");
            entity.Property(e => e.NoDerugMigbala)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("No_Derug_Migbala");
            entity.Property(e => e.ShoviKeren)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("Shovi_Keren");
            entity.Property(e => e.SugYitra).HasColumnName("Sug_Yitra");
            entity.Property(e => e.TatAfikRama2)
                .HasMaxLength(50)
                .HasColumnName("Tat_Afik_Rama_2");
            entity.Property(e => e.TeurAnaf)
                .HasMaxLength(50)
                .HasColumnName("Teur_Anaf");
            entity.Property(e => e.TeurSugModel)
                .HasMaxLength(50)
                .HasColumnName("Teur_Sug_Model");
            entity.Property(e => e.TeurTatAfik)
                .HasMaxLength(50)
                .HasColumnName("Teur_Tat_Afik");
            entity.Property(e => e.TeurTatAfikMakor)
                .HasMaxLength(50)
                .HasColumnName("Teur_Tat_Afik_Makor");
            entity.Property(e => e.TeurTikModel)
                .HasMaxLength(50)
                .HasColumnName("Teur_Tik_Model");
        });

        modelBuilder.Entity<VMvTkDmeiNihul>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_MvTk_Dmei_Nihul");

            entity.Property(e => e.Afik).HasMaxLength(50);
            entity.Property(e => e.BasisHatzmadaMigbala)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("Basis_Hatzmada_Migbala");
            entity.Property(e => e.DmeiNihul)
                .HasColumnType("decimal(31, 12)")
                .HasColumnName("Dmei_Nihul");
            entity.Property(e => e.HieTatAfikTeur1)
                .HasMaxLength(50)
                .HasColumnName("Hie_TatAfik_Teur_1");
            entity.Property(e => e.HieTatAfikTeur2)
                .HasMaxLength(50)
                .HasColumnName("Hie_TatAfik_Teur_2");
            entity.Property(e => e.HieTatAfikTeur3)
                .HasMaxLength(50)
                .HasColumnName("Hie_TatAfik_Teur_3");
            entity.Property(e => e.HieTatAfikTeur4)
                .HasMaxLength(50)
                .HasColumnName("Hie_TatAfik_Teur_4");
            entity.Property(e => e.HieTatAfikTeur5)
                .HasMaxLength(50)
                .HasColumnName("Hie_TatAfik_Teur_5");
            entity.Property(e => e.HulChasifaMigbala)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasColumnName("Hul_Chasifa_Migbala");
            entity.Property(e => e.IsKerenMigbala)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("Is_Keren_Migbala");
            entity.Property(e => e.KodMachshir).HasColumnName("Kod_Machshir");
            entity.Property(e => e.KodManpik).HasColumnName("Kod_Manpik");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.KodSugMishkal).HasColumnName("Kod_Sug_Mishkal");
            entity.Property(e => e.KodSugModel).HasColumnName("Kod_Sug_Model");
            entity.Property(e => e.KodTatAfik).HasColumnName("Kod_TatAfik");
            entity.Property(e => e.KodTikModel).HasColumnName("Kod_Tik_Model");
            entity.Property(e => e.KvutzatDerugMigbala)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("Kvutzat_Derug_Migbala");
            entity.Property(e => e.Macham).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.MachshirMigbala)
                .HasMaxLength(55)
                .HasColumnName("Machshir_Migbala");
            entity.Property(e => e.MachshirNb)
                .HasMaxLength(50)
                .HasColumnName("Machshir_NB");
            entity.Property(e => e.Matbea).HasMaxLength(50);
            entity.Property(e => e.MedinaNischeretMigbala)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Medina_Nischeret_Migbala");
            entity.Property(e => e.MedinatChasifaMigbala)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Medinat_Chasifa_Migbala");
            entity.Property(e => e.MenyautSikunMigbala)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Menyaut_Sikun_Migbala");
            entity.Property(e => e.Mishkal).HasColumnType("decimal(38, 6)");
            entity.Property(e => e.MishkalEquity)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("Mishkal_Equity");
            entity.Property(e => e.MishkalHov)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("Mishkal_Hov");
            entity.Property(e => e.Neches).HasMaxLength(250);
            entity.Property(e => e.NoDerugMigbala)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("No_Derug_Migbala");
            entity.Property(e => e.Remark).HasMaxLength(50);
            entity.Property(e => e.TatAfikRama2)
                .HasMaxLength(50)
                .HasColumnName("Tat_Afik_Rama_2");
            entity.Property(e => e.TeurSugModel)
                .HasMaxLength(50)
                .HasColumnName("Teur_Sug_Model");
            entity.Property(e => e.TeurTatAfik)
                .HasMaxLength(50)
                .HasColumnName("Teur_Tat_Afik");
            entity.Property(e => e.TeurTikModel)
                .HasMaxLength(50)
                .HasColumnName("Teur_Tik_Model");
            entity.Property(e => e.TrumaLeMacham)
                .HasColumnType("decimal(31, 12)")
                .HasColumnName("Truma_Le_Macham");
        });

        modelBuilder.Entity<VMvTkDwh>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_MvTk_DWH");

            entity.Property(e => e.Afik).HasMaxLength(50);
            entity.Property(e => e.KodAfik).HasColumnName("Kod_Afik");
            entity.Property(e => e.KodKvutza).HasColumnName("Kod_Kvutza");
            entity.Property(e => e.KodMediniyut).HasColumnName("Kod_Mediniyut");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.KodSugModel).HasColumnName("Kod_Sug_Model");
            entity.Property(e => e.KodTikModel).HasColumnName("Kod_Tik_Model");
            entity.Property(e => e.Macham).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Mishkal).HasColumnType("decimal(38, 6)");
            entity.Property(e => e.Neches).HasMaxLength(250);
            entity.Property(e => e.TeurTatAfik)
                .HasMaxLength(50)
                .HasColumnName("Teur_Tat_Afik");
            entity.Property(e => e.TeurTikModel)
                .HasMaxLength(50)
                .HasColumnName("Teur_Tik_Model");
        });

        modelBuilder.Entity<VMvTkHolding>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_MvTk_Holdings");

            entity.Property(e => e.DmeiNihul)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("Dmei_Nihul");
            entity.Property(e => e.KodMedinaNischeret).HasColumnName("Kod_Medina_Nischeret");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.KodSugMishkal).HasColumnName("Kod_Sug_Mishkal");
            entity.Property(e => e.KodSugModel).HasColumnName("Kod_Sug_Model");
            entity.Property(e => e.KodTatAfik).HasColumnName("Kod_TatAfik");
            entity.Property(e => e.Macham).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Mishkal).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.Neches).HasMaxLength(250);
            entity.Property(e => e.Remark).HasMaxLength(50);
            entity.Property(e => e.TatAfik).HasMaxLength(50);
            entity.Property(e => e.TeurSugMishkal)
                .HasMaxLength(50)
                .HasColumnName("Teur_Sug_Mishkal");
            entity.Property(e => e.TeurSugModel)
                .HasMaxLength(50)
                .HasColumnName("Teur_Sug_Model");
        });

        modelBuilder.Entity<VMvTkHoldingsLvl1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_MvTk_Holdings_Lvl_1");

            entity.Property(e => e.DmeiNihul)
                .HasColumnType("decimal(38, 10)")
                .HasColumnName("Dmei_Nihul");
            entity.Property(e => e.KodSugMishkal).HasColumnName("Kod_Sug_Mishkal");
            entity.Property(e => e.KodSugModel).HasColumnName("Kod_Sug_Model");
            entity.Property(e => e.Macham).HasColumnType("decimal(38, 10)");
            entity.Property(e => e.MenayutHol).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.Mishkal).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.Osh).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.TeurSugMishkal)
                .HasMaxLength(50)
                .HasColumnName("Teur_Sug_Mishkal");
            entity.Property(e => e.TeurSugModel)
                .HasMaxLength(50)
                .HasColumnName("Teur_Sug_Model");
        });

        modelBuilder.Entity<VMvTkHoldingsLvl2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_MvTk_Holdings_Lvl_2");

            entity.Property(e => e.DmeiNihul)
                .HasColumnType("decimal(38, 10)")
                .HasColumnName("Dmei_Nihul");
            entity.Property(e => e.KodSugMishkal).HasColumnName("Kod_Sug_Mishkal");
            entity.Property(e => e.KodSugModel).HasColumnName("Kod_Sug_Model");
            entity.Property(e => e.KodTatAfik).HasColumnName("Kod_TatAfik");
            entity.Property(e => e.Macham).HasColumnType("decimal(38, 6)");
            entity.Property(e => e.Mishkal).HasColumnType("decimal(38, 4)");
            entity.Property(e => e.TatAfik).HasMaxLength(50);
            entity.Property(e => e.TeurSugMishkal)
                .HasMaxLength(50)
                .HasColumnName("Teur_Sug_Mishkal");
            entity.Property(e => e.TeurSugModel)
                .HasMaxLength(50)
                .HasColumnName("Teur_Sug_Model");
        });

        modelBuilder.Entity<VMvTkMatach>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_MvTk_Matach");

            entity.Property(e => e.Afik).HasMaxLength(50);
            entity.Property(e => e.BasisHatzmadaMigbala)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("Basis_Hatzmada_Migbala");
            entity.Property(e => e.Chasifa).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ChasifaPiruk)
                .HasColumnType("decimal(38, 13)")
                .HasColumnName("Chasifa_Piruk");
            entity.Property(e => e.HulChasifaMigbala)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasColumnName("Hul_Chasifa_Migbala");
            entity.Property(e => e.IsKerenMigbala)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("Is_Keren_Migbala");
            entity.Property(e => e.KodMachshir).HasColumnName("Kod_Machshir");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.KodNechesKeren)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches_Keren");
            entity.Property(e => e.KodNechesKuvea)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches_Kuvea");
            entity.Property(e => e.KodTatAfik).HasColumnName("Kod_TatAfik");
            entity.Property(e => e.KodTikModel).HasColumnName("Kod_Tik_Model");
            entity.Property(e => e.KvutzatDerugMigbala)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("Kvutzat_Derug_Migbala");
            entity.Property(e => e.MachshirMigbala)
                .HasMaxLength(55)
                .HasColumnName("Machshir_Migbala");
            entity.Property(e => e.Matbea).HasMaxLength(50);
            entity.Property(e => e.MatbeaMakor)
                .HasMaxLength(50)
                .HasColumnName("Matbea_Makor");
            entity.Property(e => e.MatbeaRama2)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("Matbea_Rama_2");
            entity.Property(e => e.MedinaNischeretMigbala)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Medina_Nischeret_Migbala");
            entity.Property(e => e.MedinatChasifaMigbala)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Medinat_Chasifa_Migbala");
            entity.Property(e => e.MenyautSikunMigbala)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Menyaut_Sikun_Migbala");
            entity.Property(e => e.Mishkal).HasColumnType("decimal(12, 6)");
            entity.Property(e => e.MishkalMakor)
                .HasColumnType("decimal(5, 4)")
                .HasColumnName("Mishkal_Makor");
            entity.Property(e => e.Neches).HasMaxLength(250);
            entity.Property(e => e.NechesMakor)
                .HasMaxLength(250)
                .HasColumnName("Neches_Makor");
            entity.Property(e => e.NoDerugMigbala)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("No_Derug_Migbala");
            entity.Property(e => e.ShoviKeren)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("Shovi_Keren");
            entity.Property(e => e.TatAfikRama2)
                .HasMaxLength(50)
                .HasColumnName("Tat_Afik_Rama_2");
            entity.Property(e => e.TeurSugModel)
                .HasMaxLength(50)
                .HasColumnName("Teur_Sug_Model");
            entity.Property(e => e.TeurTatAfik)
                .HasMaxLength(50)
                .HasColumnName("Teur_Tat_Afik");
            entity.Property(e => e.TeurTatAfikMakor)
                .HasMaxLength(50)
                .HasColumnName("Teur_Tat_Afik_Makor");
            entity.Property(e => e.TeurTikModel)
                .HasMaxLength(50)
                .HasColumnName("Teur_Tik_Model");
        });

        modelBuilder.Entity<VMvTkMigbalot>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_MvTk_Migbalot");

            entity.Property(e => e.AchuzBafual)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("Achuz_Bafual");
            entity.Property(e => e.AchuzMediniyut)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("Achuz_Mediniyut");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.MaxLimit)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("Max_Limit");
            entity.Property(e => e.MinLimit)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("Min_Limit");
            entity.Property(e => e.TeurBasisHatzmada)
                .HasMaxLength(50)
                .HasColumnName("Teur_Basis_Hatzmada");
            entity.Property(e => e.TeurHulChasifa)
                .HasMaxLength(50)
                .HasColumnName("Teur_Hul_Chasifa");
            entity.Property(e => e.TeurIsKeren)
                .HasMaxLength(50)
                .HasColumnName("Teur_Is_Keren");
            entity.Property(e => e.TeurKvutzatDerug)
                .HasMaxLength(50)
                .HasColumnName("Teur_Kvutzat_Derug");
            entity.Property(e => e.TeurLoMedurag)
                .HasMaxLength(50)
                .HasColumnName("Teur_Lo_Medurag");
            entity.Property(e => e.TeurMachshir)
                .HasMaxLength(50)
                .HasColumnName("Teur_Machshir");
            entity.Property(e => e.TeurMakor)
                .HasMaxLength(50)
                .HasColumnName("Teur_Makor");
            entity.Property(e => e.TeurMedinaNischeret)
                .HasMaxLength(50)
                .HasColumnName("Teur_Medina_Nischeret");
            entity.Property(e => e.TeurMedinatChasifa)
                .HasMaxLength(50)
                .HasColumnName("Teur_Medinat_Chasifa");
            entity.Property(e => e.TeurMigbala)
                .HasMaxLength(50)
                .HasColumnName("Teur_Migbala");
            entity.Property(e => e.TeurSikunMenayut)
                .HasMaxLength(50)
                .HasColumnName("Teur_Sikun_Menayut");
            entity.Property(e => e.TeurSugMechane)
                .HasMaxLength(50)
                .HasColumnName("Teur_Sug_Mechane");
            entity.Property(e => e.TeurSugModel)
                .HasMaxLength(50)
                .HasColumnName("Teur_Sug_Model");
            entity.Property(e => e.TeurTikModel)
                .HasMaxLength(50)
                .HasColumnName("Teur_Tik_Model");
        });

        modelBuilder.Entity<VMvTkMivne>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_MvTk_Mivne");

            entity.Property(e => e.Afik).HasMaxLength(50);
            entity.Property(e => e.BasisHatzmadaMigbala)
                .HasMaxLength(55)
                .HasColumnName("Basis_Hatzmada_Migbala");
            entity.Property(e => e.DmeiNihul)
                .HasColumnType("decimal(31, 12)")
                .HasColumnName("Dmei_Nihul");
            entity.Property(e => e.HieTatAfikTeur1)
                .HasMaxLength(50)
                .HasColumnName("Hie_TatAfik_Teur_1");
            entity.Property(e => e.HieTatAfikTeur2)
                .HasMaxLength(50)
                .HasColumnName("Hie_TatAfik_Teur_2");
            entity.Property(e => e.HieTatAfikTeur3)
                .HasMaxLength(50)
                .HasColumnName("Hie_TatAfik_Teur_3");
            entity.Property(e => e.HieTatAfikTeur4)
                .HasMaxLength(50)
                .HasColumnName("Hie_TatAfik_Teur_4");
            entity.Property(e => e.HieTatAfikTeur5)
                .HasMaxLength(50)
                .HasColumnName("Hie_TatAfik_Teur_5");
            entity.Property(e => e.HulChasifaMigbala)
                .HasMaxLength(23)
                .IsUnicode(false)
                .HasColumnName("Hul_Chasifa_Migbala");
            entity.Property(e => e.IsKerenMigbala)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("Is_Keren_Migbala");
            entity.Property(e => e.Isin)
                .HasMaxLength(50)
                .HasColumnName("ISIN");
            entity.Property(e => e.KodMachshir).HasColumnName("Kod_Machshir");
            entity.Property(e => e.KodManpik).HasColumnName("Kod_Manpik");
            entity.Property(e => e.KodNeches).HasColumnName("Kod_Neches");
            entity.Property(e => e.KodSugMishkal).HasColumnName("Kod_Sug_Mishkal");
            entity.Property(e => e.KodSugModel).HasColumnName("Kod_Sug_Model");
            entity.Property(e => e.KodTatAfik).HasColumnName("Kod_TatAfik");
            entity.Property(e => e.KodTikModel).HasColumnName("Kod_Tik_Model");
            entity.Property(e => e.KvutzatDerugMigbala)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("Kvutzat_Derug_Migbala");
            entity.Property(e => e.Macham).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.MachshirMigbala)
                .HasMaxLength(55)
                .HasColumnName("Machshir_Migbala");
            entity.Property(e => e.MachshirNb)
                .HasMaxLength(50)
                .HasColumnName("Machshir_NB");
            entity.Property(e => e.Matbea).HasMaxLength(50);
            entity.Property(e => e.MedinaNischeretMigbala)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Medina_Nischeret_Migbala");
            entity.Property(e => e.MedinatChasifaMigbala)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Medinat_Chasifa_Migbala");
            entity.Property(e => e.MenyautSikunMigbala)
                .HasMaxLength(20)
                .IsUnicode(false)
                .HasColumnName("Menyaut_Sikun_Migbala");
            entity.Property(e => e.Mishkal).HasColumnType("decimal(38, 6)");
            entity.Property(e => e.MishkalEquity)
                .HasColumnType("decimal(5, 2)")
                .HasColumnName("Mishkal_Equity");
            entity.Property(e => e.MishkalHov)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("Mishkal_Hov");
            entity.Property(e => e.ModelRemark)
                .HasMaxLength(250)
                .HasColumnName("Model_Remark");
            entity.Property(e => e.Neches).HasMaxLength(250);
            entity.Property(e => e.NoDerugMigbala)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("No_Derug_Migbala");
            entity.Property(e => e.Remark).HasMaxLength(50);
            entity.Property(e => e.TatAfikRama2)
                .HasMaxLength(50)
                .HasColumnName("Tat_Afik_Rama_2");
            entity.Property(e => e.TeurSugModel)
                .HasMaxLength(50)
                .HasColumnName("Teur_Sug_Model");
            entity.Property(e => e.TeurTatAfik)
                .HasMaxLength(50)
                .HasColumnName("Teur_Tat_Afik");
            entity.Property(e => e.TeurTikModel)
                .HasMaxLength(50)
                .HasColumnName("Teur_Tik_Model");
            entity.Property(e => e.TrumaLeMacham)
                .HasColumnType("decimal(31, 12)")
                .HasColumnName("Truma_Le_Macham");
        });

        modelBuilder.Entity<VMvTkNechesProperty>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_MvTk_Neches_Properties");

            entity.Property(e => e.Afik).HasMaxLength(50);
            entity.Property(e => e.DmeiNihul)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("Dmei_Nihul");
            entity.Property(e => e.KodManpik).HasColumnName("Kod_Manpik");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.Macham).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.TeurTatAfik)
                .HasMaxLength(50)
                .HasColumnName("Teur_Tat_Afik");
        });

        modelBuilder.Entity<VMvtkHistoryDiff>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Mvtk_History_DIff");

            entity.Property(e => e.Afik).HasMaxLength(50);
            entity.Property(e => e.DateTime).HasColumnType("date");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.KodSugMishkal).HasColumnName("Kod_Sug_Mishkal");
            entity.Property(e => e.KodSugModel).HasColumnName("Kod_Sug_Model");
            entity.Property(e => e.KodTikModel)
                .HasMaxLength(10)
                .HasColumnName("Kod_Tik_Model");
            entity.Property(e => e.Mishkal).HasColumnType("decimal(5, 4)");
            entity.Property(e => e.Neches).HasMaxLength(250);
            entity.Property(e => e.Remark).HasMaxLength(50);
            entity.Property(e => e.Src)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("SRC");
            entity.Property(e => e.TeurSugModel)
                .HasMaxLength(50)
                .HasColumnName("Teur_Sug_Model");
            entity.Property(e => e.TeurTatAfik)
                .HasMaxLength(50)
                .HasColumnName("Teur_Tat_Afik");
        });

        modelBuilder.Entity<VPitzul>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Pitzul");

            entity.Property(e => e.KodMutzar).HasColumnName("Kod_Mutzar");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.Mutzar).HasMaxLength(50);
            entity.Property(e => e.Neches).HasMaxLength(250);
            entity.Property(e => e.Pitzul).HasColumnType("decimal(19, 18)");
        });

        modelBuilder.Entity<VRpaMemshakShovi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_RPA_Memshak_Shovi");

            entity.Property(e => e.CheshbonRashi)
                .HasMaxLength(50)
                .HasColumnName("Cheshbon_Rashi");
            entity.Property(e => e.CheshbonType)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("Cheshbon_Type");
            entity.Property(e => e.HarigTsuaYomitFlag).HasColumnName("Harig_Tsua_Yomit_Flag");
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
            entity.Property(e => e.LastShovi)
                .HasColumnType("decimal(38, 2)")
                .HasColumnName("Last_Shovi");
            entity.Property(e => e.LastShoviDate)
                .HasColumnType("date")
                .HasColumnName("Last_Shovi_Date");
            entity.Property(e => e.MisparTik)
                .HasMaxLength(50)
                .HasColumnName("Mispar_Tik");
            entity.Property(e => e.MisparTikAltshuler)
                .HasMaxLength(50)
                .HasColumnName("Mispar_Tik_Altshuler");
            entity.Property(e => e.Mutzar).HasMaxLength(50);
            entity.Property(e => e.RafTsuaChodshit)
                .HasColumnType("decimal(3, 2)")
                .HasColumnName("Raf_Tsua_Chodshit");
            entity.Property(e => e.RafTsuaChodshitHarig)
                .HasColumnType("decimal(3, 2)")
                .HasColumnName("Raf_Tsua_Chodshit_Harig");
            entity.Property(e => e.RafTsuaYomit)
                .HasColumnType("decimal(3, 2)")
                .HasColumnName("Raf_Tsua_Yomit");
            entity.Property(e => e.TeurCategory)
                .HasMaxLength(50)
                .HasColumnName("Teur_Category");
        });

        modelBuilder.Entity<VSwapDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Swap_Details");

            entity.Property(e => e.Interest).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.InterestDate)
                .HasColumnType("date")
                .HasColumnName("Interest_Date");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.Neches).HasMaxLength(250);
            entity.Property(e => e.Spread).HasColumnType("decimal(18, 6)");
        });

        modelBuilder.Entity<VTikTsuaHarig>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Tik_Tsua_Harig");

            entity.Property(e => e.AvgTsua)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("Avg_Tsua");
            entity.Property(e => e.Bsc)
                .HasMaxLength(50)
                .HasColumnName("BSC");
            entity.Property(e => e.HarigAbs).HasColumnName("Harig_ABS");
            entity.Property(e => e.HarigAbsDes)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("Harig_ABS_Des");
            entity.Property(e => e.HarigDes)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("Harig_Des");
            entity.Property(e => e.KodKvutza).HasColumnName("Kod_Kvutza");
            entity.Property(e => e.KodMediniyot).HasColumnName("Kod_Mediniyot");
            entity.Property(e => e.Period).HasMaxLength(50);
            entity.Property(e => e.Shovi).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Taarich).HasColumnType("date");
            entity.Property(e => e.TeurKvutzatTikim)
                .HasMaxLength(50)
                .HasColumnName("Teur_kvutzat_Tikim");
            entity.Property(e => e.TeurMediniyut)
                .HasMaxLength(50)
                .HasColumnName("Teur_Mediniyut");
            entity.Property(e => e.TeurTik)
                .HasMaxLength(250)
                .HasColumnName("Teur_Tik");
            entity.Property(e => e.Tsua).HasColumnType("decimal(22, 10)");
            entity.Property(e => e.Yoez).HasMaxLength(50);
        });

        modelBuilder.Entity<VTikTsuaHarigMonthly>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Tik_Tsua_Harig_Monthly");

            entity.Property(e => e.AvgTsua)
                .HasColumnType("decimal(38, 6)")
                .HasColumnName("Avg_Tsua");
            entity.Property(e => e.Bsc)
                .HasMaxLength(50)
                .HasColumnName("BSC");
            entity.Property(e => e.HarigDes)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("Harig_Des");
            entity.Property(e => e.KodKvutza).HasColumnName("Kod_Kvutza");
            entity.Property(e => e.KodMediniyot).HasColumnName("Kod_Mediniyot");
            entity.Property(e => e.Period).HasMaxLength(50);
            entity.Property(e => e.Shovi).HasColumnType("decimal(18, 3)");
            entity.Property(e => e.Taarich).HasColumnType("date");
            entity.Property(e => e.TeurKvutzatTikim)
                .HasMaxLength(50)
                .HasColumnName("Teur_kvutzat_Tikim");
            entity.Property(e => e.TeurMediniyut)
                .HasMaxLength(50)
                .HasColumnName("Teur_Mediniyut");
            entity.Property(e => e.TeurTik)
                .HasMaxLength(250)
                .HasColumnName("Teur_Tik");
            entity.Property(e => e.Tsua).HasColumnType("decimal(22, 10)");
            entity.Property(e => e.Yoez).HasMaxLength(50);
        });

        modelBuilder.Entity<VTnuot>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Tnuot");

            entity.Property(e => e.CheshbonMaavar)
                .HasMaxLength(50)
                .HasColumnName("Cheshbon_Maavar");
            entity.Property(e => e.CheshbonMakor)
                .HasMaxLength(50)
                .HasColumnName("Cheshbon_Makor");
            entity.Property(e => e.CheshbonYaad)
                .HasMaxLength(50)
                .HasColumnName("Cheshbon_Yaad");
            entity.Property(e => e.ErechNakuv)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Erech_Nakuv");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.KodKarteset).HasColumnName("Kod_Karteset");
            entity.Property(e => e.KodMatbea).HasColumnName("Kod_Matbea");
            entity.Property(e => e.KodMutzar).HasColumnName("Kod_Mutzar");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.KodSapak).HasColumnName("Kod_Sapak");
            entity.Property(e => e.KodTnuoa).HasColumnName("Kod_Tnuoa");
            entity.Property(e => e.Matbea).HasMaxLength(50);
            entity.Property(e => e.Mutzar).HasMaxLength(50);
            entity.Property(e => e.Neches).HasMaxLength(1000);
            entity.Property(e => e.Shaar).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Shovi).HasColumnType("decimal(38, 20)");
            entity.Property(e => e.Taarich).HasColumnType("date");
        });

        modelBuilder.Entity<VTnuotBankLeumiIl>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Tnuot_Bank_Leumi_ILS");

            entity.Property(e => e.KodBasisHatzmada).HasColumnName("Kod_Basis_Hatzmada");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.KodTnuoa).HasColumnName("Kod_Tnuoa");
            entity.Property(e => e.Taarich).HasColumnType("date");
            entity.Property(e => e.אסמכתא)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.בנקזכות).HasColumnName("בנק זכות");
            entity.Property(e => e.בנקחובה).HasColumnName("בנק חובה");
            entity.Property(e => e.מספרחשבוןאומסזהבזכות)
                .HasMaxLength(50)
                .HasColumnName("מספר חשבון או מס זהב זכות");
            entity.Property(e => e.מספרחשבוןחובה)
                .HasMaxLength(50)
                .HasColumnName("מספר חשבון חובה");
            entity.Property(e => e.סוגחשבוןזכות).HasColumnName("סוג חשבון זכות");
            entity.Property(e => e.סוגחשבוןחובה).HasColumnName("סוג חשבון חובה");
            entity.Property(e => e.סכום).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.סניףזכות).HasColumnName("סניף זכות");
            entity.Property(e => e.סניףחובה).HasColumnName("סניף חובה");
            entity.Property(e => e.שםהמוטב)
                .HasMaxLength(100)
                .HasColumnName("שם המוטב");
            entity.Property(e => e.שםהמעביר)
                .HasMaxLength(100)
                .HasColumnName("שם המעביר");
            entity.Property(e => e.תאריךבפורמטDdmmyy)
                .HasMaxLength(4000)
                .HasColumnName("תאריך בפורמט ddmmyy");
        });

        modelBuilder.Entity<VTnuotBankLeumiMatach>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Tnuot_Bank_Leumi_Matach");

            entity.Property(e => e.KodBasisHatzmada).HasColumnName("Kod_Basis_Hatzmada");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.KodTnuoa).HasColumnName("Kod_Tnuoa");
            entity.Property(e => e.Taarich).HasColumnType("date");
            entity.Property(e => e.אסמכתא)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.בוצעלאבוצע)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("בוצע/לא בוצע");
            entity.Property(e => e.העברתמטחללקוחאחר)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("העברת מטח ללקוח אחר");
            entity.Property(e => e.הערותרובוט)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("הערות רובוט");
            entity.Property(e => e.התחלה)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.חשבון)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.יוםעסקים)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("יום עסקים");
            entity.Property(e => e.מהותפעולה)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("מהות פעולה");
            entity.Property(e => e.מטבעזכות)
                .HasMaxLength(50)
                .HasColumnName("מטבע זכות");
            entity.Property(e => e.מטבעחובה)
                .HasMaxLength(50)
                .HasColumnName("מטבע חובה");
            entity.Property(e => e.מסעובד)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("מס עובד");
            entity.Property(e => e.מספרחשבוןזכות)
                .HasMaxLength(50)
                .HasColumnName("מספר חשבון זכות");
            entity.Property(e => e.מספרחשבוןחובה)
                .HasMaxLength(50)
                .HasColumnName("מספר חשבון חובה");
            entity.Property(e => e.סוגחשבוןזכות).HasColumnName("סוג חשבון זכות");
            entity.Property(e => e.סוגחשבוןחובה).HasColumnName("סוג חשבון חובה");
            entity.Property(e => e.סוגפעולה).HasColumnName("סוג פעולה");
            entity.Property(e => e.סיום)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.סכום).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.סניף)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.סניףזכות).HasColumnName("סניף זכות");
            entity.Property(e => e.סניףחובה).HasColumnName("סניף חובה");
            entity.Property(e => e.שםהחשבון)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("שם החשבון");
            entity.Property(e => e.תערךזכות)
                .HasMaxLength(4000)
                .HasColumnName("ת.ערך זכות");
            entity.Property(e => e.תערךחובה)
                .HasMaxLength(4000)
                .HasColumnName("ת.ערך חובה");
        });

        modelBuilder.Entity<VTnuotExport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Tnuot_Export");

            entity.Property(e => e.CancelOrderExport).HasColumnName("Cancel_Order_Export");
            entity.Property(e => e.ErechNakuv)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Erech_Nakuv");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.KodBasisHatzmada).HasColumnName("Kod_Basis_Hatzmada");
            entity.Property(e => e.KodKarteset).HasColumnName("Kod_Karteset");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.KodSapak).HasColumnName("Kod_Sapak");
            entity.Property(e => e.KodStatus).HasColumnName("Kod_Status");
            entity.Property(e => e.KodTnuoa).HasColumnName("Kod_Tnuoa");
            entity.Property(e => e.LastApproveUser).HasMaxLength(50);
            entity.Property(e => e.LoadProcessId).HasColumnName("Load_Process_ID");
            entity.Property(e => e.Matbea).HasMaxLength(50);
            entity.Property(e => e.Neches).HasMaxLength(250);
            entity.Property(e => e.Shaar).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Shovi).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.Taarich).HasColumnType("date");
            entity.Property(e => e.TeurKarteset)
                .HasMaxLength(250)
                .HasColumnName("Teur_Karteset");
            entity.Property(e => e.TeurSapak)
                .HasMaxLength(50)
                .HasColumnName("Teur_Sapak");
            entity.Property(e => e.TeurTnuoa)
                .HasMaxLength(50)
                .HasColumnName("Teur_Tnuoa");
        });

        modelBuilder.Entity<VTnuotIshur>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Tnuot_Ishur");

            entity.Property(e => e.CancelOrderExport).HasColumnName("Cancel_Order_Export");
            entity.Property(e => e.ErechNakuv)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Erech_Nakuv");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.KodBasisHatzmada).HasColumnName("Kod_Basis_Hatzmada");
            entity.Property(e => e.KodKarteset).HasColumnName("Kod_Karteset");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.KodSapak).HasColumnName("Kod_Sapak");
            entity.Property(e => e.KodStatus).HasColumnName("Kod_Status");
            entity.Property(e => e.KodTnuoa).HasColumnName("Kod_Tnuoa");
            entity.Property(e => e.LastApproveUser).HasMaxLength(50);
            entity.Property(e => e.LoadProcessId).HasColumnName("Load_Process_ID");
            entity.Property(e => e.Matbea).HasMaxLength(50);
            entity.Property(e => e.Neches).HasMaxLength(250);
            entity.Property(e => e.Shaar).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Shovi).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.Taarich).HasColumnType("date");
            entity.Property(e => e.TeurKarteset)
                .HasMaxLength(250)
                .HasColumnName("Teur_Karteset");
            entity.Property(e => e.TeurSapak)
                .HasMaxLength(50)
                .HasColumnName("Teur_Sapak");
            entity.Property(e => e.TeurTnuoa)
                .HasMaxLength(50)
                .HasColumnName("Teur_Tnuoa");
        });

        modelBuilder.Entity<VTnuotMetafel>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Tnuot_Metafel");

            entity.Property(e => e.Afik)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.AhuzPidyon)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Ahuz_Pidyon");
            entity.Property(e => e.AhuzRibitPachak)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Ahuz_Ribit_Pachak");
            entity.Property(e => e.AmlaKniaMechira)
                .HasColumnType("decimal(38, 14)")
                .HasColumnName("Amla_KniaMechira");
            entity.Property(e => e.AmlaKorespondent)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Amla_Korespondent");
            entity.Property(e => e.Asmachta1)
                .HasMaxLength(50)
                .HasColumnName("Asmachta_1");
            entity.Property(e => e.Asmachta2)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Asmachta_2");
            entity.Property(e => e.AvarLeHanalatHeshbonot)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Avar_LeHanalat_Heshbonot");
            entity.Property(e => e.Bank)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.DmeyMishmeret)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Dmey_Mishmeret");
            entity.Property(e => e.EMail)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("E_Mail");
            entity.Property(e => e.EchzerAmlatDiler)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Echzer_Amlat_Diler");
            entity.Property(e => e.Fax)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Hafkadot)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.HashkaatKeva)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Hashkaat_Keva");
            entity.Property(e => e.HazmadaLePidyon)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Hazmada_LePidyon");
            entity.Property(e => e.Heshbon).HasMaxLength(50);
            entity.Property(e => e.Ir)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Kamut).HasColumnType("decimal(38, 9)");
            entity.Property(e => e.KodMenaelBank)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Kod_Menael_Bank");
            entity.Property(e => e.KodPeula).HasColumnName("Kod_Peula");
            entity.Property(e => e.KodPeulaBaBank)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Kod_Peula_BaBank");
            entity.Property(e => e.KodPratim).HasColumnName("Kod_Pratim");
            entity.Property(e => e.KodTnua).HasColumnName("Kod_Tnua");
            entity.Property(e => e.KodZihuyLakoach)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Kod_Zihuy_Lakoach");
            entity.Property(e => e.MasBaMakor)
                .HasColumnType("decimal(38, 14)")
                .HasColumnName("Mas_BaMakor");
            entity.Property(e => e.Matbea).HasMaxLength(50);
            entity.Property(e => e.MazavTik)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Mazav_Tik");
            entity.Property(e => e.MenayatShlita)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Menayat_Shlita");
            entity.Property(e => e.Meshichot)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.MetafelId).HasColumnName("MetafelID");
            entity.Property(e => e.Mevutal)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Mikud)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.MisparMekushar)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Mispar_Mekushar");
            entity.Property(e => e.MisparNiar)
                .HasMaxLength(50)
                .HasColumnName("Mispar_Niar");
            entity.Property(e => e.MisparYamimPachak)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Mispar_Yamim_Pachak");
            entity.Property(e => e.Rechov)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.RecordType)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.RibitHazmada)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Ribit_Hazmada");
            entity.Property(e => e.RibitNominal)
                .HasColumnType("decimal(38, 14)")
                .HasColumnName("Ribit_Nominal");
            entity.Property(e => e.ScumKaspiLaOsh)
                .HasColumnType("decimal(38, 9)")
                .HasColumnName("Scum_Kaspi_LaOsh");
            entity.Property(e => e.Shaar).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ShaarMatbea)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Shaar_Matbea");
            entity.Property(e => e.ShaarMemotza)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Shaar_Memotza");
            entity.Property(e => e.ShemHeshbon)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Shem_Heshbon");
            entity.Property(e => e.ShitatMischar)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Shitat_Mischar");
            entity.Property(e => e.Shovi).HasColumnType("decimal(38, 9)");
            entity.Property(e => e.ShoviTikLedmeNihul)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Shovi_Tik_Ledme_Nihul");
            entity.Property(e => e.ShoviTikLetsua)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Shovi_Tik_Letsua");
            entity.Property(e => e.Snif)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Tarich).HasColumnType("date");
            entity.Property(e => e.TarichErech)
                .HasColumnType("date")
                .HasColumnName("Tarich_Erech");
            entity.Property(e => e.TarichHashkaatKeva)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Tarich_Hashkaat_Keva");
            entity.Property(e => e.TarichMenayatShlita)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Tarich_Menayat_Shlita");
            entity.Property(e => e.TarichPticha)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Tarich_Pticha");
            entity.Property(e => e.TarichSgira)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Tarich_Sgira");
            entity.Property(e => e.TarichSlikaKaspi)
                .HasColumnType("date")
                .HasColumnName("Tarich_Slika_Kaspi");
            entity.Property(e => e.TatAfik)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Tat_Afik");
            entity.Property(e => e.TelAvoda)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Tel_Avoda");
            entity.Property(e => e.TelBayit)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Tel_Bayit");
            entity.Property(e => e.TelHul)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Tel_Hul");
            entity.Property(e => e.TelNayad)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Tel_Nayad");
            entity.Property(e => e.TelNayad2)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Tel_Nayad2");
            entity.Property(e => e.TelNayad3)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Tel_Nayad3");
            entity.Property(e => e.TeurNiar)
                .HasMaxLength(250)
                .HasColumnName("Teur_Niar");
            entity.Property(e => e.TeurPeulaBabank)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Teur_Peula_Babank");
            entity.Property(e => e.TnuoaId).HasColumnName("TnuoaID");
            entity.Property(e => e.TsuaHodshit)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Tsua_Hodshit");
            entity.Property(e => e.TsuaRivonit)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Tsua_Rivonit");
            entity.Property(e => e.TsuaShnatit)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Tsua_Shnatit");
            entity.Property(e => e.TsuaYomit)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Tsua_Yomit");
            entity.Property(e => e.TzHp)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("TZ_HP");
            entity.Property(e => e.Yadani)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.YetraLaharPeula)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Yetra_Lahar_Peula");
            entity.Property(e => e.Yoetz)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VTnuotNoa>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Tnuot_Noa");

            entity.Property(e => e.TnuoaId).HasColumnName("TnuoaID");
            entity.Property(e => e.חשבון).HasMaxLength(50);
            entity.Property(e => e.חשבוןחיוב)
                .HasMaxLength(50)
                .HasColumnName("חשבון_חיוב");
            entity.Property(e => e.מוטב).HasMaxLength(100);
            entity.Property(e => e.משכורת)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.סכום).HasColumnType("decimal(38, 20)");
            entity.Property(e => e.סניףחיוב).HasColumnName("סניף_חיוב");
            entity.Property(e => e.פרטים)
                .HasMaxLength(1)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VTnuotOrder>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Tnuot_Order");

            entity.Property(e => e.CheshbonMaavar)
                .HasMaxLength(50)
                .HasColumnName("Cheshbon_Maavar");
            entity.Property(e => e.CheshbonMakor)
                .HasMaxLength(50)
                .HasColumnName("Cheshbon_Makor");
            entity.Property(e => e.CheshbonYaad)
                .HasMaxLength(50)
                .HasColumnName("Cheshbon_Yaad");
            entity.Property(e => e.KodBasisHatzmada).HasColumnName("Kod_Basis_Hatzmada");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.Mutzar).HasMaxLength(50);
            entity.Property(e => e.Neches).HasMaxLength(250);
            entity.Property(e => e.Shovi).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.Taarich).HasColumnType("date");
        });

        modelBuilder.Entity<VTnuotRikuz>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Tnuot_Rikuz");

            entity.Property(e => e.KodBasisHatzmada).HasColumnName("Kod_Basis_Hatzmada");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.KodTnuoa).HasColumnName("Kod_Tnuoa");
            entity.Property(e => e.Shovi).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.Taarich).HasColumnType("date");
        });

        modelBuilder.Entity<VTnuotRikuzWithCheshbonot>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Tnuot_Rikuz_With_Cheshbonot");

            entity.Property(e => e.CheshbonMaavar)
                .HasMaxLength(50)
                .HasColumnName("Cheshbon_Maavar");
            entity.Property(e => e.CheshbonMakor)
                .HasMaxLength(50)
                .HasColumnName("Cheshbon_Makor");
            entity.Property(e => e.CheshbonYaad)
                .HasMaxLength(50)
                .HasColumnName("Cheshbon_Yaad");
            entity.Property(e => e.IdCheshbonMaavar).HasColumnName("ID_Cheshbon_Maavar");
            entity.Property(e => e.IdCheshbonMakor).HasColumnName("ID_Cheshbon_Makor");
            entity.Property(e => e.IdCheshbonYaad).HasColumnName("ID_Cheshbon_Yaad");
            entity.Property(e => e.KodBasisHatzmada).HasColumnName("Kod_Basis_Hatzmada");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.KodTnuoa).HasColumnName("Kod_Tnuoa");
            entity.Property(e => e.Mutzar).HasMaxLength(50);
            entity.Property(e => e.Neches).HasMaxLength(250);
            entity.Property(e => e.Shovi).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.Taarich).HasColumnType("date");
        });

        modelBuilder.Entity<VTnuotRikuzWithPirut>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Tnuot_Rikuz_With_Pirut");

            entity.Property(e => e.KodBasisHatzmada).HasColumnName("Kod_Basis_Hatzmada");
            entity.Property(e => e.KodMutzar).HasColumnName("Kod_Mutzar");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.Shovi).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.Taarich).HasColumnType("date");
        });

        modelBuilder.Entity<VTnuotRpa>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Tnuot_RPA");

            entity.Property(e => e.CheshbonMakor)
                .HasMaxLength(50)
                .HasColumnName("Cheshbon_Makor");
            entity.Property(e => e.CheshbonYaad)
                .HasMaxLength(50)
                .HasColumnName("Cheshbon_Yaad");
            entity.Property(e => e.Id)
                .HasMaxLength(4000)
                .HasColumnName("ID");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.KodTnuoa).HasColumnName("Kod_Tnuoa");
            entity.Property(e => e.MisparTik)
                .HasMaxLength(50)
                .HasColumnName("Mispar_Tik");
            entity.Property(e => e.Mutzar).HasMaxLength(50);
            entity.Property(e => e.Neches).HasMaxLength(1000);
            entity.Property(e => e.Shovi).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.Taarich).HasColumnType("date");
        });

        modelBuilder.Entity<VTnuotStatusLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Tnuot_Status_Log");

            entity.Property(e => e.InsUser)
                .HasMaxLength(50)
                .HasColumnName("Ins_User");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.TimeStamp).HasColumnType("datetime");
            entity.Property(e => e.TnuotId).HasColumnName("TnuotID");
            entity.Property(e => e.TnuotStatusId).HasColumnName("TnuotStatusID");
        });

        modelBuilder.Entity<VTradeDate>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Trade_Dates");

            entity.Property(e => e.Chodesh)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.KodChodesh).HasColumnName("Kod_Chodesh");
            entity.Property(e => e.KodShana).HasColumnName("Kod_Shana");
            entity.Property(e => e.KodYom).HasColumnName("Kod_Yom");
            entity.Property(e => e.Shana)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.SortChodesh).HasColumnName("Sort_Chodesh");
            entity.Property(e => e.SortShana).HasColumnName("Sort_Shana");
            entity.Property(e => e.SortYom).HasColumnName("Sort_Yom");
            entity.Property(e => e.TaarichId)
                .HasColumnType("date")
                .HasColumnName("Taarich_ID");
            entity.Property(e => e.Yom)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VUsersWithProfile>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_usersWithProfiles");

            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsFixedLength();
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.ProfileName).HasMaxLength(50);
            entity.Property(e => e.UserName)
                .HasMaxLength(20)
                .IsUnicode(false);
        });

        modelBuilder.Entity<VYpdoch>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_YPDoch");

            entity.Property(e => e.Bank).HasMaxLength(100);
            entity.Property(e => e.KerenMechaka)
                .HasMaxLength(13)
                .IsUnicode(false)
                .HasColumnName("Keren_Mechaka");
            entity.Property(e => e.KodChaverBursa).HasColumnName("Kod_Chaver_Bursa");
            entity.Property(e => e.KodMetafel).HasColumnName("Kod_Metafel");
            entity.Property(e => e.KodMutzar).HasColumnName("Kod_Mutzar");
            entity.Property(e => e.Medina).HasMaxLength(50);
            entity.Property(e => e.Menahel).HasMaxLength(50);
            entity.Property(e => e.Metafel).HasMaxLength(50);
            entity.Property(e => e.Mutzar).HasMaxLength(50);
            entity.Property(e => e.NotActive).HasColumnName("Not_Active");
            entity.Property(e => e.PidyonotKamut).HasColumnName("Pidyonot_Kamut");
            entity.Property(e => e.PidyonotShovi)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Pidyonot_Shovi");
            entity.Property(e => e.PidyonotShoviHotz).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.PidyonotShoviPizul).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.Taarich).HasColumnType("date");
            entity.Property(e => e.Tik).HasMaxLength(50);
            entity.Property(e => e.YezirotKamut).HasColumnName("Yezirot_Kamut");
            entity.Property(e => e.YezirotShovi)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Yezirot_Shovi");
            entity.Property(e => e.YezirotShoviHotz).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.YezirotShoviPizul).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.YpshoviTotal)
                .HasColumnType("decimal(19, 2)")
                .HasColumnName("YPShoviTotal");
        });

        modelBuilder.Entity<VYpdochDailyHol>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_YPDochDailyHol");

            entity.Property(e => e.KodNeches)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.Shovi).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.Tik).HasMaxLength(50);
        });

        modelBuilder.Entity<VYtrSnir>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("v_Ytr_Snir");

            entity.Property(e => e.AchuzChasifa)
                .HasColumnType("decimal(38, 20)")
                .HasColumnName("Achuz_Chasifa");
            entity.Property(e => e.Afik).HasMaxLength(50);
            entity.Property(e => e.Chasifa).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Kamut).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.KodMachshir).HasColumnName("Kod_Machshir");
            entity.Property(e => e.KodMutzar).HasColumnName("Kod_Mutzar");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.KodNechesBasis)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches_Basis");
            entity.Property(e => e.KodNechesHamara)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches_Hamara");
            entity.Property(e => e.KodSugMutzar).HasColumnName("Kod_Sug_Mutzar");
            entity.Property(e => e.Multiplier).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Mutzar).HasMaxLength(50);
            entity.Property(e => e.Neches).HasMaxLength(1000);
            entity.Property(e => e.Shaar).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Shovi).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ShoviKeupa).HasColumnType("decimal(38, 2)");
            entity.Property(e => e.TeurTatAfik)
                .HasMaxLength(50)
                .HasColumnName("Teur_Tat_Afik");
            entity.Property(e => e.Ticker).HasMaxLength(50);
        });

        modelBuilder.Entity<YpDanelPizulim>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("YP_Danel_Pizulim");

            entity.Property(e => e.KodBank).HasColumnName("Kod_Bank");
            entity.Property(e => e.KodTnua).HasColumnName("Kod_Tnua");
            entity.Property(e => e.MisparNiar).HasColumnName("Mispar_Niar");
            entity.Property(e => e.Shaar).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Shovi).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Taarich).HasColumnType("date");
        });

        modelBuilder.Entity<YpDanelTnout>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("YP_Danel_Tnout");

            entity.Property(e => e.KodBank).HasColumnName("Kod_Bank");
            entity.Property(e => e.KodPeula).HasColumnName("Kod_Peula");
            entity.Property(e => e.KodPeulaBank)
                .HasMaxLength(5)
                .HasColumnName("Kod_Peula_Bank");
            entity.Property(e => e.MisparNiar)
                .HasMaxLength(50)
                .HasColumnName("Mispar_Niar");
            entity.Property(e => e.TaarichErech)
                .HasColumnType("date")
                .HasColumnName("Taarich_Erech");
        });

        modelBuilder.Entity<YpYomi>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("YP_Yomi");

            entity.Property(e => e.ChaverBursa)
                .HasMaxLength(50)
                .HasColumnName("Chaver_Bursa");
            entity.Property(e => e.KodChaverBursa).HasColumnName("Kod_Chaver_Bursa");
            entity.Property(e => e.KodMutzar).HasColumnName("Kod_Mutzar");
            entity.Property(e => e.Mutzar).HasMaxLength(50);
            entity.Property(e => e.PidyonotKamut).HasColumnName("Pidyonot_Kamut");
            entity.Property(e => e.PidyonotShovi)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Pidyonot_Shovi");
            entity.Property(e => e.Taarich).HasColumnType("date");
            entity.Property(e => e.YezirotKamut).HasColumnName("Yezirot_Kamut");
            entity.Property(e => e.YezirotShovi)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Yezirot_Shovi");
        });

        modelBuilder.Entity<YtrBank>(entity =>
        {
            entity.HasKey(e => new { e.Taarich, e.KodNeches, e.Cheshbon, e.SugYitra });

            entity.ToTable("Ytr_Bank");

            entity.Property(e => e.Taarich).HasColumnType("date");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.Cheshbon).HasMaxLength(50);
            entity.Property(e => e.SugYitra)
                .HasMaxLength(50)
                .HasColumnName("Sug_Yitra");
            entity.Property(e => e.Kamut).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Shaar).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Shovi).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.TeurNeches)
                .HasMaxLength(50)
                .HasColumnName("Teur_Neches");
        });

        modelBuilder.Entity<YtrSnir>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Ytr_Snir");

            entity.Property(e => e.Chasifa).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.ChasifaMatbea)
                .HasColumnType("decimal(18, 2)")
                .HasColumnName("Chasifa_Matbea");
            entity.Property(e => e.DmeiNihul)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("Dmei_Nihul");
            entity.Property(e => e.Kamut).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.KodBasisHatzmada)
                .HasMaxLength(50)
                .HasColumnName("Kod_BasisHatzmada");
            entity.Property(e => e.KodBasisHatzmadaNegative)
                .HasMaxLength(100)
                .HasColumnName("Kod_BasisHatzmada_Negative");
            entity.Property(e => e.KodHieTatAfik1).HasColumnName("Kod_Hie_TatAfik1");
            entity.Property(e => e.KodMachshir).HasColumnName("Kod_Machshir");
            entity.Property(e => e.KodManpik).HasColumnName("Kod_Manpik");
            entity.Property(e => e.KodMutzar).HasColumnName("Kod_Mutzar");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.KodSugYitra).HasColumnName("Kod_Sug_Yitra");
            entity.Property(e => e.KodTatAfik).HasColumnName("Kod_TatAfik");
            entity.Property(e => e.LoadProcessId).HasColumnName("LoadProcessID");
            entity.Property(e => e.Macham).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.Mutzar).HasMaxLength(50);
            entity.Property(e => e.Neches).HasMaxLength(1000);
            entity.Property(e => e.Shaar).HasColumnType("decimal(18, 6)");
            entity.Property(e => e.ShaarMatbeaMakor)
                .HasColumnType("decimal(18, 6)")
                .HasColumnName("Shaar_Matbea_Makor");
            entity.Property(e => e.Shovi).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.SnirNechesId).HasColumnName("Snir_Neches_ID");
            entity.Property(e => e.Taarich).HasColumnType("date");
            entity.Property(e => e.TaarichPkia)
                .HasColumnType("date")
                .HasColumnName("Taarich_Pkia");
            entity.Property(e => e.Tik).HasMaxLength(50);
        });

        modelBuilder.Entity<YtrTazrim>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Ytr_Tazrim");

            entity.Property(e => e.Counterparty).HasMaxLength(50);
            entity.Property(e => e.KodBasisHatzmada)
                .HasMaxLength(50)
                .HasColumnName("Kod_BasisHatzmada");
            entity.Property(e => e.KodMutzar).HasColumnName("Kod_Mutzar");
            entity.Property(e => e.KodNeches)
                .HasMaxLength(50)
                .HasColumnName("Kod_Neches");
            entity.Property(e => e.Shovi).HasColumnType("decimal(18, 2)");
            entity.Property(e => e.Taarich).HasColumnType("date");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
