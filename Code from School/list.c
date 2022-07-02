/*CS 410 Programming Assignment 0
You are only allowed to modify void insert(),  void dequeue(), void pop(), and void sort()
DO NOT MAKE ANY CHANGES TO OTHER PART OF THE CODE
You may modify the main() to test your program but change it back to the orignal main()
when you turn in your code.
@ Bui, Hoang

*  Randy Robinson
*  CS 410 Spring 2019
*  list.c is an imported c program created by Dr. Hoang Bui, Assistant Professor, School of Computer Science
*  void insert(), dequeue(), pop(), and sort() created by @~Randy

*/

#include<stdio.h>
#include<stdlib.h>
#include<string.h>

// Create a node that will act as a pointer to the head and the next subsequent node till points to null

   struct node {
   	int n;
   	struct node *next;
   };

// Creation of global variable node Head & Tail of the Stack / Queue

   struct node *head= NULL;
   struct node *tail= NULL;

// Output to the screen made available by this method.

   void print(){
      	struct node * current = head;
        
         	while(current!=NULL){
                   printf("%d ", current->n);
                   current=current->next;

            }
      	printf("\n");

   }
// Insertion of integer to the Stack or Queue made available by this method.

   void insert(int number){
      struct node *temp= malloc(sizeof(struct node));
      temp n-> number;
      temp-> next= NULL;
         if(head== NULL){
            head= temp;
			tail= head;
         }
        // Insertion of new element in Stack.
		else {
			tail->next = temp;
			tail= temp;
		 }
            
      return;
      
   }

   void dequeue(){
	   // Print out current head node
	   printf("dequeued node %d \n", head->n);
	   head = head->next;
   }


   void pop(){
	   // Attempt to print out current tail node commented out causes segmentation error

		//printf("tail node is %d ", tail-> n);
		/**while(head!= tail){
				tail= head-> next;
		}**/
		// temp node pointing to current tail, tail pointing  NULL, attempting to have tail= NULL;
	   struct node *temp = malloc(sizeof(struct node));
	   temp->n = tail->n;
	   temp->next = NULL;
	   //temp= tail;
	   tail = temp;
	   temp = tail;

   }


   void sort(){

	   // method to sort remaining arguments left in the list. Bubble sort information derived from
	   // java a beginners guide inplementation in C programming language // the C programming language
	   // @Kernighan, @Ritchie second edition
	   int after, before, size, temp;
	   int n = head->n;
	   size = 4; // array size by argument.
	   for (after = 0; after < size; after++) {
		   for (before = size - 1; before >= after; before--) {
			   if (head->n <= head->next->n)
				   temp = n;
			   n = head->n;
			   head->n = temp;

		   }


	   }

   }







   int main(int argc, char * argv[]){

      int i;
	   for(i=1;i<argc;i++){
	   	insert(atoi(argv[i]));

	   }


	   dequeue();
	
	   pop();
	
	   pop();

	   sort();

	   print();

	   return 0;

   }
