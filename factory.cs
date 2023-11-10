namespace MyProject;
class GameFactory
    {
        public IGame CreateStandardGame()
        {
            return new StandardGame();
        }

        public IGame CreateTrainingGame()
        {
            return new TrainingGame();
        }

        public IGame CreateSinglePlayerGame()
        {
            return new OnePlayerGame();
        }
        public IGame CreateSuperGame()
        {
            return new HighScorerGame();
        }
    }