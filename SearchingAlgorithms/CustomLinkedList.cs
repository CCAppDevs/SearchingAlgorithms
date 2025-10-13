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

        public CustomLinkedList(string value)
        {
            head = new Node(value);
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

        // add to front
        public void AddToFront(string value)
        {
            Node oldHead = head; // bookmarking it
            head = new Node(value); // replacing it
            head.next = oldHead; // putting the rest of the list back in line
        }

        // insert alphabetically
        public void Add(string value)
        {
            Node pos = head;
            Node obj = new Node(value);

            // nothing in the list, add at front
            if (pos == null)
            {
                head = obj;
                return;
            }

            // position somewhere in the middle, walk the list until we find where to insert
            while (pos.data.CompareTo(obj.data) > 0)
            {
                pos = pos.next;
            }

            obj.next = pos.next;
            pos.next = obj;


            //// position is at the end of the list, add at back
            //if (pos.next == null)
            //{
            //    pos.next = obj;
            //    return;
            //}

        }

        public override string? ToString()
        {
            string result = "";
            Node pos = head;

            // head is empty, return nothing
            if (pos == null)
            {
                return result;
            }

            // head has contents, loop over it, printing the data
            while (pos != null)
            {
                result += pos.data;
                pos = pos.next;
            }

            return result;
        }

        // add something to the list at a specific position

        // remove something from the list at a specific position

        // to string the list

    }
}
