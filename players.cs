namespace MyProject;
class StandardPlayer : Player
{
    public StandardPlayer(string userName) : base(userName) { }
}

class ReducedPenaltyPlayer : Player
{
    public ReducedPenaltyPlayer(string userName) : base(userName) { }

    public override void LoseGame(IGame game)
    {
        // Reduced penalty for lost
        currentRating -= game.CalculateRatingChange() / 2;
        gameHistory.Add(game);
        gamesCount++;
    }
}

class HighScorerPlayer : Player
{
    public HighScorerPlayer(string userName) : base(userName) { }

    public override void WinGame(IGame game)
    {
        // High scorer gets double points for winning
        currentRating += game.CalculateRatingChange() * 4;
        gameHistory.Add(game);
        gamesCount++;
    }
}