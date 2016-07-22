CREATE TABLE [dbo].[Log] (
    [ID]          BIGINT        IDENTITY (1, 1) NOT NULL,
    [Description] VARCHAR (500) NULL,
    [Type]        VARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

