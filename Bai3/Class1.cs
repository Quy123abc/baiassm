namespace Bai3
{
    public class Class1
    {
        public string GetGrade(int score)
        {
            if (score < 0 || score > 100)
            {
                throw new ArgumentOutOfRangeException(nameof(score), "Score must be between 0 and 100.");
            }

            if (score <= 40)
            {
                return "F";
            }
            else if (score <= 60)
            {
                return "D";
            }
            else if (score <= 70)
            {
                return "C";
            }
            else if (score <= 80)
            {
                return "B";
            }
            else
            {
                return "A";
            }
        }
    }
}
