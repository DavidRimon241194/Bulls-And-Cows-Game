using System;
using System.Linq;

namespace BullsEyeGame.Model
{
    public class BullsEyeLogic
    {
        private readonly int r_lengthOfPin = 4;
        private readonly eBucketOfChoice[] r_RandomKey;
        private readonly BullsEyeResultHandler r_ResultOfTheGame;
        private bool m_QuitGame;
        private eBucketOfChoice[,] m_Pins;
        private eBucketOfResult[,] m_Result;
        private int m_NumOfLines;
        private int m_NumberOfCurrentAttempt;

        public BullsEyeLogic()
        {
            NumOfLines = 4;
            m_NumberOfCurrentAttempt = -1;
            m_QuitGame = false;
            this.r_ResultOfTheGame = new BullsEyeResultHandler();
            this.r_RandomKey = chooseRandomKey();
            initializePins(NumOfLines);
            initializeResult(NumOfLines);
        }

        public BullsEyeLogic(int i_NumOfAttemptsInOneGame)
        {
            NumOfLines = i_NumOfAttemptsInOneGame;
            m_NumberOfCurrentAttempt = -1;
            m_QuitGame = false;
            this.r_ResultOfTheGame = new BullsEyeResultHandler();
            this.r_RandomKey = chooseRandomKey();
            initializePins(i_NumOfAttemptsInOneGame);
            initializeResult(i_NumOfAttemptsInOneGame);
        }

        private void initializePins(int i_NumOfAttempts)
        {
            m_Pins = new eBucketOfChoice[i_NumOfAttempts, r_lengthOfPin];

            for (int i = 0; i < i_NumOfAttempts; i++)
            {
                for(int j = 0; j < r_lengthOfPin; j++)
                {
                    m_Pins[i, j] = eBucketOfChoice.X;
                }
            }
        }

        private void initializeResult(int i_NumOfAttempts)
        {
            m_Result = new eBucketOfResult[i_NumOfAttempts, r_lengthOfPin];

            for (int i = 0; i < i_NumOfAttempts; i++)
            {
                for (int j = 0; j < r_lengthOfPin; j++)
                {
                    m_Result[i, j] = eBucketOfResult.Nothing;
                }
            }
        }

        private static eBucketOfChoice[] chooseRandomKey()
        {
            Random rand = new Random();
            eBucketOfChoice[] chosenKey = new eBucketOfChoice[4];
            int currentRandomIndex = 0;

            for (int i = 0; i < 4; i++)
            {
                currentRandomIndex = rand.Next(8);
                if (!chosenKey.Contains(enumChoiseByNumber(currentRandomIndex)))
                {
                    chosenKey[i] = enumChoiseByNumber(currentRandomIndex);
                }
                else
                {
                    i--;
                    continue;
                }
            }

            return chosenKey;
        }

        public int NumOfLines
        {
            get
            {
                return m_NumOfLines;
            }

            set
            {
                if(!BullsEyeValidator.ValidNumberOfLines(value))
                {
                    return;
                }

                m_NumOfLines = value;
                m_Pins = new eBucketOfChoice[NumOfLines, r_lengthOfPin];
                m_Result = new eBucketOfResult[NumOfLines, r_lengthOfPin];
            }
        }

        public BullsEyeResultHandler ResultOfTheGame
        {
            get
            {
                return r_ResultOfTheGame;
            }
        }
        
        private void addingNewStringPin(string i_NewPin)
        {
            for(int i = 0; i < i_NewPin.Length; i++)
            {
                m_Pins[m_NumberOfCurrentAttempt, i] = enumChoiseByLetter(i_NewPin[i]);
            }
        }

        private bool addNewPin(string i_NewPin)
        {
            bool isInitializationRight = true;

            if (!BullsEyeValidator.ValidPin(i_NewPin))
            {
                isInitializationRight = false;
            }
            else
            {
                m_NumberOfCurrentAttempt++;
                addingNewStringPin(i_NewPin);
            }

            return isInitializationRight;
        }

