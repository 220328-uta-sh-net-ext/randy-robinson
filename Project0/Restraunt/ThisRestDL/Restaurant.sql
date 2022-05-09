
/**-----------------------------------------------------------------------
                            Create Tables
-----------------------------------------------------------------------**/

CREATE TABLE [dbo].[Users]
(
    [UserTagNumber] INT NULL,
    [Username] NVARCHAR(100) NOT NULL PRIMARY KEY,
    [FirstName] NVARCHAR(40) NULL,
    [LastName] NVARCHAR(50) NULL,
    [Password] NVARCHAR(20) NULL
);
--Drop table Users
GO
CREATE TABLE [dbo].[Restaurants]
(
   [RestaurantIdseed] INT NOT NULL PRIMARY KEY,
   [RestaurantName] NVARCHAR(50) NULL,
   [RestaurantCity] NVARCHAR(50) NULL,
   [RestaurantState] NVARCHAR(5) NULL,
   [RestaurantZip] INT NULL,
   [RestaurantAvgRating] INT NULL
);
--Drop table Restaurants
GO
CREATE TABLE [dbo].[Reviews]
(
   [ReviewID] INT Primary Key,
   [RestaurantName] NVARCHAR(50) NOT NULL ,
   [Username] NVARCHAR(100) NULL,
   [Rating] INT NULL,
   [Note] NVARCHAR(200) NULL 
);
--Drop table Reviews
Select *
From Restaurants 
Select *
From Reviews
Select *
From Users