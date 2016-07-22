CREATE TABLE [dbo].[FundingDetail] (
    [FundingDetailID]             BIGINT        IDENTITY (1, 1) NOT NULL,
    [FundingID]                   BIGINT        NOT NULL,
    [BankID]                      INT           NOT NULL,
    [BuyerID]                     INT           NULL,
    [SupplierID]                  INT           NULL,
    [BuyersSupplierInvoiceNumber] VARCHAR (200) NULL,
    [InvoiceStatus]               CHAR (1)      NULL,
    [InvoiceAmount]               MONEY         NULL,
    [InvoiceDate]                 DATETIME      NULL,
    [OpenBalance]                 MONEY         NULL,
    [RemainingBalance]            MONEY         NULL,
    [CreatedBy]                   BIGINT        NULL,
    [CreatedDate]                 DATETIME      NULL,
    [UpdatedBy]                   BIGINT        NULL,
    [UpdatedDate]                 DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([FundingDetailID] ASC)
);

