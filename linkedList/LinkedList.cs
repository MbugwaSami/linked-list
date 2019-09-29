using System;
namespace linkedList
{
    public class LinkedList
    {
        public Node head;
        public LinkedList()
        {
            this.head = null;
        }

        // Add new Node at the beggining
        public void addNode(string data)
        {

            // initilize Node instance
            var newNode = new Node(data);
            // point the new node to head
            newNode.next = this.head;
            // assign head to new node
            this.head = newNode;
        }

        public void printAllNodes()
        {
            Node current = this.head;
            while (current != null)
            {
                Console.Write(current.data);
                if(current.next != null) {
                    Console.Write("-");
                }
                current = current.next;
            }
        }

        public void deleteRepeated() {
            var linkedListHelper= new LinkedListHelper();
            linkedListHelper.removeMultipleOccuringNode(this.head);
        }
    }
}