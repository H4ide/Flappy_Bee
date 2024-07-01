using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Flappy_Bird_windows_form
{
    internal  class ScoreManager
    {
        public int Score { get; set; }
        public int Max_score { get; set; }

        public ScoreManager()
        {
            Score = 0;
            Max_score = LoadMaxScore();
        }

        private int LoadMaxScore()
        {
            string filePath = "Max_score.txt";

            if (File.Exists(filePath))
            {
                string maxScoreString = File.ReadAllText(filePath);
                int maxScore;

                if (int.TryParse(maxScoreString, out maxScore))
                {
                    return maxScore;
                }
                else
                {
                    Console.WriteLine("Error while reading Max_score.txt . The default value is used.");
                }
            }

            return 0;
        }

        public void UpdateMaxScore()
        {
            if (Score > Max_score)
            {
                Max_score = Score;
                string filePath = "Max_score.txt";
                File.WriteAllText(filePath, Score.ToString());
            }
        }
    }
}
