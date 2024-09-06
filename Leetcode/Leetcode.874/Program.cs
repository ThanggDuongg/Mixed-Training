int RobotSim(int[] commands, int[][] obstacles)
{
    var directions = new int[,] { { 0, 1 }, { 1, 0 }, { 0, -1 }, { -1, 0 } };
    var obstaclesSet = obstacles.Select(x => (x[0], x[1])).ToHashSet();

    int x = 0, y = 0; // init
    var currentIndex = 0;
    var result = 0;

    foreach (var command in commands)
    {
        if (command == -1)
        {
            currentIndex = (currentIndex + 1) % 4;
        }
        else if (command == -2)
        {
            currentIndex = (currentIndex + 3) % 4;
        } else
        {
            for (var i = 1; i <= command; i++)
            {
                int nextX = x + directions[currentIndex, 0];
                var nextY = y + directions[currentIndex, 1];
                if (obstaclesSet.Contains((nextX, nextY))) {
                    break;
                } else
                {
                    x = nextX; y = nextY;
                    result = Math.Max(result, x * x + y * y);
                }
            }
        }
    }

    return result;
}