CREATE TABLE [dbo].[UserNotification] (
    [UserNotificationID] BIGINT         IDENTITY (1, 1) NOT NULL,
    [UserID]             BIGINT         NOT NULL,
    [NotificationDate]   DATETIME       NOT NULL,
    [IsRead]             BIT            NOT NULL,
    [Message]            NVARCHAR (MAX) NOT NULL,
    [IsDeleted]          BIT            NOT NULL,
    [ValidTill]          DATETIME       NOT NULL,
    [CreatedBy]          BIGINT         NULL,
    [CreatedDate]        DATE           NULL,
    [UpdatedBy]          BIGINT         NULL,
    [UpdatedDate]        DATETIME       NULL,
    PRIMARY KEY CLUSTERED ([UserNotificationID] ASC)
);

