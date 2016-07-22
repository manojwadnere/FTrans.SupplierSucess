CREATE TABLE [dbo].[OAHistory] (
    [OAHistoryID]      BIGINT   IDENTITY (1, 1) NOT NULL,
    [OAID]             BIGINT   NOT NULL,
    [BuyerID]          INT      NULL,
    [SupplierID]       INT      NULL,
    [RemittanceFileID] INT      NULL,
    [OAStatus]         CHAR (1) NULL,
    [OAAmount]         MONEY    NULL,
    [UpdatedBy]        BIGINT   NULL,
    [UpdatedDate]      DATETIME NULL,
    PRIMARY KEY CLUSTERED ([OAHistoryID] ASC)
);

