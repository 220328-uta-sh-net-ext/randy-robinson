/**
* 
*  Randy Robinson
*  CS351 Spring 19
*  Assignment 0
*  
*  Code used from "Data Structures & Algorithms" Goodrich, Michael T., Tamassia, Roberto, Goldwasser, Michael, H.
*  @Covert, Jason
*
**/


// class below creates a linked class and places (Queue's) the values of the class to the linked Queue.
   import net.datastructures.Queue;
   import net.datastructures.LinkedQueue;
   import net.datastructures.Stack;
   import net.datastructures.LinkedStack;
   


   public class firstQueue //<E> implements Queue <E>
   {
   // Main Class to create Queue and Stack then pop off the stack, 
   // append it to the end of the queue. Then print out myQueue to the screen
   
         public static void main(String[] args)
         {
            Queue <String> myQueue= new LinkedQueue<>();
              
              myQueue.enqueue ("a");
              myQueue.enqueue ("m");
              myQueue.enqueue ("f");
              myQueue.enqueue ("z");
              
             while(!myQueue.isEmpty())
             {
               myQueue.enqueue ("9");
               myQueue.enqueue ("7");
               myQueue.enqueue ("5");
               break; 
             }
             
             
             
             // Removes the first value of myQueue
             //  myQueue.dequeue();
               
              Stack<Integer> myStack= new LinkedStack<>();
              
             
               myStack.push (9);
               myStack.push (7);
               myStack.push (5);
            // while loop added by @Covert   
               while( !myStack.isEmpty() ){
                  myQueue.enqueue( myStack.pop().toString() );
               }
              System.out.println(myQueue);
         }
   } 