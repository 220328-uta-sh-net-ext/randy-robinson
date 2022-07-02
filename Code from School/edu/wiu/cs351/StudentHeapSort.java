package edu.wiu.cs351;
/**
*     Randy Robinson
*     Homework 5
*     CS351 Spring 2019
*  
*     This program will create 5 heap Priority queues that will create five student objects: StudentHeapSort creates five HeapPriorityQueues
*     from net.datastructures. HeapPriorityQueues use the each of the Comparator<Student> comparators are:
*     getComparatorByLastName() sorts in ascending order by last name, based on case-insensitive alphabetical order 
*     getComparatorByFirstName() sorts in ascending order by first name, based on case sensitive alphabetical order 
*     getComparatorByAge() sorts in descending order by age (that is, oldest students first when sorting on this field)
*     getComparatorByGPA() sorts in descending order by GPA, rounded to 2 decimal places. Decimal places are used in the ordering correctly.
*     getComparatorByMajor() sorts in ascending order by Major, based on case-insensitive alphabetical order 
*
**/
import net.datastructures.HeapPriorityQueue;
import net.datastructures.Queue;
import net.datastructures.AbstractPriorityQueue;
import net.datastructures.PriorityQueue;
import net.datastructures.ArrayList;
import java.util.Comparator;
import java.util.Scanner;
import java.io.File;
import java.io.FileNotFoundException;



      public class StudentHeapSort{
         
         static Comparator myComp;
         String myString= null;
         int crapola= 0;
            
         static PriorityQueue<Object, Student> lastNames= new HeapPriorityQueue<>();
         static PriorityQueue<Object, Student> firstNames= new HeapPriorityQueue<>();
         static PriorityQueue<Object, Student> myAges= new HeapPriorityQueue<>();
         static PriorityQueue<Object, Student> myMajors= new HeapPriorityQueue<>();
         static PriorityQueue<Object, Student> myGPA= new HeapPriorityQueue<>();
         
         
          public static Comparator<Student> getComparatorByLastName(Student s){
                  
               return new Student.getComparatorByLastName();
               
          }
          public static Comparator<Student> getComparatorByFirstName(Student s){
                  
               return new Student.getComparatorByFirstName();
               
          }
          public static Comparator<Student> getComparatorByAge(Student s){
                  
               return new Student.getComparatorByAge();
               
          }
          public static Comparator<Student> getComparatorByMajor(Student s){
                  
               return new Student.getComparatorByMajor();
               
          }
          public static Comparator<Student> getComparatorByGPA(Student s){
                  
               return new Student.getComparatorByGPA();
               
          }
          
          
          public static void main (String args[]){
          
               Scanner myScan= new Scanner(System.in);
               System.out.println(" Please enter address location for students.csv: ");
               String inLinkedPath= myScan.next();
               File linkedFile= new File(inLinkedPath);
               try{
                     myScan= new Scanner(linkedFile);
               }
               catch( FileNotFoundException e ){
                     System.err.println( "Can't find students.csv!" );
                     System.exit(1);
               }
               myScan.useDelimiter(",|\\r\\n|\\n" );
               ArrayList <Student> myArray= new ArrayList<>();
               while(myScan.hasNext()){
                        Student stu1= new Student(myScan.next(), myScan.next(), myScan.next(),myScan.nextInt(), myScan.nextInt(), myScan.nextInt(),myScan.nextInt(), myScan.nextInt());
                        int i= 0;
                        myArray.add(i,stu1);
                        i++;
                          // lastNames.insert(stu1, null);
               } 
               int y=0;
               String yoYo= null;
               //getComparatorByLastName(myArray.remove(y));          
               Scanner scan= new Scanner(System.in);
               System.out.println("To sort by Last Name enter: L , First Name enter F, Age enter A, GPA enter G, Major enter M... Entries are case sensitive. ");
                    yoYo= scan.next();
                        switch (yoYo){
                           
                           case "L":
                                 while(!myArray.isEmpty()){
                                       int i= 0;
                                       lastNames.insert(getComparatorByLastName(myArray.remove(i)),null);
                                       i++;
                                 }
                                 break;
                     
                           case "F":
                                 while(!myArray.isEmpty()){
                                       int i= 0;
                                       firstNames.insert(getComparatorByFirstName(myArray.remove(i)),null);
                                       i++;
                                 }
                                 break;
                     
                           case "A":
                                 while(!myArray.isEmpty()){
                                       int i= 0;
                                       myAges.insert(getComparatorByAge(myArray.remove(i)),null);
                                       i++;
                                 }
                                 break;      
                     
                           case "G":
                                 while(!myArray.isEmpty()){
                                       int i= 0;
                                       myGPA.insert(getComparatorByGPA(myArray.remove(i)),null);
                                       i++;
                                 }
                                 break;
                           case "M":
                                 while(!myArray.isEmpty()){
                                       int i= 0;
                                       myMajors.insert(getComparatorByMajor(myArray.remove(i)),null);
                                       i++;
                                 }
                                 break;
                     
                           default:
                                 System.out.println("please enter a valid option L,F,A,G or M : ");
                     }
                     
                 }              
          
          }    
                         
      