CREATE TABLE [dbo].[AccountTransaction] (
    [TransactionID]     BIGINT   IDENTITY (1, 1) NOT NULL,
    [TransactionDate]   DATETIME NULL,
    [TransactionTypeID] SMALLINT NULL,
    [Amount]            MONEY    NULL,
    [BuyerID]           INT      NULL,
    [SupplierID]        INT      NULL,
    [UserID]            BIGINT   NULL,
    [CreatedBy]         BIGINT   NULL,
    [CreatedDate]       DATETIME NULL,
    PRIMARY KEY CLUSTERED ([TransactionID] ASC)
);

