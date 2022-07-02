package edu.wiu.cs351;
/*
   CS351, Spring 2019
   Covert
   Student Class  Solution
*/
import java.time.LocalDate;
import java.time.Period;
import java.util.Comparator;

public class Student{
   private String firstName, lastName, major;
   private LocalDate dob;
   private int hoursAttempted;
   private int qualityPoints;
   
   // constructor
   public Student(String fn, String ln, String m, int month, int day, int year, int hours, int points ){
      firstName = fn;
      lastName = ln;
      major = m;
      dob = LocalDate.of(year,month,day);
      hoursAttempted = hours;
      qualityPoints = points;
   }
   
   // accessors
   public int getAge(){
      return Period.between(dob,LocalDate.now()).getYears();
   } 

   public double getGPA(){
      return ((double)qualityPoints)/hoursAttempted;
   }
   
   public String getLastName(){
      return lastName;
   }
   
   public String getFirstName(){
      return firstName;
   }    

   public String getMajor(){
      return major;
   }
   
   // toString for testing
   public String toString(){
      return lastName + ", " + firstName + "\nMajor = " + major + "\nAge = " + getAge() + "\nGPA = " + getGPA() + "\n";
   }
   
   /** TODO: add Comparator methods
   *     Comparator methods added by Randy E. Robinson
   *     Homework 5
   *     CS 351 Spring 2019
   *
   **/
   
   //This method is to compare students by last name.
      public static class getComparatorByLastName implements Comparator<Student>{
               
           public int compare(Student s1, Student s2){
                     return s1.lastName.toLowerCase().compareTo(s2.lastName.toLowerCase());
           }
                                   
      }
    //This method is to compare students by first name.        
      public static class getComparatorByFirstName implements Comparator<Student>{
               
           public int compare(Student s1, Student s2){
                     return s1.firstName.toUpperCase().compareTo(s2.firstName.toUpperCase());
           }
                    
      }
   //This method is to compare students by major.       
      public static class getComparatorByMajor implements Comparator<Student>{
               
           public int compare(Student s1, Student s2){
                     return s1.major.toUpperCase().compareTo(s2.major.toUpperCase());
           }
                    
      }
   //This method is to compare students by GPA         
      public static class getComparatorByGPA implements Comparator<Student>{
            // I reviewed following site to understand comparator with double type:: @Stack overflow   
            public int compare(Student s1, Student s2){
                  double grade= s1.getGPA()- s2.getGPA();
                  if(grade> 0.01){return 1;}
                  if(grade< -0.01){return -1;}
                  else{return 0;}
            }
                  
      }
   //This method is to compare students by Age         
      public static class  getComparatorByAge implements Comparator<Student>{
           // Used similar implementation as double because the comparator needs to return int 1,-1,0 when comparing    
           public int compare(Student s1, Student s2){
                 int age= s1.getAge()-s2.getAge();
                 if(age> 0){return 1;}
                 if(age< 0){return -1;}
                 else{return 0;}
           }
                    
      }
   
}