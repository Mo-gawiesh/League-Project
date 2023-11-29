CREATE TABLE [dbo].[Status] (
    [id]  INT           IDENTITY (1, 1) NOT NULL,
    [tag] NVARCHAR (50) NULL,
    CONSTRAINT [PK_Status] PRIMARY KEY CLUSTERED ([id] ASC)
);

