namespace BullsEyeGame.Model
{
    public class BullsEyeResultHandler
    {
        private bool m_IsWin;
        private bool m_IsLose;

        public BullsEyeResultHandler()
        {
            IsWin = false;
            IsLose = false;
        }

        public bool IsWin
        {
            get
            {
                return this.m_IsWin;
            }

            set
            {
                this.m_IsWin = value;
            }
        }

        public bool IsLose
        {
            get
            {
                return this.m_IsLose;
            }

            set
            {
                this.m_IsLose = value;
            }
        }

        public void YouWinner(eBucketOfResult[,] i_CurrentPin, int i_LastAttempt)
        {
            bool isWin = true;

            for(int i = 0; i < 4; i++)
            {
                if(i_CurrentPin[i_LastAttempt, i] != eBucketOfResult.Bulle)
                {
                    isWin = false;
                    break;
                }
            }

            IsWin = isWin;
        }

        public void YouLose(eBucketOfResult[,] i_CurrentPin, int i_LastAttempt, int i_NumOfLines)
        {
            bool isWin = true;

            for (int i = 0; i < 4; i++)
            {
                if (i_CurrentPin[i_LastAttempt, i] != eBucketOfResult.Bulle)
                {
                    isWin = false;
                    break;
                }
            }

            IsLose = !isWin && i_LastAttempt + 1 == i_NumOfLines;
        }
    }
}
