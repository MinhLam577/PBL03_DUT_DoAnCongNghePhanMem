CREATE TABLE [dbo].[SV] (
    [ClassName] CHAR (15)  NULL,
    [Id]        CHAR (15)  NOT NULL,
    [Name]      NCHAR (30) NULL,
    [Dtb]       FLOAT (53) NULL,
    [NS]        DATE       NULL,
    [Gender]    BIT        NULL,
    [Picture]   BIT        NULL,
    [Hb]        BIT        NULL,
    [Cccd]      BIT        NULL,
    CONSTRAINT [PK_SV] PRIMARY KEY CLUSTERED ([Id] ASC)
);

