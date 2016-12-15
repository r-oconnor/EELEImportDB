using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HamptonsDataModels
{
    public class CListings
    {
        public int ListingId { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public int AgentId { get; set; }
        public int AgentId2 { get; set; }
        public int AgentId3 { get; set; }
        public int OfficeId { get; set; }
        public int NumPhotos { get; set; }
        public string LastPriceTime { get; set; }
        public int LastPriceValue { get; set; }
        public string LastStatusTime { get; set; }
        public string LastStatusValue { get; set; }
        public int Hidden { get; set; }
        public string Visibility { get; set; }
        public string HideReason { get; set; }
        public string WebId { get; set; }
        public string SourceListingId2 { get; set; }
        public int RetsSysPublic { get; set; }
        public int RetsBrokerWeb { get; set; }
        public int RetsPt2 { get; set; }
        public int RetsRdc { get; set; }
        public int RetsZillow { get; set; }
        public int RetsTrulia { get; set; }
        public int RetsHomes { get; set; }
        public int RetsHomefinder { get; set; }
        public int RetsOnthemove { get; set; }
        public int RetsJuwai { get; set; }
        public int RetsIdx { get; set; }
        public int Status { get; set; }
        public int IsExtended { get; set; }
        public string ListDate { get; set; }
        public string ExpireDate { get; set; }
        public string ContractDate { get; set; }
        public string RentDate { get; set; }
        public string SaleDate { get; set; }
        public string WithdrawDate { get; set; }
        public string Tempoffmktdate { get; set; }
        public string PropertyType { get; set; }
        public string PropertySubtype { get; set; }
        public string PropertyClass { get; set; }
        public string SaleRent { get; set; }
        public int IsSeasonal { get; set; }
        public int Price { get; set; }
        public int PriceOriginal { get; set; }
        public int PriceSale { get; set; }
        public int ShowPrice { get; set; }
        public string MarketHeadline { get; set; }
        public string AdCopyBranded { get; set; }
        public string AdCopyUnbranded { get; set; }
        public string PrivateDescHtml { get; set; }
        public string CompanyDescHtml { get; set; }
        public string VirtualTour { get; set; }
        public string ListingUrl { get; set; }
        public string YoutubeVideoId { get; set; }
        public string Directions { get; set; }
        public decimal Latitude{ get; set; }
        public decimal Longitude{ get; set; }
        public string StreetNum { get; set; }
        public string StreetName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string County { get; set; }
        public string School { get; set; }
        public string Neighborhood { get; set; }
        public string SectionId { get; set; }
        public string Township { get; set; }
        public string HamletId { get; set; }
        public int UndisclosedAddress { get; set; }
        public string Zone { get; set; }
        public string Parcel { get; set; }
        public string ParcelNorm { get; set; }
        public int Soh { get; set; }
        public int NearTrain { get; set; }
        public int NearBus { get; set; }
        public string ListingType { get; set; }
        public int CoexAgentId { get; set; }
        public int CoexAgentId2 { get; set; }
        public string TotalCommission { get; set; }
        public string BrokerAgentCut { get; set; }
        public string BuyerAgentCut { get; set; }
        public string SubAgentCut { get; set; }
        public string BonusCut { get; set; }
        public string BuyerAgentCompany { get; set; }
        public string BuyerAgentName { get; set; }
        public int BuyerAgentId { get; set; }
        public int BuyerOfficeId { get; set; }
        public int SellerConcession { get; set; }
        public string HowSold { get; set; }
        public int TaxTotal { get; set; }
        public string TaxYear { get; set; }
        public int TaxSchool { get; set; }
        public int TaxCounty { get; set; }
        public int TaxCity { get; set; }
        public int TaxVillage { get; set; }
        public int TaxExemptions { get; set; }
        public string TaxFlip { get; set; }
        public int TaxRe { get; set; }
        public int PctTaxDeduct { get; set; }
        public int NewConstruction { get; set; }
        public int Handicap { get; set; }
        public int IsWaterfront { get; set; }
        public int IsWaterView { get; set; }
        public int HasPool { get; set; }
        public string ResidentialStyle { get; set; }
        public string BuildingStyle { get; set; }
        public string ConstructionType { get; set; }
        public string ApartmentType { get; set; }
        public string CommercialType { get; set; }
        public int Beds { get; set; }
        public int FullBaths { get; set; }
        public int HalfBaths { get; set; }
        public int Stories { get; set; }
        public string FloorNum { get; set; }
        public string UnitNum { get; set; }
        public string AboveArea { get; set; }
        public decimal LotSize{ get; set; }
        public int LotSqft { get; set; }
        public int AtticAccess { get; set; }
        public string AtticType { get; set; }
        public string GarageType { get; set; }
        public int GarageSpaces{ get; set; }
        public string YearBuilt { get; set; }
        public string RenovationDate { get; set; }
        public string RenovationYear { get; set; }
        public string RenovationComments { get; set; }
        public string Pcondition { get; set; }
        public string Occupancy { get; set; }
        public int MotDisplayLand { get; set; }
        public int MotBank { get; set; }
        public int MotForeclosure { get; set; }
        public int MotHoldpaper { get; set; }
        public int MotPreforeclosure { get; set; }
        public int MotRelocating { get; set; }
        public int MotShortsale { get; set; }
        public int MotTypical { get; set; }
        public int MotEstate { get; set; }
        public int MotFixup { get; set; }
        public int Mot1031 { get; set; }
        public string WaterType { get; set; }
        public string SewerType { get; set; }
        public int Fireplaces { get; set; }
        public int CentralAc { get; set; }
        public int WallwinAc { get; set; }
        public string KitchenCounter { get; set; }
        public string KitchenType { get; set; }
        public int Furnished { get; set; }
        public int NumRooms { get; set; }
        public string WaterName { get; set; }
        public string BasementType { get; set; }
        public int NaturalGas { get; set; }
        public string AvailDate { get; set; }
        public string MinTerm { get; set; }
        public string MaxTerm { get; set; }
        public int Hoa { get; set; }
        public int HoaFee { get; set; }
        public int NumUnits { get; set; }
        public string ComplexName { get; set; }
        public int NumLots { get; set; }
        public string MapNum { get; set; }
        public int LandFrontage { get; set; }

    }
}