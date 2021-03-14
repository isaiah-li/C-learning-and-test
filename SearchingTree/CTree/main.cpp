#include <stdio.h>
#include "config.h"

typedef struct _Node Node;
struct _Node
{
	int num;
	Node *left;
	Node *right;
};
void *BuildTree(int value[], int le, int right);


int main()
{
	Node *root = new Node();
	root->num = 10;
	int arr[10] = { 9,5,8,4,2,3,6,9,14,7 };
	root = (Node*)BuildTree(arr, 0, 10);

	return 0;
}


void* BuildTree(int value[], int lowindex, int highindex)
{
	if (lowindex > highindex)
	{
		return nullptr;
	}


	int midindex = lowindex + (highindex - lowindex) / 2;
	Node node;
	node.num = value[midindex];
	node.left = new Node();
	node.left = (Node*)BuildTree(value, lowindex, midindex);
	node.right = new Node();
	node.right = (Node*)BuildTree(value, lowindex, midindex);
	return &node;

	
}


//static Node GetTree(int[] values, int li, int hi)
//{
//	if (li > hi)
//	{
//		return null;
//	}
//	var mi = li + (hi - li) / 2;
//	var node = new Node(values[mi]);
//	node.Left = GetTree(values, li, mi - 1);
//	node.Right = GetTree(values, mi + 1, hi);
//	return node;
//}