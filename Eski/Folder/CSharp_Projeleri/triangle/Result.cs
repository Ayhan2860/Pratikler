using System;
using triangle;

public class Result{
     public static int TriangleVarieties(int vote, int n)
        {
            switch (vote)
            {
                case 1:
                    Triangles.FlatTrinagle(n);
                    break;
                case 2:
                    Triangles.InvertedTriangle(n);
                    break;
                case 3:
                    Triangles.HollowTriangle(n);
                    break;
                case 4:
                    Triangles.DirectionalPyramidTriangle(n, " ", " ");
                    break;
                case 5:
                    Triangles.DirectionalPyramidTriangle(n, "", " ");
                    break;
                case 6:
                    Triangles.DirectionalPyramidTriangle(n, " ", "");
                    break;


                default:
                    if (vote > 6 || vote < 0)
                    {
                        Console.Clear();
                        Console.WriteLine("Hatalı seçim yaptınız geri dönmek için bir tuşa basınız...");
                        Console.ReadKey();
                        vote = 0;
                    }
                    break;

            }

            return vote;
         
        }
}