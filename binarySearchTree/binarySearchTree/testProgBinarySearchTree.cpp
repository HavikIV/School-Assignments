 //Manjinder Singh
//CMPSC 261-2976
//Final Problem 5/1/2014
//How I solved this problem: I made copies of the inorder, preorder, and postorder functions and I added an addition parameter for the otherTree to copied into.
//							 Right after the funstions prints out the node, I had the functions insert the same node into the otherTree.
//Solutions:The height and leaves count i got T1(8, 6), T2(12, 6), T3(12, 6)
//			T1 postoder:10 30 28 35 40 60 62 72 55 88 90 85 80 75 98 96 99 95 50 34
//			T1 inorder:10 20 30 34 35 40 50 55 60 62 72 75 80 85 88 90 95 96 98 99
//			T1 preoder:34 28 10 30 50 40 35 95 75 55 72 62 60 80 85 90 88 99 96 98
//			T2 postoder:28 34 50 55 75 80 85 95 96 99 98 90 88 72 62 60 40 35 30 10
//			T2 inorder:10 20 30 34 35 40 50 55 60 62 72 75 80 85 88 90 95 96 98 99
//			T2 preoder:10 30 28 35 34 40 60 55 50 62 72 88 85 80 75 90 98 96 95 99
//			T3 postoder:28 34 50 55 75 80 85 95 96 99 98 90 88 72 62 60 40 35 30 10
//			T3 inorder:10 20 30 34 35 40 50 55 60 62 72 75 80 85 88 90 95 96 98 99
//			T3 preoder:10 30 28 35 34 40 60 55 50 62 72 88 85 80 75 90 98 96 95 99

#include "stdafx.h"
 
using namespace std;

int main() 
{
   bSearchTreeType<int> T1, T2, T3;
   int x[20] = {34, 50, 95, 75, 99, 40, 55, 28, 72, 80, 62, 96, 10, 60, 85, 35, 98, 90, 88, 30};

   for (int i = 0; i < 20; i++)
   {
	   T1.insert(x[i]);
   }

   T1.postorderTraversalandCopy(T2);
   cout << endl;
   T2.preorderTraversalandCopy(T3);
   cout << endl;
   T3.inorderTraversal();
   cout << endl;

   cout << "T1..." << endl;
   cout << T1.treeHeight() << " " << T1.treeLeavesCount();
   cout << endl << "T2..." << endl;
   cout << T2.treeHeight() << " " << T2.treeLeavesCount();
   cout << endl << "T3..." << endl;
   cout << T3.treeHeight() << " " << T3.treeLeavesCount();
   cout << endl << endl;

   cout << "T1..." << endl;
   cout << "postorder: ";
   T1.postorderTraversal();
   cout << endl << "inorder: ";
   T1.inorderTraversal();
   cout << endl << "preorder: ";
   T1.preorderTraversal();
   cout << endl << "T2..." << endl;
   cout << "postorder: ";
   T2.postorderTraversal();
   cout << endl << "inorder: ";
   T2.inorderTraversal();
   cout << endl << "preorder: ";
   T2.preorderTraversal();
   cout << endl << "T3..." << endl;
   cout << "postorder: ";
   T3.postorderTraversal();
   cout << endl << "inorder: ";
   T3.inorderTraversal();
   cout << endl << "preorder: ";
   T3.preorderTraversal();
   cout << endl;

    return 0;
}