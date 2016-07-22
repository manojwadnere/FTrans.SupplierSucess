CREATE TABLE [dbo].[Notification] (
    [NotificationID]    BIGINT        IDENTITY (1, 1) NOT NULL,
    [ImportanceLevelID] SMALLINT      NULL,
    [Title]             VARCHAR (100) NULL,
    [Description]       VARCHAR (500) NULL,
    [StartDate]         DATETIME      NULL,
    [EndDate]           DATETIME      NULL,
    [CreatedBy]         BIGINT        NULL,
    [CreatedDate]       DATETIME      NULL,
    [UpdatedBy]         BIGINT        NULL,
    [UpdatedDate]       DATETIME      NULL,
    PRIMARY KEY CLUSTERED ([NotificationID] ASC)
);

