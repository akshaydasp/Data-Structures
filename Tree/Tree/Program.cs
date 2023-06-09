using System;
using System.Collections.Generic;

class Graph
{
    private int V; // Number of vertices
    private List<int>[] adj; // Adjacency list

    public Graph(int v)
    {
        V = v;
        adj = new List<int>[V];
        for (int i = 0; i < V; i++)
        {
            adj[i] = new List<int>();
        }
    }

    public void AddEdge(int v, int w)
    {
        adj[v].Add(w);
    }

    public void DFS(int v)
    {
        bool[] visited = new bool[V];
        DFSUtil(v, visited);
    }

    private void DFSUtil(int v, bool[] visited)
    {
        visited[v] = true;
        Console.Write(v + " ");

        foreach (int i in adj[v])
        {
            if (!visited[i])
                DFSUtil(i, visited);
        }
    }

    public void BFS(int v)
    {
        bool[] visited = new bool[V];
        Queue<int> queue = new Queue<int>();

        visited[v] = true;
        queue.Enqueue(v);

        while (queue.Count != 0)
        {
            v = queue.Dequeue();
            Console.Write(v + " ");

            foreach (int i in adj[v])
            {
                if (!visited[i])
                {
                    visited[i] = true;
                    queue.Enqueue(i);
                }
            }
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        int v = 5;
        Graph graph = new Graph(v);
        graph.AddEdge(1, 2);
        graph.AddEdge(2, 3);
        graph.AddEdge(3, 4);
        

        graph.BFS(1);
        Console.WriteLine();


    }
       
}
