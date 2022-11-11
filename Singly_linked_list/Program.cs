using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singly_linked_list
{
    class Node
    {
        public int rollNumber;
        public string name;
        public Node next;
    }

    class List
    {
        Node START;
        public List()
        {
            START = null;
        }

        public void addNode() //add a node in list
        {
            int nim;
            String nm;
            Console.Write("\nEnter the roll number of the student : ");
            nim = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the name of the student: ");
            nm = Console.ReadLine();
            Node newnode = new Node();
            newnode.rollNumber = nim;
            newnode.name = nm;
            //untuk pengcekan apakah nimbisa di input ke awal list
            if (START == null || nim <= START.rollNumber)
            {
                if((START != null) && (nim == START.rollNumber))
                {
                    Console.WriteLine("\nDuplicate roll number not allowed\n");
                    return;
                }
                newnode.next = START;
                START = newnode;
                return;
            }

            //
            Node previous, current;
            previous = START;
            current = START;

            while((current != null) && (nim >= current.rollNumber))
            {
                if (nim == current.rollNumber)
                {
                    Console.WriteLine("\nDuplicate roll number not allowed\n");
                    return;
                }
                previous = current;
                current = current.next;
            }

            newnode.next = current;
            previous.next = newnode;

        }

        public void traverse()
        {
            if (listEmpty())
            {
                Console.WriteLine("\nList is Empty");

            }
            else
            {
                Console.WriteLine("\nThe records in the list are : ");
                Node currentNode;
                for(currentNode = START; currentNode!= null;
                    currentNode = currentNode.next)
                {
                    Console.Write(currentNode.rollNumber + " " + currentNode.name + "\n");
                }
                Console.WriteLine();
            }
        }

        public bool delNode(int nim)
        {
            Node previous, current;
            previous = current = null;
            //
            if (Search(nim, ref previous, ref current) == false)
            {
                return false;
            }
            previous.next = current.next;
            if(current == START)
            {
                START = START.next;
            }
            return true;
        }

        public bool Search(int nim, ref Node previous, ref Node current)
        {
            previous = START;
            current = START;
            
            while ((current != null) && (nim != current.rollNumber))
            {
                previous = current;
                current = current.next;

            }
            if (current == null)
            {
                return (false);
            }
            else
            {
                return (true);
            }
            
        }

        public bool listEmpty()
        {
            if(START == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List obj = new List();

            while (true)
            {
                try
                {

                }
                catch (Exception)
                {
                    Console.WriteLine("\nCheck for the value entered");
                }
            }
        }
    }
}
