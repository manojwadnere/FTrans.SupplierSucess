CREATE TABLE [dbo].[Account] (
    [AccountID]     BIGINT        NOT NULL,
    [AccountNumber] INT           NULL,
    [AccountName]   VARCHAR (500) NULL,
    [AccountView]   BIT           NULL,
    [AccountType]   VARCHAR (500) NULL,
    PRIMARY KEY CLUSTERED ([AccountID] ASC)
);

