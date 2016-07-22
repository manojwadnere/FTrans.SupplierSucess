CREATE TABLE [dbo].[BankXBuyerHistory] (
    [BankXBuyerHistoryID] BIGINT   IDENTITY (1, 1) NOT NULL,
    [BankXBuyerID]        INT      NOT NULL,
    [BankID]              INT      NOT NULL,
    [BuyerID]             INT      NOT NULL,
    [ContractStartDate]   DATETIME NULL,
    [ContractExpiryDate]  DATETIME NULL,
    [UpdatedBy]           BIGINT   NULL,
    [UpdatedDate]         DATETIME NULL,
    PRIMARY KEY CLUSTERED ([BankXBuyerHistoryID] ASC)
);

