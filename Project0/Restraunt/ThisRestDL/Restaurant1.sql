
/**-----------------------------------------------------------------------
                            Create Tables
-----------------------------------------------------------------------**/

CREATE TABLE [dbo].[Users]
(
    [UserTagNumber] NVARCHAR(10) NULL,
    [Username] NVARCHAR(100) NOT NULL PRIMARY KEY,
    [FirstName] NVARCHAR(40) Not NULL,
    [LastName] NVARCHAR(50) Not NULL,
    [Password] NVARCHAR(20)NOt NULL
);
--Drop table Users
GO
CREATE TABLE [dbo].[Restaurants]
(
   [RestaurantIdseed] NVarChar(10) not NULL ,
   [RestaurantName] NVARCHAR(50) not NULL Primary Key,
   [RestaurantCity] NVARCHAR(50)  Not NULL,
   [RestaurantState] NVARCHAR(5) Not NULL,
   [RestaurantZip] INT Not NULL,
   [RestaurantAvgRating] INT Not NULL
);
--Drop table Restaurants
GO
CREATE TABLE [dbo].[Reviews]
(
   [ReviewID] INT Primary Key,
   [RestaurantName] NVARCHAR(50) NOT NULL ,
   [Username] NVARCHAR(100)not  NULL,
   [Rating] INT not NULL,
   [Note] NVARCHAR(200) not NULL 
);
--Drop table Reviews
Select *
From Restaurants 
Select *
From Reviews
Select *
From Users