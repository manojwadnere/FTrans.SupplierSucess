CREATE TABLE [dbo].[ChargeHistory] (
    [ChargeHistoryID]  BIGINT   IDENTITY (1, 1) NOT NULL,
    [ChargeID]         BIGINT   NOT NULL,
    [BuyerID]          INT      NULL,
    [SupplierID]       INT      NULL,
    [RemittanceFileID] INT      NULL,
    [ChargeStatus]     CHAR (1) NULL,
    [ChargeAmount]     MONEY    NULL,
    [UpdatedBy]        BIGINT   NULL,
    [UpdatedDate]      DATETIME NULL,
    PRIMARY KEY CLUSTERED ([ChargeHistoryID] ASC)
);

