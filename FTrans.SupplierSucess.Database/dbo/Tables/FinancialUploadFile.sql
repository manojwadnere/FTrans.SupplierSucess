CREATE TABLE [dbo].[FinancialUploadFile] (
    [FinancialUploadFileID] BIGINT         IDENTITY (1, 1) NOT NULL,
    [FileName]              VARCHAR (200)  NOT NULL,
    [FilePath]              VARCHAR (1000) NULL,
    [BuyerID]               INT            NULL,
    [FinancialPeriod]       DATETIME       NULL,
    [UpdatedBy]             BIGINT         NULL,
    [UpdatedDate]           DATETIME       NULL,
    PRIMARY KEY CLUSTERED ([FinancialUploadFileID] ASC)
);

