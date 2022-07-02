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
import java.util.ArrayList;
import java.util.Comparator;




      public class StudentHeapSort{
         
         static Comparator myComp;
         String myString= null;
         int crapola= 0;
            
         static PriorityQueue<Student, Object> lastNames= new HeapPriorityQueue<>(myComp);
         static PriorityQueue<Student, Object> firstNames= new HeapPriorityQueue<>();
         static PriorityQueue<Student, Object> myAges= new HeapPriorityQueue<>();
         static PriorityQueue<Student, Object> myMajors= new HeapPriorityQueue<>();
         static PriorityQueue<Student, Object> myGPA= new HeapPriorityQueue<>();
         //Open the file
         //read Student & add to heap
         
         
          public static Comparator<Student> getComparatorByLastName Comparator(){
                  
               return new getComparatorByLastName();
               
          }
          
              
                         
      }