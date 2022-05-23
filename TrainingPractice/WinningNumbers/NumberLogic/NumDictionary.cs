using System;
using Microsoft.Data.SqlClient;

namespace NumberLogic

{
    public class NumDictionary <T>
    {
        readonly string yourNumbers;
        public NumDictionary(string yourNumbers) { this.yourNumbers = yourNumbers; }
        

        public SqlDataReader NumberReader= null;
        public LinkedList<T> tKey = new LinkedList<T> ();



        
 
    }
}