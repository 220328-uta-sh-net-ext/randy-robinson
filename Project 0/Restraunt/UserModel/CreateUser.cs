﻿using RestrauntUI;
using RestrauntBL;

// This Model will use SQL queries to update and manage the User Table

namespace UserModel
{
    public class CreateUser
    {

        //Private properties of this class.
        private string UserName { get; set; }
        private string FirstName { get; set; }
        public string LastName { get; set; }
        public enum UserEnum { Admin = 0, Doctor = 1, }
        public CreateUser()
        {
            UserName = " Havelpot ";
            FirstName = "-";
            LastName = "-";

        }
    }

}