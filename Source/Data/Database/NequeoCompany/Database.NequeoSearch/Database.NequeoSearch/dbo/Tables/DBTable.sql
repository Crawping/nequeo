﻿CREATE TABLE [dbo].[DBTable] (
    [TableID]   BIGINT        IDENTITY (1, 1) NOT NULL,
    [TableName] VARCHAR (500) NOT NULL,
    CONSTRAINT [PK_DBTable] PRIMARY KEY CLUSTERED ([TableID] ASC)
);

