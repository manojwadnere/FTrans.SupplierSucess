CREATE TABLE [dbo].[FundingChoice] (
    [FundingChoiceID]          SMALLINT      NOT NULL,
    [FundingChoiceCode]        VARCHAR (200) NULL,
    [FundingChoiceDescription] VARCHAR (500) NULL,
    PRIMARY KEY CLUSTERED ([FundingChoiceID] ASC)
);

