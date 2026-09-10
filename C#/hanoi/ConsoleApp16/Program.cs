using System;
using System.Collections;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        int n = 3;
        var A= new Stack<int>();
        var B= new Stack<int>();
        var C= new Stack<int>();

        for(int i = n; i >= 1; i--)
        {
            A.Push(i);
            Hanoi(n,A,C,B,'A','C','B');
        }
    }
    static void Hanoi(int n, Stack<int> z, Stack<int> c, Stack<int> p, char nazZ, char nazC, char nazP)
    {
        if (n == 1)
        {
            c.Push(z.Pop());
            return;
        }
        Hanoi(n-1,z,c,p,nazZ,nazC,nazP);
        c.Push(z.Pop());
        Hanoi(n - 1, p, c, z, nazZ, nazC, nazP);
    }
}