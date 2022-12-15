using System;
using System.Collections.Generic;
using System.Text;

namespace Session_2
{
    class Class5
    {
        public static void Main()
        {
            List<int> sampleList = new List<int>();
            sampleList.Add(1);
            sampleList.Add(2);
            foreach (var item in sampleList)
            {
                Console.WriteLine(item);
            }
            HashSet<int> odd = new HashSet<int>();
            for (int i = 0; i < 10; i++)
            {
                odd.Add(2*i+1);
            }
            foreach (var item in odd)
            {
                Console.WriteLine(item);
            }
            Dictionary<int, string> countnumber = new Dictionary<int, string>();
            //<1,"Vikash">
            //<1,"Rakesh">
            //<1,"Ramesh">
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("F#"); queue.Enqueue("C#.Net");
            queue.Enqueue("VB.Net"); queue.Enqueue("ab");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=================Stacks======================");
            Stack<string> stack = new Stack<string>();
            stack.Push("F#"); stack.Push("C#.Net");
            stack.Push("VB.Net"); stack.Push("ab");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("=================System.Collections.Stacks======================");
            System.Collections.Stack stackC = new System.Collections.Stack();
            stackC.Push("F#"); 
            stackC.Push("C#.Net");
            stackC.Push("VB.Net"); 
            stackC.Push("ab");
            stackC.Push(123123);
            stackC.Push(123.123);
            foreach (var item in stackC)
            {
                Console.WriteLine(item);
            }

        }
    }
}
