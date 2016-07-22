CREATE TABLE [dbo].[FileFormat] (
    [FileFormatID] BIGINT        IDENTITY (1, 1) NOT NULL,
    [BuyerID]      INT           NULL,
    [XMLFile]      VARCHAR (MAX) NULL,
    [FileTypeID]   SMALLINT      NULL,
    [CreatedBy]    BIGINT        NULL,
    [CreatedDate]  DATETIME      NULL,
    [UpdatedBy]    BIGINT        NULL,
    [UpdatedDate]  DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([FileFormatID] ASC)
);

