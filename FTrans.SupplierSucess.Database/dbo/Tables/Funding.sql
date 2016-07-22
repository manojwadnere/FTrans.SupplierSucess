CREATE TABLE [dbo].[Funding] (
    [FundingID]        BIGINT IDENTITY (1, 1) NOT NULL,
    [FundingAvailable] MONEY  NULL,
    [Funded]           MONEY  NULL,
    PRIMARY KEY CLUSTERED ([FundingID] ASC)
);

