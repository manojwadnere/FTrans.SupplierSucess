CREATE TABLE [dbo].[TransactionTypeXAccounts] (
    [TransactionTypeXAccountsID] INT      NOT NULL,
    [TransactionTypeID]          SMALLINT NULL,
    [DebitAcctNo]                INT      NULL,
    [CreditAcctNo]               INT      NULL,
    PRIMARY KEY CLUSTERED ([TransactionTypeXAccountsID] ASC)
);

