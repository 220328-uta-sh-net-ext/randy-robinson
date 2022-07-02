/**
*     Randy E. Robinson
*     CS351 Spring 2019
*     Homework 5  
*
*     This class creates a Student class that will use a Comparator and define the Student class. To be used in the 
*     Homework 5 that will allow the Heap Sort to work.
*
**/ 

import java.util.Comparator;
import net.datastructures.HeapPriorityQueue;
import net.datastructures.Queue;
import net.datastructures.AbstractPriorityQueue;
import net.datastructures.PriorityQueue;
import java.util.ArrayList;


      public class Student{
            
            private static double gpa;
            private static String lastName;
            private static String firstName;
            private static String major;
            private static int age;
            
            //This method creates a student
            public Student(String lastName, String firstName, int age, double gpa, String major){
                  this.lastName= lastName;
                  this.firstName= firstName;
                  this.age= age;
                  this.gpa= gpa;
                  this.major= major;            
            }

                     
      }