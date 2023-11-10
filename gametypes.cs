namespace MyProject;
class StandardGame : IGame
{
    public int CalculateRatingChange()
    {
        return 1; // Standard rating change for a game
    }
}

class TrainingGame : IGame
{
    public int CalculateRatingChange()
    {
        return 0; // No rating change for training games
    }
}

class OnePlayerGame : IGame
{
    public int CalculateRatingChange()
    {
        return 1; // Only win affects rating in one-player games
    }
}

class HighScorerGame : IGame
{
    public int CalculateRatingChange()
    {
        return 2; // High scorer gets more points for a win
    }
}