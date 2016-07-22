CREATE TABLE [dbo].[RemittanceFile] (
    [RemittanceFileID] BIGINT         IDENTITY (1, 1) NOT NULL,
    [FileName]         VARCHAR (200)  NOT NULL,
    [FilePath]         VARCHAR (1000) NULL,
    [Status]           INT            NULL,
    [BuyerID]          INT            NULL,
    [UpdatedBy]        BIGINT         NULL,
    [UpdatedDate]      DATETIME       NULL,
    [ApprovedBy]       BIGINT         NULL,
    [ApprovedDate]     DATETIME       NULL,
    PRIMARY KEY CLUSTERED ([RemittanceFileID] ASC)
);

