// Efficent in Access Element 
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
                Console.Write("PLZ Enter Object:");
                string content = Console.ReadLine();
                Hash hash = new Hash() { Data = content, };
                if (!dic.ContainsKey(Key))
                {

                    dic.Add(Key, hash);
                }
                else
                {
                    var data = dic[Key];
                    while (data.Next != null)
                    {
                        data = data.Next;
                    }
                    data.Next = hash;
                }
            }
            Console.Write("Enter Key You Want To remove ");
            string keyremove= Console.ReadLine().ToLower();
            var result = DeletByKey(keyremove, dic) ? "Done" : "Something is Wrong..";
            Console.WriteLine(result);
            foreach (var item in dic.Keys)
            {
                Console.WriteLine($"{item}");
                var data= dic[item];
                while (data != null)
                {
                    Console.WriteLine($"{data.Data}");
                    data=data.Next;
                }
            }
        }
        public static bool DeletByKey(string key,Dictionary<string,Hash> dic) {
                return dic.Remove(key)?true:false;
        }
    }
}



