
using System;

namespace triangle
{
public class Triangles
{
    public static void FlatTrinagle(int n)
    {
        for (int i = 1; i <=n; i++)
        {
         for (int j = 0; j < i; j++)
         {
             Console.Write("*");
         }

            Console.WriteLine();
        }
    }

    public static void InvertedTriangle(int n)
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = n; j > i; j--)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

    public static void HollowTriangle(int n)
    {
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j < 2*n; j++)
            {
                if(j == (n -i+1) || j ==(n +i-1)) Console.Write("* ");
                else if(i == n || (i == 11)) Console.Write("* ");
                else Console.Write(" " + " ");
            }
            Console.Write("\n");
        }
    }


    public static void DirectionalPyramidTriangle(int n, string direction1, string direction2 )
    {
        for (int i = 0; i < n; i++)
        {
            for (int j = i; j < n; j++)
            {
                Console.Write(direction1);
            }
            for (int x = 0; x <= i; x++)
            {
                Console.Write("*");
                Console.Write(direction2);
            }
            Console.WriteLine();
        }   
    }
}
}