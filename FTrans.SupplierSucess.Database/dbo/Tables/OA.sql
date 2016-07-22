CREATE TABLE [dbo].[OA] (
    [OAID]             BIGINT   IDENTITY (1, 1) NOT NULL,
    [BuyerID]          INT      NULL,
    [SupplierID]       INT      NULL,
    [RemittanceFileID] BIGINT   NULL,
    [OAStatus]         CHAR (1) NULL,
    [OAAmount]         MONEY    NULL,
    [CreatedBy]        BIGINT   NULL,
    [CreatedDate]      DATETIME NULL,
    PRIMARY KEY CLUSTERED ([OAID] ASC)
);

