CREATE TABLE [dbo].[CreditMemoHistory] (
    [CreditMemoHistoryID]    BIGINT   IDENTITY (1, 1) NOT NULL,
    [CreditMemoID]           BIGINT   NOT NULL,
    [BuyerID]                INT      NULL,
    [SupplierID]             INT      NULL,
    [BuyersCreditMemoNumber] INT      NULL,
    [CreditMemoStatus]       CHAR (1) NULL,
    [CreditMemoAmount]       MONEY    NULL,
    [CreditMemoDate]         DATETIME NULL,
    [SettlementDate]         DATETIME NULL,
    [UpdatedBy]              BIGINT   NULL,
    [UpdatedDate]            DATETIME NULL,
    PRIMARY KEY CLUSTERED ([CreditMemoHistoryID] ASC)
);

