CREATE TABLE [dbo].[PaymentTerms] (
    [PaymentTermsID]   SMALLINT      NOT NULL,
    [PaymentTermsName] VARCHAR (200) NULL,
    [Description]      VARCHAR (500) NULL,
    PRIMARY KEY CLUSTERED ([PaymentTermsID] ASC)
);

