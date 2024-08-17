USE [BookManagementDB]
GO
/****** Object:  StoredProcedure [dbo].[spInsertBookCategory]    Script Date: 17-08-2024 14:18:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create Procedure [dbo].[spInsertBookCategory]
@Name varchar(50),
@Discription varchar(1000),
@IsActive bit = 1
AS
BEGIN
  Insert into TBOOKCATEGORY (Name,Discription,IsActive)
  Values(@Name,@Discription,@IsActive)
END
GO
