namespace Classes
{
    public class Algorithm
    {
        public List<int> DeepFirstSearch(int[][] matrix)
        {
            if (!CheckMatrix(matrix))
                throw new ArgumentException("Matrix must be symmetrical");

            List<int> result = new List<int>();

            HashSet<int> visited = new HashSet<int>();

            Search(visited, result, matrix, 0);

            return result;
        }

        private void Search(HashSet<int> memo, List<int> res, int[][] matrix, int current)
        {
            res.Add(current);
            memo.Add(current);
            for (int i = 0; i < matrix[current].Length; i++)
            {
                if (matrix[current][i] == 1 && !memo.Contains(i)) 
                {
                    Search(memo, res, matrix, i);
                }
            }
        }

        private bool CheckMatrix(int[][] matrix)
        {
            for(int i = 1; i < matrix.Length; i++)
            {
                for(int j = 0; j < i; j++)
                {
                    if (matrix[i][j] != matrix[j][i])
                        return false;
                }
            }
            return true;
        }
    }
}
