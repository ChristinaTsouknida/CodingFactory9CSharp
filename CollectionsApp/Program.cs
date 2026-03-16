namespace CollectionsApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new List<string>() { "Hello", "World" }; // collection initializer
            List<string> list2 = ["Hello", "Coding"];   // C#12

            var hashSet = new HashSet<string>() { "Hello", "World" };
            HashSet<string> hashSet2 = ["Hello", "Coding"];

            var dictionary = new Dictionary<int, string>()
            {
                {1, "one" },
                {2, "two" }
            };

            var dictionary2 = new Dictionary<int, string>()
            {
                [1] = "one",
                [2] = "two"
            };

            Stack<string> stack = new Stack<string>(new[] { "Hello", "World" });
            Stack<string> stack2 = new Stack<string>(["Hello", "World"]);

            Queue<string> queue = new Queue<string>(new[] { "Hello", "World" });
            Queue<string> queue2 = new Queue<string>(["Hello", "World"]);


        }


        public static void DoList(List<string> list)
        {
            list.Add("Hello"); // inserts in the end of the list
            list.Insert(1, "World");  // inserts at index 1, shifting right all other elements
            list.AddRange(["Coding", "Factory"]);  // inserts multiple elements in the end of the list
            list.Remove("Hello");
            list.RemoveAt(0); // removes element at index 0, shifting left all other elements

            list[1] = "AUEB";  //update 
            string token = list[1];  // read 

            Console.WriteLine(list.Count);
            list.ForEach(x => Console.WriteLine(x));  // print all elements
        }

        public static void DoLinkList(LinkedList<string> linkedList)
        {
            linkedList.AddLast("Hello");
            linkedList.AddFirst("World");
            linkedList.AddAfter(linkedList.First!, "Coding");
            linkedList.AddBefore(linkedList.Last!, "Factory");

            foreach (var item in linkedList)
            {
                Console.WriteLine(item);
            }
        }

        public static void DoDictionary(Dictionary<string, int> dictionary)
        {
            dictionary.Add("one", 1);
            dictionary["Two"] = 2; // add or update
            int num  = dictionary["one"];  // read - unsafe KeyNotFoundException


            if (!dictionary.TryGetValue("two", out num))
            {
                Console.WriteLine("Error");
            }

            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"{kvp.Key}, { kvp.Value}");
            }
        }


        public static void DoStack(Stack<string> stack)
        {
            stack.Push("Hello");
            stack.Push("World");

            string topElement = stack.Pop();
            Console.WriteLine(topElement);

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
        }


        public static void DoQueue(Queue<string> queue)
        {
            queue.Enqueue("Hello"); // adds to the end of the queue
            queue.Enqueue("World");

            string frontElement = queue.Dequeue();

            foreach (var item in frontElement)
            {
                Console.WriteLine(item);
            }
        }


        public static void DoHashSet(HashSet<string> hashSet)
        {
            var hashSet2 = new HashSet<string>() { "Hello", "Coding", "Factory"};  // Initializer

            hashSet.Add("Hello");
            hashSet.Add("World");
            hashSet.Add("Hello"); // duplicate, will not be added 

            hashSet.Union(hashSet2);   // enters all the unique elements of hashSet2 to hashSet
            hashSet.IntersectWith(hashSet2); // present in both set, all the elements that are in both sets

            foreach (var item in hashSet2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
