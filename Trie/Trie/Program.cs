
/*using System;

class Program
{
    static void Main(string[] args)
    {
        Trie trie = new Trie();

        // Inserting words into the trie
        trie.Insert("apple");
        trie.Insert("banana");
        trie.Insert("cat");

        // Searching for words in the trie
        Console.WriteLine(trie.Search("apple"));    // Output: True
        Console.WriteLine(trie.Search("banana"));   // Output: True
        Console.WriteLine(trie.Search("cat"));      // Output: True
        Console.WriteLine(trie.Search("dog"));      // Output: False

        // Checking if words start with a prefix
        Console.WriteLine(trie.StartsWith("app"));  // Output: True
        Console.WriteLine(trie.StartsWith("ban"));  // Output: True
        Console.WriteLine(trie.StartsWith("ca"));   // Output: True
        Console.WriteLine(trie.StartsWith("do"));   // Output: False

        // Counting the total number of words in the trie
        Console.WriteLine(trie.CountWords());        // Output: 3
    }
}


public class Trie
{
    private TrieNode root;
    private int count;

    public Trie()
    {
        root = new TrieNode();
        count = 0;
    }

    public void Insert(string word)
    {
        TrieNode currentNode = root;
        foreach (char c in word)
        {
            if (!currentNode.ContainsKey(c))
            {
                TrieNode newNode = new TrieNode();
                currentNode.AddChild(c, newNode);
            }
            currentNode = currentNode.GetChild(c);
        }
        currentNode.SetEndOfWord(true);
        count++;
    }

    public bool Search(string word)
    {
        TrieNode currentNode = root;
        foreach (char c in word)
        {
            if (!currentNode.ContainsKey(c))
                return false;
            currentNode = currentNode.GetChild(c);
        }
        return currentNode.IsEndOfWord();
    }

    public bool StartsWith(string prefix)
    {
        TrieNode currentNode = root;
        foreach (char c in prefix)
        {
            if (!currentNode.ContainsKey(c))
                return false;
            currentNode = currentNode.GetChild(c);
        }
        return true;
    }
    public int CountWords()
    {
        return count;
    }
}

public class TrieNode
{
    private Dictionary<char, TrieNode> children;
    private bool isEndOfWord;

    public TrieNode()
    {
        children = new Dictionary<char, TrieNode>();
        isEndOfWord = false;
    }

    public bool ContainsKey(char c)
    {
        return children.ContainsKey(c);
    }

    public TrieNode GetChild(char c)
    {
        return children[c];
    }

    public void AddChild(char c, TrieNode node)
    {
        children.Add(c, node);
    }

    public bool IsEndOfWord()
    {
        return isEndOfWord;
    }

    public void SetEndOfWord(bool isEnd)
    {
        isEndOfWord = isEnd;
    }
}*/

using System.Collections.Generic;

class TrieNode
{
    public Dictionary<char, TrieNode> Children;
    public bool IsEndOfWord;

    public TrieNode()
    {
        Children = new Dictionary<char, TrieNode>();
        IsEndOfWord = false;
    }
}

class Trie
{
    private TrieNode root;

    public Trie()
    {
        root = new TrieNode();
    }

    public void Insert(string word)
    {
        TrieNode node = root;
        foreach (char c in word)
        {
            if (!node.Children.ContainsKey(c))
            {
                node.Children[c] = new TrieNode();
            }
            node = node.Children[c];
        }
        node.IsEndOfWord = true;
    }

    public bool Search(string word)
    {
        TrieNode node = root;
        foreach (char c in word)
        {
            if (!node.Children.ContainsKey(c))
            {
                return false;
            }
            node = node.Children[c];
        }
        return node.IsEndOfWord;
    }

    public bool StartsWith(string prefix)
    {
        TrieNode node = root;
        foreach (char c in prefix)
        {
            if (!node.Children.ContainsKey(c))
            {
                return false;
            }
            node = node.Children[c];
        }
        return true;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Trie trie = new Trie();
        trie.Insert("apple");
        trie.Insert("banana");
        trie.Insert("cherry");

        Console.WriteLine(trie.Search("apple")); // True
        Console.WriteLine(trie.Search("grape")); // False

        Console.WriteLine(trie.StartsWith("app")); // True
        Console.WriteLine(trie.StartsWith("grap")); // False
    }
}


