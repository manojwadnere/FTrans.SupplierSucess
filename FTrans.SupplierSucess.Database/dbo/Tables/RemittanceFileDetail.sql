CREATE TABLE [dbo].[RemittanceFileDetail] (
    [RemittanceFileDetailID]      BIGINT        IDENTITY (1, 1) NOT NULL,
    [RemittanceFileID]            BIGINT        NULL,
    [BuyersSupplierID]            INT           NULL,
    [BuyersSupplierInvoiceNumber] VARCHAR (200) NULL,
    [InvoiceAmount]               MONEY         NULL,
    [PaymentAmount]               MONEY         NULL,
    PRIMARY KEY CLUSTERED ([RemittanceFileDetailID] ASC)
);

