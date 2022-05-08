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
using System.Data.SqlClient;
using System;
using ThisRestUI;
using RestaurantModels;
using UserModel;
using ReviewModels;
using ThisRestDL;



//create and configure our logger
Log.Logger = new LoggerConfiguration()
    .WriteTo.Console().MinimumLevel.Debug()
    .WriteTo.File("./Logs/user.txt").MinimumLevel.Debug().MinimumLevel.Information()// we want to save the ;ogs in this file
    .CreateLogger();
string connectionStringFilePath = "../../../../PokemonDL/connection-string.txt";
string connectionString = File.ReadAllText(connectionStringFilePath);

IRestaurantRepo repository = new SqlRepository(connectionString);
IRestaurantLogic logic = new RestaurantLogic(repository);
RestaurantOps operations = new(repository);

Restaurant imNewRestraunt = new Restaurant();
imNewRestraunt.RestaurantName = "nextTacoTruck";
DisplayMenu displayMenu = new DisplayMenu();