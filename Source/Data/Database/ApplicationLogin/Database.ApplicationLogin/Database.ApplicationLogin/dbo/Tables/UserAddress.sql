﻿CREATE TABLE [dbo].[UserAddress] (
    [UserAddressID]  BIGINT         IDENTITY (1, 1) NOT NULL,
    [FirstName]      VARCHAR (50)   NOT NULL,
    [LastName]       VARCHAR (50)   NOT NULL,
    [Address1]       VARCHAR (200)  NULL,
    [Address2]       VARCHAR (200)  NULL,
    [Suburb]         VARCHAR (50)   NULL,
    [StateID]        BIGINT         NULL,
    [PostCode]       VARCHAR (4)    NULL,
    [CountryID]      BIGINT         NULL,
    [PhoneNumber]    VARCHAR (50)   NULL,
    [FaxNumber]      VARCHAR (50)   NULL,
    [MobileNumber]   VARCHAR (50)   NULL,
    [EmailAddress]   VARCHAR (100)  NULL,
    [WebSite]        VARCHAR (500)  NULL,
    [Comments]       VARCHAR (1000) NULL,
    [ModifiedDate]   DATETIME       NULL,
    [RowVersionData] ROWVERSION     NULL,
    [UserSuspended]  BIT            NOT NULL,
    [DepartmentID]   BIGINT         NULL,
    CONSTRAINT [PK_UserAddress] PRIMARY KEY CLUSTERED ([UserAddressID] ASC),
    CONSTRAINT [FK_UserAddress_Country] FOREIGN KEY ([CountryID]) REFERENCES [dbo].[Country] ([CountryID]),
    CONSTRAINT [FK_UserAddress_Department] FOREIGN KEY ([DepartmentID]) REFERENCES [dbo].[Department] ([DepartmentID]),
    CONSTRAINT [FK_UserAddress_State] FOREIGN KEY ([StateID]) REFERENCES [dbo].[State] ([StateID])
);

