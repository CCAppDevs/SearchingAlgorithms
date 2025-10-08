using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchingAlgorithms
{
    public class CustomLinkedList
    {
        // this is the linked list container - Represents the whole list

        // THE MOST IMPORTANT - do not lose this ever
        private Node head;

        public CustomLinkedList()
        {
            head = null;
        }

        // add a new node to the end list
        public void AddToBack(string value)
        {
            Node obj = new Node(value);

            // is head null, if so insert @ head
            if (head == null)
            {
                head = obj;
                return;
            }

            // start at the head
            Node pos = head;

            // loop until i get to the end of the list
            while (pos.next != null)
            {
                pos = pos.next;
            }

            // add the new node there
            pos.next = obj;
        }

        // add something to the list at a specific position

        // remove something from the list at a specific position

        // to string the list
    }
}
