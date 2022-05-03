﻿/**
 * 
 * @Havelpot ~RandyERobinson The Solution appended to this UI of Restraunt will communicate to the user.
 * 
 * Functionality will be as follows:
    - add a new user
    - ability to search user as admin
    - display details of a restaurant for user
    - add reviews to a restaurant as a user
    - view details of restaurants as a user
    - view reviews of restaurants as a user
    - calculate reviews’ average rating for each restaurant
    - search restaurant (by name, rating, zip code, etc.)
 * 
 * 
 **/
global using Serilog;
using System;
using RestrauntUI;
using RestrauntBL;
using RestaurantDL;

/**create and configure our logger
Log.Logger Ylogg= new LoggerConfiguration()
    .WriteTo.File("");**/
Restaurant imNewRestraunt= new Restaurant();
imNewRestraunt.RestaurantName = "nextTacoTruck";
DisplayMenu displayMenu = new DisplayMenu();
displayMenu.Start();