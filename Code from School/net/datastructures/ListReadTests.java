/*
*
* Randy Robinson
* CS 351 Spring 2019
* Homework 1
*
**/

import net.datastructures.ArrayList;
import net.datastructures.List;
import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;

   public class ListReadTests
   {
      private int capasity= 1000000;
      Integer [] data= new Integer[capasity];
      Integer [] data2= new Integer[capasity];
      File inputFile= new File("C:\\Users\\goodh\\TestData1\\TestData\\65536.txt");
     /**
     *   After this assignment was completed I realized I could just call method ArrayList(File f, Integer[] data)
     *   I then simply could've created java.util.ArrayList(File h, Integer[] data2) method
     *   called both methods and implemented code to obtain information from user.
     *   oh well, not changing. I learned a lot from my over indulgence in killing and over expressing the assignment.
     *   @~Randy
     **/
      public static void ArrayList(File f,Integer[] data)
      {
         Scanner in= null;
         try{ in= new Scanner (f); }
         catch(FileNotFoundException e){
            System.err.println("File not found in ArrayList. Please make sure your address location is correct.");
            System.exit(1);
         }
         int i= 0;
         while(in.hasNext()){
            if(in.hasNextInt())
               data[i++]= in.nextInt();
            else
               in.next();
         }
         
        }
        //Method to Time net.datastructures ArrayList          
        public static long testArrayListAdd(ArrayList<Integer> list, Integer[]data)
        {
          long startTime= System.currentTimeMillis(); //if nano time is desired:  
               for(int i= 0; i<data.length;i++){     //System.nanoTime();
                  list.add(0, data[i]);
               }
               
          long endTime= System.currentTimeMillis();
          long value= endTime-startTime;
          return value;
           
        }
        //Method to Time java.util.ArrayList
        public static long testArrayListAdd2(java.util.ArrayList<Integer> list, Integer[]data)
        {
          long startTime= System.currentTimeMillis(); //if nano time is desired:  
               for(int i= 0; i<data.length;i++){     //System.nanoTime();
                  list.add(0, data[i]);
               }
               
          long endTime= System.currentTimeMillis();
          long value= endTime-startTime;
          return value;
           
        }
       //method to implement SSL to test timing.
        public static List ArrayList2(File f,Integer[] data)
        {
              Scanner in= null;
              try{ in= new Scanner (f); }
              catch(FileNotFoundException e){
              System.err.println("File not found in ArrayList. Please make sure your address location is correct.");
              System.exit(1);
         }
         int i= 0;
         while(in.hasNext()){
            if(in.hasNextInt())
               data[i++]= in.nextInt();
            else
               in.next();
         }
         return data;
        }
        // Main Method to compare Big O timing of java.util vs net.dataStructures
        public static void main(String[] args)
        {        
            Scanner testAL= null;
            Scanner testAL2= null;
            Scanner testMe= new Scanner(System.in);
            Scanner sizeMe= new Scanner(System.in);
            
               System.out.println("Please input file address location for our test: ");
               String inPath= testMe.next();
               File testFile= new File(inPath);
               System.out.println("Enter the size of your Array: ");
               int sizeFinally= sizeMe.nextInt();
               Integer [] data= new Integer[sizeFinally];
                  try{ testAL= new Scanner (testFile); }
                  catch(FileNotFoundException e){
                     System.err.println("File not found in ArrayList. Please make sure your address location is correct.");
                     System.exit(1);
                  } 
            ArrayList <Integer> testReadArray= new ArrayList<>();
            ArrayList <Integer> readArray= new ArrayList<>();
            java.util.ArrayList <Integer> readNextArray= new java.util.ArrayList<>();
            ArrayList <Integer> testReadArray2= new ArrayList<>();
            int i=0;
            while(testReadArray.isEmpty()){
                  
                  while(testAL.hasNext()){
                    data[i++]= testAL.nextInt();
                  }          //Below is code that attempts to copy the integer range.
                     //Integer copyData []= new Integer [capasity];
                     //copyData.copyOfRange(data,copyData);
                     testReadArray.add(0,69);   
                     /*How can I get data to be static?*/
                     
                     //Integer [] myData= data[data.length];    
            }     
               //Timing Array iteration.
              long value= testArrayListAdd(readArray, data); 
              //System.out.println(readArray);
              System.out.println("\n" + "It took the System " + value +" milliseconds to process this Array");
              Scanner javaUtilTest= new Scanner(System.in);
              System.out.println("Would you like to test this with the Java.Util Array 1 for yes 0 for no? ");
              int xYes= javaUtilTest.nextInt();
               if(xYes== 1){
                   System.out.println("Please input file address location for our test: ");
                   String inPath2= testMe.next();
                   File testFile2= new File(inPath2);
                   System.out.println("Enter the size of your Array: ");
                   int sizeFinally2= sizeMe.nextInt();
                   Integer [] data2= new Integer[sizeFinally2]; 
                      try{ testAL2= new Scanner (testFile2); }
                      catch(FileNotFoundException e){
                         System.err.println("File not found in ArrayList. Please make sure your address location is correct.");
                         System.exit(1);
                      }
                      int j= 0;
                        while(testReadArray2.isEmpty()){
                  
                             while(testAL2.hasNext()){
                                data2[j++]= testAL2.nextInt();
                             }          
                          testReadArray2.add(0,69);   
                       
                       }
               
               
               long nextValue= testArrayListAdd2( readNextArray, data2); 
               System.out.println("\n" + "It took the System " + nextValue +" milliseconds to process the java.util.ArrayList.");                   
                        }
                else 
                   return;
                     
        }
            
      
           
   }