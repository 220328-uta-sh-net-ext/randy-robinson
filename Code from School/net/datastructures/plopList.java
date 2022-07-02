/**
*  Randy Robinson 
*  CS 351
*  Participation Assignment 2
*
**/

   //import net.datastructures.Queue;
   //import net.datastructures.LinkedQueue;
   import net.datastructures.List;
   //import net.datastructures.LinkedStack;
   import net.datastructures.ArrayList;   
      
      public class plopList
      {
         int i=0;         
         public static void main (String[] args)
         {
           List<Integer> numberPlops= new ArrayList<>();
           //attempt to increment the value in the array list.
           /*while(numberPlops.isEmpty())
             {
               if (i>=0)
               {
                  numberPlops.add(0, 5,--); 
               }
               break; 
             }
             */
           numberPlops.add(0,5);
           numberPlops.add(1,4);
           numberPlops.add(2,3);
           numberPlops.add(3,2);
           numberPlops.add(4,1);
           numberPlops.add(5,0);
           // Prints out value of index 2
           System.out.println(numberPlops.get(2));
           // Removes value of index 2 and replaces it with desired integer
           numberPlops.set(2,45);
           // Print out the changed index
           System.out.println(numberPlops.get(2)); 
           
           
         }
      
      }