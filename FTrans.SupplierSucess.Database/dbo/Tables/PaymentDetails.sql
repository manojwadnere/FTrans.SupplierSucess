CREATE TABLE [dbo].[PaymentDetails] (
    [PaymentDetailID] BIGINT   IDENTITY (1, 1) NOT NULL,
    [BuyerID]         INT      NULL,
    [InvoiceID]       BIGINT   NULL,
    [PaymentAmount]   MONEY    NULL,
    [PaymentDate]     DATETIME NULL,
    [CreatedBy]       BIGINT   NULL,
    [CreatedDate]     DATETIME NULL,
    [UpdatedBy]       BIGINT   NULL,
    [UpdatedDate]     DATETIME NULL,
    PRIMARY KEY CLUSTERED ([PaymentDetailID] ASC)
);

