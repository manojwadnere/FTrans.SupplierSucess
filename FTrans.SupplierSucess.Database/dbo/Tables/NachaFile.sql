CREATE TABLE [dbo].[NachaFile] (
    [NachaFileID] BIGINT         IDENTITY (1, 1) NOT NULL,
    [FileName]    VARCHAR (200)  NOT NULL,
    [FilePath]    VARCHAR (1000) NULL,
    [BankID]      INT            NULL,
    [CreatedBy]   BIGINT         NULL,
    [CreatedDate] DATETIME       NULL,
    PRIMARY KEY CLUSTERED ([NachaFileID] ASC)
);

