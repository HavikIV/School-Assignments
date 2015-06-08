#ifndef H_UnorderedLinkedList
#define H_UnorderedLinkedList

#include "linkedList.h"
  
using namespace std; 

template <class Type>
class unorderedLinkedList: public linkedListType<Type>
{
public:
    bool search(const Type& searchItem) const;
      //Function to determine whether searchItem is in the list.
      //Postcondition: Returns true if searchItem is in the 
      //               list, otherwise the value false is 
      //               returned.

    void insertFirst(const Type& newItem);
      //Function to insert newItem at the beginning of the list.
      //Postcondition: first points to the new list, newItem is
      //               inserted at the beginning of the list,
      //               last points to the last node in the  
      //               list, and count is incremented by 1.

    void insertLast(const Type& newItem);
      //Function to insert newItem at the end of the list.
      //Postcondition: first points to the new list, newItem 
      //               is inserted at the end of the list,
      //               last points to the last node in the 
      //               list, and count is incremented by 1.

    void deleteNode(const Type& deleteItem);
      //Function to delete deleteItem from the list.
      //Postcondition: If found, the node containing 
      //               deleteItem is deleted from the list.
      //               first points to the first node, last
      //               points to the last node of the updated 
      //               list, and count is decremented by 1.

    void mergeSort();
	void setitems();
	int getAssignments();
	int getComparsions();

private:
    void recMergeSort(nodeType<Type>* &head);
    void divideList(nodeType<Type>* first1, 
                    nodeType<Type>* &first2);
    nodeType<Type>* mergeList(nodeType<Type>* first1, 
                              nodeType<Type>* first2);
	int itemAssignments, itemComparsions;

};


template<class Type>
bool unorderedLinkedList<Type>::
                   search(const Type& searchItem) const
{
    nodeType<Type> *current; //pointer to traverse the list
    bool found = false;
    
    current = first; //set current to point to the first 
                     //node in the list

    while (current != NULL && !found)    //search the list
        if (current->info == searchItem) //searchItem is found
            found = true;
        else
            current = current->link; //make current point to
                                     //the next node
    return found; 
}//end search

template<class Type>
void unorderedLinkedList<Type>::insertFirst(const Type& newItem)
{
   nodeType<Type> *newNode; //pointer to create the new node

   newNode = new nodeType<Type>; //create the new node

   assert(newNode != NULL);      //if unable to allocate memory, 
                                 //terminate the program

   newNode->info = newItem; 	   //store the new item in the node
   newNode->link = first;        //insert newNode before first
   first = newNode;              //make first point to the 
                                 //actual first node
   count++; 			   //increment count

   if (last == NULL)   //if the list was empty, newNode is also 
                      //the last node in the list
      last = newNode;
}//end insertFirst

template<class Type>
void unorderedLinkedList<Type>::insertLast(const Type& newItem)
{
    nodeType<Type> *newNode; //pointer to create the new node

    newNode = new nodeType<Type>; //create the new node

    assert(newNode != NULL);    //if unable to allocate memory,
                                //terminate the program

    newNode->info = newItem;   //store the new item in the node
    newNode->link = NULL;   //set the link field of newNode
                            //to NULL

    if (first == NULL)  //if the list is empty, newNode is 
                        //both the first and last node
    {
        first = newNode;
        last = newNode;
        count++;        //increment count
    }
    else    //the list is not empty, insert newNode after last
    {
        last->link = newNode; //insert newNode after last
        last = newNode; //make last point to the actual 
                        //last node in the list
        count++;        //increment count
    }
}//end insertLast


template<class Type>
void unorderedLinkedList<Type>::deleteNode(const Type& deleteItem)
{
    nodeType<Type> *current; //pointer to traverse the list
    nodeType<Type> *trailCurrent; //pointer just before current
    bool found;

    if (first == NULL)    //Case 1; the list is empty. 
        cout << "Cannot delete from an empty list."
             << endl;
    else
    {
        if (first->info == deleteItem) //Case 2 
        {
            current = first;
            first = first->link;
            count--;
            if (first == NULL)    //the list has only one node
                last = NULL;
            delete current;
        }
        else //search the list for the node with the given info
        {
            found = false;
            trailCurrent = first;  //set trailCurrent to point
                                   //to the first node
            current = first->link; //set current to point to 
                                   //the second node

            while (current != NULL && !found)
            {
                if (current->info != deleteItem) 
                {
                    trailCurrent = current;
                    current = current-> link;
                }
                else
                    found = true;
            }//end while

            if (found) //Case 3; if found, delete the node
            {
                trailCurrent->link = current->link;
                count--;

                if (last == current)   //node to be deleted 
                                       //was the last node
                    last = trailCurrent; //update the value 
                                         //of last
                delete current;  //delete the node from the list
            }
            else
                cout << "The item to be deleted is not in "
                     << "the list." << endl;
        }//end else
    }//end else
}//end deleteNode

