//Header File Binary Search Tree
#ifndef H_binaryTree
#define H_binaryTree
 
#include <iostream> 

using namespace std; 

    //Definition of the Node
template <class elemType>
struct nodeType
{
    elemType info;
    nodeType<elemType> *lLink;
    nodeType<elemType> *rLink;
};
	
    //Definition of the class
template <class elemType>
class binaryTreeType
{
public:
    const binaryTreeType<elemType>& operator=
                 (const binaryTreeType<elemType>&); 
      //Overload the assignment operator.

    bool isEmpty() const;
      //Function to determine whether the binary tree is empty.
      //Postcondition: Returns true if the binary tree is empty;
      //               otherwise, returns false.

    void inorderTraversal() const;
      //Function to do an inorder traversal of the binary tree.
      //Postcondition: Nodes are printed in inorder sequence.

	void inorderTraversalandCopy(binaryTreeType<elemType>& otherTree) const;

    void preorderTraversal() const;
      //Function to do a preorder traversal of the binary tree.
      //Postcondition: Nodes are printed in preorder sequence.

	void preorderTraversalandCopy(binaryTreeType<elemType>& otherTree) const;

    void postorderTraversal() const;
      //Function to do a postorder traversal of the binary tree.
      //Postcondition: Nodes are printed in postorder sequence.

	void postorderTraversalandCopy(binaryTreeType<elemType>& otherTree) const;

    int treeHeight() const;
      //Function to determine the height of a binary tree.
      //Postcondition: Returns the height of the binary tree.

    int treeNodeCount() const;
      //Function to determine the number of nodes in a 
      //binary tree.
      //Postcondition: Returns the number of nodes in the 
      //               binary tree.

    int treeLeavesCount() const;
      //Function to determine the number of leaves in a 
      //binary tree.
      //Postcondition: Returns the number of leaves in the 
      //               binary tree.

    void destroyTree();
      //Function to destroy the binary tree.
      //Postcondition: Memory space occupied by each node 
      //               is deallocated.
      //               root = NULL;

	void swapTrees() const;

    virtual bool search(const elemType& searchItem) const = 0;
      //Function to determine if searchItem is in the binary 
      //tree.
      //Postcondition: Returns true if searchItem is found in 
      //               the binary tree; otherwise, returns 
      //               false.

    virtual void insert(const elemType& insertItem) = 0;
      //Function to insert insertItem in the binary tree.
      //Postcondition: If there is no node in the binary tree
      //               that has the same info as insertItem, a
      //               node with the info insertItem is created
      //               and inserted in the binary search tree.

    virtual void deleteNode(const elemType& deleteItem) = 0;
      //Function to delete deleteItem from the binary tree 
      //Postcondition: If a node with the same info as 
      //               deleteItem is found, it is deleted from
      //               the binary tree.
      //               If the binary tree is empty or 
      //               deleteItem is not in the binary tree, 
      //               an appropriate message is printed.

    binaryTreeType(const binaryTreeType<elemType>& otherTree); 
      //Copy constructor

    binaryTreeType();   
      //Default constructor

    ~binaryTreeType();   
      //Destructor

protected:
    nodeType<elemType>  *root;

private:
    void copyTree(nodeType<elemType>* &copiedTreeRoot,
                  nodeType<elemType>* otherTreeRoot);
      //Makes a copy of the binary tree to which 
      //otherTreeRoot points. 
      //Postcondition: The pointer copiedTreeRoot points to
      //               the root of the copied binary tree.

    void destroy(nodeType<elemType>* &p);
      //Function to destroy the binary tree to which p points. 
      //Postcondition: Memory space occupied by each node, in 
      //               the binary tree to which p points, is 
      //               deallocated.
      //               p = NULL;

    void inorder(nodeType<elemType> *p) const;
      //Function to do an inorder traversal of the binary
      //tree to which p points.  
      //Postcondition: Nodes of the binary tree, to which p
      //               points, are printed in inorder sequence.

	void inorderandCopy(nodeType<elemType> *p, binaryTreeType<elemType>& otherTree) const;

    void preorder(nodeType<elemType> *p) const;
      //Function to do a preorder traversal of the binary
      //tree to which p points.  
      //Postcondition: Nodes of the binary tree, to which p
      //               points, are printed in preorder 
      //               sequence.

	void preorderandCopy(nodeType<elemType> *p, binaryTreeType<elemType>& otherTree) const;

