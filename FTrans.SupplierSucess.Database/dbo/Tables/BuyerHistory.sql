CREATE TABLE [dbo].[BuyerHistory] (
    [BuyerHistoryID]        BIGINT         IDENTITY (1, 1) NOT NULL,
    [BuyerID]               INT            NOT NULL,
    [Name]                  VARCHAR (100)  NOT NULL,
    [ACHRountingNumber]     INT            NULL,
    [BankAccountNumber]     VARCHAR (50)   NULL,
    [DiversityPayRate]      MONEY          NULL,
    [ProcessingRate]        MONEY          NULL,
    [Rate]                  MONEY          NULL,
    [FloorForLiborRate]     MONEY          NULL,
    [Logo]                  VARCHAR (1000) NULL,
    [ReportFrequencyID]     SMALLINT       NULL,
    [FinancialDaysToReport] SMALLINT       NULL,
    [ReportingPeriodEnd]    DATETIME       NULL,
    [UpdatedBy]             BIGINT         NULL,
    [UpdatedDate]           DATETIME       NULL,
    PRIMARY KEY CLUSTERED ([BuyerHistoryID] ASC)
);

