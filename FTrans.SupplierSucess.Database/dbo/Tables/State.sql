CREATE TABLE [dbo].[State] (
    [StateID]   SMALLINT      IDENTITY (1, 1) NOT NULL,
    [StateCode] VARCHAR (3)   NULL,
    [StateName] VARCHAR (200) NULL,
    PRIMARY KEY CLUSTERED ([StateID] ASC)
);

