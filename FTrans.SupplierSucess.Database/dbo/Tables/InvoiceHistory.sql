CREATE TABLE [dbo].[InvoiceHistory] (
    [InvoiceHistoryID]            BIGINT        IDENTITY (1, 1) NOT NULL,
    [InvoiceID]                   BIGINT        NOT NULL,
    [BuyerID]                     INT           NULL,
    [SupplierID]                  INT           NULL,
    [BuyersSupplierInvoiceNumber] VARCHAR (200) NULL,
    [InvoiceStatus]               CHAR (1)      NULL,
    [InvoiceAmount]               MONEY         NULL,
    [InvoiceDate]                 DATETIME      NULL,
    [DueDate]                     DATETIME      NULL,
    [PaymentTerms]                INT           NULL,
    [PONumber]                    INT           NULL,
    [OpenBalance]                 MONEY         NULL,
    [SettlementAmount]            MONEY         NULL,
    [SettlementDate]              DATETIME      NULL,
    [Closed]                      DATETIME      NULL,
    [Diversity]                   MONEY         NULL,
    [Processing]                  MONEY         NULL,
    [Discount]                    MONEY         NULL,
    [UpdatedBy]                   BIGINT        NULL,
    [UpdatedDate]                 DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([InvoiceHistoryID] ASC)
);

