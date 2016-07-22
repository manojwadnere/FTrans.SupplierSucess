CREATE TABLE [dbo].[InvoiceFileDetail] (
    [InvoiceFileDetailID]         BIGINT        IDENTITY (1, 1) NOT NULL,
    [InvoiceFileID]               BIGINT        NULL,
    [BuyersSupplierID]            INT           NULL,
    [BuyersSupplierInvoiceNumber] VARCHAR (200) NULL,
    [InvoiceAmount]               MONEY         NULL,
    [InvoiceDate]                 DATETIME      NULL,
    [DueDate]                     DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([InvoiceFileDetailID] ASC)
);

