using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trie
{
    class Program
    {
        static void Main(string[] args)
        {
            Trie trie = new Trie();
            trie.Insert("hello");
            //Console.ReadLine();
            //trie.Search("apple");
            Console.WriteLine("{0}", trie.Search("hello"));
            Console.ReadLine();
            Console.WriteLine("{0}", trie.Search("hell"));
            Console.ReadLine();
            Console.WriteLine("{0}", trie.Search("helloa"));
            Console.ReadLine();
            trie.Search("app");
            
        }
    }
}
