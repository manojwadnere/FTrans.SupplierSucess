CREATE TABLE [dbo].[Charge] (
    [ChargeID]         BIGINT   IDENTITY (1, 1) NOT NULL,
    [BuyerID]          INT      NULL,
    [SupplierID]       INT      NULL,
    [RemittanceFileID] BIGINT   NULL,
    [ChargeStatus]     CHAR (1) NULL,
    [ChargeAmount]     MONEY    NULL,
    [CreatedBy]        BIGINT   NULL,
    [CreatedDate]      DATETIME NULL,
    PRIMARY KEY CLUSTERED ([ChargeID] ASC)
);

