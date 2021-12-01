using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace pr_32_prakt17_5_OAP_Kolyasnikova.V
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader t = new StreamReader("t.txt");
            string n = t.ReadToEnd();
            Console.WriteLine(n);
            Console.WriteLine("Введите поисковое слово:");
            string p = "слон";
            string[] z = n.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
            var f = from x in z
                             where x.ToLowerInvariant() == p.ToLowerInvariant()
                             select x;
            int c = f.Count();
            Console.WriteLine("Были найдены {0} вхождения(ий) поискового слова {1}", c, p);
            Console.ReadKey();
        }
    }
}