    void postorder(nodeType<elemType> *p) const;
      //Function to do a postorder traversal of the binary
      //tree to which p points.  
      //Postcondition: Nodes of the binary tree, to which p
      //               points, are printed in postorder 
      //               sequence.

	void postorderandCopy(nodeType<elemType> *p, binaryTreeType<elemType>& otherTree) const;

    int height(nodeType<elemType> *p) const;
      //Function to determine the height of the binary tree
      //to which p points. 
      //Postcondition: Height of the binary tree to which 
      //               p points is returned.

    int max(int x, int y) const;
      //Function to determine the larger of x and y.
      //Postcondition: Returns the larger of x and y.

    int nodeCount(nodeType<elemType> *p) const;
      //Function to determine the number of nodes in 
      //the binary tree to which p points. 
      //Postcondition: The number of nodes in the binary 
      //               tree to which p points is returned.

    int leavesCount(nodeType<elemType> *p) const;
      //Function to determine the number of leaves in  
      //the binary tree to which p points 
      //Postcondition: The number of leaves in the binary 
      //               tree to which p points is returned.

	void swapSubtrees(nodeType<elemType> *p) const;
	  //Function to swap all of the left and right subtree
	  //of a binary tree.
	  //Postcondition: The left side shoukd be on the right side
	  //			   while the right should be on the left side.

};

	//Definition of member functions

template <class elemType>
binaryTreeType<elemType>::binaryTreeType()
{
    root = NULL;
}

template <class elemType>
bool binaryTreeType<elemType>::isEmpty() const
{
    return (root == NULL);
}

template <class elemType>
void binaryTreeType<elemType>::inorderTraversal() const
{
    inorder(root);
}

template <class elemType>
void binaryTreeType<elemType>::inorderTraversalandCopy(binaryTreeType<elemType>& otherTree) const
{
    inorderandCopy(root, otherTree);
}

template <class elemType>
void binaryTreeType<elemType>::preorderTraversal() const
{
    preorder(root);
}

template <class elemType>
void binaryTreeType<elemType>::preorderTraversalandCopy(binaryTreeType<elemType>& otherTree) const
{
    preorderandCopy(root, otherTree);
}

template <class elemType>
void binaryTreeType<elemType>::postorderTraversal() const
{
    postorder(root);
}

template <class elemType>
void binaryTreeType<elemType>::postorderTraversalandCopy(binaryTreeType<elemType>& otherTree) const
{
    postorderandCopy(root, otherTree);
}

template <class elemType>
int binaryTreeType<elemType>::treeHeight() const
{
    return height(root);
}

template <class elemType>
int binaryTreeType<elemType>::treeNodeCount() const
{
    return nodeCount(root);
}

template <class elemType>
int binaryTreeType<elemType>::treeLeavesCount() const
{
    return leavesCount(root);
}

template <class elemType>
void binaryTreeType<elemType>::swapTrees() const
{
	swapSubtrees(root);
}

template <class elemType>
void  binaryTreeType<elemType>::copyTree
                       (nodeType<elemType>* &copiedTreeRoot,
                        nodeType<elemType>* otherTreeRoot)
{
    if (otherTreeRoot == NULL)
        copiedTreeRoot = NULL;
    else
    {
        copiedTreeRoot = new nodeType<elemType>;
        copiedTreeRoot->info = otherTreeRoot->info;
        copyTree(copiedTreeRoot->lLink, otherTreeRoot->lLink);
        copyTree(copiedTreeRoot->rLink, otherTreeRoot->rLink);
    }
} //end copyTree

template <class elemType>
void binaryTreeType<elemType>::inorder
                              (nodeType<elemType> *p) const
{
    if (p != NULL)
    {
        inorder(p->lLink);
        cout << p->info << " ";
        inorder(p->rLink);
    }
}

template <class elemType>
void binaryTreeType<elemType>::inorderandCopy
                              (nodeType<elemType> *p, binaryTreeType<elemType>& otherTree) const
{
    if (p != NULL)
    {
        inorderandCopy(p->lLink, otherTree);
        cout << p->info << " ";
		otherTree.insert(p->info);
        inorderandCopy(p->rLink, otherTree);
    }
}

template <class elemType>
void binaryTreeType<elemType>::preorder
                              (nodeType<elemType> *p) const
{
    if (p != NULL)
    {
        cout << p->info << " ";
        preorder(p->lLink);
        preorder(p->rLink);
    }
}

template <class elemType>
void binaryTreeType<elemType>::preorderandCopy
                              (nodeType<elemType> *p, binaryTreeType<elemType>& otherTree) const
{
    if (p != NULL)
    {
        cout << p->info << " ";
		otherTree.insert(p->info);
		preorderandCopy(p->lLink, otherTree);
        preorderandCopy(p->rLink, otherTree);
    }
}

