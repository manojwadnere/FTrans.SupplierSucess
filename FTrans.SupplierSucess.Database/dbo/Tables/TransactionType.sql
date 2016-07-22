CREATE TABLE [dbo].[TransactionType] (
    [TransactionTypeID] SMALLINT      NOT NULL,
    [TransactionName]   VARCHAR (100) NULL,
    [Description]       VARCHAR (500) NULL,
    PRIMARY KEY CLUSTERED ([TransactionTypeID] ASC)
);

