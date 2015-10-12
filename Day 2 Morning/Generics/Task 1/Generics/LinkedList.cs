using System;

namespace Generics
{
	public class LinkedList<T>
	{
		/// <summary>
		/// In Linked List each element (we will call it a node) of a list is comprising of two items - the data and a reference to the next node. 
		/// </summary>
		public class Node
		{
			public Node next = null;
			public object data;
		}
		/// <summary>
		/// The entry point into a linked list is called the head of the list. If the list is empty then the head is a null reference.
		/// </summary>
		private Node head = null;

		public Node First { get { return head; } }

		/// <summary>
		/// Returns the count of Nodes in linked list
		/// </summary>
		public int Count {
			get
			{
				
				Node curr = head;
				if (curr == null)
					return 0;
				
				int count = 1;
				while (curr.next != null) 
				{
					count++;
					curr = curr.next;
				}
				return count;
			}
		}

		/// <summary>
		/// Gives the last node in the linked list
		/// </summary>
		public Node Last 
		{
			get
			{
				Node curr = head;
				if (curr == null)
					return null;
				while (curr.next != null)
					curr = curr.next;
				return curr;
			}
		}

		/// <summary>
		/// Adds a new Value by creating a new node
		/// </summary>
		public void Add(T value)
		{
			Node n = new Node { data = value };
			if (head == null)
				head = n;
			else
				Last.next = n;
		}

		/// <summary>
		/// Removes a node from the linked list
		/// </summary>
		/// <param name="n">N.</param>
		public void Remove(Node n)
		{
			if (head == n) 
			{
				head = n.next;
				n.next = null;
			}
			else
			{
				Node curr = head;
				while (curr.next != null)
				{
					if (curr.next == n)
					{
						curr.next = n.next;
						n.next = null;
						break;
					}
					curr = curr.next;
				}
			}
		}

		/// <summary>
		/// Finds whether a value is present. If present returns the same and logs the appropriate message
		/// </summary>
		public T Find (T value)
		{

			Node curr = First;
			if (curr == null) 
			{
				Console.WriteLine ("No Such Value Found and the Linked List is Empty");
				return default(T);
			}

			while (curr.next != null) 
			{
				if(curr.data.Equals(value))
				{
					Console.WriteLine ("Value Found: {0}", curr.data);
					return (T)curr.data;
				}
				curr = curr.next;
			}

			Console.WriteLine ("No Such Value Found");
			return default(T);
		}
	}
}

