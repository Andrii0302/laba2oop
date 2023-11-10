using System;
using System.Collections.Generic;
namespace MyProject;

class Program
{
    static void Main(string[] args)
    {
        Player standardPlayer = new StandardPlayer("Petya");
        Player reducedPenaltyPlayer = new ReducedPenaltyPlayer("Boris");
        Player highScorerPlayer = new HighScorerPlayer("Alice");
        GameFactory factory = new GameFactory();
        IGame standardGame1 = factory.CreateStandardGame();
        IGame trainingGame1 = factory.CreateTrainingGame();
        IGame onePlayerGame1 = factory.CreateSinglePlayerGame();
        IGame highScorerGame1 = factory.CreateSuperGame();

        standardPlayer.LoseGame(standardGame1);
        reducedPenaltyPlayer.WinGame(standardGame1);
        highScorerPlayer.LoseGame(standardGame1);
        standardPlayer.WinGame(trainingGame1);
        reducedPenaltyPlayer.WinGame(onePlayerGame1);
        highScorerPlayer.WinGame(highScorerGame1);

        standardPlayer.GetStats();
        reducedPenaltyPlayer.GetStats();
        highScorerPlayer.GetStats();
    }
}
