namespace QuizMaster_Challenge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                StartQuiz();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally {
                Console.WriteLine("The Exam Finished.");
            }
        }
        static void StartQuiz()
        {
            int Score = 0;
            bool Ans ;
            dynamic [,] QustAndAns = { { "Sharks are mammals?(True/False)", false },
                                     { "The blue whale is the biggest animal to have ever lived?(True/False)", true },
                                     { "Bats are blind?(True/False)", false },
                                     { "Pigs roll in the mud because they don't like being clean?(True/False)", false },
                                     { "Infants have more bones than adults?(True/False)", true } };
            try
            {
                for (int i = 0; i < QustAndAns.Length / 2; i++)
                {
                    Console.WriteLine(QustAndAns[i, 0]);
                    Ans = bool.Parse(Console.ReadLine());
                    if (Ans == QustAndAns[i, 1])
                    {
                        Console.WriteLine("Right Answer");
                        Score += 5;
                    }
                    else
                    {
                        Console.WriteLine("Wrong Answer");
                    }
                }
                Console.WriteLine("Your Score is : " + Score + "/25");
            }
            catch (FormatException e)
            {
                Console.WriteLine("Please , Try Again.");
                Console.WriteLine(e.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
           
        }
    }
}