        private void addNewResult()
        {
            int currentIndex = 0;
            int countOfBulls = 0;
            int countOfPgia = 0;

            while (currentIndex < 4)
            {
                for (int j = 0; j < r_lengthOfPin; j++)
                {
                    if (m_Pins[m_NumberOfCurrentAttempt, currentIndex] == r_RandomKey[j])
                    {
                        if (currentIndex == j)
                        {
                            countOfBulls++;
                        }
                        else
                        {
                            countOfPgia++;
                        }
                    }
                }

                currentIndex++;
            }

            for(int i = 0; i < r_lengthOfPin; i++)
            {
                if(countOfBulls > 0)
                {
                    m_Result[m_NumberOfCurrentAttempt, i] = eBucketOfResult.Bulle;
                    countOfBulls--;
                }
                else if(countOfPgia > 0)
                {
                    m_Result[m_NumberOfCurrentAttempt, i] = eBucketOfResult.Pgia;
                    countOfPgia--;
                }
                else
                {
                    m_Result[m_NumberOfCurrentAttempt, i] = eBucketOfResult.Nothing;
                }
            }
        }

        public void PlayMove(string i_NewPin)
        {
            if (addNewPin(i_NewPin))
            {
                addNewResult();
            }

            ResultOfTheGame.YouLose(m_Result, m_NumberOfCurrentAttempt, NumOfLines);
            ResultOfTheGame.YouWinner(m_Result, m_NumberOfCurrentAttempt);
        }
         
        private static eBucketOfChoice enumChoiseByNumber(int i_Number)
        {
            eBucketOfChoice choiceToReturn = eBucketOfChoice.A;

            switch(i_Number)
            {
                case 0:
                    choiceToReturn = eBucketOfChoice.A;
                    break;
                case 1:
                    choiceToReturn = eBucketOfChoice.B;
                    break;
                case 2:
                    choiceToReturn = eBucketOfChoice.C;
                    break;
                case 3:
                    choiceToReturn = eBucketOfChoice.D;
                    break;
                case 4:
                    choiceToReturn = eBucketOfChoice.E;
                    break;
                case 5:
                    choiceToReturn = eBucketOfChoice.F;
                    break;
                case 6:
                    choiceToReturn = eBucketOfChoice.G;
                    break;
                case 7:
                    choiceToReturn = eBucketOfChoice.H;
                    break;
                default:
                    choiceToReturn = eBucketOfChoice.X;
                    break;
            }

            return choiceToReturn;
        }

        private static eBucketOfChoice enumChoiseByLetter(char i_Letter)
        {
            eBucketOfChoice choiceToReturn = eBucketOfChoice.A;

            switch (i_Letter)
            {
                case 'A':
                    choiceToReturn = eBucketOfChoice.A;
                    break;
                case 'B':
                    choiceToReturn = eBucketOfChoice.B;
                    break;
                case 'C':
                    choiceToReturn = eBucketOfChoice.C;
                    break;
                case 'D':
                    choiceToReturn = eBucketOfChoice.D;
                    break;
                case 'E':
                    choiceToReturn = eBucketOfChoice.E;
                    break;
                case 'F':
                    choiceToReturn = eBucketOfChoice.F;
                    break;
                case 'G':
                    choiceToReturn = eBucketOfChoice.G;
                    break;
                case 'H':
                    choiceToReturn = eBucketOfChoice.H;
                    break;
            }

            return choiceToReturn;
        }

        public string GetStringOfLastRandomKey()
        {
            return r_RandomKey[0].ToString() + r_RandomKey[1].ToString() + r_RandomKey[2].ToString() + r_RandomKey[3].ToString();
        }

        public string GetStringOfSpesificResult(int i_Index)
        {
            string resultToReturn = null;

            for(int i = 0; i < r_lengthOfPin; i++)
            {
                if(m_Result[i_Index, i] == eBucketOfResult.Bulle)
                {
                    resultToReturn += "V";
                }
                else if(m_Result[i_Index, i] == eBucketOfResult.Pgia)
                {
                    resultToReturn += "X";
                }
                else
                {
                    resultToReturn += " ";
                }
            }

            return resultToReturn;
        }
    }
}
