using System;

namespace Day6
{
	interface StackADT
	{
		Boolean isEmpty();
		void Push(Object element);
		Object Pop();
		Object Peek();
		void Display();
	}
	class stack : StackADT
	{
		private int StackSize;
		public int StackSizeSet
		{
			get { return StackSize; }
			set { StackSize = value; }
		}
		public int top;
		Object[] item;
		public stack()
		{
			StackSizeSet = 10;
			item = new Object[StackSizeSet];
			top = -1;
		}
		public stack(int capacity)
		{
			StackSizeSet = capacity;
			item = new Object[StackSizeSet];
			top = -1;
		}
		public bool isEmpty()
		{
			if (top == -1) return true;

			return false;
		}
		public void Push(object element)
		{
			if (top == (StackSize - 1))
			{
				Console.WriteLine("Stack is full!");
			}

			else
			{

				item[++top] = element;
				Console.WriteLine("Item pushed successfully!");
			}
		}
		public object Pop()
		{
			if (isEmpty())
			{
				Console.WriteLine("Stack is empty!");
				return "No elements";
			}
			else
			{

				return item[top--];
			}
		}
		public object Peek()
		{
			if (isEmpty())
			{

				Console.WriteLine("Stack is empty!");
				return "No elements";
			}
			else
			{
				return item[top];
			}
		}


		public void Display()
		{
			for (int i = top; i > -1; i--)
			{

				Console.WriteLine("Item {0}: {1}", (i + 1), item[i]);
			}
		}
	}
}


