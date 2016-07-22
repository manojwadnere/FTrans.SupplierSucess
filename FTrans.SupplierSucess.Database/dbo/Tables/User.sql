CREATE TABLE [dbo].[User] (
    [ID]                  BIGINT         IDENTITY (1, 1) NOT NULL,
    [UserName]            VARCHAR (100)  NOT NULL,
    [Password]            VARCHAR (50)   NOT NULL,
    [FirstName]           VARCHAR (100)  NULL,
    [LastName]            VARCHAR (100)  NULL,
    [Email]               NVARCHAR (100) NULL,
    [PhoneNumber]         VARCHAR (15)   NULL,
    [UserTypeID]          SMALLINT       NULL,
    [UserRoleID]          SMALLINT       NULL,
    [EntityID]            INT            NULL,
    [Active]              BIT            NULL,
    [NotificationOptID]   SMALLINT       NULL,
    [PasswordChangedDate] DATETIME       NULL,
    [CreatedBy]           BIGINT         NULL,
    [CreatedDate]         DATETIME       NULL,
    [UpdatedBy]           BIGINT         NULL,
    [UpdatedDate]         DATETIME       NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

