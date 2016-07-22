CREATE TABLE [dbo].[Fields] (
    [FieldID]         SMALLINT      NOT NULL,
    [FieldName]       INT           NULL,
    [FieldType]       VARCHAR (200) NULL,
    [FileTypeID]      SMALLINT      NULL,
    [IsRequiredField] BIT           NULL,
    PRIMARY KEY CLUSTERED ([FieldID] ASC)
);

