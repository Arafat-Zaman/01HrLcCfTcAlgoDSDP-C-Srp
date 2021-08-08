using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
namespace HackerRank
{

	class Node02
	{
		public int data;
		public Node02 next;
		public Node02(int d)
		{
			data = d;
			next = null;
		}
	}
	class Day24_MoreLinkedLists
	{

		public static Node02 removeDuplicates(Node02 head)
		{
			var Node02Current = head;
			while (Node02Current.next != null)
			{
				if (Node02Current.data == Node02Current.next.data)
					Node02Current.next = Node02Current.next.next;
				else
					Node02Current = Node02Current.next;
			}

			return head;
		}

		public static Node02 insert(Node02 head, int data)
		{
			Node02 p = new Node02(data);

			if (head == null)
				head = p;
			else if (head.next == null)
				head.next = p;
			else
			{
				Node02 start = head;
				while (start.next != null)
					start = start.next;
				start.next = p;
			}
			return head;
		}
		public static void display(Node02 head)
		{
			Node02 start = head;
			while (start != null)
			{
				Console.Write(start.data + " ");
				start = start.next;
			}
		}

		static void Main(String[] args)
		{
			Node02 head = null;
			int T = Int32.Parse(Console.ReadLine());
			while (T-- > 0)
			{
				int data = Int32.Parse(Console.ReadLine());
				head = insert(head, data);
			}
			head = removeDuplicates(head);
			display(head);
		}
	}
}