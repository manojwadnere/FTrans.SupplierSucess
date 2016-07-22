CREATE TABLE [dbo].[ReportFrequency] (
    [ReportFrequencyID]   SMALLINT      NOT NULL,
    [ReportFrequencyCode] VARCHAR (200) NULL,
    [Description]         VARCHAR (500) NULL,
    PRIMARY KEY CLUSTERED ([ReportFrequencyID] ASC)
);