template <class elemType>
void binaryTreeType<elemType>::postorder
                              (nodeType<elemType> *p) const
{
    if (p != NULL)
    {
        postorder(p->lLink);
        postorder(p->rLink);
        cout << p->info << " ";
    }		
}

template <class elemType>
void binaryTreeType<elemType>::postorderandCopy
                              (nodeType<elemType> *p, binaryTreeType<elemType>& otherTree) const
{
    if (p != NULL)
    {
        postorderandCopy(p->lLink, otherTree);
        postorderandCopy(p->rLink, otherTree);
		cout << p->info << " ";
		otherTree.insert(p->info);
    }
}

   //Overload the assignment operator
template <class elemType>
const binaryTreeType<elemType>& binaryTreeType<elemType>::
        operator=(const binaryTreeType<elemType>& otherTree)
{ 
    if (this != &otherTree) //avoid self-copy
    {
        if (root != NULL)   //if the binary tree is not empty,
                            //destroy the binary tree
            destroy(root);

        if (otherTree.root == NULL) //otherTree is empty
            root = NULL;
        else
            copyTree(root, otherTree.root);
    }//end else

    return *this; 
}

template <class elemType>
void  binaryTreeType<elemType>::destroy(nodeType<elemType>* &p)
{
    if (p != NULL)
    {
        destroy(p->lLink);
        destroy(p->rLink);
        delete p;
        p = NULL;
    }
}

template <class elemType>
void  binaryTreeType<elemType>::destroyTree()
{
    destroy(root);
}

	//copy constructor
template <class elemType>
binaryTreeType<elemType>::binaryTreeType
                (const binaryTreeType<elemType>& otherTree)
{
    if (otherTree.root == NULL) //otherTree is empty
        root = NULL;
    else
        copyTree(root, otherTree.root);
}

    //Destructor
template <class elemType>
binaryTreeType<elemType>::~binaryTreeType()
{
    destroy(root);
}

template<class elemType>
int binaryTreeType<elemType>::height
                             (nodeType<elemType> *p) const
{
    if (p == NULL)
        return 0;
    else
        return 1 + max(height(p->lLink), height(p->rLink));
}

template <class elemType>
int binaryTreeType<elemType>::max(int x, int y) const
{
    if (x >= y)
        return x;
    else
        return y;
}

template <class elemType>
int binaryTreeType<elemType>::nodeCount(nodeType<elemType> *p) const
{
    if (p != NULL)
    {
        if (p->lLink == NULL && p->rLink == NULL) // checks to see if both sides are NULL
		{
			return 1;
		}
		else if (p->lLink == NULL && p->rLink != NULL) // Checks to see if only the left side is NULL
			return nodeCount(p->rLink) + 1;
		else if (p->lLink != NULL && p->rLink == NULL) // Checks to see if only the right side is NULL
			return nodeCount(p->lLink) + 1;
		else // else both sides are not NULL
			return nodeCount(p->lLink) + nodeCount(p->rLink) + 1;
    }


    return 0;
}

template <class elemType>
int binaryTreeType<elemType>::leavesCount(nodeType<elemType> *p) const
{
	if (p != NULL)
    {
        if (p->lLink == NULL && p->rLink == NULL) // checks to see if both sides are NULL
		{
			return 1;
		}
		else if (p->lLink == NULL && p->rLink != NULL) // Checks to see if only the left side is NULL
			return leavesCount(p->rLink);
		else if (p->lLink != NULL && p->rLink == NULL) // Checks to see if only the right side is NULL
			return leavesCount(p->lLink);
		else // else both sides are not NULL
			return leavesCount(p->lLink) + leavesCount(p->rLink);
    }
}

template <class elemType>
void binaryTreeType<elemType>::swapSubtrees(nodeType<elemType> *p) const
{
	nodeType<elemType> *temp;
	if (p != NULL)
	{
		temp = p->rLink;
		p->rLink = p->lLink;
		p->lLink = temp;
		if (p->lLink != NULL && p->rLink == NULL)
			swapSubtrees(p->lLink);
		else if (p->lLink == NULL && p->rLink != NULL)
			swapSubtrees(p->rLink);
		else if (p->lLink != NULL && p->rLink != NULL)
		{
			swapSubtrees(p->lLink);
			swapSubtrees(p->rLink);
		}

	}
}

#endif