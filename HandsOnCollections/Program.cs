using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace HandsOnCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(5);
            al.Add("gany");
            al.Add(2.33);
            al.Add('d');
            al.Remove(2.33);
            foreach (var val in al)
                Console.WriteLine(val);
            Queue qlist = new Queue();
            qlist.Enqueue(2);
            qlist.Enqueue("gany");
            qlist.Enqueue('c');
            Console.WriteLine(qlist.Dequeue());
            foreach (var val in qlist)
                Console.WriteLine(val);         
            Stack slist = new Stack();
            slist.Push(23);
            slist.Push("hello");
            slist.Push(23.45);
            Console.WriteLine(slist.Pop());
            Console.WriteLine(slist.Peek());
            foreach (var s in slist)
                Console.WriteLine(s);              

            Hashtable ht = new Hashtable();
            ht.Add(1, "cts");
            ht.Add('a', 1000);
            ht.Add("t1", 30);
            foreach (var val in ht.Keys)
            {
                Console.WriteLine(val);
                Console.WriteLine(ht[val]);        
            }
            List<int> list = new List<int>();
            list.Add(10);
            list.Add('a');
            list.Add(34);
            foreach (int val in list)
                Console.WriteLine(val);


            Queue<string> gqlist = new Queue<string>();
            gqlist.Enqueue("1");
            gqlist.Enqueue("arun");
            gqlist.Enqueue("c");
            Console.WriteLine(gqlist.Dequeue());
            foreach (var val in gqlist)
                Console.WriteLine(val);


            Stack<float> gslist = new Stack<float>();
            gslist.Push(23);
            gslist.Push(23.434f);
            gslist.Push(23.33f);

            Console.WriteLine(gslist.Pop());
            Console.WriteLine(gslist.Peek());
            foreach (var s in gslist)
                Console.WriteLine(s);


            HashSet<int> hs = new HashSet<int>();
            Console.WriteLine();


            Dictionary<int, string> dt = new Dictionary<int, string>();
            dt.Add(1, "raj");
            dt.Add(2, "gamy");
            dt.Add(3, "laksh");
            foreach(KeyValuePair<int,string>kl in dt)
            {
                Console.WriteLine(kl.Key);
                Console.WriteLine(kl.Value);
            }

            Console.ReadLine();
        }
    }
}
