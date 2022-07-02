/**
*  
*  Randy Robinson
*  CS 351 Spring 2019
*  Homework  !2
*
*  This assignment will take in a collection of parenthesized arithmetic expressions from a file using two Stacks (or 
*  more) The general flow will be ask for file,read in file, parse with a scanner, While file not empty read in line, 
*  while line isn't empty: if value numeric push onto operand stack, if text push on operator stack. if left ( encountered
*  push onto ( stack. if right ) pop off two operands pop operator off stack Perform operation indicated. push answer
*  back onto operand stack. Part B of this program will take any file and print out the positional list and return the middle
*  of the positional list. 
* 
*  Homework 3 will modify the current state of homework 2 and will use the abstract data class tree to sort and build a proper binary
*  Tree. I will also remove instances of none used methods and modify accordinly others to satisfy requirements of the binary Tree. 
*
**/

import net.datastructures.LinkedStack;
import net.datastructures.Stack;
import net.datastructures.LinkedPositionalList;
import net.datastructures.PositionalList;
import net.datastructures.AbstractBinaryTree;
import net.datastructures.LinkedBinaryTree;
import net.datastructures.BinaryTree;
import net.datastructures.Tree;
import net.datastructures.Position;
import java.lang.Number;
import java.io.File;
import java.io.FileNotFoundException;
import java.util.Scanner;


public class ProcessInFixFromFile{

      static Stack<String> myLeftPar= new LinkedStack<>();
      static Stack<String> myRightPar= new LinkedStack<>();
      static Stack<String> myOperatorStack= new LinkedStack<>();
      static Stack<Number> myNumberStack= new LinkedStack<>();
      static LinkedPositionalList<String> myPosition= new LinkedPositionalList<>(); 
            
      // Super method that takes in multiple methods to create an output 
      public static void superReadFile (File yourFile ){
         Number nums= null;
         String oper1= null;
         String pars= null;
         String chooseWisely= null;
         Scanner numInput= null;         
         try{ numInput= new Scanner (yourFile); }
         catch(FileNotFoundException e){
            System.err.println("File not found in ArrayList. Please make sure your address location is correct.");
            System.exit(1);
         }
         //loop to read file and send information to the Stack methods
            while(numInput.hasNext()){
         
            if(numInput.hasNextInt() || numInput.hasNextDouble() || numInput.hasNextFloat() || numInput.hasNextLong()){
                           nums= numInput.nextDouble();
                           myNumbers(nums);
                           
            }
            else{
               chooseWisely= numInput.next();
               switch(chooseWisely){
                  case "+":
                      oper1= chooseWisely;
                      myOperators(oper1);
                      break;
                  
                  case "-":
                      oper1= chooseWisely;
                      myOperators(oper1);
                      break;
                  
                  case "*":
                      oper1= chooseWisely;
                      myOperators(oper1);
                      break;
                  
                  case "/":
                      oper1= chooseWisely;
                      myOperators(oper1);
                      break;
                  
                  case "(":
                      pars= chooseWisely;
                      myParentheses(pars);
                      break;
                  
                  case ")":
                      pars= chooseWisely;
                      myParentheses(pars);
                      break;
                  
                  default:
                      System.out.println("I'm sorry the value of "+ chooseWisely +" isn't a valid argument.");
               }
            }
         }
      }
         
