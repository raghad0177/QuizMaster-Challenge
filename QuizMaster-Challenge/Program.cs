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
            char Ans ;
            dynamic [,] QustAndAns = { { "Sharks are mammals?(True/False)", 'F' },
                                     { "The blue whale is the biggest animal to have ever lived?(True/False)", 'T' },
                                     { "Bats are blind?(True/False)", 'F' },
                                     { "Pigs roll in the mud because they don't like being clean?(True/False)", 'F' },
                                     { "Infants have more bones than adults?(True/False)", 'T' } };
            try
            {
                for (int i = 0; i < QustAndAns.Length / 2; i++)
                {
                    Console.WriteLine(QustAndAns[i, 0]);
                    Ans = char.ToUpper(char.Parse(Console.ReadLine().ToUpper()));
                    if (Ans == QustAndAns[i, 1])
                    {
                        Console.WriteLine("Right Answer");
                        Score += 5;
                    }
                    while (Ans != QustAndAns[i, 1]) {
                        if (  Ans == 'T' || Ans == 'F')
                        {
                            Console.WriteLine("Wrong Answer");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("You Should answer (T) for True and (F) For False only !!");
                            Console.WriteLine(QustAndAns[i, 0]);
                            Ans = char.ToUpper(char.Parse(Console.ReadLine().ToUpper()));
                        }
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
