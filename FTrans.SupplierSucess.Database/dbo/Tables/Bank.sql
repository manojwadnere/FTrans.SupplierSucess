﻿CREATE TABLE [dbo].[Bank] (
    [BankID]            INT            IDENTITY (1, 1) NOT NULL,
    [Name]              VARCHAR (100)  NOT NULL,
    [ACHRountingNumber] INT            NULL,
    [BankAccountNumber] VARCHAR (50)   NULL,
    [Logo]              VARCHAR (1000) NULL,
    [UpdatedBy]         BIGINT         NULL,
    [UpdatedDate]       DATETIME       NULL,
    PRIMARY KEY CLUSTERED ([BankID] ASC)
);
