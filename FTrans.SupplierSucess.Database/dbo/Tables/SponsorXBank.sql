CREATE TABLE [dbo].[SponsorXBank] (
    [SponsorXBankID]     INT      IDENTITY (1, 1) NOT NULL,
    [SponsorID]          INT      NOT NULL,
    [BankID]             INT      NOT NULL,
    [ContractStartDate]  DATETIME NULL,
    [ContractExpiryDate] DATETIME NULL,
    [UpdatedBy]          BIGINT   NULL,
    [UpdatedDate]        DATETIME NULL,
    PRIMARY KEY CLUSTERED ([SponsorXBankID] ASC)
);

