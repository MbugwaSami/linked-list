using System;

namespace linkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var linkedList = new LinkedList();
            linkedList.addNode("B");
            linkedList.addNode("B");
            linkedList.addNode("A");
            linkedList.addNode("C");
            linkedList.addNode("A");
            linkedList.addNode("B");
            linkedList.addNode("A");
            Console.WriteLine("input >>>>>>>>>");
            linkedList.printAllNodes();
            linkedList.deleteRepeated();
            Console.WriteLine();
            Console.WriteLine("After calling the method >>>>>>>>>");
            linkedList.printAllNodes();
        }
    }
}
