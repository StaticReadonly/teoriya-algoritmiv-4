using Classes;

namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Algorithm alg = new Algorithm();

            int[][] matrix = new int[][]
            {
                new int[]{0,0,0,1,0,0,0,0,1},
                new int[]{0,0,1,1,0,1,0,0,1},
                new int[]{0,1,0,0,1,0,1,0,0},
                new int[]{1,1,0,0,1,0,0,0,1},
                new int[]{0,0,1,1,0,0,0,1,0},
                new int[]{0,1,0,0,0,0,1,0,0},
                new int[]{0,0,1,0,0,1,0,0,0},
                new int[]{0,0,0,0,1,0,0,0,0},
                new int[]{1,1,0,1,0,0,0,0,0}
            };

            List<int> res = alg.DeepFirstSearch(matrix);

            foreach(int r in res)
            {
                Console.WriteLine(r);
            }
        }
    }
}
