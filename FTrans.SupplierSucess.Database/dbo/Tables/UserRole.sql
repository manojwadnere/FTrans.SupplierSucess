CREATE TABLE [dbo].[UserRole] (
    [UserRoleID]   SMALLINT      NOT NULL,
    [UserRoleName] VARCHAR (100) NULL,
    [Description]  VARCHAR (500) NULL,
    PRIMARY KEY CLUSTERED ([UserRoleID] ASC)
);

