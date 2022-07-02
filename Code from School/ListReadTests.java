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
      Integer [] data3= new Integer[capasity];
      
      File inputFile= new File("P:\\TestData\\TestData\\1024.txt");
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
        //method to call to implement SSL 
        public static List<Integer> arrayList2 (ArrayList<Integer> numberPlops,  File f)
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
                          numberPlops.add(i,in.nextInt());
               
                        else
                        in.next();
                     }
               return numberPlops;
        }
        //method to time SSL
        public static long testListAdd(List<Integer> list, Integer[]data)
        {
          long startTime= System.currentTimeMillis(); //if nano time is desired:  
               for(int i= 0; i<data.length;i++){     //System.nanoTime();
                  list.add(0, data[i]);
               }
               
          long endTime= System.currentTimeMillis();
          long value= endTime-startTime;
          return value;
           
        }
        
        // Main Method to compare Big O timing of java.util vs net.dataStructures vs SSL
        public static void main(String[] args)
        {        
            Scanner testAL= null;
            Scanner testAL2= null;
            Scanner testAL3= null;
            Scanner testAL4= null;
            Scanner testMe= new Scanner(System.in);
            Scanner sizeMe= new Scanner(System.in);
            Scanner listMe= new Scanner(System.in);
            Scanner listMeAgain= new Scanner(System.in);
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
            //ArrayList <Integer> testReadArray3= new ArrayList<>();
            ArrayList <Integer> testReadArray4= new ArrayList<>();
            List <Integer> myList= new ArrayList<>();
            List <Integer> myList2= new ArrayList<>();
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
              System.out.println("Would you like to test this with the Java.Util Array or a SSL? " + "\n"); 
              System.out.println("For Java.Util please enter 1 for SSL please enter 2, Or if you are finished please enter 0 ");
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
               if(xYes== 2){
                   System.out.println("Please input file address location for our test: ");
                   String inPath3= listMe.next();
                   File testFile3= new File(inPath3);
                   /*ArrayList <Integer> myList= new ArrayList<>();
                   arrayList2(myList,testFile3 );
                   */
                   System.out.println("Enter the size of your Array: ");
                   int sizeFinally3= listMeAgain.nextInt();
                   Integer [] data3= new Integer[sizeFinally3]; 
                      try{ testAL3= new Scanner (testFile3); }
                      catch(FileNotFoundException e){
                         System.err.println("File not found in ArrayList. Please make sure your address location is correct.");
                         System.exit(1);
                      }
                      int k= 0;
                      int l= 0;
                        testAL4= testAL3;
                        while(testAL3.hasNext()){
                              if(testAL3.hasNextInt())
                                 myList2.add(k,testAL3.nextInt());
                              else
                                 testAL3.next();
                     }          
                             
                          while(testReadArray4.isEmpty()){
                  
                             while(testAL4.hasNext()){
                                data3[l++]= testAL4.nextInt();
                             }          
                          testReadArray4.add(0,69);   
                       
                       }
                       long nextValue2= testListAdd(myList2 , data3); 
                       System.out.println("\n" + "It took the System " + nextValue2 +" milliseconds to process the List.");   
                }
                
                
                else 
                   return;
                     
             }
            
      }
   