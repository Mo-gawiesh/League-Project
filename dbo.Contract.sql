CREATE TABLE [dbo].[Contract] (
    [id]      INT           IDENTITY (1, 1) NOT NULL,
    [surname] NVARCHAR (50) NULL,
    [name]    NVARCHAR (50) NULL,
    [payment] MONEY         NULL,
    [term]    INT           NULL,
    CONSTRAINT [PK_Contract] PRIMARY KEY CLUSTERED ([id] ASC)
);

