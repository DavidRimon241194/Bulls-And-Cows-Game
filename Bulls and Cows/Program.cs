namespace BullsEyeGame
{
    public class Program
    {
        public static void Main()
        {
            startGame();
        }


        private static void startGame()
        {
            FormGameFlow newGame = new FormGameFlow();

            newGame.ShowDialog();
        }
    }
}
