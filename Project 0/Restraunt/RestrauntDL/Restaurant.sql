CREATE SCHEMA Restaurant
GO
-- The Tables associated with this Schema Restaurant

CREATE TABLE Restaurant.RestaurantID(
    RestaurantName NVARCHAR(150),
    RestaurantCity NVARCHAR(50),
    RestaurantState NVARCHAR(5),
    RestaurantZip NVARCHAR(5), 
    RestaurantReview NVARCHAR(5),

)
CREATE TABLE Restaurant.Users(
            UserTagNumber NVARCHAR(5),
            UserName NVARCHAR(5),
            FirstName NVARCHAR(5), 
            LastName NVARCHAR(5),
            Password NVARCHAR(5)
)
SELECT*
FROM Restaurant.Users
