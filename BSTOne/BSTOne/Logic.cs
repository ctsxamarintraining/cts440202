using System;

namespace BSTOne
{

	public class Node
	{
		public Node left;
		public int data;
		public Node right;

		public    Node(int value)
		{

			left = null;
			data = value;
			right = null;
		}
	}

	public class createView
	{


	}

	public class list
	{
		private Node startNode;

		public int level=0;

		public    list()
		{
			startNode = null;
		}
		public    void printAllNodes(Node pointer)
		{
			//            moveForwadFromNode (pointer);
			//            moveBackwardFromNode (pointer);
		}
		public void moveForwadFromNode(Node n)
		{
			while (n != null) {
				Console.WriteLine (n.data);
				n = n.right;
			}
			Console.WriteLine ("End of Forward");
		}
		public void moveBackwardFromNode(Node n)
		{
			while (n!= null) {
				Console.WriteLine (n.data);
				n = n.left;
			}
			Console.WriteLine ("End of backward");
		}


		public void Insert(Node incomingNode)
		{

			if (startNode == null) {
				startNode = incomingNode;
			} 
			else {
				Node tempNode = startNode;

				while (incomingNode.data>tempNode.data) {
					if (tempNode.right != null) {
						tempNode = tempNode.right;
						level++;

					}
					else
						tempNode.right = incomingNode;

				}
				while (incomingNode.data < tempNode.data ) {
					if (tempNode.left != null) {
						tempNode = tempNode.left;
						level++;
					}
					else
						tempNode.left = incomingNode;
				}

			}
		}
	}


}
public class BinaryTree
{
	public BinaryTree ()
	{
	}



}

