CREATE TABLE [dbo].[AddressType] (
    [AddressTypeID]   SMALLINT       NOT NULL,
    [AddressTypeName] VARCHAR (100)  NULL,
    [Description]     VARCHAR (1000) NULL,
    PRIMARY KEY CLUSTERED ([AddressTypeID] ASC)
);

