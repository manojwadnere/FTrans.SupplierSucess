CREATE TABLE [dbo].[Country] (
    [CountryID]   SMALLINT      IDENTITY (1, 1) NOT NULL,
    [CountryCode] VARCHAR (3)   NULL,
    [CountryName] VARCHAR (200) NULL,
    PRIMARY KEY CLUSTERED ([CountryID] ASC)
);

