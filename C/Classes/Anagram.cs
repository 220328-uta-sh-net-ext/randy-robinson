using System;
using Classes;


namespace Classes
{
    public class Anagram
    {
        //properties of Anagram
        // string s1;
        //string s2;
        

        
      
        //method to create an Anagram
        public static bool Anagrams(string s1, string s2)
        {
            char[]inputStr1= s1.ToCharArray();
            char[]inputStr2= s2.ToCharArray();

            if(s1.Length== s2.Length)
            {
                //Taking the first Char[] in 
                for(int i= 0; i<=inputStr1.Length; i++)
                {
                        char jumpto= 'a';
                        char jumpout= 'b';
                    foreach (var item in inputStr1)
                    {
                        // char match do this:

                        if(item== inputStr2[i])
                        {
                            jumpto= inputStr2[i];
                            jumpout= item;
                            
                            if(jumpto== jumpout)
                            {
                                Console.Write($"Hey, hey, these letters match {jumpto} {jumpout}"); 
                                Console.WriteLine("this is an anagram!");  
                            }
                            else
	                        {
                                Console.WriteLine("I haven't figured this out sad face");
	                        }
                             //Console.WriteLine("True");
                            //return true;      // 
                        }
                        else
                        {
                           Console.WriteLine("This is not a Anagram");
                           return true;
                            //return false;//chars do not match do this:
                        }//else

                    }

                } 
            }
             /*   for(int i=0; i<N; i++){                        
                    int index=allLetters.IndexOf(inputStr[i]);
                    result += allLetters[allLetters.Length-1-index];
        }*/
            return true;
        }


    //Constructor class
        public Anagram(string s1, string s2)
        {
            
            //throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            string inputStr1= s1;
            string inputStr2= s2;
            Anagrams(inputStr1, inputStr2);
        }
    }
}