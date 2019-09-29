using System;
namespace linkedList
{
    public class LinkedListHelper
    {
        public void removeMultipleOccuringNode(Node head)
        {
            Node current = head;
            while (current != null && current.next !=null)
            {
                Node temp = current;
                int count = 1;            
                while(temp != null && temp.next != null)
                {
                    if(current.data == temp.next.data){
                        count = count+1;
                    }
                    if (count > 2)
                    {
                        temp.next = temp.next.next;
                    }
                    temp = temp.next;
                }
                current = current.next;
            }
        }
    }
}
