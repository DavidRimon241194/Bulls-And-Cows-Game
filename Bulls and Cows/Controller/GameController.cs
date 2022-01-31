using BullsEyeGame.Model;

namespace BullsEyeGame.Controller
{
    public class GameController
    {
        private readonly BullsEyeLogic r_Game;

        public GameController()
        {
            this.r_Game = new BullsEyeLogic();
        }

        public int NumOfAttempts
        {
            get
            {
                return this.r_Game.NumOfLines;
            }

            set
            {
                this.r_Game.NumOfLines = value;
            }
        }

        public string RandomKey
        {
            get
            {
                return this.r_Game.GetStringOfLastRandomKey();
            }
        }

        public string GetSpesificResult(int i_Index)
        {
                return this.r_Game.GetStringOfSpesificResult(i_Index);
        }

        public void SendRequestToTheModel(string i_Pin)
        {
            r_Game.PlayMove(i_Pin);
        }

        public bool IsWin()
        {
            return r_Game.ResultOfTheGame.IsWin;
        }

        public bool IsLose()
        {
            return r_Game.ResultOfTheGame.IsLose;
        }
    }
}
