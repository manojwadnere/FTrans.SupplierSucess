CREATE TABLE [dbo].[Address] (
    [AddressID]     BIGINT        IDENTITY (1, 1) NOT NULL,
    [AddressLine1]  VARCHAR (100) NULL,
    [AddressLine2]  VARCHAR (100) NULL,
    [City]          VARCHAR (50)  NULL,
    [StateID]       SMALLINT      NULL,
    [ZipCode]       VARCHAR (10)  NULL,
    [CountryID]     SMALLINT      NULL,
    [AddressTypeID] SMALLINT      NULL,
    [EntityID]      INT           NULL,
    [UserTypeID]    SMALLINT      NULL,
    [UpdatedBy]     BIGINT        NULL,
    [UpdatedDate]   DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([AddressID] ASC)
);