template <class Type>
void unorderedLinkedList<Type>::
               divideList(nodeType<Type>* first1, 
                          nodeType<Type>* &first2)
{
    nodeType<Type>* middle;
    nodeType<Type>* current;

    if (first1 == NULL)   //list is empty
	{
        first2 = NULL;
		itemAssignments += 1;
	}
    else if (first1->link == NULL)  //list has only one node
	{
        first2 = NULL;
		itemAssignments += 1;
	}
    else
    {
        middle = first1;
        current = first1->link;
		itemAssignments += 2;

        if (current != NULL)    //list has more than two nodes
            current = current->link;
		itemComparsions += 1;
        while (current != NULL)
        {
            middle = middle->link;
            current = current->link;
			itemAssignments += 2;
            if (current != NULL)
                current = current->link;
			itemComparsions += 2;
        } //end while

        first2 = middle->link; //first2 points to the first 
                               //node of the second sublist
        middle->link = NULL;   //set the link of the last node
                               //of the first sublist to NULL
		itemAssignments += 2;
    } //end else
	itemComparsions += 2;
} //end divideList

template<class Type>
nodeType<Type>* unorderedLinkedList<Type>::
                  mergeList(nodeType<Type>* first1, 
                            nodeType<Type>* first2)
{
    nodeType<Type> *lastSmall; //pointer to the last node of 
                               //the merged list
    nodeType<Type> *newHead;   //pointer to the merged list

    if (first1 == NULL)   //the first sublist is empty
        return first2;
    else if (first2 == NULL)   //the second sublist is empty
        return first1;
    else
    {
        if (first1->info < first2->info) //compare the 
                                         //first nodes
        {
            newHead = first1;  
            first1 = first1->link;
            lastSmall = newHead;
			itemAssignments += 3;
        }
        else
        {
            newHead = first2;
            first2 = first2->link;
            lastSmall = newHead;
			itemAssignments += 3;
        }
		itemComparsions += 1;
        while (first1 != NULL && first2 != NULL)
        {
            if (first1->info < first2->info)
            {
                lastSmall->link = first1;
                lastSmall = lastSmall->link;
                first1 = first1->link;
				itemAssignments += 3;
            }
            else
            {
                lastSmall->link = first2;
                lastSmall = lastSmall->link;
                first2 = first2->link;
				itemAssignments += 3;
            }
			itemComparsions += 2;
        } //end while

        if (first1 == NULL) //first sublist is exhausted first
            lastSmall->link = first2;
        else               //second sublist is exhausted first
            lastSmall->link = first1;

        return newHead;
    } 
	itemComparsions += 2;
}//end mergeList

template<class Type>
void unorderedLinkedList<Type>::recMergeSort(
                                    nodeType<Type>* &head)
{
    nodeType<Type> *otherHead;

    if (head != NULL)  //if the list is not empty
	{
        if (head->link != NULL)  //if the list has more than 
                                 //one node
        {
            divideList(head, otherHead);
            recMergeSort(head);
            recMergeSort(otherHead);
            head = mergeList(head, otherHead);
			itemAssignments += 1;
        }
		itemComparsions += 1;
	}
} //end recMergeSort

template<class Type>
void unorderedLinkedList<Type>::mergeSort()
{
    recMergeSort(first);

    if (first == NULL)
        last = NULL;
    else
    {
        last = first;
		itemAssignments += 1;
        while (last->link != NULL)
		{
            last = last->link;
			itemComparsions += 1;
		}
    }
} //end mergeSort

template<class Type>
int unorderedLinkedList<Type>::getAssignments()
{
	return itemAssignments;
}

template<class Type>
int unorderedLinkedList<Type>::getComparsions()
{
	return itemComparsions;
}

template<class Type>
void unorderedLinkedList<Type>::setitems()
{
	itemAssignments = 0;
	itemComparsions = 0;
}

#endif
