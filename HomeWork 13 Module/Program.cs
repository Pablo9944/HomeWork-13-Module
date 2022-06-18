﻿using System.Diagnostics;


class Program
{
    static void Main()
    {
        var watch = Stopwatch.StartNew();

        List<string> list = new List<string>();
        list = File.ReadLines("Text1.txt").ToList();
        Console.WriteLine($"Вставка в  List<T>: {watch.Elapsed.TotalMilliseconds}  мс");


        LinkedList<string> listLinked = new LinkedList<string>();
        listLinked.AddFirst(File.ReadAllText("Text1.txt"));
        Console.WriteLine($"Вставка в  LinkedList<T>: {watch.Elapsed.TotalMilliseconds}  мс");






    }

}