      public static LinkedBinaryTree<String> myTree(Scanner nextScan){
         LinkedBinaryTree<String> left,right,parent;
         String tokens= null;
         Number nums1= null;
         
         while(!nextScan.hasNext()){
            
            if(nextScan.hasNextInt() || nextScan.hasNextDouble() || nextScan.hasNextFloat() || nextScan.hasNextLong()){
               nums1= nextScan.nextDouble();
               tokens= nums1.toString();
            }
            tokens= nextScan.next();
            if(tokens.equals("(")){
               left= myTree(nextScan);
            }
            if(nextScan.hasNextInt() || nextScan.hasNextDouble() || nextScan.hasNextFloat() || nextScan.hasNextLong()){
               nums1= nextScan.nextDouble();
            }
         }
      }
      
      
      public static Number myNumbers (Number num1){
         int size= myNumberStack.size();   
         myNumberStack.push(num1); 
         Number num2= null;
         Number value= null;
         Number temp= null;
            if(num1.equals(3.41E-11)){
                temp= myNumberStack.pop();
            }      
         String op1= "pOne";
         String par1= "match!";
         
                       
               while(myParentheses (par1)){
                  num2= myNumberStack.pop();
                  num1= myNumberStack.pop();
                  String operater1= myOperators(op1);
                  
                  if( operater1.equals ("+")){
                        System.out.println(num1 + operater1 + num2);
                        value= num1.doubleValue()+ num2.doubleValue();
                        myNumberStack.push(value);
                        size= myNumberStack.size();
                        System.out.println(" Here is the value of this evaluation: " + value);
                                               
                  }
                  else if( operater1.equals ("-")){
                        System.out.println(num1 + operater1 + num2);
                        value= num1.doubleValue()- num2.doubleValue();
                        myNumberStack.push(value);
                        size= myNumberStack.size();
                        System.out.println(" Here is the value of this evaluation: " + value);
                        
                  }
                  else if( operater1.equals ("*")){
                        System.out.println(num1 + operater1 + num2);
                        value= num1.doubleValue()* num2.doubleValue();
                        myNumberStack.push(value);
                        size= myNumberStack.size();
                        System.out.println(" Here is the value of this evaluation: " + value);
                        
                  }
                  else if( operater1.equals ("/")){
                        System.out.println(num1 + operater1 + num2);
                           if(num2.doubleValue()== 0){
                                 System.out.println("unable to divide by zero. Please check that your arithmetic is correct!");
                                 return num2;
                           }
                        value= num1.doubleValue()/ num2.doubleValue();
                        myNumberStack.push(value);
                        size= myNumberStack.size();
                        System.out.println(" Here is the value of this evaluation: " + value);
                        
                  }
                  System.out.println(" Here is the complete evaluation: " + value);
               }
         
         return value;      
      }
      //Method to take in operators and send information to myNumbers to be evaluated.
      public static String myOperators (String op1){
            
               String op2= op1;
               myOperatorStack.push(op1);
               int size= myOperatorStack.size();
               
               // return operator to myNumbers to be calculated and update size.
               if(op2.equals ("pOne")){
                  op2= myOperatorStack.pop();
                  op1= myOperatorStack.pop();
                  size= myOperatorStack.size();
                  return op1;
               }
               
         return op1;
      }
      
      public static boolean myParentheses (String par){
            String par2= null;
            int size1= myLeftPar.size();
            int size2= myRightPar.size();
                     
            if(par.equals ("(")){
               myLeftPar.push(par);
               size1= myLeftPar.size();
            }
            if(par.equals (")")){
               myRightPar.push(par);
               size2=myRightPar.size();
               //enter path to myNums to pop off per size =2
               if(size1==size2){
                  myNumbers(.0000000000341);
               }
            }
            if(par.equals ("match!")){
               if(size1==size2){
                  myRightPar.pop();
                  myLeftPar.pop();
                  par2= "match!";
                  par= par2;
                  size1--;
                  size2--;
               }
               if(size1< 0 || size2< 0){
                     size1= myLeftPar.size();
                     size2= myRightPar.size();
                     return false;
               }
               
               if(size1!= size2) {
                    // System.out.println("Unable to process your file correctly! please fix and re-submit file please. ");
                     
                     return false;
               }
               
               return true;
            }
            return true;
      }
      
      public static String thePositionIs (File yourFile){
         String firstPosition= null;
         String modifiedPosition= null;
         Position <String> middle= null;
         int sizePosition= myPosition.size();   
         Scanner stringInput= null;         
         try{ stringInput= new Scanner (yourFile); }
         catch(FileNotFoundException e){
            System.err.println("File not found in ArrayList. Please make sure your address location is correct.");
            System.exit(1);
         }
         //loop to read file and be processed as a positional List
         System.out.println("Please note that this is part B: ");
         while(stringInput.hasNext()){
              firstPosition=stringInput.next();
              sizePosition= myPosition.size();
                        if(myPosition.isEmpty()){
                              middle= myPosition.addFirst(firstPosition);
                              sizePosition=myPosition.size();
                        } 
                        
                        if(sizePosition% 2== 0){
                               //update middle Position
                               middle= myPosition.addAfter(middle,firstPosition);
                               sizePosition= myPosition.size();
                               System.out.println("The current state of the positional list: " + myPosition);
                        }
                        else {
                              myPosition.addAfter(middle,firstPosition);
                              System.out.println("The current state of the positional list: " + myPosition);
                        }
                        
                }
           modifiedPosition= myPosition.remove(middle);
           System.out.println("This is the middle " + modifiedPosition);
           return firstPosition;
      }
      
      
      
      public static void main(String[] args){
         Scanner linkedStackOrQueue= new Scanner(System.in);
         Scanner linkedPosition= new Scanner(System.in);
         System.out.println(" Please enter file to compare values: ");
         String inLinkedPath= linkedStackOrQueue.next();
         File linkedFile= new File(inLinkedPath);
         
         superReadFile(linkedFile);
         
         System.out.println(" Please enter the next information you would like the system to process: ");
         inLinkedPath=linkedPosition.next();
         thePositionIs(linkedFile);
                                                
      }   


}

