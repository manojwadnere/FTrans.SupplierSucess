CREATE TABLE [dbo].[BuyerXSupplierHistory] (
    [BuyerXSupplierHistoryID] BIGINT   IDENTITY (1, 1) NOT NULL,
    [BuyerXSupplierID]        INT      NOT NULL,
    [BuyerID]                 INT      NOT NULL,
    [SupplierID]              INT      NOT NULL,
    [BuyersSupplierID]        INT      NOT NULL,
    [FundingChoiceID]         SMALLINT NOT NULL,
    [ContractStartDate]       DATETIME NULL,
    [ContractExpiryDate]      DATETIME NULL,
    [UpdatedBy]               BIGINT   NULL,
    [UpdatedDate]             DATETIME NULL,
    PRIMARY KEY CLUSTERED ([BuyerXSupplierHistoryID] ASC)
);

