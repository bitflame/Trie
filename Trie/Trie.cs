using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trie
{
    public class Trie
    {

        private TrieNode root;
        public Trie()
        {
            root = new TrieNode();
        }
        /** Inserts a word into the trie. */
        public void Insert(string word)
        {
            TrieNode node = root;
            for (int i = 0; i < word.Length; i++)
            {
                char currentChar = word.ElementAt(i);
                if (!node.ContainsKey(currentChar))
                {
                    node.Put(currentChar, new TrieNode());
                }
                node = node.Get(currentChar);
            }
            node.SetEnd();
        }
        private TrieNode SearchPrefix(string word)
        {
            TrieNode node = root;
            for (int i = 0; i < word.Length; i++)
            {
                char curLetter = word.ElementAt(i);
                if (node.ContainsKey(curLetter))
                {
                    node = node.Get(curLetter);
                }
                else
                {
                    return null;
                }
            }
            return node;
        }
        /** Returns if the word is in the trie. */
        public bool Search(string word)
        {
            TrieNode node = SearchPrefix(word);
            return node != null && node.IsEnd();
        }


        /** Returns if there is any word in the trie that starts with the given prefix. */
        public bool StartsWith(string prefix)
        {
            TrieNode node = SearchPrefix(prefix);
            return node != null;
        }
    }
    public class TrieNode
    {
        private TrieNode[] links;
        private static int R = 26;
        private bool isEnd;
        /** Initialize your data structure here. */
        public TrieNode()
        {
            links = new TrieNode[R];
        }
        public bool ContainsKey(char ch)
        {
            return links[ch - 'a'] != null;
        }
        public TrieNode Get(char ch)
        {
            return links[ch - 'a'];
        }
        public void Put(char ch, TrieNode node)
        {
            links[ch - 'a'] = node;
        }
        public void SetEnd()
        {
            isEnd = true;
        }
        public bool IsEnd()
        {
            return isEnd;
        }
    }
    /**
     * Your Trie object will be instantiated and called as such:
     * Trie obj = new Trie();
     * obj.Insert(word);
     * bool param_2 = obj.Search(word);
     * bool param_3 = obj.StartsWith(prefix);
     */
}
