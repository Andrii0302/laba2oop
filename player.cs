namespace MyProject;
abstract class Player
{
    protected string userName;
    protected int currentRating;
    protected int gamesCount;
    protected List<IGame> gameHistory;
    
    public Player(string userName)
    {
        this.userName = userName;
        currentRating = 1;
        gamesCount = 0;
        gameHistory = new List<IGame>();
    }

    public virtual void WinGame(IGame game)
    {
        if (currentRating < 0)
        {
            throw new ArgumentException("Rating cannot be negative.");
        }
        currentRating += game.CalculateRatingChange();
        gameHistory.Add(game);
        gamesCount++;
        
        
    }

    public virtual void LoseGame(IGame game)
    {
         if (currentRating< 0)
        {
            throw new ArgumentException("Rating cannot be negative.");
        }

        if (currentRating < 1)
        {
            currentRating = 1;
        }
        currentRating -= game.CalculateRatingChange();
        gameHistory.Add(game);
        gamesCount++;
        

        
    }

    public void GetStats()
{
    Console.WriteLine($"Stats for {userName}:");
    for (int i = 0; i < gameHistory.Count; i++)
    {
        
        Console.WriteLine($"Game {i + 1}: Rating Change - {gameHistory[i].CalculateRatingChange()}");
    }
    Console.WriteLine($"Total Games Played: {gamesCount}, Current Rating: {currentRating}");
}

}