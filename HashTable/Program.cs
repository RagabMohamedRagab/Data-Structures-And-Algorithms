// Efficent in Access Element 
//Date : 17-1-2023 9:46 pm
using System;
namespace HashTable {
    public class Hash {
        public string Data { get; set; }
        public Hash Next { get; set; }
        public Hash()
        {
            Next = null;
        }
    }
    class Program {
        // Time Complexity O(N)
        static void Main(string[] args)
        {
            Dictionary<string, Hash> dic = new Dictionary<string, Hash>();
            Console.Write("Number Of Data:");
            int size = Int32.Parse(Console.ReadLine());
            int i = 0;
            while (i++ < size)
            {
                Console.Write("PLZ Enter Key:");
                string Key = Console.ReadLine().ToLower();
                Add(Key, dic);
            }
            Console.Write("Enter Key You Want To remove:");
            string keyremove = Console.ReadLine().ToLower();
            var result = DeletByKey(keyremove, dic) ? "Done" : "Something is Wrong..";
            Console.WriteLine(result);
            GetAll(dic);
            Console.Write("PLZ Enter Search Value:");
            string searchVal = Console.ReadLine();
            Search(searchVal, dic);

        }
        // Time Complexity O(N)
        public static void Add(string key, Dictionary<string, Hash> dic)
        {
            Console.Write("PLZ Enter Object:");
            string content = Console.ReadLine();
            Hash hash = new Hash() { Data = content, };
            if (!dic.ContainsKey(key))
            {

                dic.Add(key, hash);
            }
            else
            {
                var data = dic[key];
                while (data.Next != null)
                {
                    data = data.Next;
                }
                data.Next = hash;
            }
        }
        // Time Complexity O(1)
        public static bool DeletByKey(string key, Dictionary<string, Hash> dic)
        {
            return dic.Remove(key) ? true : false;
        }
        // Time Complexity O(N^2)
        public static void GetAll(Dictionary<string, Hash> dic)
        {
            foreach (var item in dic.Keys)
            {
                Console.WriteLine($"{item}");
                var data = dic[item];
                while (data != null)
                {
                    Console.WriteLine($"{data.Data}");
                    data = data.Next;
                }
            }
        }
        // Time Complexity O(N)
        public static void Search(string key,Dictionary<string,Hash> dic)
        {
            var data = dic[key];
            if (data != null)
            {
                while (data != null)
                {
                    Console.WriteLine($"{data.Data}");
                    // i++
                    data = data.Next;
                }
            }
            else
            {
                Console.WriteLine("Not Found Fucken Key Hhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhhh .....");
            }
        }
    }
}





