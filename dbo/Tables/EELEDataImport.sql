﻿CREATE TABLE [dbo].[EELEDataImport] (
    [ImportId]           INT            IDENTITY (1, 1) NOT NULL,
    [ListingId]          INT            NOT NULL,
    [Created]            DATETIME       NOT NULL,
    [Modified]           DATETIME       NOT NULL,
    [ImportCreated]      DATETIME       NOT NULL,
    [ImportModified]     DATETIME       NOT NULL,
    [AgentId]            INT            NULL,
    [AgentId2]           INT            NULL,
    [AgentId3]           INT            NULL,
    [OfficeId]           INT            NULL,
    [NumPhotos]          TINYINT        NULL,
    [LastPriceTime]      VARCHAR (50)   NULL,
    [LastPriceValue]     INT            NULL,
    [LastStatusTime]     VARCHAR (50)   NULL,
    [LastStatusValue]    SMALLINT       NULL,
    [Hidden]             TINYINT        NULL,
    [Visibility]         VARCHAR (64)   NULL,
    [HideReason]         VARCHAR (64)   NULL,
    [WebId]              VARCHAR (16)   NULL,
    [SourceListingId2]   VARCHAR (32)   NULL,
    [RetsBrokerWeb]      TINYINT        NULL,
    [RetsPt2]            TINYINT        NULL,
    [RetsRdc]            TINYINT        NULL,
    [RetsZillow]         TINYINT        NULL,
    [RetsTrulia]         TINYINT        NULL,
    [RetsHomes]          TINYINT        NULL,
    [RetsHomefinder]     TINYINT        NULL,
    [RetsOnthemove]      TINYINT        NULL,
    [RetsJuwai]          TINYINT        NULL,
    [RetsIdx]            TINYINT        NULL,
    [Status]             INT            NULL,
    [IsExtended]         TINYINT        NULL,
    [ListDate]           VARCHAR (10)   NULL,
    [ExpireDate]         VARCHAR (10)   NULL,
    [ContractDate]       VARCHAR (10)   NULL,
    [RentDate]           VARCHAR (10)   NULL,
    [SaleDate]           VARCHAR (10)   NULL,
    [WithdrawDate]       VARCHAR (10)   NULL,
    [Tempoffmkdate]      VARCHAR (10)   NULL,
    [PropertyType]       SMALLINT       NULL,
    [PropertySubType]    VARCHAR (128)  NULL,
    [PropertyClass]      VARCHAR (2)    NULL,
    [SaleRent]           VARCHAR (1)    NULL,
    [IsSeasonal]         TINYINT        NULL,
    [Price]              INT            NULL,
    [PriceOriginal]      INT            NULL,
    [PriceSale]          INT            NULL,
    [ShowPrice]          TINYINT        NULL,
    [MarketHeadline]     VARCHAR (128)  NULL,
    [AdCopyBranded]      VARCHAR (5000) NULL,
    [AdCopyUnbranded]    VARCHAR (5000) NULL,
    [PrivateDescHtml]    VARCHAR (5000) NULL,
    [CompanyDescHtml]    VARCHAR (5000) NULL,
    [VirtualTour]        VARCHAR (5000) NULL,
    [ListingUrl]         VARCHAR (5000) NULL,
    [YoutubeVideoId]     VARCHAR (512)  NULL,
    [Directions]         VARCHAR (5000) NULL,
    [Latitude]           DECIMAL (10)   NULL,
    [Longitude]          DECIMAL (10)   NULL,
    [StreetNum]          VARCHAR (16)   NULL,
    [StreetName]         VARCHAR (40)   NULL,
    [Address]            VARCHAR (64)   NULL,
    [City]               VARCHAR (64)   NULL,
    [State]              VARCHAR (64)   NULL,
    [Zip]                VARCHAR (5)    NULL,
    [County]             VARCHAR (6)    NULL,
    [School]             VARCHAR (128)  NULL,
    [Neighborhood]       VARCHAR (64)   NULL,
    [SectionId]          SMALLINT       NULL,
    [Township]           VARCHAR (64)   NULL,
    [HamletId]           SMALLINT       NULL,
    [UndisclosedAddress] TINYINT        NULL,
    [Zone]               SMALLINT       NULL,
    [Parcel]             VARCHAR (40)   NULL,
    [ParcelNorm]         VARCHAR (40)   NULL,
    [Soh]                TINYINT        NULL,
    [NearTrain]          TINYINT        NULL,
    [NearBus]            TINYINT        NULL,
    [ListingType]        SMALLINT       NULL,
    [CoexAgentId]        INT            NULL,
    [CoexAgentId2]       INT            NULL,
    [TotalCommission]    VARCHAR (32)   NULL,
    [BrokerAgentCut]     VARCHAR (32)   NULL,
    [BuyerAgentCut]      VARCHAR (32)   NULL,
    [SubAgentCut]        VARCHAR (32)   NULL,
    [BonusCut]           VARCHAR (32)   NULL,
    [BuyerAgentCompany]  VARCHAR (64)   NULL,
    [BuyerAgentName]     VARCHAR (64)   NULL,
    [BuyerAgentId]       INT            NULL,
    [BuyerOfficeId]      INT            NULL,
    [SellerConcession]   INT            NULL,
    [HowSold]            VARCHAR (64)   NULL,
    [TaxTotal]           INT            NULL,
    [TaxYear]            SMALLINT       NULL,
    [TaxSchool]          INT            NULL,
    [TaxCounty]          INT            NULL,
    [TaxCity]            INT            NULL,
    [TaxVillage]         INT            NULL,
    [TaxExemptions]      TINYINT        NULL,
    [TaxFlip]            VARCHAR (16)   NULL,
    [TaxRe]              INT            NULL,
    [PctTaxDeduct]       TINYINT        NULL,
    [NewConstruction]    TINYINT        NULL,
    [Handicap]           TINYINT        NULL,
    [IsWaterfront]       TINYINT        NULL,
    [IsWaterView]        TINYINT        NULL,
    [HasPool]            TINYINT        NULL,
    [ResidentialStyle]   SMALLINT       NULL,
    [BuildingStyle]      SMALLINT       NULL,
    [ConstructionType]   SMALLINT       NULL,
    [ApartmentType]      SMALLINT       NULL,
    [CommercialType]     SMALLINT       NULL,
    [Beds]               TINYINT        NULL,
    [FullBaths]          TINYINT        NULL,
    [HalfBaths]          TINYINT        NULL,
    [Stories]            TINYINT        NULL,
    [FloorNum]           VARCHAR (16)   NULL,
    [UnitNum]            VARCHAR (16)   NULL,
    [AboveArea]          SMALLINT       NULL,
    [LotSize]            DECIMAL (10)   NULL,
    [LotSqft]            INT            NULL,
    [AtticAccess]        TINYINT        NULL,
    [AtticType]          SMALLINT       NULL,
    [GarageType]         SMALLINT       NULL,
    [YearBuilt]          SMALLINT       NULL,
    [RenovationDate]     VARCHAR (10)   NULL,
    [RenovationYear]     SMALLINT       NULL,
    [RenovationComments] VARCHAR (5000) NULL,
    [Pcondition]         SMALLINT       NULL,
    [Occupancy]          SMALLINT       NULL,
    [MotDisplayLand]     TINYINT        NULL,
    [MotBank]            TINYINT        NULL,
    [MotForeclosure]     TINYINT        NULL,
    [MotHoldpaper]       TINYINT        NULL,
    [MotPreforeclosure]  TINYINT        NULL,
    [MotRelocating]      TINYINT        NULL,
    [MotShortsale]       TINYINT        NULL,
    [MotTypical]         TINYINT        NULL,
    [MotEstate]          TINYINT        NULL,
    [MotFixup]           TINYINT        NULL,
    [Mot1031]            TINYINT        NULL,
    [WaterType]          SMALLINT       NULL,
    [SewerType]          SMALLINT       NULL,
    [Fireplaces]         TINYINT        NULL,
    [CentralAc]          TINYINT        NULL,
    [WallwinAc]          TINYINT        NULL,
    [KitchenCounter]     SMALLINT       NULL,
    [KitchenType]        SMALLINT       NULL,
    [Furnished]          TINYINT        NULL,
    [NumRooms]           TINYINT        NULL,
    [WaterName]          VARCHAR (40)   NULL,
    [BasementType]       SMALLINT       NULL,
    [NaturalGas]         TINYINT        NULL,
    [AvailDate]          VARCHAR (16)   NULL,
    [MinTerm]            VARCHAR (16)   NULL,
    [MaxTerm]            VARCHAR (16)   NULL,
    [Hoa]                TINYINT        NULL,
    [HoaFree]            INT            NULL,
    [NumUnits]           TINYINT        NULL,
    [ComplexName]        VARCHAR (40)   NULL,
    [NumLots]            TINYINT        NULL,
    [MapNum]             VARCHAR (16)   NULL,
    [LandFrontage]       INT            NULL,
    CONSTRAINT [PK_EELEDataImport] PRIMARY KEY CLUSTERED ([ImportId] ASC)
);

