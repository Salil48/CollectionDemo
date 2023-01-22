namespace CollectionDemo
{
    class Program
    {
        public static void Main(string[] args)
        {
            doListDemo();
            doStackDemo();
            doQueueDemo();
            doSetDemo();
            doDictionaryDemo();
        }
        private static void doDictionaryDemo()
        {
            Console.WriteLine("----------------------------------------------");

            Console.WriteLine("In doDictionaryDemo");
            Dictionary<int, string> dictionary = new Dictionary<int, string>();
            dictionary.Add(100, "Amit");
            dictionary.Add(101, "Amit");
            dictionary.Add(102, "Amit");

            Console.WriteLine("Access value using Key(key=100) " + dictionary[100]);

            Console.WriteLine("Iterating dictionary");

            foreach (var elements in dictionary)
            {
                Console.WriteLine("key = " + elements.Key + "Value = " + elements.Value);
            }
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("----------------------------------------------");

        }
        private static void doSetDemo()
        {
            Console.WriteLine("----------------------------------------------");

            Console.WriteLine("In doSetDemo");
            HashSet<string> set = new HashSet<string>();
            set.Add("Ravi");
            set.Add("Vijay");
            set.Add("Ravi");
            set.Add("Ajay");

            foreach (var element in set)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("----------------------------------------------");

        }
        private static void doQueueDemo()
        {
            Console.WriteLine("----------------------------------------------");

            Console.WriteLine("In doQueueDemo");

            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Amit Sharma");
            queue.Enqueue("Vijay Rai");
            queue.Enqueue("Jaishankar");
            queue.Enqueue("Raj");

            Console.WriteLine("Head: " + queue.Peek());
            Console.WriteLine("Iterating the queue elements");

            foreach (var elemlent in queue)
            {
                Console.WriteLine(elemlent);
            }

            string dequeue = queue.Dequeue();
            Console.WriteLine("Dequeue elements " + dequeue);
            Console.WriteLine("Iterating the queue elements after the dequeue one element");
            foreach (var elemlent in queue)
            {
                Console.WriteLine(elemlent);
            }
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("----------------------------------------------");

        }
        private static void doStackDemo()
        {
            Console.WriteLine("----------------------------------------------");

            Console.WriteLine("In doStackDemo");
            Stack<string> stack = new Stack<string>();
            stack.Push("Ayush");
            stack.Push("Garvit");
            stack.Push("Amit");
            stack.Push("Ashish");
            string pop = stack.Pop();

            foreach (var element in stack)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine("Poped element pop " + pop);
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("----------------------------------------------");

        }
        private static void doListDemo()
        {
            Console.WriteLine("----------------------------------------------");

            Console.WriteLine("In doListDemo");
            List<string> list = new List<string>();
            list.Add("Ravi");
            list.Add("Vijay");
            list.Add("Ravi");
            list.Add("Ajay");

            foreach (var element in list)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("----------------------------------------------");
        }
    }
}


