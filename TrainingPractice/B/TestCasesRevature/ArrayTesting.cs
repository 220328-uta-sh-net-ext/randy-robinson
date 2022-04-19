using System;
namespace TestCasesRevature
{
    public class ArrayTesting
    {   
    public static string secretWord(int N,string S)
    {
        //this is default OUTPUT. You can change it.
        string result = "-404";
        string[] alphArray= new string[N];
        string input = String.Empty;
        try
        {
            int numResult = Int32.Parse(input);
            Console.WriteLine(numResult);
        }
        catch (FormatException)
        {
            Console.WriteLine($"Unable to parse '{input}'");
        }
        
        return result;
    }
    }
}