namespace DragonsWay.Logic
{
    public class Game
    {

        private char[,] _maze;


        public Game(int n, string camino)
        {
            N = n;
            Camino = camino; 
            _maze = new char[N, N * 2];
            FillBorders();
        }

        public int N { get; }

        public string Camino { get; }

        public override string ToString()
        {
            var output = string.Empty;
            for (int i = 0; i < N; i++)
            {
                output += $"{i}\t";

                for (int j = 0; j < N ; j++)
                {
                    output += $"{ _maze[i, j]}";
                }
                output += "\n";
            }
            return output;
        }


        private void FillBorders()
        {
            for (int i = 0; i < N; i++)
            {
                _maze[0, i] = '█';
            }
            for (int i = 0; i < N - 1; i++)
            {
                _maze[1, i] = ' ';
            }

            _maze[1, N - 1] = '█';
            for (int i = 2; i < N - 2; i++)
            {
                _maze[i, 0] = '█';
                for (int j = 1; j < N - 1; j++)
                {
                    _maze[i, j] = ' ';
                }
                _maze[i, N - 1] = '█';
            }
            _maze[N - 2, 0] = '█';
            for (int i = 1; i < N; i++)
            {
                _maze[N - 2, i] = ' ';
            }

            for (int i = 0; i < N; i++)
            {
                _maze[N - 1, i] = '█';
            }
        }

        private void Way()
        {
            for (int i = 1; i < N; i++)
            {
                
            }
        }
    }
}